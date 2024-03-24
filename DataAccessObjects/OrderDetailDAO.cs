using DataAccessObjects.Extensions;
using System.Drawing;

namespace DataAccessObjects
{
    public class OrderDetailDAO
    {
        public int OrderId { get; set; }
        public int FlowerBouquetId { get; set; }
        public string? FlowerBouquetName { get; set; }
		public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; }
    }
}