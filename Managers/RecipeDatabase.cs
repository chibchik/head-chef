using head_chef.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace head_chef.Managers
{
    // Менеджер бази рецептів
    public class RecipeDatabase
    {
        public List<Dish> Recipes { get; set; }

        public RecipeDatabase()
        {
            Recipes = new List<Dish>();
        }

        public void CreateRecipe(Dish d)
        {
            Recipes.Add(d);
        }

        public Dish FindRecipe(string name)
        {
            return Recipes.FirstOrDefault(d => d.Name.Contains(name));
        }

        public void DeleteRecipe(Dish d)
        {
            Recipes.Remove(d);
        }
    }
}
