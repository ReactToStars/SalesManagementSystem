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
	public partial class frmOrder : Form
	{
		public static frmOrder? Instance;
		public OrderDialogData? orderDialogData;
		private Order order;
		private readonly IServiceProvider _serviceProvider;
		private readonly List<string> orderStatusSource = new List<string> {
				OrderStatus.Completed.ToString(),
				OrderStatus.Shipping.ToString(),
				OrderStatus.Cancelled.ToString(),
			};
		public frmOrder(IServiceProvider serviceProvider)
		{
			InitializeComponent();
			_serviceProvider = serviceProvider;
			Instance = this;
		}

		private void btnDetails_Click(object sender, EventArgs e)
		{
			if (frmOrderDetail.Instance != null)
			{
				frmOrderDetail.Instance._order = order;
				frmOrderDetail.Instance.ShowDialog();
			}
			else
			{
				frmOrderDetail frmod = new frmOrderDetail(_serviceProvider, order);
				frmod.ShowDialog();
			}
		}

		private void frmOrder_Load(object sender, EventArgs e)
		{
			LoadComboBox();
			Display();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			orderDialogData.Id.Enabled = true;
			orderDialogData.Customer.Enabled = true;
			var orderDialog = new OrderDialog(_serviceProvider);
			orderDialog.ShowDialog();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtId.Text))
			{
				MessageBox.Show("Please select an order", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// load dialog
			orderDialogData.Id.Enabled = false;
			orderDialogData.Customer.Enabled = false;
			var orderDialog = new OrderDialog(_serviceProvider);
			orderDialog.ShowDialog();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				using var scope = _serviceProvider.CreateScope();
				var repository = scope.ServiceProvider.GetRequiredService<IOrderRepository>();
				if (ValidationHelper.IsNullOrWhiteSpace(txtId.Text) || !int.TryParse(txtId.Text, out int id))
				{
					throw new Exception("Please select an order");
				}

				var order = repository.Get(x => x.OrderId == id);
				if (order == null)
				{
					throw new Exception($"Could not find the order '{id}'");
				}

				DialogResult result = MessageBox.Show($"Do you want to delete order '{id}'?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (result == DialogResult.Yes)
				{
					repository.Delete(order);
					MessageBox.Show("Delete order successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Display();
					Clear();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			using var scope = _serviceProvider.CreateScope();
			var customerRepository = scope.ServiceProvider.GetRequiredService<ICustomerRepository>();
			var customers = customerRepository.GetBy(x => x.CustomerStatus == 1).Select(x => x.CustomerId).ToList();
			if (e.RowIndex > -1)
			{
				var selectedRow = e.RowIndex;

				txtId.Text = dataGridView1.Rows[selectedRow].Cells[0].Value.ToString();
				var customerId = (int)dataGridView1.Rows[selectedRow].Cells[1].Value;
				cbxCustomer.SelectedIndex = customers.IndexOf(customerId);
				dtOrderDate.Value = (DateTime)dataGridView1.Rows[selectedRow].Cells[3].Value;
				dtShippedDate.Value = (DateTime)dataGridView1.Rows[selectedRow].Cells[4].Value;
				txtTotal.Text = dataGridView1.Rows[selectedRow].Cells[5].Value.ToString();
				var status = dataGridView1.Rows[selectedRow].Cells[6].Value.ToString();
				cbxStatus.SelectedIndex = this.orderStatusSource.IndexOf(status.Trim());

				order = new Order()
				{
					OrderId = int.Parse(txtId.Text),
					CustomerId = (int)cbxCustomer.SelectedValue,
					OrderDate = dtOrderDate.Value,
					ShippedDate = dtShippedDate.Value,
					Total = decimal.Parse(txtTotal.Text),
					OrderStatus = cbxStatus.SelectedValue.ToString()
				};

				btnDetails.Enabled = true;
			}
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			Clear();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			try
			{
				using var scope = _serviceProvider.CreateScope();
				var repository = scope.ServiceProvider.GetRequiredService<IOrderRepository>();
				var mapper = scope.ServiceProvider.GetRequiredService<IMapper>();

				if (ValidationHelper.IsNullOrWhiteSpace(txtSearch.Text))
				{
					throw new Exception("Please type order id, customer id or customer name that you want to find");
				}
				IEnumerable<BusinessObjects.Order>? orders = null;
				if (int.TryParse(txtSearch.Text, out int id))
				{
					orders = repository.GetBy(x => x.OrderId == id);
				}

				if (orders == null || !orders.Any())
				{
					orders = repository.GetBy(x => x.CustomerId.ToString().Equals(txtSearch.Text) || x.Customer.CustomerName.ToLower().Contains(txtSearch.Text.ToLower()));
				}

				if (orders == null || !orders.Any())
				{
					MessageBox.Show($"Could not find order", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					dataGridView1.DataSource = mapper.Map<IEnumerable<DataAccessObjects.OrderDAO>>(orders);
					string[] headers = ConstantHeaders.Order;
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

		public void Display()
		{
			using var scope = _serviceProvider.CreateScope();
			var repository = scope.ServiceProvider.GetRequiredService<IOrderRepository>();
			var mapper = scope.ServiceProvider.GetRequiredService<IMapper>();

			dataGridView1.DataSource = mapper.Map<IEnumerable<DataAccessObjects.OrderDAO>>(repository.GetAll());

			string[] headers = ConstantHeaders.Order;
			int i = 0;
			foreach (var header in headers)
			{
				dataGridView1.Columns[i].HeaderText = header;
				i++;
			}

			// Load dialog
			orderDialogData = new()
			{
				Id = txtId,
				Customer = cbxCustomer,
				OrderDate = dtOrderDate,
				ShippedDate = dtShippedDate,
				Total = txtTotal,
				Status = cbxStatus
			};

			if (string.IsNullOrEmpty(txtId.Text))
			{
				btnDetails.Enabled = false;
			}
			else
			{
				btnDetails.Enabled = true;
			}

			txtId.Enabled = false;
			cbxCustomer.Enabled = false;
			cbxStatus.Enabled = false;
			txtTotal.Enabled = false;
			dtOrderDate.Enabled = false;
			dtShippedDate.Enabled = false;
		}

		private void Clear()
		{
			txtId.Text = string.Empty;
			cbxCustomer.SelectedIndex = 0;
			dtOrderDate.Value = DateTime.Now;
			dtShippedDate.Value = DateTime.Now;
			txtTotal.Text = string.Empty;
			cbxStatus.SelectedIndex = 0;
			txtSearch.Text = string.Empty;
			Display();
		}

		private void LoadComboBox()
		{
			using var scope = _serviceProvider.CreateScope();
			var customerRepository = scope.ServiceProvider.GetRequiredService<ICustomerRepository>();
			var mapper = scope.ServiceProvider.GetRequiredService<IMapper>();

			// load Customer
			var customers = mapper.Map<IEnumerable<CustomerDAO>>(customerRepository.GetBy(x => x.CustomerStatus == 1));
			var customerDataSource = new Dictionary<int, string>();
			foreach (var customer in customers)
			{
				customerDataSource.Add(customer.CustomerId, customer.CustomerName);
			}

			cbxCustomer.DataSource = new BindingSource(customerDataSource, null);
			cbxCustomer.DisplayMember = "Value";
			cbxCustomer.ValueMember = "Key";
			cbxCustomer.DropDownHeight = cbxCustomer.Font.Height * 10;

			cbxStatus.DataSource = this.orderStatusSource;
		}
	}
}
