using System;
using System.Collections.Generic;
using System.Text;

namespace head_chef.Models
{
    // Клас, що описує товар на складі
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public double QuantityInStock { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
