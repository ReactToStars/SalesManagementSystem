using BusinessObjects;
using DataAccessObjects.Extensions;
using DataAccessObjects.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repositories;
using SaleManagementWinApp.Authentications;
using System.Drawing.Text;

namespace SaleManagementWinApp
{
	public partial class frmLogin : Form
	{
		private readonly IServiceProvider _serviceProvider;

		public frmLogin(IServiceProvider serviceProvider)
		{
			InitializeComponent();
			_serviceProvider = serviceProvider;
		}

		private void frmLogin_Load(object sender, EventArgs e)
		{

		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			using var scope = _serviceProvider.CreateScope();
			var customerRepository = scope.ServiceProvider.GetRequiredService<ICustomerRepository>();
			var configuration = new ConfigurationBuilder()
								.SetBasePath(Directory.GetCurrentDirectory())
								.AddJsonFile("appsettings.json")
								.Build();
			var email = configuration.GetSection("DefaultAccount").GetSection("email").Value;
			var password = configuration.GetSection("DefaultAccount").GetSection("password").Value;

			if (!ValidationHelper.IsValidEmail(email))
			{
				MessageBox.Show("Your email is not correct format", "Warn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (txtEmail.Text == email && txtPassword.Text == password)
			{
				this.LoadCurrentUser();
				return;
			}

			if (!ValidationHelper.IsValidPassword(txtPassword.Text))
			{
				MessageBox.Show("Your password must has an upper letter, a lower letter, a number and at least 8 characters", "Warn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				var existMember = customerRepository.Get(x => x.Email == txtEmail.Text);
				if (existMember != null)
				{
					if (existMember.Password != txtPassword.Text)
					{
						MessageBox.Show("Your password is not correct", "Warn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
					else
					{
						this.LoadCurrentUser(existMember);
					}
				}
				else
				{
					MessageBox.Show("Your email is not correct", "Warn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}

		private void LoadCurrentUser(Customer? customer = null)
		{
			var currentUser = new CurrentUser();
			if (customer == null)
			{
				currentUser.Email = txtEmail.Text;
				currentUser.Password = txtPassword.Text;
				currentUser.Name = "Admin";
				currentUser.Role = "admin";
			}
			else
			{
				if (customer.CustomerStatus == 0)
				{
					MessageBox.Show("Your account cannot access to the app, please contact the admin", "Warn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				currentUser.Id = customer.CustomerId;
				currentUser.Email = txtEmail.Text;
				currentUser.Password = txtPassword.Text;
				currentUser.Name = customer.CustomerName;
				currentUser.Role = "member";
			}

			// Create a custom identity using your current user instance
			var customIdentity = new CustomIdentity(currentUser);

			// Create a custom principal using the custom identity
			var customPrincipal = new CustomPrincipal(customIdentity);

			// Set the custom principal for the current thread
			Thread.CurrentPrincipal = customPrincipal;

			this.Hide();
			var mainForm = new frmMain(_serviceProvider);
			mainForm.ShowDialog();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void txtPassword_TextChanged(object sender, EventArgs e)
		{
		}

		private void txtPassword_Enter(object sender, EventArgs e)
		{
			//txtPassword.Text = string.Empty;
			txtPassword.UseSystemPasswordChar = true;
		}
	}
}
