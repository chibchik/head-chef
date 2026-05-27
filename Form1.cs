using head_chef.Managers;
using head_chef.Models;
using head_chef.Services;

namespace head_chef
{
    public partial class Form1 : Form
    {
        // Оголошуємо змінні для бізнес-логіки та роботи з файлами
        private StorageManager _storageManager;
        private FileService _fileService;
        private RecipeDatabase _recipeDatabase;
        private DailyMenu _dailyMenu;

        // Шлях до файлу з даними
        private const string FilePath = "C:\\Users\\ivang\\source\\repos\\head-chef\\Jsons\\gemini-code-1779875496843.json";

        public Form1()
        {
            InitializeComponent();

            // Ініціалізуємо об'єкти під час створення форми
            _fileService = new FileService();
            _storageManager = new StorageManager();
            _recipeDatabase = new RecipeDatabase();
            _dailyMenu = new DailyMenu();
        }

        private void Load_Json()
        {
            try
            {
                // Зчитуємо загальний файл даних. Ваш FileService вже вміє це робити завдяки <T>
                AppData loadedData = _fileService.LoadData<AppData>(FilePath);

                MessageBox.Show(loadedData != null ? "Дані завантажено успішно" : "Не вдалося завантажити дані");

                if (loadedData != null)
                {
                    // Якщо файл знайдено, роздаємо дані менеджерам
                    _storageManager.Products = loadedData.Products;
                    _recipeDatabase.Recipes = loadedData.Recipes;
                    _dailyMenu = loadedData.Menu;

                    // Якщо у вас є менеджер меню, передайте дані і йому
                }
                else
                {
                    // Перший запуск програми, файлу ще немає
                    _storageManager.Products = new List<Product>();
                    _recipeDatabase.Recipes = new List<Dish>();
                    _dailyMenu = new DailyMenu();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження даних: {ex.Message}");
            }
        }

        // Обробник події завантаження форми
        private void Form1_Load(object sender, EventArgs e)
        {
            Load_Json();

            // Прив'язуємо ComboBox'и та DataGrid'и до відповідних джерел даних
            DailyMenuDG.DataSource = _dailyMenu.SelectedDishes;

            SelectedDishCB.DataSource = _recipeDatabase.Recipes;
            SelectedDishCB.DisplayMember = "Name"; // Відображаємо назву страви в ComboBox
        }

        private void AddToMenuBTN_Click(object sender, EventArgs e)
        {
            try
            {
                Dish selectedDish = SelectedDishCB.SelectedItem as Dish;
                if (selectedDish == null)
                {
                    MessageBox.Show("Будь ласка, оберіть страву зі списку.");
                    return;
                }

                foreach (var dish in _dailyMenu.SelectedDishes)
                {
                    if (dish.Name == selectedDish.Name)
                    {
                        MessageBox.Show("Ця страва вже додана до меню.");
                        return;
                    }
                }

                _dailyMenu.SelectedDishes.Add(selectedDish);

                DailyMenuDG.DataSource = null; // Оновлюємо DataGrid
                DailyMenuDG.DataSource = _dailyMenu.SelectedDishes;
                MessageBox.Show($"Страву '{selectedDish.Name}' додано до меню.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка при додаванні страви: {ex.Message}");
            }
        }

        private void CreateMenuBTN_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = DateTime.Now;
                int PersonsCount = (int)PersonsCountUD.Value;

                DailyMenu newMenu = new DailyMenu
                {
                    Date = date,
                    PersonsCount = PersonsCount,
                    SelectedDishes = new List<Dish>(_dailyMenu.SelectedDishes) // Копіюємо вибрані страви
                };

                MessageBox.Show($"Меню на {date.ToShortDateString()} для {PersonsCount} осіб створено успішно!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка при створенні меню: {ex.Message}");
            }
        }

        private void SelectedDishCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
