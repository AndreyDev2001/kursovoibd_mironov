namespace SYBDKR
{
    partial class PremisesForm
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
            dataGridViewPremises = new DataGridView();
            groupBox1 = new GroupBox();
            txtAddress = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtPremisesId = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtSearch = new TextBox();
            label4 = new Label();
            btnExit = new Button();
            btnAddPremises = new Button();
            btnUpdatePremises = new Button();
            btnDeletePremises = new Button();
            btnSearchPremises = new Button();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPremises).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewPremises
            // 
            dataGridViewPremises.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPremises.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPremises.Location = new Point(12, 50);
            dataGridViewPremises.Name = "dataGridViewPremises";
            dataGridViewPremises.Size = new Size(776, 286);
            dataGridViewPremises.TabIndex = 0;
            dataGridViewPremises.CellClick += dataGridViewPremises_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtPremisesId);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(11, 340);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(372, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод данных";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(56, 71);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(310, 23);
            txtAddress.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 74);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 4;
            label3.Text = "Адрес:";
            // 
            // txtName
            // 
            txtName.Location = new Point(69, 43);
            txtName.Name = "txtName";
            txtName.Size = new Size(297, 23);
            txtName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 46);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "Название:";
            // 
            // txtPremisesId
            // 
            txtPremisesId.Location = new Point(103, 16);
            txtPremisesId.Name = "txtPremisesId";
            txtPremisesId.Size = new Size(263, 23);
            txtPremisesId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 19);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "ID помещения:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(389, 340);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(399, 49);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Поиск помещения (по названию)";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(67, 17);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(326, 23);
            txtSearch.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 20);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 0;
            label4.Text = "Название:";
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnExit.Location = new Point(389, 395);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(193, 45);
            btnExit.TabIndex = 3;
            btnExit.Text = "Закрыть форму";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnAddPremises
            // 
            btnAddPremises.Location = new Point(16, 12);
            btnAddPremises.Name = "btnAddPremises";
            btnAddPremises.Size = new Size(75, 23);
            btnAddPremises.TabIndex = 4;
            btnAddPremises.Text = "Добавить";
            btnAddPremises.UseVisualStyleBackColor = true;
            btnAddPremises.Click += btnAddPremises_Click;
            // 
            // btnUpdatePremises
            // 
            btnUpdatePremises.Location = new Point(223, 12);
            btnUpdatePremises.Name = "btnUpdatePremises";
            btnUpdatePremises.Size = new Size(75, 23);
            btnUpdatePremises.TabIndex = 5;
            btnUpdatePremises.Text = "Изменить";
            btnUpdatePremises.UseVisualStyleBackColor = true;
            btnUpdatePremises.Click += btnUpdatePremises_Click;
            // 
            // btnDeletePremises
            // 
            btnDeletePremises.Location = new Point(507, 12);
            btnDeletePremises.Name = "btnDeletePremises";
            btnDeletePremises.Size = new Size(75, 23);
            btnDeletePremises.TabIndex = 6;
            btnDeletePremises.Text = "Удалить";
            btnDeletePremises.UseVisualStyleBackColor = true;
            btnDeletePremises.Click += btnDeletePremises_Click;
            // 
            // btnSearchPremises
            // 
            btnSearchPremises.Location = new Point(713, 12);
            btnSearchPremises.Name = "btnSearchPremises";
            btnSearchPremises.Size = new Size(75, 23);
            btnSearchPremises.TabIndex = 7;
            btnSearchPremises.Text = "Поиск";
            btnSearchPremises.UseVisualStyleBackColor = true;
            btnSearchPremises.Click += btnSearchPremises_Click;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnLoad.Location = new Point(588, 395);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(200, 45);
            btnLoad.TabIndex = 8;
            btnLoad.Text = "Загрузить таблицу";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // PremisesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoad);
            Controls.Add(btnSearchPremises);
            Controls.Add(btnDeletePremises);
            Controls.Add(btnUpdatePremises);
            Controls.Add(btnAddPremises);
            Controls.Add(btnExit);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewPremises);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "PremisesForm";
            Text = "Помещения";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPremises).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewPremises;
        private GroupBox groupBox1;
        private TextBox txtName;
        private Label label2;
        private TextBox txtPremisesId;
        private Label label1;
        private TextBox txtAddress;
        private Label label3;
        private GroupBox groupBox2;
        private TextBox txtSearch;
        private Label label4;
        private Button btnExit;
        private Button btnAddPremises;
        private Button btnUpdatePremises;
        private Button btnDeletePremises;
        private Button btnSearchPremises;
        private Button btnLoad;
    }
}