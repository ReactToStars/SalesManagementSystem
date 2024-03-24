using AutoMapper;
using BusinessObjects;
using DataAccessObjects;
using Microsoft.Extensions.DependencyInjection;
using Repositories;
using SaleManagementWinApp.Constant;
using SaleManagementWinApp.Models;

namespace SaleManagementWinApp
{
	public partial class frmOrderDetail : Form
	{
		public static frmOrderDetail? Instance;
		public OrderDetailDialogData? orderDetailDialogData;
		private readonly IServiceProvider _serviceProvider;
		public Order _order;
		public frmOrderDetail(IServiceProvider serviceProvider, Order order)
		{
			InitializeComponent();
			_serviceProvider = serviceProvider;
			Instance = this;
			_order = order;
		}

		private void frmOrderDetail_Load(object sender, EventArgs e)
		{
			LoadComboBox();
			Display();
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			using var scope = _serviceProvider.CreateScope();
			var orderRepository = scope.ServiceProvider.GetRequiredService<IOrderRepository>();
			if (_order.Total != null && _order.Total != 0)
			{
				orderRepository.Update(_order);
			}
			else
			{
				orderRepository.Add(_order);
			}
			this.Hide();
			if(OrderDialog.Instance != null)
			{
				OrderDialog.Instance.Hide();
			}
			frmOrder.Instance.Display();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			orderDetailDialogData.Product.Enabled = true;
			_order.Total = 0;
			var orderDetailDialog = new OrderDetailDialog(_serviceProvider, this._order);
			orderDetailDialog.ShowDialog();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtId.Text))
			{
				DialogResult result = MessageBox.Show($"Please select a product to edit", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				orderDetailDialogData.Product.Enabled = false;
				var orderDetailDialog = new OrderDetailDialog(_serviceProvider, this._order);
				orderDetailDialog.ShowDialog();
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				using var scope = _serviceProvider.CreateScope();
				var repository = scope.ServiceProvider.GetRequiredService<IOrderDetailRepository>();
				var orderRepository = scope.ServiceProvider.GetRequiredService<IOrderRepository>();
				if (!int.TryParse(txtId.Text, out int id) || cbxProduct.SelectedValue == null)
				{
					throw new Exception("Please select an item");
				}

				var orderDetail = repository.Get(x => x.OrderId == id && x.FlowerBouquetId == (int)cbxProduct.SelectedValue);
				if (orderDetail == null)
				{
					throw new Exception($"Could not find the item '{cbxProduct.Text}' in order '{id}'");
				}

				DialogResult result = MessageBox.Show($"Do you want to delete item '{cbxProduct.Text}'?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (result == DialogResult.Yes)
				{
					repository.Delete(orderDetail);
					MessageBox.Show("Delete item successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this._order.Total = repository.GetBy(x => x.OrderId == this._order.OrderId).Sum(x => x.Quantity * x.UnitPrice * (1 - (decimal)x.Discount / 100));
					orderRepository.Update(this._order);
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
			var productRepository = scope.ServiceProvider.GetRequiredService<IProductRepository>();
			var products = productRepository.GetAll().Select(x => x.FlowerBouquetId).ToList();
			var discounts = new List<double>() { 0, 5, 10, 20, 25, 50, 75, 100 };
			if (e.RowIndex > -1)
			{
				var selectedRow = e.RowIndex;

				txtId.Text = dataGridView1.Rows[selectedRow].Cells[0].Value.ToString();
				var productId = (int)dataGridView1.Rows[selectedRow].Cells[1].Value;
				cbxProduct.SelectedIndex = products.IndexOf(productId);
				txtUnitPrice.Text = dataGridView1.Rows[selectedRow].Cells[3].Value.ToString();
				numQuantity.Text = dataGridView1.Rows[selectedRow].Cells[4].Value.ToString();
				var discount = (double)dataGridView1.Rows[selectedRow].Cells[5].Value;
				cbxDiscount.SelectedIndex = discounts.IndexOf(discount);
			}
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			Clear();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		public void Display()
		{
			using var scope = _serviceProvider.CreateScope();
			var orderRepository = scope.ServiceProvider.GetRequiredService<IOrderRepository>();
			var repository = scope.ServiceProvider.GetRequiredService<IOrderDetailRepository>();
			var productRepository = scope.ServiceProvider.GetRequiredService<IProductRepository>();
			var mapper = scope.ServiceProvider.GetRequiredService<IMapper>();

			dataGridView1.DataSource = mapper.Map<IEnumerable<OrderDetailDAO>>(repository.GetBy(x => x.OrderId == _order.OrderId));

			string[] headers = ConstantHeaders.OrderDetails;
			int i = 0;
			foreach (var header in headers)
			{
				dataGridView1.Columns[i].HeaderText = header;
				i++;
			}

			// Load dialog
			orderDetailDialogData = new()
			{
				Id = txtId,
				Product = cbxProduct,
				UnitPrice = txtUnitPrice,
				Quantity = numQuantity,
				Discount = cbxDiscount
			};

			txtId.Text = _order.OrderId.ToString();

			txtId.Enabled = false;
			txtUnitPrice.Enabled = false;
			numQuantity.Enabled = false;
			cbxDiscount.Enabled = false;
			cbxProduct.Enabled = false;
			var order = orderRepository.Get(x => x.OrderId == _order.OrderId);
			if (order != null)
			{
				_order = order;
			}

			if (_order.Total == null || _order.Total == 0)
			{
				btnSubmit.Enabled = false;
				btnEdit.Enabled = false;
			}
			else
			{
				btnSubmit.Enabled = true;
				btnEdit.Enabled = true;
			}

			var productId = (KeyValuePair<int, string>)cbxProduct.SelectedItem;
			txtUnitPrice.Text = productRepository.Get(x => x.FlowerBouquetId == productId.Key).UnitPrice.ToString();
		}

		private void Clear()
		{
			using var scope = _serviceProvider.CreateScope();
			var productRepository = scope.ServiceProvider.GetRequiredService<IProductRepository>();
			var productId = (KeyValuePair<int, string>)cbxProduct.SelectedItem;
			txtUnitPrice.Text = productRepository.Get(x => x.FlowerBouquetId == productId.Key).UnitPrice.ToString();
			numQuantity.Value = 0;
			cbxDiscount.SelectedIndex = 0;
			Display();
		}

		private void LoadComboBox()
		{
			using var scope = _serviceProvider.CreateScope();
			var productRepository = scope.ServiceProvider.GetRequiredService<IProductRepository>();
			var mapper = scope.ServiceProvider.GetRequiredService<IMapper>();

			cbxDiscount.DataSource = new List<string>() { "0", "5%", "20%", "25%", "50%", "75%", "100%" };

			// load Product
			var products = mapper.Map<IEnumerable<FlowerBouquetDAO>>(productRepository.GetAll());
			var productDataSource = new Dictionary<int, string>();
			foreach (var product in products)
			{
				productDataSource.Add(product.FlowerBouquetId, product.FlowerBouquetName);
			}

			cbxProduct.DataSource = new BindingSource(productDataSource, null);
			cbxProduct.DisplayMember = "Value";
			cbxProduct.ValueMember = "Key";
			cbxProduct.DropDownHeight = cbxProduct.Font.Height * 10;
		}
	}
}
