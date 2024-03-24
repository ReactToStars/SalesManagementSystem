using DataAccessObjects.Models;
using SaleManagementWinApp.Authentications;
using System.Security.Principal;

namespace SaleManagementWinApp
{
	public partial class frmMain : Form
	{
		private CurrentUser _currentUser;
		private readonly IServiceProvider _serviceProvider;

		public frmMain(IServiceProvider serviceProvider)
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
				_currentUser.Email = customIdentity.Email;
				_currentUser.Name = customIdentity.Name;
				_currentUser.Role = customIdentity.Role;
				if (currentPrincipal.IsInRole("admin"))
				{
					menu.Enabled = true;
					historyOrdersToolStripMenuItem.Enabled = false;
				}
				else
				{
					menu.Enabled = false;
				}
			}
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			lblWelcome.Text = $"Welcome, {_currentUser.Name}";
		}

		private void productsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frmProduct = new frmProduct(_serviceProvider);
			frmProduct.ShowDialog();
		}

		private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frmOrder = new frmOrder(_serviceProvider);
			frmOrder.ShowDialog();
		}

		private void statisticsSalesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frmStatisticSales = new frmStatisticSales(_serviceProvider);
			frmStatisticSales.ShowDialog();
		}

		private void customersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frmCustomer = new frmCustomer(_serviceProvider);
			frmCustomer.ShowDialog();
		}

		private void profileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frmProfile = new frmProfile(_serviceProvider);
			frmProfile.ShowDialog();
		}

		private void historyOrdersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frmOrderHistory = new frmOrderHistory(_serviceProvider);
			frmOrderHistory.ShowDialog();
		}

		private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide();
			var frmLogin = new frmLogin(_serviceProvider);
			frmLogin.ShowDialog();
		}
	}
}
