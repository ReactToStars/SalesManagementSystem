namespace DataAccessObjects
{
	public class HistoryOrderDAO
	{
		public int OrderId { get; set; }
		public DateTime OrderDate { get; set; }
		public DateTime? ShippedDate { get; set; }
		public decimal? Total { get; set; }
		public string? OrderStatus { get; set; }
	}
}
