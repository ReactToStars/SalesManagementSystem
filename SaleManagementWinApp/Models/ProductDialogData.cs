namespace SaleManagementWinApp.Models
{
	public class ProductDialogData
	{
		public TextBox? Id { get; set; }
		public ComboBox? Category { get; set; }
		public TextBox? Name { get; set; }
		public TextBox? Description { get; set; }
		public NumericUpDown? UnitPrice { get; set; }
		public NumericUpDown? UnitsInStock { get; set; }
		public ComboBox? Supplier { get; set; }
		public ComboBox? Status { get; set; }
		public TextBox? ImagePath { get; set; }
	}
}
