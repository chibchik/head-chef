namespace head_chef
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            TabControl = new TabControl();
            DailyMenu = new TabPage();
            groupBox2 = new GroupBox();
            DelDishFromMenuBTN = new Button();
            PersonsCountUD = new NumericUpDown();
            DailyMenuDG = new DataGridView();
            CreateMenuBTN = new Button();
            label2 = new Label();
            groupBox1 = new GroupBox();
            SelectedDishCB = new ComboBox();
            recipeDatabaseBindingSource = new BindingSource(components);
            AddToMenuBTN = new Button();
            label1 = new Label();
            Storage = new TabPage();
            groupBox4 = new GroupBox();
            QuantityUD = new NumericUpDown();
            PriceUD = new NumericUpDown();
            ToAddBTN = new Button();
            CompleteEditBTN = new Button();
            ExpirationDateDtP = new DateTimePicker();
            NameTB = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox3 = new GroupBox();
            label7 = new Label();
            SearchTB = new TextBox();
            DeleteProductBTN = new Button();
            EditProductBTN = new Button();
            StorageDG = new DataGridView();
            RecipeDatabase = new TabPage();
            groupBox5 = new GroupBox();
            CompleteBTN = new Button();
            IngrQuantityUD = new NumericUpDown();
            RecipeNameTB = new TextBox();
            ProductCB = new ComboBox();
            RecipeTextTB = new RichTextBox();
            label13 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            IngredientsDG = new DataGridView();
            DeleteIngrBTN = new Button();
            AddIngrBTN = new Button();
            groupBox6 = new GroupBox();
            label12 = new Label();
            RecipeSearchTB = new TextBox();
            DelRecipeBTN = new Button();
            EditRecipeBTN = new Button();
            RecipeDG = new DataGridView();
            productBindingSource = new BindingSource(components);
            productBindingSource1 = new BindingSource(components);
            dailyMenuBindingSource = new BindingSource(components);
            dishBindingSource1 = new BindingSource(components);
            storageManagerBindingSource = new BindingSource(components);
            dishBindingSource = new BindingSource(components);
            fileServiceBindingSource = new BindingSource(components);
            dailyMenuBindingSource1 = new BindingSource(components);
            appDataBindingSource = new BindingSource(components);
            TabControl.SuspendLayout();
            DailyMenu.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PersonsCountUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DailyMenuDG).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)recipeDatabaseBindingSource).BeginInit();
            Storage.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)QuantityUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PriceUD).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StorageDG).BeginInit();
            RecipeDatabase.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IngrQuantityUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IngredientsDG).BeginInit();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RecipeDG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dailyMenuBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dishBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)storageManagerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dishBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileServiceBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dailyMenuBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)appDataBindingSource).BeginInit();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TabControl.Controls.Add(DailyMenu);
            TabControl.Controls.Add(Storage);
            TabControl.Controls.Add(RecipeDatabase);
            TabControl.Location = new Point(12, 12);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(776, 426);
            TabControl.TabIndex = 0;
            // 
            // DailyMenu
            // 
            DailyMenu.Controls.Add(groupBox2);
            DailyMenu.Controls.Add(groupBox1);
            DailyMenu.Location = new Point(4, 24);
            DailyMenu.Name = "DailyMenu";
            DailyMenu.Padding = new Padding(3);
            DailyMenu.Size = new Size(768, 398);
            DailyMenu.TabIndex = 0;
            DailyMenu.Text = "Меню на день";
            DailyMenu.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DelDishFromMenuBTN);
            groupBox2.Controls.Add(PersonsCountUD);
            groupBox2.Controls.Add(DailyMenuDG);
            groupBox2.Controls.Add(CreateMenuBTN);
            groupBox2.Controls.Add(label2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.Location = new Point(3, 94);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(762, 301);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Заплановані на сьогодні страви:";
            // 
            // DelDishFromMenuBTN
            // 
            DelDishFromMenuBTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DelDishFromMenuBTN.Location = new Point(6, 215);
            DelDishFromMenuBTN.Name = "DelDishFromMenuBTN";
            DelDishFromMenuBTN.Size = new Size(750, 23);
            DelDishFromMenuBTN.TabIndex = 5;
            DelDishFromMenuBTN.Text = "Видалити страву за меню на день";
            DelDishFromMenuBTN.UseVisualStyleBackColor = true;
            DelDishFromMenuBTN.Click += DelDishFromMenuBTN_Click;
            // 
            // PersonsCountUD
            // 
            PersonsCountUD.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            PersonsCountUD.Font = new Font("Segoe UI", 9F);
            PersonsCountUD.Location = new Point(133, 243);
            PersonsCountUD.Name = "PersonsCountUD";
            PersonsCountUD.Size = new Size(84, 23);
            PersonsCountUD.TabIndex = 4;
            // 
            // DailyMenuDG
            // 
            DailyMenuDG.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DailyMenuDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DailyMenuDG.Location = new Point(6, 22);
            DailyMenuDG.Name = "DailyMenuDG";
            DailyMenuDG.Size = new Size(750, 187);
            DailyMenuDG.TabIndex = 1;
            // 
            // CreateMenuBTN
            // 
            CreateMenuBTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CreateMenuBTN.Cursor = Cursors.Hand;
            CreateMenuBTN.Location = new Point(6, 272);
            CreateMenuBTN.Name = "CreateMenuBTN";
            CreateMenuBTN.Size = new Size(750, 23);
            CreateMenuBTN.TabIndex = 0;
            CreateMenuBTN.Text = "Сформувати меню та перевірити запаси";
            CreateMenuBTN.UseVisualStyleBackColor = true;
            CreateMenuBTN.Click += CreateMenuBTN_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(25, 245);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 1;
            label2.Text = "Кількість персон:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(SelectedDishCB);
            groupBox1.Controls.Add(AddToMenuBTN);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(762, 91);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Додати страву в меню на день";
            // 
            // SelectedDishCB
            // 
            SelectedDishCB.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SelectedDishCB.DataSource = recipeDatabaseBindingSource;
            SelectedDishCB.Font = new Font("Segoe UI", 9F);
            SelectedDishCB.FormattingEnabled = true;
            SelectedDishCB.Location = new Point(123, 25);
            SelectedDishCB.Name = "SelectedDishCB";
            SelectedDishCB.Size = new Size(633, 23);
            SelectedDishCB.TabIndex = 3;
            // 
            // recipeDatabaseBindingSource
            // 
            recipeDatabaseBindingSource.DataSource = typeof(Managers.RecipeDatabase);
            // 
            // AddToMenuBTN
            // 
            AddToMenuBTN.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddToMenuBTN.Cursor = Cursors.Hand;
            AddToMenuBTN.Location = new Point(25, 54);
            AddToMenuBTN.Name = "AddToMenuBTN";
            AddToMenuBTN.Size = new Size(731, 23);
            AddToMenuBTN.TabIndex = 2;
            AddToMenuBTN.Text = "Додати до меню";
            AddToMenuBTN.UseVisualStyleBackColor = true;
            AddToMenuBTN.Click += AddToMenuBTN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(25, 28);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 0;
            label1.Text = "Оберіть страву:";
            // 
            // Storage
            // 
            Storage.Controls.Add(groupBox4);
            Storage.Controls.Add(groupBox3);
            Storage.Location = new Point(4, 24);
            Storage.Name = "Storage";
            Storage.Padding = new Padding(3);
            Storage.Size = new Size(768, 398);
            Storage.TabIndex = 1;
            Storage.Text = "Склад";
            Storage.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox4.Controls.Add(QuantityUD);
            groupBox4.Controls.Add(PriceUD);
            groupBox4.Controls.Add(ToAddBTN);
            groupBox4.Controls.Add(CompleteEditBTN);
            groupBox4.Controls.Add(ExpirationDateDtP);
            groupBox4.Controls.Add(NameTB);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(label3);
            groupBox4.Location = new Point(502, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(263, 392);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Додавання продукту:";
            // 
            // QuantityUD
            // 
            QuantityUD.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            QuantityUD.DecimalPlaces = 2;
            QuantityUD.Location = new Point(6, 128);
            QuantityUD.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            QuantityUD.Name = "QuantityUD";
            QuantityUD.Size = new Size(251, 23);
            QuantityUD.TabIndex = 11;
            // 
            // PriceUD
            // 
            PriceUD.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PriceUD.DecimalPlaces = 2;
            PriceUD.Location = new Point(6, 84);
            PriceUD.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            PriceUD.Name = "PriceUD";
            PriceUD.Size = new Size(251, 23);
            PriceUD.TabIndex = 10;
            // 
            // ToAddBTN
            // 
            ToAddBTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ToAddBTN.Cursor = Cursors.Hand;
            ToAddBTN.Location = new Point(6, 366);
            ToAddBTN.Name = "ToAddBTN";
            ToAddBTN.Size = new Size(251, 23);
            ToAddBTN.TabIndex = 9;
            ToAddBTN.Text = "Перейти до додавання продуктів";
            ToAddBTN.UseVisualStyleBackColor = true;
            ToAddBTN.Click += ToAddBTN_Click;
            // 
            // CompleteEditBTN
            // 
            CompleteEditBTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CompleteEditBTN.Cursor = Cursors.Hand;
            CompleteEditBTN.Location = new Point(6, 339);
            CompleteEditBTN.Name = "CompleteEditBTN";
            CompleteEditBTN.Size = new Size(251, 23);
            CompleteEditBTN.TabIndex = 8;
            CompleteEditBTN.Text = "Готово";
            CompleteEditBTN.UseVisualStyleBackColor = true;
            CompleteEditBTN.Click += CompleteAddBTN_Click;
            // 
            // ExpirationDateDtP
            // 
            ExpirationDateDtP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ExpirationDateDtP.Location = new Point(6, 172);
            ExpirationDateDtP.Name = "ExpirationDateDtP";
            ExpirationDateDtP.Size = new Size(251, 23);
            ExpirationDateDtP.TabIndex = 7;
            // 
            // NameTB
            // 
            NameTB.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTB.Location = new Point(6, 40);
            NameTB.Name = "NameTB";
            NameTB.Size = new Size(251, 23);
            NameTB.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 154);
            label6.Name = "label6";
            label6.Size = new Size(118, 15);
            label6.TabIndex = 3;
            label6.Text = "Термін придатності:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 110);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 2;
            label5.Text = "Кількість";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 66);
            label4.Name = "label4";
            label4.Size = new Size(136, 15);
            label4.TabIndex = 1;
            label4.Text = "Ціна за одиницю (грн.):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 22);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 0;
            label3.Text = "Найменування:";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(SearchTB);
            groupBox3.Controls.Add(DeleteProductBTN);
            groupBox3.Controls.Add(EditProductBTN);
            groupBox3.Controls.Add(StorageDG);
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(499, 392);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Поточні запаси:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(6, 369);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 4;
            label7.Text = "Пошук:";
            // 
            // SearchTB
            // 
            SearchTB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SearchTB.Location = new Point(61, 366);
            SearchTB.Name = "SearchTB";
            SearchTB.Size = new Size(432, 23);
            SearchTB.TabIndex = 3;
            SearchTB.TextChanged += SearchTB_TextChanged;
            // 
            // DeleteProductBTN
            // 
            DeleteProductBTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DeleteProductBTN.Cursor = Cursors.Hand;
            DeleteProductBTN.Location = new Point(251, 338);
            DeleteProductBTN.Name = "DeleteProductBTN";
            DeleteProductBTN.Size = new Size(242, 25);
            DeleteProductBTN.TabIndex = 2;
            DeleteProductBTN.Text = "Видалити";
            DeleteProductBTN.UseVisualStyleBackColor = true;
            DeleteProductBTN.Click += DeleteProductBTN_Click;
            // 
            // EditProductBTN
            // 
            EditProductBTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            EditProductBTN.Cursor = Cursors.Hand;
            EditProductBTN.Location = new Point(3, 338);
            EditProductBTN.Name = "EditProductBTN";
            EditProductBTN.Size = new Size(242, 25);
            EditProductBTN.TabIndex = 1;
            EditProductBTN.Text = "Редагувати";
            EditProductBTN.UseVisualStyleBackColor = true;
            EditProductBTN.Click += EditProductBTN_Click;
            // 
            // StorageDG
            // 
            StorageDG.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StorageDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StorageDG.Location = new Point(3, 22);
            StorageDG.Name = "StorageDG";
            StorageDG.Size = new Size(490, 310);
            StorageDG.TabIndex = 0;
            // 
            // RecipeDatabase
            // 
            RecipeDatabase.Controls.Add(groupBox5);
            RecipeDatabase.Controls.Add(groupBox6);
            RecipeDatabase.Location = new Point(4, 24);
            RecipeDatabase.Name = "RecipeDatabase";
            RecipeDatabase.Padding = new Padding(3);
            RecipeDatabase.Size = new Size(768, 398);
            RecipeDatabase.TabIndex = 2;
            RecipeDatabase.Text = "База рецептур";
            RecipeDatabase.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox5.Controls.Add(CompleteBTN);
            groupBox5.Controls.Add(IngrQuantityUD);
            groupBox5.Controls.Add(RecipeNameTB);
            groupBox5.Controls.Add(ProductCB);
            groupBox5.Controls.Add(RecipeTextTB);
            groupBox5.Controls.Add(label13);
            groupBox5.Controls.Add(label11);
            groupBox5.Controls.Add(label10);
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(label8);
            groupBox5.Controls.Add(IngredientsDG);
            groupBox5.Controls.Add(DeleteIngrBTN);
            groupBox5.Controls.Add(AddIngrBTN);
            groupBox5.Location = new Point(498, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(267, 392);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            groupBox5.Text = "Додавання рецепту:";
            // 
            // CompleteBTN
            // 
            CompleteBTN.Location = new Point(6, 135);
            CompleteBTN.Name = "CompleteBTN";
            CompleteBTN.Size = new Size(255, 23);
            CompleteBTN.TabIndex = 21;
            CompleteBTN.Text = "Готово";
            CompleteBTN.UseVisualStyleBackColor = true;
            CompleteBTN.Click += CompleteBTN_Click;
            // 
            // IngrQuantityUD
            // 
            IngrQuantityUD.Location = new Point(6, 238);
            IngrQuantityUD.Name = "IngrQuantityUD";
            IngrQuantityUD.Size = new Size(255, 23);
            IngrQuantityUD.TabIndex = 20;
            // 
            // RecipeNameTB
            // 
            RecipeNameTB.Location = new Point(6, 37);
            RecipeNameTB.Name = "RecipeNameTB";
            RecipeNameTB.Size = new Size(255, 23);
            RecipeNameTB.TabIndex = 19;
            // 
            // ProductCB
            // 
            ProductCB.FormattingEnabled = true;
            ProductCB.Location = new Point(6, 194);
            ProductCB.Name = "ProductCB";
            ProductCB.Size = new Size(255, 23);
            ProductCB.TabIndex = 18;
            // 
            // RecipeTextTB
            // 
            RecipeTextTB.Location = new Point(6, 81);
            RecipeTextTB.Name = "RecipeTextTB";
            RecipeTextTB.Size = new Size(255, 48);
            RecipeTextTB.TabIndex = 17;
            RecipeTextTB.Text = "";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 220);
            label13.Name = "label13";
            label13.Size = new Size(59, 15);
            label13.TabIndex = 15;
            label13.Text = "Кількість:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 176);
            label11.Name = "label11";
            label11.Size = new Size(56, 15);
            label11.TabIndex = 14;
            label11.Text = "Продукт:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 161);
            label10.Name = "label10";
            label10.Size = new Size(66, 15);
            label10.TabIndex = 13;
            label10.Text = "Розкладка:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 63);
            label9.Name = "label9";
            label9.Size = new Size(48, 15);
            label9.TabIndex = 12;
            label9.Text = "Рецепт:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 19);
            label8.Name = "label8";
            label8.Size = new Size(82, 15);
            label8.TabIndex = 11;
            label8.Text = "Назва страви:";
            // 
            // IngredientsDG
            // 
            IngredientsDG.AllowUserToAddRows = false;
            IngredientsDG.AllowUserToDeleteRows = false;
            IngredientsDG.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            IngredientsDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            IngredientsDG.Location = new Point(6, 294);
            IngredientsDG.Name = "IngredientsDG";
            IngredientsDG.Size = new Size(255, 69);
            IngredientsDG.TabIndex = 10;
            // 
            // DeleteIngrBTN
            // 
            DeleteIngrBTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DeleteIngrBTN.Cursor = Cursors.Hand;
            DeleteIngrBTN.Location = new Point(6, 366);
            DeleteIngrBTN.Name = "DeleteIngrBTN";
            DeleteIngrBTN.Size = new Size(255, 23);
            DeleteIngrBTN.TabIndex = 9;
            DeleteIngrBTN.Text = "Видалити інгредієнт";
            DeleteIngrBTN.UseVisualStyleBackColor = true;
            DeleteIngrBTN.Click += DeleteIngrBTN_Click;
            // 
            // AddIngrBTN
            // 
            AddIngrBTN.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddIngrBTN.Cursor = Cursors.Hand;
            AddIngrBTN.Location = new Point(6, 265);
            AddIngrBTN.Name = "AddIngrBTN";
            AddIngrBTN.Size = new Size(255, 23);
            AddIngrBTN.TabIndex = 8;
            AddIngrBTN.Text = "Додати інгредієнт";
            AddIngrBTN.UseVisualStyleBackColor = true;
            AddIngrBTN.Click += AddIngrBTN_Click;
            // 
            // groupBox6
            // 
            groupBox6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox6.Controls.Add(label12);
            groupBox6.Controls.Add(RecipeSearchTB);
            groupBox6.Controls.Add(DelRecipeBTN);
            groupBox6.Controls.Add(EditRecipeBTN);
            groupBox6.Controls.Add(RecipeDG);
            groupBox6.Location = new Point(3, 3);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(495, 392);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            groupBox6.Text = "Поточні рецепти:";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label12.AutoSize = true;
            label12.Location = new Point(6, 369);
            label12.Name = "label12";
            label12.Size = new Size(49, 15);
            label12.TabIndex = 4;
            label12.Text = "Пошук:";
            // 
            // RecipeSearchTB
            // 
            RecipeSearchTB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RecipeSearchTB.Location = new Point(61, 366);
            RecipeSearchTB.Name = "RecipeSearchTB";
            RecipeSearchTB.Size = new Size(428, 23);
            RecipeSearchTB.TabIndex = 3;
            RecipeSearchTB.TextChanged += RecipeSearchTB_TextChanged;
            // 
            // DelRecipeBTN
            // 
            DelRecipeBTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DelRecipeBTN.Cursor = Cursors.Hand;
            DelRecipeBTN.Location = new Point(247, 338);
            DelRecipeBTN.Name = "DelRecipeBTN";
            DelRecipeBTN.Size = new Size(242, 25);
            DelRecipeBTN.TabIndex = 2;
            DelRecipeBTN.Text = "Видалити";
            DelRecipeBTN.UseVisualStyleBackColor = true;
            DelRecipeBTN.Click += DelRecipeBTN_Click;
            // 
            // EditRecipeBTN
            // 
            EditRecipeBTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            EditRecipeBTN.AutoSize = true;
            EditRecipeBTN.Cursor = Cursors.Hand;
            EditRecipeBTN.Location = new Point(3, 338);
            EditRecipeBTN.Name = "EditRecipeBTN";
            EditRecipeBTN.Size = new Size(242, 25);
            EditRecipeBTN.TabIndex = 1;
            EditRecipeBTN.Text = "Редагувати";
            EditRecipeBTN.UseVisualStyleBackColor = true;
            EditRecipeBTN.Click += EditRecipeBTN_Click;
            // 
            // RecipeDG
            // 
            RecipeDG.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RecipeDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RecipeDG.Location = new Point(3, 22);
            RecipeDG.Name = "RecipeDG";
            RecipeDG.Size = new Size(486, 310);
            RecipeDG.TabIndex = 0;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Models.Product);
            // 
            // productBindingSource1
            // 
            productBindingSource1.DataSource = typeof(Models.Product);
            // 
            // dailyMenuBindingSource
            // 
            dailyMenuBindingSource.DataSource = typeof(Models.DailyMenu);
            // 
            // dishBindingSource1
            // 
            dishBindingSource1.DataSource = typeof(Models.Dish);
            // 
            // storageManagerBindingSource
            // 
            storageManagerBindingSource.DataSource = typeof(Managers.StorageManager);
            // 
            // dishBindingSource
            // 
            dishBindingSource.DataSource = typeof(Models.Dish);
            // 
            // fileServiceBindingSource
            // 
            fileServiceBindingSource.DataSource = typeof(Services.FileService);
            // 
            // dailyMenuBindingSource1
            // 
            dailyMenuBindingSource1.DataSource = typeof(Models.DailyMenu);
            // 
            // appDataBindingSource
            // 
            appDataBindingSource.DataSource = typeof(Models.AppData);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TabControl);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            TabControl.ResumeLayout(false);
            DailyMenu.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PersonsCountUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)DailyMenuDG).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)recipeDatabaseBindingSource).EndInit();
            Storage.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)QuantityUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)PriceUD).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)StorageDG).EndInit();
            RecipeDatabase.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IngrQuantityUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)IngredientsDG).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RecipeDG).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dailyMenuBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dishBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)storageManagerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dishBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileServiceBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dailyMenuBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)appDataBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl;
        private TabPage DailyMenu;
        private TabPage Storage;
        private TabPage RecipeDatabase;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Button CreateMenuBTN;
        private Button AddToMenuBTN;
        private Label label2;
        private Label label1;
        private NumericUpDown PersonsCountUD;
        private ComboBox SelectedDishCB;
        private DataGridView DailyMenuDG;
        private BindingSource dailyMenuBindingSource;
        private BindingSource dishBindingSource;
        private BindingSource productBindingSource;
        private BindingSource fileServiceBindingSource;
        private BindingSource storageManagerBindingSource;
        private BindingSource dailyMenuBindingSource1;
        private BindingSource appDataBindingSource;
        private BindingSource dishBindingSource1;
        private BindingSource recipeDatabaseBindingSource;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private DataGridView StorageDG;
        private BindingSource productBindingSource1;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label5;
        private TextBox NameTB;
        private DateTimePicker ExpirationDateDtP;
        private Button CompleteEditBTN;
        private Label label7;
        private TextBox SearchTB;
        private Button DeleteProductBTN;
        private Button EditProductBTN;
        private Button ToAddBTN;
        private NumericUpDown QuantityUD;
        private NumericUpDown PriceUD;
        private Button DelDishFromMenuBTN;
        private GroupBox groupBox5;
        private Button DeleteIngrBTN;
        private Button AddIngrBTN;
        private GroupBox groupBox6;
        private Label label12;
        private TextBox RecipeSearchTB;
        private Button DelRecipeBTN;
        private Button EditRecipeBTN;
        private DataGridView RecipeDG;
        private DataGridView IngredientsDG;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label13;
        private RichTextBox RecipeTextTB;
        private ComboBox ProductCB;
        private TextBox RecipeNameTB;
        private Button CompleteBTN;
        private NumericUpDown IngrQuantityUD;
    }
}
