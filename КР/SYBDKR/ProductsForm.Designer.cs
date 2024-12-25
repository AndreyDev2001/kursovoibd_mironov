namespace SYBDKR
{
    partial class ProductsForm
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
            dataGridViewProducts = new DataGridView();
            btnAddProduct = new Button();
            txtProductId = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtImagePath = new TextBox();
            label4 = new Label();
            txtSupplierId = new TextBox();
            label3 = new Label();
            txtDescription = new TextBox();
            label2 = new Label();
            btnUpdateProduct = new Button();
            btnDeleteProduct = new Button();
            groupBox2 = new GroupBox();
            txtSearch = new TextBox();
            label5 = new Label();
            btnSearchProduct = new Button();
            btnUploadImage = new Button();
            openFileDialog = new OpenFileDialog();
            exitBtn = new Button();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(12, 33);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.Size = new Size(776, 266);
            dataGridViewProducts.TabIndex = 0;
            dataGridViewProducts.CellClick += dataGridViewProducts_CellClick;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(12, 4);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(75, 23);
            btnAddProduct.TabIndex = 1;
            btnAddProduct.Text = "Добавить";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(73, 14);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(288, 23);
            txtProductId.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 16);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 3;
            label1.Text = "ID товара:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtImagePath);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtSupplierId);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtProductId);
            groupBox1.Location = new Point(12, 305);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(371, 133);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод данных";
            // 
            // txtImagePath
            // 
            txtImagePath.Enabled = false;
            txtImagePath.Location = new Point(131, 92);
            txtImagePath.Name = "txtImagePath";
            txtImagePath.Size = new Size(230, 23);
            txtImagePath.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 95);
            label4.Name = "label4";
            label4.Size = new Size(126, 15);
            label4.TabIndex = 8;
            label4.Text = "Путь к изображению:";
            // 
            // txtSupplierId
            // 
            txtSupplierId.Location = new Point(95, 65);
            txtSupplierId.Name = "txtSupplierId";
            txtSupplierId.Size = new Size(266, 23);
            txtSupplierId.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 68);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 6;
            label3.Text = "ID поставщика:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(74, 39);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(287, 23);
            txtDescription.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 40);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 4;
            label2.Text = "Описание:";
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.Location = new Point(172, 4);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(75, 23);
            btnUpdateProduct.TabIndex = 5;
            btnUpdateProduct.Text = "Изменить";
            btnUpdateProduct.UseVisualStyleBackColor = true;
            btnUpdateProduct.Click += btnUpdateProduct_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(332, 4);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(75, 23);
            btnDeleteProduct.TabIndex = 6;
            btnDeleteProduct.Text = "Удалить";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(395, 310);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(393, 50);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Поиск в таблице";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(224, 16);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(163, 23);
            txtSearch.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 19);
            label5.Name = "label5";
            label5.Size = new Size(224, 15);
            label5.TabIndex = 0;
            label5.Text = "Данные для поиска (описание товара): ";
            // 
            // btnSearchProduct
            // 
            btnSearchProduct.Location = new Point(483, 4);
            btnSearchProduct.Name = "btnSearchProduct";
            btnSearchProduct.Size = new Size(75, 23);
            btnSearchProduct.TabIndex = 8;
            btnSearchProduct.Text = "Поиск";
            btnSearchProduct.UseVisualStyleBackColor = true;
            btnSearchProduct.Click += btnSearchProduct_Click;
            // 
            // btnUploadImage
            // 
            btnUploadImage.Location = new Point(641, 4);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new Size(147, 23);
            btnUploadImage.TabIndex = 9;
            btnUploadImage.Text = "Загрузить изображение";
            btnUploadImage.UseVisualStyleBackColor = true;
            btnUploadImage.Click += btnUploadImage_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // exitBtn
            // 
            exitBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            exitBtn.Location = new Point(400, 366);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(198, 72);
            exitBtn.TabIndex = 10;
            exitBtn.Text = "Закрыть форму";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnLoad.Location = new Point(601, 366);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(187, 72);
            btnLoad.TabIndex = 11;
            btnLoad.Text = "Загрузить таблицу";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoad);
            Controls.Add(exitBtn);
            Controls.Add(btnUploadImage);
            Controls.Add(btnSearchProduct);
            Controls.Add(groupBox2);
            Controls.Add(btnDeleteProduct);
            Controls.Add(btnUpdateProduct);
            Controls.Add(groupBox1);
            Controls.Add(btnAddProduct);
            Controls.Add(dataGridViewProducts);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ProductsForm";
            Text = "Товары";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewProducts;
        private Button btnAddProduct;
        private TextBox txtProductId;
        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox txtDescription;
        private Label label2;
        private TextBox txtImagePath;
        private Label label4;
        private TextBox txtSupplierId;
        private Button btnUpdateProduct;
        private Button btnDeleteProduct;
        private GroupBox groupBox2;
        private TextBox txtSearch;
        private Label label5;
        private Button btnSearchProduct;
        private Button btnUploadImage;
        private OpenFileDialog openFileDialog;
        private Button exitBtn;
        private Button btnLoad;
    }
}