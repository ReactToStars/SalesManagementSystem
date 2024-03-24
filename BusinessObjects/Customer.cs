using System;
using System.Collections.Generic;

namespace BusinessObjects
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int CustomerId { get; set; }
        public string Email { get; set; } = string.Empty;
        public string CustomerName { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public DateTime? Birthday { get; set; }
        public byte? CustomerStatus { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
