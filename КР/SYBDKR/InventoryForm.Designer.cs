namespace SYBDKR
{
    partial class InventoryForm
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
            dataGridViewInventory = new DataGridView();
            groupBox1 = new GroupBox();
            label5 = new Label();
            txtPremisesId = new TextBox();
            txtDateReceived = new TextBox();
            label4 = new Label();
            txtQuantity = new TextBox();
            label3 = new Label();
            txtProductId = new TextBox();
            label2 = new Label();
            txtInventoryId = new TextBox();
            label1 = new Label();
            btnAddInventory = new Button();
            btnUpdateInventory = new Button();
            btnDeleteInventory = new Button();
            btnSearchInventory = new Button();
            groupBox2 = new GroupBox();
            txtSearch = new TextBox();
            label6 = new Label();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventory).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewInventory
            // 
            dataGridViewInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInventory.Location = new Point(12, 41);
            dataGridViewInventory.Name = "dataGridViewInventory";
            dataGridViewInventory.Size = new Size(776, 272);
            dataGridViewInventory.TabIndex = 0;
            dataGridViewInventory.CellClick += dataGridViewInventory_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtPremisesId);
            groupBox1.Controls.Add(txtDateReceived);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtProductId);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtInventoryId);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(14, 319);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(407, 119);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод данных";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(205, 18);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 9;
            label5.Text = "ID помещения:";
            // 
            // txtPremisesId
            // 
            txtPremisesId.Location = new Point(301, 15);
            txtPremisesId.Name = "txtPremisesId";
            txtPremisesId.Size = new Size(100, 23);
            txtPremisesId.TabIndex = 8;
            // 
            // txtDateReceived
            // 
            txtDateReceived.Location = new Point(118, 91);
            txtDateReceived.Name = "txtDateReceived";
            txtDateReceived.Size = new Size(100, 23);
            txtDateReceived.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 94);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 6;
            label4.Text = "Дата поступления:";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(100, 68);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 71);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 4;
            label3.Text = "Кол-во товара:";
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(71, 41);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(100, 23);
            txtProductId.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 44);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 2;
            label2.Text = "ID товара:";
            // 
            // txtInventoryId
            // 
            txtInventoryId.Location = new Point(71, 15);
            txtInventoryId.Name = "txtInventoryId";
            txtInventoryId.Size = new Size(100, 23);
            txtInventoryId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 18);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "ID склада:";
            // 
            // btnAddInventory
            // 
            btnAddInventory.Location = new Point(12, 12);
            btnAddInventory.Name = "btnAddInventory";
            btnAddInventory.Size = new Size(75, 23);
            btnAddInventory.TabIndex = 2;
            btnAddInventory.Text = "Добавить";
            btnAddInventory.UseVisualStyleBackColor = true;
            btnAddInventory.Click += btnAddInventory_Click;
            // 
            // btnUpdateInventory
            // 
            btnUpdateInventory.Location = new Point(234, 12);
            btnUpdateInventory.Name = "btnUpdateInventory";
            btnUpdateInventory.Size = new Size(75, 23);
            btnUpdateInventory.TabIndex = 3;
            btnUpdateInventory.Text = "Изменить";
            btnUpdateInventory.UseVisualStyleBackColor = true;
            btnUpdateInventory.Click += btnUpdateInventory_Click;
            // 
            // btnDeleteInventory
            // 
            btnDeleteInventory.Location = new Point(497, 12);
            btnDeleteInventory.Name = "btnDeleteInventory";
            btnDeleteInventory.Size = new Size(75, 23);
            btnDeleteInventory.TabIndex = 4;
            btnDeleteInventory.Text = "Удалить";
            btnDeleteInventory.UseVisualStyleBackColor = true;
            btnDeleteInventory.Click += btnDeleteInventory_Click;
            // 
            // btnSearchInventory
            // 
            btnSearchInventory.Location = new Point(713, 12);
            btnSearchInventory.Name = "btnSearchInventory";
            btnSearchInventory.Size = new Size(75, 23);
            btnSearchInventory.TabIndex = 5;
            btnSearchInventory.Text = "Поиск";
            btnSearchInventory.UseVisualStyleBackColor = true;
            btnSearchInventory.Click += btnSearchInventory_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(427, 319);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(361, 48);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Поиск склада (по ID товара)";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(70, 16);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(285, 23);
            txtSearch.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 19);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 0;
            label6.Text = "ID товара:";
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnExit.Location = new Point(429, 371);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(359, 67);
            btnExit.TabIndex = 7;
            btnExit.Text = "Закрыть форму";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(groupBox2);
            Controls.Add(btnSearchInventory);
            Controls.Add(btnDeleteInventory);
            Controls.Add(btnUpdateInventory);
            Controls.Add(btnAddInventory);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewInventory);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "InventoryForm";
            Text = "Склад";
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventory).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewInventory;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox txtProductId;
        private Label label2;
        private TextBox txtInventoryId;
        private Label label1;
        private Label label5;
        private TextBox txtPremisesId;
        private TextBox txtDateReceived;
        private Label label4;
        private TextBox txtQuantity;
        private Button btnAddInventory;
        private Button btnUpdateInventory;
        private Button btnDeleteInventory;
        private Button btnSearchInventory;
        private GroupBox groupBox2;
        private TextBox txtSearch;
        private Label label6;
        private Button btnExit;
    }
}