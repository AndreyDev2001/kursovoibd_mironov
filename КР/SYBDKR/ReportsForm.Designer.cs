namespace SYBDKR
{
    partial class ReportsForm
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
            btnGenerateReport = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Location = new Point(12, 12);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(235, 23);
            btnGenerateReport.TabIndex = 0;
            btnGenerateReport.Text = "Сгенерировать отчёты";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(12, 41);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(235, 23);
            btnExit.TabIndex = 1;
            btnExit.Text = "Закрыть форму";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 71);
            Controls.Add(btnExit);
            Controls.Add(btnGenerateReport);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ReportsForm";
            Text = "Генерация отчётов";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGenerateReport;
        private Button btnExit;
    }
}