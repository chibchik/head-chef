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
            RecipeDatabase = new TabPage();
            dailyMenuBindingSource = new BindingSource(components);
            dishBindingSource1 = new BindingSource(components);
            productBindingSource = new BindingSource(components);
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
            ((System.ComponentModel.ISupportInitialize)dailyMenuBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dishBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
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
            DailyMenuDG.Size = new Size(750, 215);
            DailyMenuDG.TabIndex = 1;
            // 
            // CreateMenuBTN
            // 
            CreateMenuBTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            SelectedDishCB.SelectedIndexChanged += SelectedDishCB_SelectedIndexChanged;
            // 
            // recipeDatabaseBindingSource
            // 
            recipeDatabaseBindingSource.DataSource = typeof(Managers.RecipeDatabase);
            // 
            // AddToMenuBTN
            // 
            AddToMenuBTN.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            Storage.Location = new Point(4, 24);
            Storage.Name = "Storage";
            Storage.Padding = new Padding(3);
            Storage.Size = new Size(768, 398);
            Storage.TabIndex = 1;
            Storage.Text = "Склад";
            Storage.UseVisualStyleBackColor = true;
            // 
            // RecipeDatabase
            // 
            RecipeDatabase.Location = new Point(4, 24);
            RecipeDatabase.Name = "RecipeDatabase";
            RecipeDatabase.Padding = new Padding(3);
            RecipeDatabase.Size = new Size(768, 398);
            RecipeDatabase.TabIndex = 2;
            RecipeDatabase.Text = "База рецептур";
            RecipeDatabase.UseVisualStyleBackColor = true;
            // 
            // dailyMenuBindingSource
            // 
            dailyMenuBindingSource.DataSource = typeof(Models.DailyMenu);
            // 
            // dishBindingSource1
            // 
            dishBindingSource1.DataSource = typeof(Models.Dish);
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Models.Product);
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
            ((System.ComponentModel.ISupportInitialize)dailyMenuBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dishBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
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
    }
}
