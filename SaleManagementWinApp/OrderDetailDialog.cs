using AutoMapper;
using BusinessObjects;
using DataAccessObjects;
using DataAccessObjects.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Repositories;

namespace SaleManagementWinApp
{
	public partial class OrderDetailDialog : Form
	{
		private readonly IServiceProvider _serviceProvider;
		private Order _order;

		public OrderDetailDialog(IServiceProvider serviceProvider, Order order)
		{
			InitializeComponent();
			_serviceProvider = serviceProvider;
			_order = order;
		}

		private void OrderDetailDialog_Load(object sender, EventArgs e)
		{
			txtUnitPrice.Enabled = false;
			txtId.Enabled = false;
			LoadComboBox();

			using var scope = _serviceProvider.CreateScope();
			var productRepository = scope.ServiceProvider.GetRequiredService<IProductRepository>();
			txtId.Text = frmOrderDetail.Instance.orderDetailDialogData.Id.Text;
			cbxProduct.SelectedIndex = frmOrderDetail.Instance.orderDetailDialogData.Product.SelectedIndex;
			cbxProduct.Enabled = frmOrderDetail.Instance.orderDetailDialogData.Product.Enabled;
			numQuantity.Value = frmOrderDetail.Instance.orderDetailDialogData.Quantity.Value;
			cbxDiscount.SelectedIndex = frmOrderDetail.Instance.orderDetailDialogData.Discount.SelectedIndex;

			var productId = (KeyValuePair<int, string>)cbxProduct.SelectedItem;
			txtUnitPrice.Text = productRepository.Get(x => x.FlowerBouquetId == productId.Key).UnitPrice.ToString();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Upsert();
		}


		private void cbxProduct_SelectedValueChanged(object sender, EventArgs e)
		{
			using var scope = _serviceProvider.CreateScope();
			var productRepository = scope.ServiceProvider.GetRequiredService<IProductRepository>();
			var productId = (KeyValuePair<int, string>)cbxProduct.SelectedItem;
			txtUnitPrice.Text = productRepository.Get(x => x.FlowerBouquetId == productId.Key).UnitPrice.ToString();
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			Clear();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			frmOrderDetail.Instance.Display();
		}


		private void Upsert()
		{
			try
			{
				using var scope = _serviceProvider.CreateScope();
				var orderRepository = scope.ServiceProvider.GetRequiredService<IOrderRepository>();
				var orderDetailRepository = scope.ServiceProvider.GetRequiredService<IOrderDetailRepository>();

				if (!int.TryParse(txtId.Text, out int id))
				{
					throw new Exception("Order id must be integer");
				}

				if (numQuantity.Value < 1)
				{
					throw new Exception("Quantity must be integer and greater than 0");
				}

				var unitPrice = decimal.Parse(txtUnitPrice.Text);
				decimal total = 0;
				var discount = cbxDiscount.SelectedItem.ToString().Split('%').First();
				var orderExist = orderRepository.Get(x => x.OrderId == id);
				if (orderExist != null)
				{
					var orderDetailExist = orderDetailRepository.Get(x => x.OrderId == id && x.FlowerBouquetId == (int)cbxProduct.SelectedValue);

					if (orderDetailExist != null)
					{
						if (cbxProduct.Enabled)
						{
							throw new Exception($"This product is already exist in order '{_order.OrderId}'");
						}
						orderDetailExist.Quantity = (int)numQuantity.Value;
						orderDetailExist.Discount = double.Parse(discount);
						orderDetailRepository.Update(orderDetailExist);
					}
					else
					{
						var orderDetail = new OrderDetail()
						{
							OrderId = id,
							FlowerBouquetId = (int)cbxProduct.SelectedValue,
							UnitPrice = unitPrice,
							Quantity = (int)numQuantity.Value,
							Discount = double.Parse(discount)
						};
						orderDetailRepository.Add(orderDetail);
					}

					var order = orderRepository.Get(x => x.OrderId == _order.OrderId);
					order.Total = order.OrderDetails.Sum(x => x.UnitPrice * x.Quantity * (1 - decimal.Parse(discount) / 100));
					orderRepository.Update(order);
					MessageBox.Show($"Update order '{id}' successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					_order.Total = unitPrice * numQuantity.Value * (1 - decimal.Parse(discount) / 100);
					orderRepository.Add(_order);
					var orderDetail = new OrderDetail()
					{
						OrderId = id,
						FlowerBouquetId = (int)cbxProduct.SelectedValue,
						UnitPrice = unitPrice,
						Quantity = (int)numQuantity.Value,
						Discount = double.Parse(cbxDiscount.SelectedValue.ToString().Split("%").First())
					};

					orderDetailRepository.Add(orderDetail);
					MessageBox.Show($"Add new order '{id}' successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

				Clear();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Clear()
		{
			using var scope = _serviceProvider.CreateScope();
			var productRepository = scope.ServiceProvider.GetRequiredService<IProductRepository>();
			var productId = (KeyValuePair<int, string>)cbxProduct.SelectedItem;
			txtUnitPrice.Text = productRepository.Get(x => x.FlowerBouquetId == productId.Key).UnitPrice.ToString();
			numQuantity.Value = 0;
			cbxDiscount.SelectedIndex = 0;
		}

		private void LoadComboBox()
		{
			using var scope = _serviceProvider.CreateScope();
			var productRepository = scope.ServiceProvider.GetRequiredService<IProductRepository>();
			var mapper = scope.ServiceProvider.GetRequiredService<IMapper>();

			cbxDiscount.DataSource = new List<string>() { "0", "5%", "20%", "25%", "50%", "75%", "100%" };

			// load products
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
