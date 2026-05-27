using System.ComponentModel;

namespace head_chef.Models
{
    // Клас, що описує страву
    public class Dish
    {
        [DisplayName("Назва страви")]
        public string Name { get; set; } // Назва страви

        [DisplayName("Текст рецепту")]
        public string RecipeText { get; set; } // Текст рецепту

        [Browsable(false)]
        public List<RecipeIngredient> Ingredients { get; set; } // Список інгредієнтів

        [DisplayName("Розкладка інгредієнтів")]
        public string IngredientDisplay => string.Join(",\n", Ingredients.Select(r => $"{r.IngredientProduct.Name} - {r.RequiredQuantity}")); // Відображення інгредієнтів у вигляді рядка для DataGridView
        public Dish()
        {
            Ingredients = new List<RecipeIngredient>();
        }
    }
}