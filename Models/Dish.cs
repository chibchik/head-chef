using System;
using System.Collections.Generic;
using System.Text;


namespace head_chef.Models
{
    // Клас, що описує страву
    public class Dish
    {
        public string Name { get; set; }
        public string RecipeText { get; set; }
        public List<RecipeIngredient> Ingredients { get; set; }

        public Dish()
        {
            Ingredients = new List<RecipeIngredient>();
        }
    }
}