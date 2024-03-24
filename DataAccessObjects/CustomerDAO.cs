namespace DataAccessObjects
{
    public class CustomerDAO
    {
        public int CustomerId { get; set; }
        public string Email { get; set; } = string.Empty;
        public string CustomerName { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public DateTime? Birthday { get; set; }
        public byte? CustomerStatus { get; set; }
    }
}