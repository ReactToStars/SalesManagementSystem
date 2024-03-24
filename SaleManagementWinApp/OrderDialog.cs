using AutoMapper;
using BusinessObjects;
using DataAccessObjects;
using DataAccessObjects.Enums;
using DataAccessObjects.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Repositories;
using SaleManagementWinApp.Models;

namespace SaleManagementWinApp
{
	public partial class OrderDialog : Form
	{
		private readonly IServiceProvider _serviceProvider;
		public static OrderDialog Instance;
		public OrderDialogData? orderDialogData;
		public OrderDialog(IServiceProvider serviceProvider)
		{
			InitializeComponent();
			_serviceProvider = serviceProvider;
			Instance = this;
		}

		private void OrderDialog_Load(object sender, EventArgs e)
		{
			txtTotal.Enabled = false;
			LoadComboBox();

			txtId.Enabled = frmOrder.Instance.orderDialogData.Id.Enabled;
			txtId.Text = frmOrder.Instance.orderDialogData.Id.Text;
			cbxCustomer.Enabled = frmOrder.Instance.orderDialogData.Customer.Enabled;
			cbxCustomer.SelectedIndex = frmOrder.Instance.orderDialogData.Customer.SelectedIndex;
			dtOrderDate.Value = frmOrder.Instance.orderDialogData.OrderDate.Value;
			dtShippedDate.Value = frmOrder.Instance.orderDialogData.ShippedDate.Value;
			cbxStatus.SelectedIndex = frmOrder.Instance.orderDialogData.Status.SelectedIndex;
			if (txtId.Enabled)
			{
				txtTotal.Text = "0";
			}
			else
			{
				txtTotal.Text = frmOrder.Instance.orderDialogData.Total.Text;
			}
		}

		private void btnDetails_Click(object sender, EventArgs e)
		{
			if (txtId.Enabled)
			{
				Add();
			}
			else
			{
				Edit();
			}
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			Clear();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			frmOrder.Instance.Display();
		}

		private void Add()
		{
			try
			{
				using var scope = _serviceProvider.CreateScope();
				var mapper = scope.ServiceProvider.GetRequiredService<IMapper>();
				var repository = scope.ServiceProvider.GetRequiredService<IOrderRepository>();

				if (!int.TryParse(txtId.Text, out int id) || id < 0)
				{
					throw new Exception("Order id must be integer and greater than 0");
				}

				if (dtShippedDate.Value < dtOrderDate.Value)
				{
					throw new Exception("'Shipped date' must greater than 'Order date'");
				}


				var exist = repository.Get(x => x.OrderId == id);
				if (exist != null)
				{
					throw new Exception("Order id is exist, please use the other");
				}

				var order = new Order()
				{
					OrderId = id,
					CustomerId = cbxCustomer.SelectedIndex,
					OrderDate = dtOrderDate.Value,
					ShippedDate = dtOrderDate.Value,
					OrderStatus = cbxStatus.SelectedValue.ToString(),
				};

				var frmOrderDetail = new frmOrderDetail(_serviceProvider, order);
				frmOrderDetail.ShowDialog();
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
				var mapper = scope.ServiceProvider.GetRequiredService<IMapper>();
				var repository = scope.ServiceProvider.GetRequiredService<IOrderRepository>();

				if (ValidationHelper.IsNullOrWhiteSpace(txtId.Text))
				{
					throw new Exception("Please select an order");
				}

				if (dtShippedDate.Value < dtOrderDate.Value)
				{
					throw new Exception("'Shipped date' must greater than 'Order date'");
				}

				var order = repository.Get(x => x.OrderId == int.Parse(txtId.Text));
				if (order == null)
				{
					throw new Exception("Could not find the order");
				}

				order.CustomerId = (int)cbxCustomer.SelectedValue;
				order.OrderDate = dtOrderDate.Value;
				order.ShippedDate = dtShippedDate.Value;
				order.OrderStatus = (string)cbxStatus.SelectedValue;

				var frmOrderDetail = new frmOrderDetail(_serviceProvider, order);
				frmOrderDetail.ShowDialog();
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
			}
			cbxCustomer.SelectedIndex = 0;
			dtOrderDate.Value = DateTime.Now;
			dtShippedDate.Value = DateTime.Now;
			txtTotal.Text = string.Empty;
			cbxStatus.SelectedIndex = 0;
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

			cbxStatus.DataSource = new List<string> {
				OrderStatus.Completed.ToString(),
				OrderStatus.Shipping.ToString(),
				OrderStatus.Cancelled.ToString(),
			};
		}
	}
}
