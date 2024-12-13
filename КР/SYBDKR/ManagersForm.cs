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
    public partial class ManagersForm : Form
    {
        private string connectionString = "Host=localhost;Username=postgres;Password=admin1234;Database=electrost";

        public ManagersForm()
        {
            InitializeComponent();
            LoadManagers();
        }

        private void LoadManagers()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT manager_id, name, position FROM managers", conn))
                {
                    var reader = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(reader);
                    dataGridViewManagers.DataSource = dt;
                }
            }
        }

        private void btnAddManager_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("INSERT INTO managers (name, position) VALUES (@name, @position)", conn))
                {
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@position", txtPosition.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            LoadManagers();
            ClearFields();
        }

        private void ClearFields()
        {
            txtManagerId.Clear();
            txtName.Clear();
            txtPosition.Clear();
        }

        private void btnUpdateManager_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("UPDATE managers SET name = @name, position = @position WHERE manager_id = @manager_id", conn))
                {
                    cmd.Parameters.AddWithValue("@manager_id", int.Parse(txtManagerId.Text));
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@position", txtPosition.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            LoadManagers();
            ClearFields();
        }

        private void btnDeleteManager_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("DELETE FROM managers WHERE manager_id = @manager_id", conn))
                {
                    cmd.Parameters.AddWithValue("@manager_id", int.Parse(txtManagerId.Text));
                    cmd.ExecuteNonQuery();
                }
            }
            LoadManagers();
            ClearFields();
        }

        private void btnSearchManager_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT manager_id, name, position FROM managers WHERE name LIKE @name", conn))
                {
                    cmd.Parameters.AddWithValue("@name", "%" + txtSearch.Text + "%");
                    var reader = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(reader);
                    dataGridViewManagers.DataSource = dt;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewManagers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewManagers.Rows[e.RowIndex];
                txtManagerId.Text = row.Cells["manager_id"].Value.ToString();
                txtName.Text = row.Cells["name"].Value.ToString();
                txtPosition.Text = row.Cells["position"].Value.ToString();
            }
        }
    }
}
