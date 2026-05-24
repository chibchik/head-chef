using System;
using System.Collections.Generic;
using System.Text;

namespace head_chef.Models
{
    // Клас для меню на конкретний день
    public class DailyMenu
    {
        public DateTime Date { get; set; }
        public int PersonsCount { get; set; }
        public List<Dish> SelectedDishes { get; set; }

        public DailyMenu()
        {
            SelectedDishes = new List<Dish>();
        }
    }
}
