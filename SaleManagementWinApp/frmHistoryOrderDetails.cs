using AutoMapper;
using BusinessObjects;
using DataAccessObjects;
using Microsoft.Extensions.DependencyInjection;
using Repositories;
using SaleManagementWinApp.Constant;

namespace SaleManagementWinApp
{
	public partial class frmHistoryOrderDetails : Form
	{
		private readonly IServiceProvider _serviceProvider;
		private readonly Order _order;

		public frmHistoryOrderDetails(IServiceProvider serviceProvider, Order order)
		{
			InitializeComponent();
			_serviceProvider = serviceProvider;
			_order = order;
		}

		private void frmHistoryOrderDetails_Load(object sender, EventArgs e)
		{
			Display();
		}

		private void Display()
		{
			using var scope = _serviceProvider.CreateScope();
			var repository = scope.ServiceProvider.GetRequiredService<IOrderDetailRepository>();
			var mapper = scope.ServiceProvider.GetRequiredService<IMapper>();

			dataGridView1.DataSource = mapper.Map<IEnumerable<OrderDetailDAO>>(repository.GetBy(x => x.OrderId == _order.OrderId));

			string[] headers = ConstantHeaders.OrderDetails;
			int i = 0;
			foreach (var header in headers)
			{
				dataGridView1.Columns[i].HeaderText = header;
				i++;
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
