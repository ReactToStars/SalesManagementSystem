using AutoMapper;
using BusinessObjects;
using DataAccessObjects;
using DataAccessObjects.Enums;
using DataAccessObjects.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Repositories;
using SaleManagementWinApp.Constant;
using SaleManagementWinApp.Models;

namespace SaleManagementWinApp
{
	public partial class frmCustomer : Form
	{
		public static frmCustomer? Instance;
		public CustomerDialogData CustomerDialogData;
		private readonly IServiceProvider _serviceProvider;

		public frmCustomer(IServiceProvider serviceProvider)
		{
			InitializeComponent();
			_serviceProvider = serviceProvider;
			Instance = this;
		}

		private void frmCustomer_Load(object sender, EventArgs e)
		{
			Display();
			LoadComboBox();

			txtId.Enabled = false;
			txtName.Enabled = false;
			txtEmail.Enabled = false;
			txtCity.Enabled = false;
			txtCountry.Enabled = false;
			dtBirthday.Enabled = false;
			cbxStatus.Enabled = false;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			CustomerDialogData.Id.Enabled = true;
			var customerDialog = new CustomerDialog(_serviceProvider);
			customerDialog.ShowDialog();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtId.Text))
			{
				MessageBox.Show("Please select a customer", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// load dialog
			CustomerDialogData.Id.Enabled = false;
			var customerDialog = new CustomerDialog(_serviceProvider);
			customerDialog.ShowDialog();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				using var scope = _serviceProvider.CreateScope();
				var repository = scope.ServiceProvider.GetRequiredService<ICustomerRepository>();
				if (ValidationHelper.IsNullOrWhiteSpace(txtId.Text) || !int.TryParse(txtId.Text, out int id))
				{
					throw new Exception("Please select a customer");
				}

				var customer = repository.Get(x => x.CustomerId == id);
				if (customer == null)
				{
					throw new Exception("Could not find the customer");
				}

				DialogResult result = MessageBox.Show($"Do you want to delete customer '{customer.CustomerName}'?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (result == DialogResult.Yes)
				{
					repository.Delete(customer);
					MessageBox.Show("Delete customer successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Display();
					Clear();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			Clear();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			try
			{
				using var scope = _serviceProvider.CreateScope();
				var repository = scope.ServiceProvider.GetRequiredService<ICustomerRepository>();
				var mapper = scope.ServiceProvider.GetRequiredService<IMapper>();

				if (ValidationHelper.IsNullOrWhiteSpace(txtSearch.Text))
				{
					throw new Exception("Please type customer id, name or email that you want to find");
				}
				IEnumerable<Customer>? customers = null;
				if (int.TryParse(txtSearch.Text, out int id))
				{
					customers = repository.GetBy(x => x.CustomerId == id);
				}

				if (customers == null || !customers.Any())
				{
					customers = repository.GetBy(x => x.CustomerName.ToLower().Contains(txtSearch.Text.ToLower()) || x.Email.ToLower().Contains(txtSearch.Text.ToLower()) || x.City.Contains(txtSearch.Text.ToLower()) || x.Country.ToLower().Contains(txtSearch.Text.ToLower()));
				}

				if (customers == null || !customers.Any())
				{
					MessageBox.Show("Could not find customer", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					dataGridView1.DataSource = mapper.Map<IEnumerable<CustomerDAO>>(customers);
					string[] headers = ConstantHeaders.Customer;
					int i = 0;
					foreach (var header in headers)
					{
						dataGridView1.Columns[i].HeaderText = header;
						i++;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				var selectedRow = e.RowIndex;

				txtId.Text = dataGridView1.Rows[selectedRow].Cells[0].Value.ToString();
				txtEmail.Text = dataGridView1.Rows[selectedRow].Cells[1].Value.ToString();
				txtName.Text = dataGridView1.Rows[selectedRow].Cells[2].Value.ToString();
				txtCity.Text = dataGridView1.Rows[selectedRow].Cells[3].Value.ToString();
				txtCountry.Text = dataGridView1.Rows[selectedRow].Cells[4].Value.ToString();
				dtBirthday.Value = (DateTime)dataGridView1.Rows[selectedRow].Cells[5].Value;
				var status = dataGridView1.Rows[selectedRow].Cells[6].Value.ToString();
				cbxStatus.SelectedIndex = status == "1" ? 0 : 1;
			}
		}

		private void Display()
		{
			using var scope = _serviceProvider.CreateScope();
			var repository = scope.ServiceProvider.GetRequiredService<ICustomerRepository>();
			var mapper = scope.ServiceProvider.GetRequiredService<IMapper>();

			dataGridView1.DataSource = mapper.Map<IEnumerable<CustomerDAO>>(repository.GetAll());

			string[] headers = ConstantHeaders.Customer;
			int i = 0;
			foreach (var header in headers)
			{
				dataGridView1.Columns[i].HeaderText = header;
				i++;
			}

			// Load dialog
			CustomerDialogData = new()
			{
				Id = txtId,
				Name = txtName,
				Email = txtEmail,
				City = txtCity,
				Country = txtCountry,
				BirthDay = dtBirthday,
				Status = cbxStatus
			};
		}

		private void Clear()
		{
			txtId.Text = string.Empty;
			txtEmail.Text = string.Empty;
			txtCity.Text = string.Empty;
			txtCountry.Text = string.Empty;
			dtBirthday.Value = DateTime.Now;
			txtName.Text = string.Empty;
			txtName.Text = string.Empty;
			cbxStatus.SelectedIndex = 0;
			txtSearch.Text = string.Empty;
			Display();
		}

		private void LoadComboBox()
		{
			cbxStatus.DataSource = new List<string> { Status.Active.ToString(), Status.Inactive.ToString() };
		}
	}

}
