using System;
using System.Collections.Generic;
using System.Text;

namespace head_chef.Models
{
    // Клас, що пов'язує продукт із необхідною масою/об'ємом для рецепта
    public class RecipeIngredient
    {
        public Product IngredientProduct { get; set; }
        public double RequiredQuantity { get; set; }
    }
}
