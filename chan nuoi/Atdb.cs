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
    public partial class Atdb : Form
    {
        SqlConnection con = new SqlConnection("Data source=NTRLORD; Initial Catalog=channuoi; Integrated Security=true ");
        public Atdb()
        {
            InitializeComponent();
            LoadData();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Themvung a = new Themvung();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchQuery = textBox1.Text.Trim();
            SearchData(searchQuery);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                int vungId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["IDVungAnToan"].Value);

                DeleteVung(vungId);
            }
            else
            {
                MessageBox.Show("Chọn hàng để xóa", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LoadData()
        {
            try
            {
                con.Open();

                // Select all records from the VungAnToan table
                string query = "SELECT * FROM VungAnToan";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
        private void SearchData(string query)
        {
            try
            {
                con.Open();

                // Implement the search functionality
                string searchQuery = "SELECT * FROM VungAnToan WHERE Tinh LIKE '%" + query + "%' OR Quan LIKE '%" + query + "%'";
                using (SqlDataAdapter adapter = new SqlDataAdapter(searchQuery, con))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void DeleteVung(int vungId)
        {
            try
            {
                con.Open();

                // Implement the delete functionality
                string deleteQuery = "DELETE FROM VungAnToan WHERE IDVungAnToan = " + vungId;
                using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                {
                    cmd.ExecuteNonQuery();
                }

                LoadData(); // Refresh the data after deletion
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

    }
}
