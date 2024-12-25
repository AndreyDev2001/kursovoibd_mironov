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
    public partial class ProductsForm : Form
    {
        private string connectionString = "Host=localhost;Username=postgres;Password=admin1234;Database=electrost";

        public ProductsForm()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("SELECT product_id, description, supplier_id, image FROM products", conn))
                    {
                        var reader = cmd.ExecuteReader();
                        var dt = new DataTable();
                        dt.Load(reader);
                        dataGridViewProducts.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных из таблицы: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            txtProductId.Clear();
            txtDescription.Clear();
            txtSupplierId.Clear();
            txtImagePath.Clear();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("INSERT INTO products (description, supplier_id, image) VALUES (@description, @supplier_id, @image)", conn))
                    {
                        cmd.Parameters.AddWithValue("@description", txtDescription.Text);
                        cmd.Parameters.AddWithValue("@supplier_id", int.Parse(txtSupplierId.Text));
                        cmd.Parameters.AddWithValue("@image", File.ReadAllBytes(txtImagePath.Text));
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadProducts();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления данных: " + ex.Message);
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("UPDATE products SET description = @description, supplier_id = @supplier_id, image = @image WHERE product_id = @product_id", conn))
                    {
                        cmd.Parameters.AddWithValue("@product_id", int.Parse(txtProductId.Text));
                        cmd.Parameters.AddWithValue("@description", txtDescription.Text);
                        cmd.Parameters.AddWithValue("@supplier_id", int.Parse(txtSupplierId.Text));
                        cmd.Parameters.AddWithValue("@image", File.ReadAllBytes(txtImagePath.Text));
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadProducts();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении данных: " + ex.Message);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("DELETE FROM products WHERE product_id = @product_id", conn))
                    {
                        cmd.Parameters.AddWithValue("@product_id", int.Parse(txtProductId.Text));
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadProducts();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления данных: " + ex.Message);
            }
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("SELECT product_id, description, supplier_id, image FROM products WHERE description LIKE @description", conn))
                    {
                        cmd.Parameters.AddWithValue("@description", "%" + txtSearch.Text + "%");
                        var reader = cmd.ExecuteReader();
                        var dt = new DataTable();
                        dt.Load(reader);
                        dataGridViewProducts.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка поиска данных: " + ex.Message);
            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        txtImagePath.Text = openFileDialog.FileName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке изображения: " + ex.Message);
            }
        }

        private void dataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewProducts.Rows[e.RowIndex];
                txtProductId.Text = row.Cells["product_id"].Value.ToString();
                txtDescription.Text = row.Cells["description"].Value.ToString();
                txtSupplierId.Text = row.Cells["supplier_id"].Value.ToString();
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}
