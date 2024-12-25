namespace SYBDKR
{
    partial class SuppliersForm
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
            dataGridViewSuppliers = new DataGridView();
            groupBox1 = new GroupBox();
            txtAddress = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtSupplierId = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label4 = new Label();
            txtSearch = new TextBox();
            btnExit = new Button();
            btnAddSupplier = new Button();
            btnUpdateSupplier = new Button();
            btnDeleteSupplier = new Button();
            btnSearchSupplier = new Button();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewSuppliers
            // 
            dataGridViewSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSuppliers.Location = new Point(12, 48);
            dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            dataGridViewSuppliers.Size = new Size(776, 265);
            dataGridViewSuppliers.TabIndex = 0;
            dataGridViewSuppliers.CellClick += dataGridViewSuppliers_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtSupplierId);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 319);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(383, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод данных";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(48, 68);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(329, 23);
            txtAddress.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 72);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 4;
            label3.Text = "Адрес:";
            // 
            // txtName
            // 
            txtName.Location = new Point(65, 39);
            txtName.Name = "txtName";
            txtName.Size = new Size(312, 23);
            txtName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 42);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "Название:";
            // 
            // txtSupplierId
            // 
            txtSupplierId.Location = new Point(20, 12);
            txtSupplierId.Name = "txtSupplierId";
            txtSupplierId.Size = new Size(357, 23);
            txtSupplierId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 15);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Location = new Point(401, 319);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(387, 48);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Поиск данных (по названию):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 17);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 1;
            label4.Text = "Название:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(76, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(304, 23);
            txtSearch.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnExit.Location = new Point(400, 367);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(203, 52);
            btnExit.TabIndex = 3;
            btnExit.Text = "Закрыть форму";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnAddSupplier
            // 
            btnAddSupplier.Location = new Point(14, 10);
            btnAddSupplier.Name = "btnAddSupplier";
            btnAddSupplier.Size = new Size(75, 23);
            btnAddSupplier.TabIndex = 4;
            btnAddSupplier.Text = "Добавить";
            btnAddSupplier.UseVisualStyleBackColor = true;
            btnAddSupplier.Click += btnAddSupplier_Click;
            // 
            // btnUpdateSupplier
            // 
            btnUpdateSupplier.Location = new Point(259, 10);
            btnUpdateSupplier.Name = "btnUpdateSupplier";
            btnUpdateSupplier.Size = new Size(75, 23);
            btnUpdateSupplier.TabIndex = 5;
            btnUpdateSupplier.Text = "Изменить";
            btnUpdateSupplier.UseVisualStyleBackColor = true;
            btnUpdateSupplier.Click += btnUpdateSupplier_Click;
            // 
            // btnDeleteSupplier
            // 
            btnDeleteSupplier.Location = new Point(477, 10);
            btnDeleteSupplier.Name = "btnDeleteSupplier";
            btnDeleteSupplier.Size = new Size(75, 23);
            btnDeleteSupplier.TabIndex = 6;
            btnDeleteSupplier.Text = "Удалить";
            btnDeleteSupplier.UseVisualStyleBackColor = true;
            btnDeleteSupplier.Click += btnDeleteSupplier_Click;
            // 
            // btnSearchSupplier
            // 
            btnSearchSupplier.Location = new Point(660, 10);
            btnSearchSupplier.Name = "btnSearchSupplier";
            btnSearchSupplier.Size = new Size(121, 23);
            btnSearchSupplier.TabIndex = 7;
            btnSearchSupplier.Text = "Поиск поставщика";
            btnSearchSupplier.UseVisualStyleBackColor = true;
            btnSearchSupplier.Click += btnSearchSupplier_Click;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnLoad.Location = new Point(606, 367);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(182, 52);
            btnLoad.TabIndex = 8;
            btnLoad.Text = "Загрузить таблицу";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // SuppliersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 425);
            Controls.Add(btnLoad);
            Controls.Add(btnSearchSupplier);
            Controls.Add(btnDeleteSupplier);
            Controls.Add(btnUpdateSupplier);
            Controls.Add(btnAddSupplier);
            Controls.Add(btnExit);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewSuppliers);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SuppliersForm";
            Text = "Поставщики";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewSuppliers;
        private GroupBox groupBox1;
        private TextBox txtSupplierId;
        private Label label1;
        private TextBox txtName;
        private Label label2;
        private TextBox txtAddress;
        private Label label3;
        private GroupBox groupBox2;
        private Label label4;
        private TextBox txtSearch;
        private Button btnExit;
        private Button btnAddSupplier;
        private Button btnUpdateSupplier;
        private Button btnDeleteSupplier;
        private Button btnSearchSupplier;
        private Button btnLoad;
    }
}