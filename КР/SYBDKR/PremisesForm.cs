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
    public partial class PremisesForm : Form
    {
        private string connectionString = "Host=localhost;Username=postgres;Password=admin1234;Database=electrost";

        public PremisesForm()
        {
            InitializeComponent();
            LoadPremises();
        }

        private void LoadPremises()
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("SELECT premises_id, name, address FROM premises", conn))
                    {
                        var reader = cmd.ExecuteReader();
                        var dt = new DataTable();
                        dt.Load(reader);
                        dataGridViewPremises.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных из таблицы: " + ex.Message);
            }
        }

        private void btnUpdatePremises_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("UPDATE premises SET name = @name, address = @address WHERE premises_id = @premises_id", conn))
                    {
                        cmd.Parameters.AddWithValue("@premises_id", int.Parse(txtPremisesId.Text));
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadPremises();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении данных: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            txtPremisesId.Clear();
            txtName.Clear();
            txtAddress.Clear();
        }

        private void btnAddPremises_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("INSERT INTO premises (name, address) VALUES (@name, @address)", conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadPremises();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении данных: " + ex.Message);
            }
        }

        private void btnDeletePremises_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("DELETE FROM premises WHERE premises_id = @premises_id", conn))
                    {
                        cmd.Parameters.AddWithValue("@premises_id", int.Parse(txtPremisesId.Text));
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadPremises();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении данных: " + ex.Message);
            }
        }

        private void btnSearchPremises_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("SELECT premises_id, name, address FROM premises WHERE name LIKE @name", conn))
                    {
                        cmd.Parameters.AddWithValue("@name", "%" + txtSearch.Text + "%");
                        var reader = cmd.ExecuteReader();
                        var dt = new DataTable();
                        dt.Load(reader);
                        dataGridViewPremises.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при поиске данных: " + ex.Message);
            }
        }

        private void dataGridViewPremises_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewPremises.Rows[e.RowIndex];
                txtPremisesId.Text = row.Cells["premises_id"].Value.ToString();
                txtName.Text = row.Cells["name"].Value.ToString();
                txtAddress.Text = row.Cells["address"].Value.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadPremises();
        }
    }
}
