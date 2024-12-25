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
    public partial class InventoryForm : Form
    {
        private string connectionString = "Host=localhost;Username=postgres;Password=admin1234;Database=electrost";

        public InventoryForm()
        {
            InitializeComponent();
            LoadInventory();
        }

        private void LoadInventory()
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("SELECT inventory_id, product_id, quantity, date_received, premises_id FROM inventory", conn))
                    {
                        var reader = cmd.ExecuteReader();
                        var dt = new DataTable();
                        dt.Load(reader);
                        dataGridViewInventory.DataSource = dt;
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
            txtInventoryId.Clear();
            txtProductId.Clear();
            txtQuantity.Clear();
            txtDateReceived.Clear();
            txtPremisesId.Clear();
        }

        private void btnAddInventory_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("INSERT INTO inventory (product_id, quantity, date_received, premises_id) VALUES (@product_id, @quantity, @date_received, @premises_id)", conn))
                    {
                        cmd.Parameters.AddWithValue("@product_id", int.Parse(txtProductId.Text));
                        cmd.Parameters.AddWithValue("@quantity", int.Parse(txtQuantity.Text));
                        cmd.Parameters.AddWithValue("@date_received", DateTime.Parse(txtDateReceived.Text));
                        cmd.Parameters.AddWithValue("@premises_id", int.Parse(txtPremisesId.Text));
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadInventory();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления данных: " + ex.Message);
            }
        }

        private void btnUpdateInventory_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("INSERT INTO inventory (product_id, quantity, date_received, premises_id) VALUES (@product_id, @quantity, @date_received, @premises_id)", conn))
                    {
                        cmd.Parameters.AddWithValue("@product_id", int.Parse(txtProductId.Text));
                        cmd.Parameters.AddWithValue("@quantity", int.Parse(txtQuantity.Text));
                        cmd.Parameters.AddWithValue("@date_received", DateTime.Parse(txtDateReceived.Text));
                        cmd.Parameters.AddWithValue("@premises_id", int.Parse(txtPremisesId.Text));
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadInventory();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при изменении данных: " + ex.Message);
            }
        }

        private void btnDeleteInventory_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("INSERT INTO inventory (product_id, quantity, date_received, premises_id) VALUES (@product_id, @quantity, @date_received, @premises_id)", conn))
                    {
                        cmd.Parameters.AddWithValue("@product_id", int.Parse(txtProductId.Text));
                        cmd.Parameters.AddWithValue("@quantity", int.Parse(txtQuantity.Text));
                        cmd.Parameters.AddWithValue("@date_received", DateTime.Parse(txtDateReceived.Text));
                        cmd.Parameters.AddWithValue("@premises_id", int.Parse(txtPremisesId.Text));
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadInventory();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления данных: " + ex.Message);
            }
        }

        private void btnSearchInventory_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("SELECT inventory_id, product_id, quantity, date_received, premises_id FROM inventory WHERE product_id = @product_id", conn))
                    {
                        cmd.Parameters.AddWithValue("@product_id", int.Parse(txtSearch.Text));
                        var reader = cmd.ExecuteReader();
                        var dt = new DataTable();
                        dt.Load(reader);
                        dataGridViewInventory.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка поиска данных в таблице: " + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewInventory.Rows[e.RowIndex];
                txtInventoryId.Text = row.Cells["inventory_id"].Value.ToString();
                txtProductId.Text = row.Cells["product_id"].Value.ToString();
                txtQuantity.Text = row.Cells["quantity"].Value.ToString();
                txtDateReceived.Text = row.Cells["date_received"].Value.ToString();
                txtPremisesId.Text = row.Cells["premises_id"].Value.ToString();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadInventory();
        }
    }
}
