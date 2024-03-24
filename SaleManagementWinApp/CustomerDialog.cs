using BusinessObjects;
using DataAccessObjects.Enums;
using DataAccessObjects.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Repositories;
using System;

namespace SaleManagementWinApp
{
	public partial class CustomerDialog : Form
	{
		private readonly IServiceProvider _serviceProvider;
		public CustomerDialog(IServiceProvider serviceProvider)
		{
			InitializeComponent();
			_serviceProvider = serviceProvider;
		}

		private void CustomerDialog_Load(object sender, EventArgs e)
		{
			this.LoadComboBox();
			if (frmCustomer.Instance?.CustomerDialogData != null)
			{
				txtId.Enabled = frmCustomer.Instance?.CustomerDialogData.Id.Enabled ?? false;
				txtId.Text = frmCustomer.Instance?.CustomerDialogData.Id.Text;
				txtName.Text = frmCustomer.Instance?.CustomerDialogData.Name.Text;
				txtEmail.Text = frmCustomer.Instance?.CustomerDialogData.Email.Text;
				txtCity.Text = frmCustomer.Instance?.CustomerDialogData.City.Text;
				txtCountry.Text = frmCustomer.Instance?.CustomerDialogData.Country.Text;
				dtBirthday.Value = frmCustomer.Instance?.CustomerDialogData.BirthDay.Value ?? DateTime.Now;
				cbxStatus.SelectedIndex = frmCustomer.Instance?.CustomerDialogData.Status.SelectedIndex ?? 0;
			}
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			if (txtId.Enabled)
			{
				this.Add();
			}
			else
			{
				this.Edit();
			}
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			Clear();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void Add()
		{
			try
			{
				using var scope = _serviceProvider.CreateScope();
				var repository = scope.ServiceProvider.GetRequiredService<ICustomerRepository>();
				if (ValidationHelper.IsNullOrWhiteSpace(txtId.Text, txtEmail.Text, txtName.Text, txtCity.Text, txtCountry.Text))
				{
					throw new Exception("Do not accept empty value");
				}

				if (!int.TryParse(txtId.Text, out int id))
				{
					throw new Exception("Customer id must be integer");
				}

				if (!ValidationHelper.IsValidEmail(txtEmail.Text))
				{
					throw new Exception("Invalid email");
				}

				if (!ValidationHelper.IsValidText(txtName.Text, txtCity.Text, txtCountry.Text))
				{
					throw new Exception("Name, City, Country must be text");
				}

				var exist = repository.Get(x => x.CustomerId == id || x.Email == txtEmail.Text);
				if (exist != null)
				{
					throw new Exception("This customer id or email is used, please use the other");
				}
				var customer = new Customer()
				{
					CustomerId = id,
					Email = txtEmail.Text,
					CustomerName = txtName.Text,
					City = txtCity.Text,
					Country = txtCountry.Text,
					Password = "Password1",
					Birthday = dtBirthday.Value,
					CustomerStatus = cbxStatus.Text == "Active" ? (byte)1 : (byte)0
				};
				repository.Add(customer);
				MessageBox.Show("Add new customer successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Clear();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Edit()
		{
			try
			{
				using var scope = _serviceProvider.CreateScope();
				var repository = scope.ServiceProvider.GetRequiredService<ICustomerRepository>();

				if (ValidationHelper.IsNullOrWhiteSpace(txtId.Text, txtEmail.Text, txtName.Text, txtCity.Text, txtCountry.Text))
				{
					throw new Exception("Do not accept empty value");
				}

				if (ValidationHelper.IsNullOrWhiteSpace(txtId.Text))
				{
					throw new Exception("Please select a customer");
				}

				if (!ValidationHelper.IsValidEmail(txtEmail.Text))
				{
					throw new Exception("Invalid email");
				}

				if (!ValidationHelper.IsValidText(txtName.Text, txtCity.Text, txtCountry.Text))
				{
					throw new Exception("Name, City, Country must be text");
				}

				var existEmail = repository.GetBy(x => x.Email == txtEmail.Text && x.CustomerId != int.Parse(txtId.Text));
				if (existEmail != null && existEmail.Any())
				{
					throw new Exception("This email is used, please use the other");
				}

				var customer = repository.Get(x => x.CustomerId == int.Parse(txtId.Text));
				if (customer == null)
				{
					throw new Exception("Could not find the customer");
				}

				customer.Email = txtEmail.Text;
				customer.CustomerName = txtName.Text;
				customer.City = txtCity.Text;
				customer.Country = txtCountry.Text;
				customer.Birthday = dtBirthday.Value;
				customer.CustomerStatus = cbxStatus.Text == "Active" ? (byte)1 : (byte)0;

				DialogResult result = MessageBox.Show("Do you want to update this customer?", "Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (result == DialogResult.Yes)
				{
					repository.Update(customer);
					MessageBox.Show("Update customer successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Clear()
		{
			if (txtId.Enabled)
			{
				txtId.Text = string.Empty;
				txtEmail.Text = string.Empty;
				txtCity.Text = string.Empty;
				txtCountry.Text = string.Empty;
				dtBirthday.Value = DateTime.Now;
				txtName.Text = string.Empty;
				txtName.Text = string.Empty;
				cbxStatus.SelectedIndex = 0;
			}
		}

		private void LoadComboBox()
		{
			cbxStatus.DataSource = new List<string> { Status.Active.ToString(), Status.Inactive.ToString() };
		}
	}
}
