using AutoMapper;
using BusinessObjects;
using DataAccessObjects;
using DataAccessObjects.Enums;
using DataAccessObjects.Extensions;
using DataAccessObjects.Models;
using Microsoft.Extensions.DependencyInjection;
using Repositories;
using SaleManagementWinApp.Authentications;
using SaleManagementWinApp.Constant;
using System.Security.Principal;

namespace SaleManagementWinApp
{
	public partial class frmOrderHistory : Form
	{
		private CurrentUser _currentUser;
		private readonly IServiceProvider _serviceProvider;
		private readonly List<string> orderStatusSource = new List<string> {
				OrderStatus.Completed.ToString(),
				OrderStatus.Shipping.ToString(),
				OrderStatus.Cancelled.ToString(),
			};
		public frmOrderHistory(IServiceProvider serviceProvider)
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
			}
		}

		private void frmOrderHistory_Load(object sender, EventArgs e)
		{
			txtId.Enabled = false;
			txtTotal.Enabled = false;
			dtOrderDate.Enabled = false;
			dtShippedDate.Enabled = false;
			cbxStatus.Enabled = false;
			btnDetails.Enabled = false;
			Display();
			LoadComboBox();
		}

		private void btnFind_Click(object sender, EventArgs e)
		{
			try
			{
				using var scope = _serviceProvider.CreateScope();
				var repository = scope.ServiceProvider.GetRequiredService<IOrderRepository>();
				var mapper = scope.ServiceProvider.GetRequiredService<IMapper>();

				if (ValidationHelper.IsNullOrWhiteSpace(txtFind.Text))
				{
					throw new Exception("Please enter order number that you want to find");
				}
				IEnumerable<BusinessObjects.Order>? orders = null;
				orders = repository.GetBy(x => x.CustomerId.Equals(_currentUser.Id) && x.OrderId.ToString().Contains(txtFind.Text));

				if (orders == null || !orders.Any())
				{
					MessageBox.Show($"Could not find order", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					dataGridView1.DataSource = mapper.Map<IEnumerable<DataAccessObjects.HistoryOrderDAO>>(orders);
					string[] headers = ConstantHeaders.HistoryOrders;
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

		public void Display()
		{
			using var scope = _serviceProvider.CreateScope();
			var repository = scope.ServiceProvider.GetRequiredService<IOrderRepository>();
			var mapper = scope.ServiceProvider.GetRequiredService<IMapper>();

			dataGridView1.DataSource = mapper.Map<IEnumerable<DataAccessObjects.HistoryOrderDAO>>(repository.GetBy(x => x.CustomerId.Equals(_currentUser.Id)));

			string[] headers = ConstantHeaders.HistoryOrders;
			int i = 0;
			foreach (var header in headers)
			{
				dataGridView1.Columns[i].HeaderText = header;
				i++;
			}
		}

		private void btnDetails_Click(object sender, EventArgs e)
		{
			var order = new Order { OrderId = int.Parse(txtId.Text)};
			var frmHistoryOrderDetails = new frmHistoryOrderDetails(_serviceProvider, order);
			frmHistoryOrderDetails.ShowDialog();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				var selectedRow = e.RowIndex;

				txtId.Text = dataGridView1.Rows[selectedRow].Cells[0].Value.ToString();
				dtOrderDate.Value = (DateTime)dataGridView1.Rows[selectedRow].Cells[1].Value;
				dtShippedDate.Value = (DateTime)dataGridView1.Rows[selectedRow].Cells[2].Value;
				txtTotal.Text = dataGridView1.Rows[selectedRow].Cells[3].Value.ToString();
				var status = dataGridView1.Rows[selectedRow].Cells[4].Value.ToString();
				cbxStatus.SelectedIndex = this.orderStatusSource.IndexOf(status.Trim());

				btnDetails.Enabled = true;
			}
		}


		private void LoadComboBox()
		{
			cbxStatus.DataSource = this.orderStatusSource;
		}
	}
}
