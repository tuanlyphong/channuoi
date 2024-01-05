using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace chan_nuoi
{
    public partial class Banthuoc : Form
    {
        private readonly string connectionString = "Data source=NTRLORD; Initial Catalog=channuoi; Integrated Security=true "; // Replace with your actual connection string

        public Banthuoc()
        {
            InitializeComponent();
            LoadData(); // Load initial data when the form is loaded
        }

        private void LoadData()
        {
            // Load data into the DataGridView
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM DaiLyBanThuoc";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Search operation
            string searchKeyword = textBox1.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $"SELECT * FROM DaiLyBanThuoc WHERE TenDaiLy LIKE '%{searchKeyword}%'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Delete operation
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                int daiLyId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["DaiLyID"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $"DELETE FROM DaiLyBanThuoc WHERE DaiLyID = {daiLyId}";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                }

                LoadData(); // Refresh the DataGridView after deletion
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Open the form for adding new records
            Thembanthuoc thembanthuocForm = new Thembanthuoc();
            DialogResult result = thembanthuocForm.ShowDialog();

            // After adding data, refresh or update the DataGridView
            if (result == DialogResult.OK)
            {
                LoadData();
            }
        }
    }
}