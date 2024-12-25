namespace SYBDKR
{
    partial class SalesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewSales = new DataGridView();
            btnAddSale = new Button();
            groupBox1 = new GroupBox();
            label6 = new Label();
            txtManagerId = new TextBox();
            label5 = new Label();
            txtSalePrice = new TextBox();
            label4 = new Label();
            txtSaleDate = new TextBox();
            label3 = new Label();
            txtQuantity = new TextBox();
            txtProductId = new TextBox();
            label2 = new Label();
            txtSaleId = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtSearch = new TextBox();
            label7 = new Label();
            btnExit = new Button();
            btnUpdateSale = new Button();
            btnDeleteSale = new Button();
            btnSearchSale = new Button();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSales).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewSales
            // 
            dataGridViewSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSales.Location = new Point(12, 41);
            dataGridViewSales.Name = "dataGridViewSales";
            dataGridViewSales.Size = new Size(776, 275);
            dataGridViewSales.TabIndex = 0;
            dataGridViewSales.CellClick += dataGridViewSales_CellClick;
            // 
            // btnAddSale
            // 
            btnAddSale.Location = new Point(12, 12);
            btnAddSale.Name = "btnAddSale";
            btnAddSale.Size = new Size(75, 23);
            btnAddSale.TabIndex = 1;
            btnAddSale.Text = "Добавить";
            btnAddSale.UseVisualStyleBackColor = true;
            btnAddSale.Click += btnAddSale_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtManagerId);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtSalePrice);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtSaleDate);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(txtProductId);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtSaleId);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(11, 321);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(376, 117);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод данных";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(185, 45);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 11;
            label6.Text = "ID менеджера:";
            // 
            // txtManagerId
            // 
            txtManagerId.Location = new Point(277, 42);
            txtManagerId.Name = "txtManagerId";
            txtManagerId.Size = new Size(93, 23);
            txtManagerId.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(181, 18);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 9;
            label5.Text = "Цена продажи:";
            // 
            // txtSalePrice
            // 
            txtSalePrice.Location = new Point(277, 15);
            txtSalePrice.Name = "txtSalePrice";
            txtSalePrice.Size = new Size(93, 23);
            txtSalePrice.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 97);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 7;
            label4.Text = "Дата продажи:";
            // 
            // txtSaleDate
            // 
            txtSaleDate.Location = new Point(100, 94);
            txtSaleDate.Name = "txtSaleDate";
            txtSaleDate.Size = new Size(100, 23);
            txtSaleDate.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 69);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 5;
            label3.Text = "Кол-во товара:";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(100, 66);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 4;
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(72, 39);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(100, 23);
            txtProductId.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 42);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 2;
            label2.Text = "ID товара:";
            // 
            // txtSaleId
            // 
            txtSaleId.Location = new Point(75, 15);
            txtSaleId.Name = "txtSaleId";
            txtSaleId.Size = new Size(100, 23);
            txtSaleId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 18);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "ID продажи:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(395, 321);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(393, 48);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Поиск данных (по ID товара)";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(72, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(315, 23);
            txtSearch.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 18);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 0;
            label7.Text = "ID товара:";
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnExit.Location = new Point(395, 375);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(213, 63);
            btnExit.TabIndex = 4;
            btnExit.Text = "Закрыть форму";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnUpdateSale
            // 
            btnUpdateSale.Location = new Point(226, 12);
            btnUpdateSale.Name = "btnUpdateSale";
            btnUpdateSale.Size = new Size(75, 23);
            btnUpdateSale.TabIndex = 5;
            btnUpdateSale.Text = "Изменить";
            btnUpdateSale.UseVisualStyleBackColor = true;
            btnUpdateSale.Click += btnUpdateSale_Click;
            // 
            // btnDeleteSale
            // 
            btnDeleteSale.Location = new Point(478, 12);
            btnDeleteSale.Name = "btnDeleteSale";
            btnDeleteSale.Size = new Size(75, 23);
            btnDeleteSale.TabIndex = 6;
            btnDeleteSale.Text = "Удалить";
            btnDeleteSale.UseVisualStyleBackColor = true;
            btnDeleteSale.Click += btnDeleteSale_Click;
            // 
            // btnSearchSale
            // 
            btnSearchSale.Location = new Point(713, 12);
            btnSearchSale.Name = "btnSearchSale";
            btnSearchSale.Size = new Size(75, 23);
            btnSearchSale.TabIndex = 7;
            btnSearchSale.Text = "Поиск";
            btnSearchSale.UseVisualStyleBackColor = true;
            btnSearchSale.Click += btnSearchSale_Click;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnLoad.Location = new Point(609, 375);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(179, 63);
            btnLoad.TabIndex = 8;
            btnLoad.Text = "Загрузить таблицу";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoad);
            Controls.Add(btnSearchSale);
            Controls.Add(btnDeleteSale);
            Controls.Add(btnUpdateSale);
            Controls.Add(btnExit);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnAddSale);
            Controls.Add(dataGridViewSales);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SalesForm";
            Text = "Продажи";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSales).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewSales;
        private Button btnAddSale;
        private GroupBox groupBox1;
        private TextBox txtSaleId;
        private Label label1;
        private Label label3;
        private TextBox txtQuantity;
        private TextBox txtProductId;
        private Label label2;
        private Label label6;
        private TextBox txtManagerId;
        private Label label5;
        private TextBox txtSalePrice;
        private Label label4;
        private TextBox txtSaleDate;
        private GroupBox groupBox2;
        private TextBox txtSearch;
        private Label label7;
        private Button btnExit;
        private Button btnUpdateSale;
        private Button btnDeleteSale;
        private Button btnSearchSale;
        private Button btnLoad;
    }
}