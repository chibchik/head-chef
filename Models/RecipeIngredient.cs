using System.ComponentModel;

namespace head_chef.Models
{
    // Клас, що пов'язує продукт із необхідною масою/об'ємом для рецепта
    public class RecipeIngredient
    {
        [Browsable(false)]
        public required Product IngredientProduct { get; set; }
        // Властивість для відображення назви продукту в DataGridView
        [DisplayName("Назва інгредієнту")]
        public string IngredientName => IngredientProduct?.Name ?? string.Empty;

        [DisplayName("Необхідна кількість")]
        public double RequiredQuantity { get; set; }
    }   
}
