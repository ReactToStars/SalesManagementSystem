namespace SaleManagementWinApp.Models
{
	public class CustomerDialogData
	{
		public TextBox? Id { get; set; }
		public TextBox? Email { get; set; }
		public TextBox? Name { get; set; }
		public TextBox? City { get; set; }
		public TextBox? Country { get; set; }
		public DateTimePicker? BirthDay { get; set; }
		public ComboBox? Status { get; set; }
	}
}
