using DataAccessObjects.Extensions;
using System.Drawing;

namespace DataAccessObjects
{
	public class FlowerBouquetDAO
    {
        public int FlowerBouquetId { get; set; }

        public Image? Picture
        {
            get
            {
                if (!string.IsNullOrEmpty(Morphology))
                {
                    if (File.Exists(Morphology))
                    {
                        return ImageHelper.ResizeImage(Image.FromFile(Morphology), 50, 50) ;
                    }
                }

                return null;
            }
        }

        public string? CategoryName { get; set; }
        public string FlowerBouquetName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public string? SupplierName { get; set; }
		public byte? FlowerBouquetStatus { get; set; }
		public string? Morphology { get; set; }
	}
}