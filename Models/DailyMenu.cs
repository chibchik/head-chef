using System;
using System.Collections.Generic;

namespace head_chef.Models
{
    // Клас для меню на конкретний день
    public class DailyMenu
    {
        public DateTime Date { get; set; } // Дата, для якої створюється меню
        public int PersonsCount { get; set; } // Кількість осіб, для яких створюється меню
        public List<Dish> SelectedDishes { get; set; } // Список обраних страв

        public DailyMenu()
        {
            SelectedDishes = new List<Dish>();
        }
    }
}
