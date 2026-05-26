using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace head_chef.Services
{
    public class FileService
    {
        // Збереження будь-якого об'єкта (списку продуктів або рецептів) у форматі JSON
        public void SaveData<T>(T data, string filePath)
        {
            string jsonString = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, jsonString);
        }

        // Загрузка данных из JSON
        // Завантаження даних з JSON
        public T LoadData<T>(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return default;
            }

            string jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<T>(jsonString);
        }
    }
}
