using head_chef.Models;

namespace head_chef.Managers
{
    // Менеджер з керуванням складом
    public class StorageManager
    {
        public List<Product> Products { get; set; }

        public StorageManager()
        {
            Products = new List<Product>();
        }

        // Додавання нового продукту на склад
        public void AddProduct(Product p)
        {
            Products.Add(p);
        }

        // Редагування даних про продукт
        public void EditProduct(Product oldProduct, Product newProduct)
        {
            var product = Products.Find(p => p == oldProduct);
            if (product != null)
            {
                product.Name = newProduct.Name;
                product.Price = newProduct.Price;
                product.QuantityInStock = newProduct.QuantityInStock;
                product.ExpirationDate = newProduct.ExpirationDate;
            }
        }

        // Видалення продукту зі складу
        public void DeleteProduct(Product p)
        {
            Products.Remove(p);
        }

        // Перевірка наявності продуктів на складі для списку інгредієнтів
        public bool CheckStock(List<RecipeIngredient> requiredIngredients)
        {
            foreach (var ingredient in requiredIngredients)
            {
                var product = Products.Find(p => p.Name == ingredient.IngredientProduct.Name);
                if (product == null || product.QuantityInStock < ingredient.RequiredQuantity)
                {
                    return false; // Недостатньо продукту на складі
                }
            }
            return true; // Всі продукти доступні на складі
        }

        // Списання продуктів та формування накладної
        public ExpenseInvoice WriteOff(List<RecipeIngredient> requiredIngredients)
        {
            decimal totalSum = 0;
            // Логіка вичитання кількості зі складу
            foreach (var ingredient in requiredIngredients)
            {
                var product = Products.Find(p => p.Name == ingredient.IngredientProduct.Name);
                if (product != null)
                {
                    product.QuantityInStock = Math.Round(product.QuantityInStock - ingredient.RequiredQuantity, 3); // Вичитання кількості зі складу
                    totalSum += (decimal)ingredient.RequiredQuantity * product.Price; // Додаємо вартість списаного продукту
                }
            }
            // Розрахунок загальної вартості
            return new ExpenseInvoice
            {
                InvoiceNumber = new Random().Next(1000, 9999),
                CreationDate = DateTime.Now,
                WrittenOffItems = requiredIngredients,
                TotalSum = totalSum // Тут буде підрахунок суми
            };
        }
    }
}
