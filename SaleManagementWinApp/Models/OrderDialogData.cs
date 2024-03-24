namespace SaleManagementWinApp.Models
{
	public class OrderDialogData
	{
        public TextBox? Id { get; set; }
        public ComboBox? Customer { get; set; }
        public DateTimePicker? OrderDate { get; set; }
        public DateTimePicker? ShippedDate { get; set; }
        public TextBox? Total { get; set; }
        public ComboBox? Status { get; set; }
    }
}
