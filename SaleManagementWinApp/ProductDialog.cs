using AutoMapper;
using BusinessObjects;
using DataAccessObjects;
using DataAccessObjects.Enums;
using DataAccessObjects.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Repositories;

namespace SaleManagementWinApp
{
	public partial class ProductDialog : Form
	{
		private readonly IServiceProvider _serviceProvider;

		public ProductDialog(IServiceProvider serviceProvider)
		{
			InitializeComponent();
			_serviceProvider = serviceProvider;
		}

		private void ProductDialog_Load(object sender, EventArgs e)
		{
			// Set how the image should be displayed in the PictureBox
			txtMorphology.Enabled = false;
			ptMorphology.SizeMode = PictureBoxSizeMode.StretchImage;
			LoadComboBox();
			if (frmProduct.Instance?.ProductDialogData != null)
			{
				txtId.Enabled = frmProduct.Instance?.ProductDialogData?.Id?.Enabled ?? true;

				txtId.Text = frmProduct.Instance?.ProductDialogData?.Id?.Text;
				txtDescription.Text = frmProduct.Instance?.ProductDialogData?.Description?.Text;
				txtName.Text = frmProduct.Instance?.ProductDialogData?.Name?.Text;
				numUnitsInStock.Value = frmProduct.Instance?.ProductDialogData?.UnitsInStock?.Value ?? 0;
				numUnitsInStock.Value = frmProduct.Instance?.ProductDialogData?.UnitPrice?.Value ?? 0;
				txtMorphology.Text = frmProduct.Instance?.ProductDialogData?.ImagePath?.Text;
				cbxCategory.SelectedIndex = frmProduct.Instance?.ProductDialogData?.Category?.SelectedIndex ?? 0;
				cbxStatus.SelectedIndex = frmProduct.Instance?.ProductDialogData?.Status?.SelectedIndex ?? 0;
				cbxSupplier.SelectedIndex = frmProduct.Instance?.ProductDialogData?.Supplier?.SelectedIndex ?? 0;
				ptMorphology.Image = string.IsNullOrEmpty(txtMorphology.Text) ? null : Image.FromFile(txtMorphology.Text);
			}
		}

		private void btnSelect_Click(object sender, EventArgs e)
		{
			// Show an OpenFileDialog to select an image file
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All files (*.*)|*.*";
				openFileDialog.RestoreDirectory = true;

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					try
					{
						var src = openFileDialog.FileName;
						if (!string.IsNullOrEmpty(src))
						{
							string destinationFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");

							// Ensure the destination folder exists, if not, create it
							if (!Directory.Exists(destinationFolder))
							{
								Directory.CreateDirectory(destinationFolder);
							}

							var des = Path.Combine(destinationFolder, Path.GetFileName(src));
							File.Copy(src, des, true);
							// Load the selected image and display it in the PictureBox
							ptMorphology.Image = Image.FromFile(des);
							txtMorphology.Text = des;
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtMorphology.Text = string.Empty;
			ptMorphology.Image = null;
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

		private void btnReset_Click(object sender, EventArgs e)
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
				var repository = scope.ServiceProvider.GetRequiredService<IProductRepository>();
				if (ValidationHelper.IsNullOrWhiteSpace(txtId.Text, txtDescription.Text, txtName.Text))
				{
					throw new Exception("Do not accept empty value");
				}

				if (!int.TryParse(txtId.Text, out int id) || id < 0 || numUnitsInStock.Value < 0 || numUnitPrice.Value < 0)
				{
					throw new Exception("Id, unit price or units in stock must be number and greater than 0");
				}


				var exist = repository.Get(x => x.FlowerBouquetId == id || x.FlowerBouquetName.ToLower() == txtName.Text.ToLower());
				if (exist != null)
				{
					throw new Exception("Id or name is in used, please use the other");
				}
				var flowerBouquet = new FlowerBouquet()
				{
					FlowerBouquetId = id,
					CategoryId = (int)cbxCategory.SelectedValue,
					FlowerBouquetName = txtName.Text,
					Description = txtDescription.Text,
					SupplierId = (int)cbxSupplier.SelectedValue,
					UnitPrice = numUnitPrice.Value,
					UnitsInStock = (int)numUnitsInStock.Value,
					Morphology = txtMorphology.Text,
					FlowerBouquetStatus = cbxStatus.Text == Status.Active.ToString() ? (byte)1 : (byte)0
				};

				repository.Add(flowerBouquet);
				MessageBox.Show("Add new item successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
				var repository = scope.ServiceProvider.GetRequiredService<IProductRepository>();
				if (ValidationHelper.IsNullOrWhiteSpace(txtId.Text, txtDescription.Text, txtName.Text))
				{
					throw new Exception("Do not accept empty value");
				}

				if (!int.TryParse(txtId.Text, out int id) || id < 0 || numUnitsInStock.Value < 0 || numUnitPrice.Value < 0)
				{
					throw new Exception("Id, unit price or units in stock must be number");
				}


				var exist = repository.Get(x => x.FlowerBouquetId != id && x.FlowerBouquetName.ToLower() == txtName.Text.ToLower());
				if (exist != null)
				{
					throw new Exception("Name is in used, please use the other");
				}

				var flowerBouquet = repository.Get(x => x.FlowerBouquetId == id);

				flowerBouquet.CategoryId = (int)cbxCategory.SelectedValue;
				flowerBouquet.FlowerBouquetName = txtName.Text;
				flowerBouquet.Description = txtDescription.Text;
				flowerBouquet.SupplierId = (int)cbxSupplier.SelectedValue;
				flowerBouquet.UnitPrice = numUnitPrice.Value;
				flowerBouquet.UnitsInStock = (int)numUnitsInStock.Value;
				flowerBouquet.Morphology = txtMorphology.Text;
				flowerBouquet.FlowerBouquetStatus = cbxStatus.Text == Status.Active.ToString() ? (byte)1 : (byte)0;

				repository.Update(flowerBouquet);
				MessageBox.Show("Update item successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
				cbxCategory.SelectedIndex = 0;
				txtName.Text = string.Empty;
				txtDescription.Text = string.Empty;
				numUnitPrice.Value = 0;
				numUnitsInStock.Value = 0;
				cbxSupplier.SelectedIndex = 0;
				cbxStatus.SelectedIndex = 0;
				txtMorphology.Text = string.Empty;
				ptMorphology.Image = null;
			}
		}

		private void LoadComboBox()
		{
			using var scope = _serviceProvider.CreateScope();
			var categoryRepository = scope.ServiceProvider.GetRequiredService<ICategoryRepository>();
			var supplierRepository = scope.ServiceProvider.GetRequiredService<ISupplierRepository>();
			var mapper = scope.ServiceProvider.GetRequiredService<IMapper>();

			cbxStatus.DataSource = new List<string> { Status.Active.ToString(), Status.Inactive.ToString() };

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
		}
	}
}
