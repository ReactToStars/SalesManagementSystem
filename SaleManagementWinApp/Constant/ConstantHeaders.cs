namespace SaleManagementWinApp.Constant
{
    public static class ConstantHeaders
    {
        public static string[] Customer = new string[] { "Id", "Email", "Customer Name", "City", "Country", "Birthday", "Status" };

        public static string[] Product = new string[] { "Id", "Morphology", "Category", "Name", "Description", "Unit Price", "Units In Stock", "Supplier", "Status", "Image Path" };

        public static string[] Order = new string[] { "Id", "Customer Id", "Customer Name", "Order Date", "Shipped Date", "Total", "Status"};

        public static string[] OrderDetails = new string[] { "Id", "Product Id", "Product Name", "Unit Price", "Quantity", "Discount"};

		public static string[] HistoryOrders = new string[] { "Id", "Order Date", "Shipped Date", "Total", "Status" };
	}
}
