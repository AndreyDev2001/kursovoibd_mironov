namespace SYBDKR
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
            btnProducts = new Button();
            btnSuppliers = new Button();
            btnManagers = new Button();
            btnInventory = new Button();
            btnSales = new Button();
            btnReports = new Button();
            btnPremises = new Button();
            SuspendLayout();
            // 
            // btnProducts
            // 
            btnProducts.Location = new Point(18, 19);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(75, 23);
            btnProducts.TabIndex = 0;
            btnProducts.Text = "Товары";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.Location = new Point(120, 19);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(87, 23);
            btnSuppliers.TabIndex = 1;
            btnSuppliers.Text = "Поставщики";
            btnSuppliers.UseVisualStyleBackColor = true;
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // btnManagers
            // 
            btnManagers.Location = new Point(234, 19);
            btnManagers.Name = "btnManagers";
            btnManagers.Size = new Size(82, 23);
            btnManagers.TabIndex = 2;
            btnManagers.Text = "Менеджеры";
            btnManagers.UseVisualStyleBackColor = true;
            btnManagers.Click += btnManagers_Click;
            // 
            // btnInventory
            // 
            btnInventory.Location = new Point(339, 19);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(75, 23);
            btnInventory.TabIndex = 3;
            btnInventory.Text = "Склад";
            btnInventory.UseVisualStyleBackColor = true;
            btnInventory.Click += btnInventory_Click;
            // 
            // btnSales
            // 
            btnSales.Location = new Point(433, 19);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(75, 23);
            btnSales.TabIndex = 4;
            btnSales.Text = "Продажи";
            btnSales.UseVisualStyleBackColor = true;
            btnSales.Click += btnSales_Click;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(525, 19);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(129, 23);
            btnReports.TabIndex = 5;
            btnReports.Text = "Генерация отчётов";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnPremises
            // 
            btnPremises.Location = new Point(685, 19);
            btnPremises.Name = "btnPremises";
            btnPremises.Size = new Size(103, 23);
            btnPremises.TabIndex = 6;
            btnPremises.Text = "Помещения";
            btnPremises.UseVisualStyleBackColor = true;
            btnPremises.Click += btnPremises_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 57);
            Controls.Add(btnPremises);
            Controls.Add(btnReports);
            Controls.Add(btnSales);
            Controls.Add(btnInventory);
            Controls.Add(btnManagers);
            Controls.Add(btnSuppliers);
            Controls.Add(btnProducts);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Выбор формы";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProducts;
        private Button btnSuppliers;
        private Button btnManagers;
        private Button btnInventory;
        private Button btnSales;
        private Button btnReports;
        private Button btnPremises;
    }
}
