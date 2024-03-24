using AutoMapper;
using BusinessObjects;
using DataAccessObjects;
using DataAccessObjects.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Repositories;
using SaleManagementWinApp.Constant;
using SaleManagementWinApp.Models;
using System.Data;

namespace SaleManagementWinApp
{
	public partial class frmProduct : Form
	{
		private readonly IServiceProvider _serviceProvider;
		public ProductDialogData? ProductDialogData;
		public static frmProduct? Instance;

		public frmProduct(IServiceProvider serviceProvider)
		{
			InitializeComponent();
			_serviceProvider = serviceProvider;
			Instance = this;
		}

		private void frmProduct_Load(object sender, EventArgs e)
		{
			Display();
			LoadComboBox();

			txtId.Enabled = false;
			txtName.Enabled = false;
			txtDescription.Enabled = false;
			txtMorphology.Enabled = false;
			numUnitPrice.Enabled = false;
			numUnitsInStock.Enabled = false;
			cbxCategory.Enabled = false;
			cbxStatus.Enabled = false;
			cbxSupplier.Enabled = false;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			ProductDialogData.Id.Enabled = true;
			var productDialog = new ProductDialog(_serviceProvider);
			productDialog.ShowDialog();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtId.Text))
			{
				MessageBox.Show("Please select a product", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			ProductDialogData.Id.Enabled = false;
			var productDialog = new ProductDialog(_serviceProvider);
			productDialog.ShowDialog();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				using var scope = _serviceProvider.CreateScope();
				var repository = scope.ServiceProvider.GetRequiredService<IProductRepository>();
				if (ValidationHelper.IsNullOrWhiteSpace(txtId.Text) || !int.TryParse(txtId.Text, out int id))
				{
					throw new Exception("Please select an item");
				}

				var flowerBouquet = repository.Get(x => x.FlowerBouquetId == id);
				if (flowerBouquet == null)
				{
					throw new Exception("Could not find this item");
				}

				DialogResult result = MessageBox.Show($"Do you want to delete  {flowerBouquet.FlowerBouquetName}?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (result == DialogResult.Yes)
				{
					repository.Delete(flowerBouquet);
					MessageBox.Show($"Delete {flowerBouquet.FlowerBouquetName} successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
				var repository = scope.ServiceProvider.GetRequiredService<IProductRepository>();
				var mapper = scope.ServiceProvider.GetRequiredService<IMapper>();

				if (ValidationHelper.IsNullOrWhiteSpace(txtSearch.Text))
				{
					throw new Exception("Please type id, name, category or supplier that you want to find");
				}
				IEnumerable<FlowerBouquet>? flowerBouquets = null;
				if (int.TryParse(txtSearch.Text, out int id))
				{
					flowerBouquets = repository.GetBy(x => x.FlowerBouquetId == id);
				}

				if (flowerBouquets == null || !flowerBouquets.Any())
				{
					flowerBouquets = repository.GetBy(
						x => x.FlowerBouquetName.ToLower().Contains(txtSearch.Text.ToLower()) || x.Category.CategoryName.ToLower().Contains(txtSearch.Text.ToLower()) || x.Supplier.SupplierName.Contains(txtSearch.Text.ToLower()));
				}

				if (flowerBouquets == null || !flowerBouquets.Any())
				{
					MessageBox.Show("Could not find item", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					dataGridView1.DataSource = mapper.Map<IEnumerable<FlowerBouquetDAO>>(flowerBouquets);
					string[] headers = ConstantHeaders.Product;
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
			using var scope = _serviceProvider.CreateScope();
			var categoryRepository = scope.ServiceProvider.GetRequiredService<ICategoryRepository>();
			var supplierRepository = scope.ServiceProvider.GetRequiredService<ISupplierRepository>();
			var categories = categoryRepository.GetAll().Select(x => x.CategoryName).ToList();
			var suppliers = supplierRepository.GetAll().Select(x => x.SupplierName).ToList();

			if (e.RowIndex > -1)
			{
				var selectedRow = e.RowIndex;

				txtId.Text = dataGridView1.Rows[selectedRow].Cells[0].Value.ToString();
				ptMorphology.Image = dataGridView1.Rows[selectedRow].Cells[1].Value as Image;
				var category = dataGridView1.Rows[selectedRow].Cells[2].Value.ToString();
				cbxCategory.SelectedIndex = categories.IndexOf(category);
				txtName.Text = dataGridView1.Rows[selectedRow].Cells[3].Value.ToString();
				txtDescription.Text = dataGridView1.Rows[selectedRow].Cells[4].Value.ToString();
				numUnitPrice.Value = (decimal)dataGridView1.Rows[selectedRow].Cells[5].Value;
				numUnitsInStock.Value = decimal.Parse(dataGridView1.Rows[selectedRow].Cells[6].Value.ToString());
				var supplier = dataGridView1.Rows[selectedRow].Cells[7].Value.ToString();
				cbxSupplier.SelectedIndex = suppliers.IndexOf(supplier) + 1;
				var status = dataGridView1.Rows[selectedRow].Cells[8].Value.ToString();
				cbxStatus.SelectedIndex = status == "1" ? 0 : 1;
				txtMorphology.Text = dataGridView1.Rows[selectedRow].Cells[9].Value.ToString();
			}
		}

		private void Display()
		{
			using var scope = _serviceProvider.CreateScope();
			var repository = scope.ServiceProvider.GetRequiredService<IProductRepository>();
			var mapper = scope.ServiceProvider.GetRequiredService<IMapper>();

			dataGridView1.DataSource = mapper.Map<IEnumerable<FlowerBouquetDAO>>(repository.GetProducts());
			dataGridView1.Columns[1].Width = 100;
			dataGridView1.RowTemplate.Height = 100;
			string[] headers = ConstantHeaders.Product;
			int i = 0;
			foreach (var header in headers)
			{
				dataGridView1.Columns[i].HeaderText = header;
				i++;
			}

			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				// Set the height of each row
				row.Height = 50; // Adjust the height as needed
			}

			// Set how the image should be displayed in the PictureBox
			ptMorphology.SizeMode = PictureBoxSizeMode.StretchImage;

			// Load Product Dialog
			ProductDialogData = new()
			{
				Id = txtId,
				Category = cbxCategory,
				Description = txtDescription,
				ImagePath = txtMorphology,
				Name = txtName,
				Status = cbxStatus,
				Supplier = cbxSupplier,
				UnitPrice = numUnitPrice,
				UnitsInStock = numUnitsInStock
			};
		}

		private void Clear()
		{
			txtId.Text = string.Empty;
			cbxCategory.SelectedIndex = 0;
			txtName.Text = string.Empty;
			txtDescription.Text = string.Empty;
			numUnitsInStock.Text = string.Empty;
			numUnitPrice.Text = string.Empty;
			cbxSupplier.SelectedIndex = 0;
			cbxStatus.SelectedIndex = 0;
			txtMorphology.Text = string.Empty;
			txtSearch.Text = string.Empty;
			ptMorphology.Image = null;
			Display();
		}

		private void LoadComboBox()
		{
			using var scope = _serviceProvider.CreateScope();
			var categoryRepository = scope.ServiceProvider.GetRequiredService<ICategoryRepository>();
			var supplierRepository = scope.ServiceProvider.GetRequiredService<ISupplierRepository>();
			var mapper = scope.ServiceProvider.GetRequiredService<IMapper>();

			cbxStatus.DataSource = new List<string> { "Active", "Inactive" };

			// load categories
			var categories = mapper.Map<IEnumerable<CategoryDAO>>(categoryRepository.GetAll());
			var categoryDataSource = new Dictionary<int, string>();
			foreach (var category in categories)
			{
				categoryDataSource.Add(category.CategoryId, category.CategoryName);
			}

			cbxCategory.DataSource = new BindingSource(categoryDataSource, null);
			cbxCategory.DisplayMember = "Value";
			cbxCategory.ValueMember = "Key";
			cbxCategory.DropDownHeight = cbxCategory.Font.Height * 10;

			//load suppliers
			var suppliers = mapper.Map<IEnumerable<SupplierDAO>>(supplierRepository.GetAll());
			var supplierDataSource = new Dictionary<int, string?>() { { 0, "" } };
			foreach (var supplier in suppliers)
			{
				supplierDataSource.Add(supplier.SupplierId, supplier.SupplierName);
			}

			cbxSupplier.DataSource = new BindingSource(supplierDataSource, null);
			cbxSupplier.DisplayMember = "Value";
			cbxSupplier.ValueMember = "Key";
			cbxSupplier.DropDownHeight = cbxSupplier.Font.Height * 10;

			//// load filter
			var filerSource = new Dictionary<int, string>()
			{
				{0, "Unit Price" },
				{1, "0 - 50$" },
				{2, "51$ - 100$" },
				{3, "101$ - 200$" },
				{4, "201$ - 500$" },
				{5, "> 500$" },
			};

			cbxFilter.DataSource = new BindingSource(filerSource, null);
			cbxFilter.DisplayMember = "Value";
			cbxFilter.ValueMember = "Key";
			cbxFilter.DropDownHeight = cbxFilter.Font.Height * 5;
		}

		private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				using var scope = _serviceProvider.CreateScope();
				var repository = scope.ServiceProvider.GetRequiredService<IProductRepository>();
				var mapper = scope.ServiceProvider.GetRequiredService<IMapper>();
				var filter = (KeyValuePair<int, string>)cbxFilter.SelectedItem;
				decimal from = 0, to = 0;
				switch (filter.Key)
				{
					case 1:
						from = 0;
						to = 50;
						break;
					case 2:
						from = 51;
						to = 100;
						break;
					case 3:
						from = 101;
						to = 200;
						break;
					case 4:
						from = 201;
						to = 500;
						break;
					case 5:
						from = 501;
						break;
				}
				var flowerBouquets = repository.GetBy(x => x.UnitPrice >= from && (to > 0 ? x.UnitPrice < to : true));
				dataGridView1.DataSource = mapper.Map<IEnumerable<FlowerBouquetDAO>>(flowerBouquets);
				string[] headers = ConstantHeaders.Product;
				int i = 0;
				foreach (var header in headers)
				{
					dataGridView1.Columns[i].HeaderText = header;
					i++;
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
