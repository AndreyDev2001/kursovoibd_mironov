using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYBDKR
{
    public partial class SalesForm : Form
    {
        private string connectionString = "Host=localhost;Username=postgres;Password=admin1234;Database=electrost";

        public SalesForm()
        {
            InitializeComponent();
            LoadSales();
        }

        private void LoadSales()
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("SELECT sale_id, product_id, quantity, sale_date, sale_price, manager_id FROM sales", conn))
                    {
                        var reader = cmd.ExecuteReader();
                        var dt = new DataTable();
                        dt.Load(reader);
                        dataGridViewSales.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных из таблицы: " + ex.Message);
            }
        }

        private void btnAddSale_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("INSERT INTO sales (product_id, quantity, sale_date, sale_price, manager_id) VALUES (@product_id, @quantity, @sale_date, @sale_price, @manager_id)", conn))
                    {
                        cmd.Parameters.AddWithValue("@product_id", int.Parse(txtProductId.Text));
                        cmd.Parameters.AddWithValue("@quantity", int.Parse(txtQuantity.Text));
                        cmd.Parameters.AddWithValue("@sale_date", DateTime.Parse(txtSaleDate.Text));
                        cmd.Parameters.AddWithValue("@sale_price", decimal.Parse(txtSalePrice.Text));
                        cmd.Parameters.AddWithValue("@manager_id", int.Parse(txtManagerId.Text));
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadSales();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении данных: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            txtSaleId.Clear();
            txtProductId.Clear();
            txtQuantity.Clear();
            txtSaleDate.Clear();
            txtSalePrice.Clear();
            txtManagerId.Clear();
        }

        private void btnUpdateSale_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("UPDATE sales SET product_id = @product_id, quantity = @quantity, sale_date = @sale_date, sale_price = @sale_price, manager_id = @manager_id WHERE sale_id = @sale_id", conn))
                    {
                        cmd.Parameters.AddWithValue("@sale_id", int.Parse(txtSaleId.Text));
                        cmd.Parameters.AddWithValue("@product_id", int.Parse(txtProductId.Text));
                        cmd.Parameters.AddWithValue("@quantity", int.Parse(txtQuantity.Text));
                        cmd.Parameters.AddWithValue("@sale_date", DateTime.Parse(txtSaleDate.Text));
                        cmd.Parameters.AddWithValue("@sale_price", decimal.Parse(txtSalePrice.Text));
                        cmd.Parameters.AddWithValue("@manager_id", int.Parse(txtManagerId.Text));
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadSales();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении данных: " + ex.Message);
            }
        }

        private void btnDeleteSale_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("DELETE FROM sales WHERE sale_id = @sale_id", conn))
                    {
                        cmd.Parameters.AddWithValue("@sale_id", int.Parse(txtSaleId.Text));
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadSales();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении данных: " + ex.Message);
            }
        }

        private void btnSearchSale_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("SELECT sale_id, product_id, quantity, sale_date, sale_price, manager_id FROM sales WHERE product_id = @product_id", conn))
                    {
                        cmd.Parameters.AddWithValue("@product_id", int.Parse(txtSearch.Text));
                        var reader = cmd.ExecuteReader();
                        var dt = new DataTable();
                        dt.Load(reader);
                        dataGridViewSales.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при поиске данных: " + ex.Message);
            }
        }

        private void dataGridViewSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewSales.Rows[e.RowIndex];
                txtSaleId.Text = row.Cells["sale_id"].Value.ToString();
                txtProductId.Text = row.Cells["product_id"].Value.ToString();
                txtQuantity.Text = row.Cells["quantity"].Value.ToString();
                txtSaleDate.Text = row.Cells["sale_date"].Value.ToString();
                txtSalePrice.Text = row.Cells["sale_price"].Value.ToString();
                txtManagerId.Text = row.Cells["manager_id"].Value.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadSales();
        }
    }
}
