using head_chef.Models;
using System;
using System.Collections.Generic;
using System.Text;

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

        public void AddProduct(Product p)
        {
            Products.Add(p);
        }

        public void EditProduct(Product oldProduct, Product newProduct)
        {
            // Логіка пошуку та заміни даних про продукт
        }

        public void DeleteProduct(Product p)
        {
            Products.Remove(p);
        }

        // Перевірка наявності продуктів на складі для списку інгредієнтів
        public bool CheckStock(List<RecipeIngredient> requiredIngredients)
        {
            // Логіка порівняння requiredIngredients з Products.QuantityInStock
            return true; // Тимчасова заглушка
        }

        // Списання продуктів та формування накладної
        public ExpenseInvoice WriteOff(List<RecipeIngredient> requiredIngredients)
        {
            // Логіка вичитання кількості зі складу
            // Розрахунок загальної вартості
            return new ExpenseInvoice
            {
                InvoiceNumber = new Random().Next(1000, 9999),
                CreationDate = DateTime.Now,
                WrittenOffItems = requiredIngredients,
                TotalSum = 0 // Тут буде підрахунок суми
            };
        }
    }
}
