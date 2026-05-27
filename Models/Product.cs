using System.ComponentModel;

namespace head_chef.Models
{
    // Клас, що описує товар на складі
    public class Product
    {
        [DisplayName("Найменування")]
        public required string Name { get; set; }

        [DisplayName("Ціна (грн.)")]
        public decimal Price { get; set; }

        [DisplayName("Кількість на складі")]
        public double QuantityInStock { get; set; }

        [DisplayName("Термін придатності")]
        public DateTime ExpirationDate { get; set; }
    }
}
