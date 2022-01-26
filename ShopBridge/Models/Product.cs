using System;
using System.Collections.Generic;

#nullable disable

namespace ShopBridge.Models
{
    public partial class Product
    {
        public Product()
        {
            Orders = new HashSet<Order>();
            Users = new HashSet<User>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public int? Discount { get; set; }
        public int? TotalNoOfProducts { get; set; }
        public int? RemainingProducts { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
