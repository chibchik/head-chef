using head_chef.Managers;
using head_chef.Models;
using head_chef.Services;
using System.ComponentModel;

namespace head_chef
{
    public partial class Form1 : Form
    {
        private const string _file = "C:\\Users\\ivang\\source\\repos\\head-chef\\Jsons\\data.json";
        // Оголошуємо змінні для бізнес-логіки та роботи з файлами
        private FileService _fileService;
        private StorageManager _storageManager;
        private RecipeDatabase _recipeDatabase;
        private DailyMenu _dailyMenu;
        private BindingList<RecipeIngredient> _newRecipeIngredients = new BindingList<RecipeIngredient>();

        public Form1()
        {
            InitializeComponent();

            // Ініціалізуємо об'єкти під час створення форми
            _fileService = new FileService();
            _storageManager = new StorageManager();
            _recipeDatabase = new RecipeDatabase();
            _dailyMenu = new DailyMenu();
        }

        // Обробник події завантаження форми
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                (_storageManager.Products, _recipeDatabase.Recipes, _dailyMenu) = _fileService.Load_Json();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження даних: {ex.Message}");
            }

            // Прив'язуємо ComboBox'и та DataGrid'и до відповідних джерел даних
            DailyMenuDG.DataSource = _dailyMenu.SelectedDishes;
            StorageDG.DataSource = _storageManager.Products;
            RecipeDG.DataSource = _recipeDatabase.Recipes;
            IngredientsDG.DataSource = _newRecipeIngredients;
            IngredientsDG.DataError += (s, e) => { e.ThrowException = false; };

            // Розтягуємо колонки на всю ширину DataGridView
            DailyMenuDG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StorageDG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            RecipeDG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            IngredientsDG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            SelectedDishCB.DataSource = _recipeDatabase.Recipes;
            SelectedDishCB.DisplayMember = "Name"; // Відображаємо назву страви в ComboBox
            ProductCB.DataSource = _storageManager.Products;
            ProductCB.DisplayMember = "Name"; // Відображаємо назву продукту в ComboBox
        }

        private void AddToMenuBTN_Click(object sender, EventArgs e)
        {
            try
            {
                Dish? selectedDish = SelectedDishCB.SelectedItem as Dish;
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

        private void DelDishFromMenuBTN_Click(object sender, EventArgs e)
        {
            if (DailyMenuDG.CurrentRow?.DataBoundItem != null)
            {
                _dailyMenu.SelectedDishes.Remove(DailyMenuDG.CurrentRow?.DataBoundItem as Dish);
                DailyMenuDG.DataSource = null; // Оновлюємо DataGrid
                DailyMenuDG.DataSource = _dailyMenu.SelectedDishes;
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть страву для видалення.");
            }
        }

        private void CreateMenuBTN_Click(object sender, EventArgs e)
        {
            // Створюємо меню на основі вибраних страв та кількості осіб
            DateTime date = DateTime.Now;
            int PersonsCount = (int)PersonsCountUD.Value;

            if (PersonsCount <= 0 || _dailyMenu.SelectedDishes.Count == 0)
            {
                MessageBox.Show("Будь ласка, встановіть кількість осіб та додайте хоча б одну страву до меню.");
                return;
            }

            try
            {
                _dailyMenu = new DailyMenu
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


            // Розраховуємо загальну кількість кожного інгредієнта, необхідного для приготування вибраних страв
            List<RecipeIngredient> requiredIngredients = new List<RecipeIngredient>();

            foreach (Dish dish in _dailyMenu.SelectedDishes)
            {
                foreach (RecipeIngredient ingredient in dish.Ingredients)
                {
                    double totalAmount = ingredient.RequiredQuantity * _dailyMenu.PersonsCount;
                    var existing = requiredIngredients.FirstOrDefault(p => p.IngredientProduct == ingredient.IngredientProduct);


                    if (existing != null)
                    {
                        existing.RequiredQuantity += totalAmount;
                    }
                    else
                    {
                        RecipeIngredient copiedIngredient = new RecipeIngredient
                        {
                            IngredientProduct = ingredient.IngredientProduct,
                            RequiredQuantity = totalAmount
                        };
                        requiredIngredients.Add(copiedIngredient);
                    }
                }
            }

            // Перевіряємо наявність необхідних інгредієнтів на складі
            bool stockAvailable = _storageManager.CheckStock(requiredIngredients);
            if (stockAvailable)
            {
                ExpenseInvoice invoice = _storageManager.WriteOff(requiredIngredients);
                // Виведення накладної
                if (invoice != null)
                {
                    MessageBox.Show($"Інгредієнти успішно списані зі складу. Накладна №{invoice.InvoiceNumber} створена. Загальна сума: {invoice.TotalSum:C}");
                }
            }
            else
            {
                MessageBox.Show("На складі недостатньо інгредієнтів для приготування меню. Будь ласка, поповніть запаси.");
            }
        }

        private void SearchTB_TextChanged(object sender, EventArgs e)
        {
            string searchText = SearchTB.Text.ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                StorageDG.DataSource = _storageManager.Products;
            }
            else
            {
                var filteredProducts = _storageManager.Products
                    .Where(p => p.Name.ToLower().Contains(searchText))
                    .ToList();
                StorageDG.DataSource = filteredProducts;
            }
        }

        private void CompleteAddBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string name = NameTB.Text;
                decimal price = PriceUD.Value;
                double quantityInStock = (double)QuantityUD.Value;
                DateTime expirationDate = ExpirationDateDtP.Value;

                if (name.Length <= 0 || name.Length > 50 || price <= 0 || quantityInStock <= 0 || expirationDate <= DateTime.Now)
                {
                    MessageBox.Show("Помилка введення інформації про продукт.");
                    return;
                }
                else if (_storageManager.Products.Any(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("Продукт з такою назвою вже існує на складі.");
                    return;
                }
                else
                {
                    _storageManager.AddProduct(new Product
                    {
                        Name = name,
                        Price = price,
                        QuantityInStock = quantityInStock,
                        ExpirationDate = expirationDate
                    });
                    StorageDG.DataSource = null; // Оновлюємо DataGridView
                    StorageDG.DataSource = _storageManager.Products;
                    ToAddBTN_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка при додаванні продукту: {ex.Message}");
            }
        }

        private void CompleteEditBTN_Click(object sender, EventArgs e)
        {
            try
            {
                Product selectedProduct = StorageDG.CurrentRow?.DataBoundItem as Product;
                if (selectedProduct == null)
                {
                    MessageBox.Show("Будь ласка, виберіть продукт для редагування.");
                    return;
                }
                string name = NameTB.Text;
                decimal price = PriceUD.Value;
                double quantityInStock = (double)QuantityUD.Value;
                DateTime expirationDate = ExpirationDateDtP.Value;

                if (name.Length <= 0 || name.Length > 50 || price <= 0 || quantityInStock <= 0 || expirationDate <= DateTime.Now)
                {
                    MessageBox.Show("Помилка введення інформації про продукт.");
                    return;
                }
                else
                {
                    Product updatedProduct = new Product
                    {
                        Name = name,
                        Price = price,
                        QuantityInStock = quantityInStock,
                        ExpirationDate = expirationDate
                    };

                    _storageManager.EditProduct(selectedProduct, updatedProduct);

                    StorageDG.DataSource = null; // Оновлюємо DataGridView
                    StorageDG.DataSource = _storageManager.Products;
                    ToAddBTN_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка при редагуванні продукту: {ex.Message}");
            }
        }

        private void EditProductBTN_Click(object sender, EventArgs e)
        {
            Product selectedProduct = StorageDG.CurrentRow?.DataBoundItem as Product;
            if (selectedProduct != null)
            {
                NameTB.Text = selectedProduct.Name;
                PriceUD.Value = (decimal)selectedProduct.Price;
                QuantityUD.Value = (decimal)selectedProduct.QuantityInStock;
                ExpirationDateDtP.Value = selectedProduct.ExpirationDate;
                CompleteEditBTN.Click -= CompleteAddBTN_Click;
                CompleteEditBTN.Click -= CompleteEditBTN_Click;
                CompleteEditBTN.Click += CompleteEditBTN_Click;
                groupBox4.Text = "Редагування продукту";
            }
        }

        private void ToAddBTN_Click(object sender, EventArgs e)
        {
            NameTB.Text = string.Empty;
            PriceUD.Value = 0;
            QuantityUD.Value = 0;
            ExpirationDateDtP.Value = DateTime.Now;
            CompleteEditBTN.Click -= CompleteEditBTN_Click;
            CompleteEditBTN.Click -= CompleteAddBTN_Click;
            CompleteEditBTN.Click += CompleteAddBTN_Click;
            groupBox4.Text = "Додавання продукту";
        }

        private void DeleteProductBTN_Click(object sender, EventArgs e)
        {
            _storageManager.DeleteProduct(StorageDG.CurrentRow?.DataBoundItem as Product);
            StorageDG.DataSource = null; // Оновлюємо DataGridView
            StorageDG.DataSource = _storageManager.Products;
        }

        private void AddIngrBTN_Click(object sender, EventArgs e)
        {
            if (ProductCB.SelectedItem != null && (double)IngrQuantityUD.Value > 0)
            {
                if (_newRecipeIngredients.Any(r => r.IngredientProduct == ProductCB.SelectedItem as Product))
                {
                    MessageBox.Show("Інгредієнт вже додано.");
                    return;
                }
                _newRecipeIngredients.Add(new RecipeIngredient
                {
                    IngredientProduct = ProductCB.SelectedItem as Product,
                    RequiredQuantity = (double)IngrQuantityUD.Value
                });
            }
            else
            {
                MessageBox.Show("Будь ласка, заповніть всі поля для додання інгредієнту.");
            }
        }

        // Поточний рецепт, що редагується (null = режим додавання)
        private Dish? _editingDish = null;

        private void CompleteBTN_Click(object sender, EventArgs e)
        {
            if (RecipeNameTB.Text.Length <= 0 || _newRecipeIngredients.Count <= 0 || RecipeTextTB.Text.Length <= 0)
            {
                MessageBox.Show("Будь ласка, заповніть всі поля для створення рецепта.");
                return;
            }

            if (_editingDish != null)
            {
                // Режим редагування
                _recipeDatabase.EditRecipe(_editingDish, new Dish
                {
                    Name = RecipeNameTB.Text,
                    RecipeText = RecipeTextTB.Text,
                    Ingredients = new List<RecipeIngredient>(_newRecipeIngredients)
                });
                MessageBox.Show($"Рецепт '{RecipeNameTB.Text}' успішно оновлено.");
            }
            else
            {
                // Режим додавання
                _recipeDatabase.CreateRecipe(new Dish
                {
                    Name = RecipeNameTB.Text,
                    RecipeText = RecipeTextTB.Text,
                    Ingredients = new List<RecipeIngredient>(_newRecipeIngredients)
                });
                MessageBox.Show($"Рецепт '{RecipeNameTB.Text}' успішно створено.");
            }

            RefreshRecipeGrid();
            ResetRecipeForm();
        }

        private void DeleteIngrBTN_Click(object sender, EventArgs e)
        {
            if (IngredientsDG.CurrentRow?.DataBoundItem != null)
            {
                _newRecipeIngredients.Remove(IngredientsDG.CurrentRow?.DataBoundItem as RecipeIngredient);
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть інгредієнт для видалення.");
            }
        }

        // Редагування обраного рецепту
        private void EditRecipeBTN_Click(object sender, EventArgs e)
        {
            Dish? selectedDish = RecipeDG.CurrentRow?.DataBoundItem as Dish;
            if (selectedDish == null)
            {
                MessageBox.Show("Будь ласка, виберіть рецепт для редагування.");
                return;
            }

            _editingDish = selectedDish;
            RecipeNameTB.Text = selectedDish.Name;
            RecipeTextTB.Text = selectedDish.RecipeText;

            // Завантажуємо інгредієнти рецепту в список
            _newRecipeIngredients.Clear();
            foreach (var ingredient in selectedDish.Ingredients)
            {
                _newRecipeIngredients.Add(new RecipeIngredient
                {
                    IngredientProduct = ingredient.IngredientProduct,
                    RequiredQuantity = ingredient.RequiredQuantity
                });
            }

            groupBox5.Text = "Редагування рецепту";
            CompleteBTN.Text = "Зберегти зміни";
        }

        // Видалення обраного рецепту
        private void DelRecipeBTN_Click(object sender, EventArgs e)
        {
            Dish? selectedDish = RecipeDG.CurrentRow?.DataBoundItem as Dish;
            if (selectedDish == null)
            {
                MessageBox.Show("Будь ласка, виберіть рецепт для видалення.");
                return;
            }

            var result = MessageBox.Show(
                $"Ви впевнені, що хочете видалити рецепт '{selectedDish.Name}'?",
                "Підтвердження видалення",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _recipeDatabase.DeleteRecipe(selectedDish);
                RefreshRecipeGrid();
                ResetRecipeForm();
                MessageBox.Show("Рецепт успішно видалено.");
            }
        }

        // Пошук рецепту за назвою
        private void RecipeSearchTB_TextChanged(object sender, EventArgs e)
        {
            string searchText = RecipeSearchTB.Text.ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                RecipeDG.DataSource = _recipeDatabase.Recipes;
            }
            else
            {
                var filteredRecipes = _recipeDatabase.Recipes
                    .Where(d => d.Name.ToLower().Contains(searchText))
                    .ToList();
                RecipeDG.DataSource = filteredRecipes;
            }
        }

        // Оновлення DataGridView рецептів та ComboBox страв
        private void RefreshRecipeGrid()
        {
            RecipeDG.DataSource = null;
            RecipeDG.DataSource = _recipeDatabase.Recipes;

            SelectedDishCB.DataSource = null;
            SelectedDishCB.DataSource = _recipeDatabase.Recipes;
            SelectedDishCB.DisplayMember = "Name";
        }

        // Скидання форми рецепту в режим додавання
        private void ResetRecipeForm()
        {
            _editingDish = null;
            RecipeNameTB.Text = string.Empty;
            RecipeTextTB.Text = string.Empty;
            _newRecipeIngredients.Clear();
            groupBox5.Text = "Додавання рецепту";
            CompleteBTN.Text = "Готово";
        }

        // Збереження даних при закритті форми
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            try
            {
                var appData = new AppData
                {
                    Products = _storageManager.Products,
                    Recipes = _recipeDatabase.Recipes,
                    Menu = _dailyMenu
                };
                _fileService.SaveData(appData, _file);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка збереження даних: {ex.Message}");
            }
            base.OnFormClosing(e);
        }
    }
}
