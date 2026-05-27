using head_chef.Models;
using System.Text.Json;

namespace head_chef.Services
{
    public class FileService
    {
        private readonly string _file = "C:\\Users\\ivang\\source\\repos\\head-chef\\Jsons\\data.json";
        // Збереження будь-якого об'єкта (списку продуктів або рецептів) у форматі JSON
        public void SaveData<T>(T data, string filePath)
        {
            string jsonString = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, jsonString);
        }

        // Завантаження даних з JSON
        public T? LoadData<T>(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return default;
            }

            string jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<T>(jsonString);
        }

        public (List<Product> storageManager, List<Dish> recipeDatabase, DailyMenu dailyMenu) Load_Json()
        {
            // Зчитуємо загальний файл даних
            AppData? loadedData = LoadData<AppData>(_file);

            MessageBox.Show(loadedData != null ? "Дані завантажено успішно" : "Не вдалося завантажити дані");

            if (loadedData != null)
            {
                // Якщо файл знайдено, роздаємо дані менеджерам
                return (loadedData.Products, loadedData.Recipes, loadedData.Menu);
            }
            else
            {
                // Перший запуск програми, файлу ще немає
                return (new List<Product>(), new List<Dish>(), new DailyMenu { Date = DateTime.Now, PersonsCount = 0, SelectedDishes = new List<Dish>() });
            }
        }
    }
}
