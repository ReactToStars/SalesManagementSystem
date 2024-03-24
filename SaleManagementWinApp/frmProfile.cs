using DataAccessObjects.Extensions;
using DataAccessObjects.Models;
using Microsoft.Extensions.DependencyInjection;
using Repositories;
using SaleManagementWinApp.Authentications;
using System.Security.Principal;

namespace SaleManagementWinApp
{
	public partial class frmProfile : Form
	{
		private CurrentUser _currentUser;
		private readonly IServiceProvider _serviceProvider;
		public frmProfile(IServiceProvider serviceProvider)
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
				if (currentPrincipal.IsInRole("admin"))
				{
					btnSubmit.Enabled = false;
					txtEmail.Enabled = false;
					txtName.Enabled = false;
					txtCity.Enabled = false;
					txtCountry.Enabled = false;
					dtBirthday.Enabled = false;
					btnChangePassword.Enabled = false;
				}
			}
		}

		private void frmProfile_Load(object sender, EventArgs e)
		{
			using var scope = _serviceProvider.CreateScope();
			var customerRepository = scope.ServiceProvider.GetRequiredService<ICustomerRepository>();
			txtEmail.Text = _currentUser.Email;
			txtName.Text = _currentUser.Name;
			if (_currentUser.Id != null)
			{
				var customer = customerRepository.Get(x => x.CustomerId.Equals(_currentUser.Id));
				if (customer != null)
				{
					txtCity.Text = customer.City;
					txtCountry.Text = customer.Country;
					dtBirthday.Value = customer.Birthday ?? default;
				}
			}
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			try
			{
				using var scope = _serviceProvider.CreateScope();
				var repository = scope.ServiceProvider.GetRequiredService<ICustomerRepository>();

				if (ValidationHelper.IsNullOrWhiteSpace(txtEmail.Text, txtName.Text, txtCity.Text, txtCountry.Text))
				{
					throw new Exception("Do not accept empty value");
				}

				if (!ValidationHelper.IsValidEmail(txtEmail.Text))
				{
					throw new Exception("Invalid email");
				}

				if (!ValidationHelper.IsValidText(txtName.Text, txtCity.Text, txtCountry.Text))
				{
					throw new Exception("Name, City, Country must be text");
				}

				var existEmail = repository.GetBy(x => x.Email == txtEmail.Text && x.CustomerId != _currentUser.Id);
				if (existEmail != null && existEmail.Any())
				{
					throw new Exception("This email is used, please use the other");
				}

				var customer = repository.Get(x => x.CustomerId == _currentUser.Id);
				if (customer == null)
				{
					throw new Exception("Some errors have occurred");
				}

				customer.Email = txtEmail.Text;
				customer.CustomerName = txtName.Text;
				customer.City = txtCity.Text;
				customer.Country = txtCountry.Text;
				customer.Birthday = dtBirthday.Value;

				DialogResult result = MessageBox.Show("Do you want to update your profile?", "Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (result == DialogResult.Yes)
				{
					repository.Update(customer);
					_currentUser.Email = customer.Email;
					_currentUser.Name = customer.CustomerName;
					var customIdentity = new CustomIdentity(_currentUser);
					var customPrincipal = new CustomPrincipal(customIdentity);
					Thread.CurrentPrincipal = customPrincipal;

					MessageBox.Show("Update information successfully, you should log-in again to refresh your profile", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnChangePassword_Click(object sender, EventArgs e)
		{
			var passwordDialog = new PasswordDialog(_serviceProvider);
			passwordDialog.ShowDialog();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
