namespace DataAccessObjects
{
    public class CategoryDAO
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string? CategoryDescription { get; set; }
        public string? CategoryNote { get; set; }
    }
}