using DataAccessObjects.Extensions;
using DataAccessObjects.Models;
using Microsoft.Extensions.DependencyInjection;
using Repositories;
using SaleManagementWinApp.Authentications;
using System.Security.Principal;

namespace SaleManagementWinApp
{
	public partial class PasswordDialog : Form
	{

		private CurrentUser _currentUser;
		private readonly IServiceProvider _serviceProvider;
		public PasswordDialog(IServiceProvider serviceProvider)
		{
			InitializeComponent();
			_serviceProvider = serviceProvider;
			IPrincipal currentPrincipal = Thread.CurrentPrincipal;
			// Check if the current principal is of the custom principal type
			if (currentPrincipal is CustomPrincipal customPrincipal)
			{
				// Access the custom identity and retrieve the NguoiDung object
				CustomIdentity customIdentity = (CustomIdentity)customPrincipal.Identity;
				_currentUser = new CurrentUser();
				_currentUser.Id = customIdentity.Id;
				_currentUser.Email = customIdentity.Email;
				_currentUser.Name = customIdentity.Name;
				_currentUser.Role = customIdentity.Role;
				_currentUser.Password = customIdentity.Password;
			}
		}

		private void PasswordDialog_Load(object sender, EventArgs e)
		{
			lblNotify.Text = string.Empty;
			lblNotify.BackColor = Color.Red;
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			try
			{
				using var scope = _serviceProvider.CreateScope();
				var customerRepository = scope.ServiceProvider.GetRequiredService<ICustomerRepository>();
				var oldPassword = txtPassword.Text;
				var newPassword = txtNewPassword.Text;
				var verifyPassword = txtVerifyPassword.Text;
				if (ValidationHelper.IsNullOrWhiteSpace(oldPassword, newPassword, verifyPassword) || newPassword.Any(char.IsWhiteSpace))
				{
					throw new Exception("Your password cannot have white space or is empty");
				}

				if (oldPassword != _currentUser.Password)
				{
					throw new Exception("Your password is not correct");
				}

				if (!ValidationHelper.IsValidPassword(newPassword))
				{
					throw new Exception("Password must have minimum 8 characters, at least 1 uppercase letter, 1 lowercase letter and 1 number");
				}

				if (newPassword != verifyPassword)
				{
					throw new Exception("Your new password is not matched");
				}

				var user = customerRepository.Get(x => x.CustomerId.Equals(_currentUser.Id));
				user.Password = newPassword;
				customerRepository.Update(user);

				_currentUser.Password = newPassword;
				var customIdentity = new CustomIdentity(_currentUser);
				var customPrincipal = new CustomPrincipal(customIdentity);
				Thread.CurrentPrincipal = customPrincipal;

				MessageBox.Show("Change password successfully, you should log-in again to refresh your password", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Hide();
			}
			catch (Exception ex)
			{
				lblNotify.Text = ex.Message;
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void txtPassword_Enter(object sender, EventArgs e)
		{
			txtPassword.UseSystemPasswordChar = true;
		}

		private void txtNewPassword_Enter(object sender, EventArgs e)
		{
			txtNewPassword.UseSystemPasswordChar = true;
		}

		private void txtVerifyPassword_Enter(object sender, EventArgs e)
		{
			txtVerifyPassword.UseSystemPasswordChar = true;
		}
	}
}
