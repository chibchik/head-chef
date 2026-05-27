using head_chef.Models;

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

        public void EditRecipe(Dish oldDish, Dish newDish)
        {
            var dish = Recipes.Find(d => d == oldDish);
            if (dish != null)
            {
                dish.Name = newDish.Name;
                dish.RecipeText = newDish.RecipeText;
                dish.Ingredients = newDish.Ingredients;
            }
        }

        public void DeleteRecipe(Dish d)
        {
            Recipes.Remove(d);
        }
    }
}
