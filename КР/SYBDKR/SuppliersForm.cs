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
using System.Xml.Linq;

namespace SYBDKR
{
    public partial class SuppliersForm : Form
    {
        private string connectionString = "Host=localhost;Username=postgres;Password=admin1234;Database=electrost";

        public SuppliersForm()
        {
            InitializeComponent();
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT supplier_id, name, address FROM suppliers", conn))
                {
                    var reader = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(reader);
                    dataGridViewSuppliers.DataSource = dt;
                }
            }
        }

        private void ClearFields()
        {
            txtSupplierId.Clear();
            txtName.Clear();
            txtAddress.Clear();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("INSERT INTO suppliers (name, address) VALUES (@name, @address)", conn))
                {
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            LoadSuppliers();
            ClearFields();
        }

        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("UPDATE suppliers SET name = @name, address = @address WHERE supplier_id = @supplier_id", conn))
                {
                    cmd.Parameters.AddWithValue("@supplier_id", int.Parse(txtSupplierId.Text));
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            LoadSuppliers();
            ClearFields();
        }

        private void btnSearchSupplier_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT supplier_id, name, address FROM suppliers WHERE name LIKE @name", conn))
                {
                    cmd.Parameters.AddWithValue("@name", "%" + txtSearch.Text + "%");
                    var reader = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(reader);
                    dataGridViewSuppliers.DataSource = dt;
                }
            }
        }

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("DELETE FROM suppliers WHERE supplier_id = @supplier_id", conn))
                {
                    cmd.Parameters.AddWithValue("@supplier_id", int.Parse(txtSupplierId.Text));
                    cmd.ExecuteNonQuery();
                }
            }
            LoadSuppliers();
            ClearFields();
        }

        private void dataGridViewSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewSuppliers.Rows[e.RowIndex];
                txtSupplierId.Text = row.Cells["supplier_id"].Value.ToString();
                txtName.Text = row.Cells["name"].Value.ToString();
                txtAddress.Text = row.Cells["address"].Value.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
