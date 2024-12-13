using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using Npgsql;

namespace SYBDKR
{
    public partial class ReportsForm : Form
    {
        private string connectionString = "Host=localhost;Username=postgres;Password=admin1234;Database=electrost";

        public ReportsForm()
        {
            InitializeComponent();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            // Генерация отчета о количестве проданной техники
            GenerateSalesQuantityReport();

            // Генерация отчета о выручке от продаж
            GenerateSalesRevenueReport();
        }

        private void GenerateSalesQuantityReport()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT product_id, SUM(quantity) AS total_quantity FROM sales GROUP BY product_id", conn))
                {
                    var reader = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(reader);

                    // Создание PDF документа
                    PdfDocument document = new PdfDocument();
                    PdfPage page = document.AddPage();
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    XFont font = new XFont("Verdana", 20);

                    gfx.DrawString("Отчёт о количестве продаж", font, XBrushes.Black, new XRect(0, 0, page.Width, page.Height), XStringFormats.Center);

                    // Добавление данных в PDF
                    XFont dataFont = new XFont("Verdana", 12);
                    double yOffset = 50;

                    foreach (DataRow row in dt.Rows)
                    {
                        string productId = row["product_id"].ToString();
                        string totalQuantity = row["total_quantity"].ToString();
                        gfx.DrawString($"ID товара: {productId}, Общее количество: {totalQuantity}", dataFont, XBrushes.Black, new XRect(50, yOffset, page.Width - 100, page.Height), XStringFormats.TopLeft);
                        yOffset += 20;
                    }

                    string filename = "SalesQuantityReport.pdf";
                    document.Save(filename);
                    MessageBox.Show("Отчёт о количестве продаж сгенерирован успешно!");
                }
            }
        }

        private void GenerateSalesRevenueReport()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT product_id, SUM(sale_price * quantity) AS total_revenue FROM sales GROUP BY product_id", conn))
                {
                    var reader = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(reader);

                    // Создание PDF документа
                    PdfDocument document = new PdfDocument();
                    PdfPage page = document.AddPage();
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    XFont font = new XFont("Verdana", 20);

                    gfx.DrawString("Отчёт о выручке от продаж", font, XBrushes.Black, new XRect(0, 0, page.Width, page.Height), XStringFormats.Center);

                    // Добавление данных в PDF
                    XFont dataFont = new XFont("Verdana", 12);
                    double yOffset = 50;

                    foreach (DataRow row in dt.Rows)
                    {
                        string productId = row["product_id"].ToString();
                        string totalRevenue = row["total_revenue"].ToString();
                        gfx.DrawString($"ID товара: {productId}, Общая выручка: {totalRevenue}", dataFont, XBrushes.Black, new XRect(50, yOffset, page.Width - 100, page.Height), XStringFormats.TopLeft);
                        yOffset += 20;
                    }

                    string filename = "SalesRevenueReport.pdf";
                    document.Save(filename);
                    MessageBox.Show("Отчёт о выручке от продаж сгенерирован успешно!");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
