using System;
using System.Collections.Generic;
using System.Text;

namespace head_chef.Models
{
    // Головний клас для збереження всіх даних програми
    public class AppData
    {
        public List<Product> Products { get; set; }
        public List<Dish> Recipes { get; set; }
        public DailyMenu Menu { get; set; }

        public AppData()
        {
            // Ініціалізуємо порожні списки, щоб уникнути помилок (NullReferenceException)
            Products = new List<Product>();
            Recipes = new List<Dish>();
            Menu = new DailyMenu();
        }
    }
}
