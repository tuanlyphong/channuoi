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

namespace chan_nuoi
{

    public partial class Cscb : Form
    {
        SqlConnection con = new SqlConnection("Data source=NTRLORD; Initial Catalog=channuoi; Integrated Security=true ");
        public Cscb()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Themcscb a = new Themcscb();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text;
            SearchCosoCB(searchText);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteCosoCB();
        }
        private void SearchCosoCB(string searchText)
        {
            using (SqlConnection connection = new SqlConnection("Data source=NTRLORD; Initial Catalog=channuoi; Integrated Security=true "))
            {
                connection.Open();

                // Use a parameterized query to prevent SQL injection
                string query = "SELECT * FROM CosoCB WHERE TenCoso LIKE @searchText";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable resultDataTable = new DataTable();
                        adapter.Fill(resultDataTable);
                        dataGridView1.DataSource = resultDataTable;
                    }
                }
            }
        }

        private void DeleteCosoCB()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                int idCosoToDelete = (int)dataGridView1.Rows[selectedIndex].Cells["IDCoso"].Value;

                using (SqlConnection connection = new SqlConnection("Data source=NTRLORD; Initial Catalog=channuoi; Integrated Security=true "))
                {
                    connection.Open();

                    // Use a parameterized query to prevent SQL injection
                    string query = "DELETE FROM CosoCB WHERE IDCoso = @idCoso";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idCoso", idCosoToDelete);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Record deleted successfully.");
                // Refresh the data after deletion
                SearchCosoCB("");
            }
            else
            {
                MessageBox.Show("Please select a record to delete.");
            }
        }

        private void Cscb_Load(object sender, EventArgs e)
        {
            // Load initial data or perform any initialization
            SearchCosoCB("");
        }
    }
}
