namespace SYBDKR
{
    partial class ManagersForm
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
            dataGridViewManagers = new DataGridView();
            btnAddManager = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            txtPosition = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            txtManagerId = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtSearch = new TextBox();
            label4 = new Label();
            btnExit = new Button();
            btnUpdateManager = new Button();
            btnDeleteManager = new Button();
            btnSearchManager = new Button();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewManagers).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewManagers
            // 
            dataGridViewManagers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewManagers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewManagers.Location = new Point(8, 49);
            dataGridViewManagers.Name = "dataGridViewManagers";
            dataGridViewManagers.Size = new Size(780, 273);
            dataGridViewManagers.TabIndex = 0;
            dataGridViewManagers.CellClick += dataGridViewManagers_CellClick;
            // 
            // btnAddManager
            // 
            btnAddManager.Location = new Point(11, 10);
            btnAddManager.Name = "btnAddManager";
            btnAddManager.Size = new Size(75, 23);
            btnAddManager.TabIndex = 1;
            btnAddManager.Text = "Добавить";
            btnAddManager.UseVisualStyleBackColor = true;
            btnAddManager.Click += btnAddManager_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPosition);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtManagerId);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(8, 328);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(345, 110);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод данных";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 77);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 5;
            label3.Text = "Должность:";
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(82, 74);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(257, 23);
            txtPosition.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(36, 45);
            txtName.Name = "txtName";
            txtName.Size = new Size(303, 23);
            txtName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 48);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 2;
            label2.Text = "Имя:";
            // 
            // txtManagerId
            // 
            txtManagerId.Location = new Point(28, 16);
            txtManagerId.Name = "txtManagerId";
            txtManagerId.Size = new Size(311, 23);
            txtManagerId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 19);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(358, 328);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(430, 43);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Поиск данных (по имени):";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(36, 14);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(388, 23);
            txtSearch.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 17);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 0;
            label4.Text = "Имя:";
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnExit.Location = new Point(358, 405);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(430, 33);
            btnExit.TabIndex = 4;
            btnExit.Text = "Закрыть форму";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnUpdateManager
            // 
            btnUpdateManager.Location = new Point(204, 12);
            btnUpdateManager.Name = "btnUpdateManager";
            btnUpdateManager.Size = new Size(75, 23);
            btnUpdateManager.TabIndex = 5;
            btnUpdateManager.Text = "Изменить";
            btnUpdateManager.UseVisualStyleBackColor = true;
            btnUpdateManager.Click += btnUpdateManager_Click;
            // 
            // btnDeleteManager
            // 
            btnDeleteManager.Location = new Point(484, 12);
            btnDeleteManager.Name = "btnDeleteManager";
            btnDeleteManager.Size = new Size(75, 23);
            btnDeleteManager.TabIndex = 6;
            btnDeleteManager.Text = "Удалить";
            btnDeleteManager.UseVisualStyleBackColor = true;
            btnDeleteManager.Click += btnDeleteManager_Click;
            // 
            // btnSearchManager
            // 
            btnSearchManager.Location = new Point(707, 12);
            btnSearchManager.Name = "btnSearchManager";
            btnSearchManager.Size = new Size(75, 23);
            btnSearchManager.TabIndex = 7;
            btnSearchManager.Text = "Поиск";
            btnSearchManager.UseVisualStyleBackColor = true;
            btnSearchManager.Click += btnSearchManager_Click;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnLoad.Location = new Point(359, 376);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(429, 23);
            btnLoad.TabIndex = 8;
            btnLoad.Text = "Загрузить таблицу";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // ManagersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoad);
            Controls.Add(btnSearchManager);
            Controls.Add(btnDeleteManager);
            Controls.Add(btnUpdateManager);
            Controls.Add(btnExit);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnAddManager);
            Controls.Add(dataGridViewManagers);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ManagersForm";
            Text = "Менеджеры";
            ((System.ComponentModel.ISupportInitialize)dataGridViewManagers).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewManagers;
        private Button btnAddManager;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox txtPosition;
        private TextBox txtName;
        private Label label2;
        private TextBox txtManagerId;
        private Label label1;
        private GroupBox groupBox2;
        private Label label4;
        private TextBox txtSearch;
        private Button btnExit;
        private Button btnUpdateManager;
        private Button btnDeleteManager;
        private Button btnSearchManager;
        private Button btnLoad;
    }
}