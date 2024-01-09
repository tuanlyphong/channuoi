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
    public partial class Honhole : Form
    {
        SqlConnection con = new SqlConnection("Data Source=NTRLORD; Initial Catalog=channuoi; Integrated Security=True;");

        public Honhole()
        {
            InitializeComponent();
            // Call a method to populate dataGridView1 with data from HoChanNuoi
            PopulateHoChanNuoiData();
            // Call a method to populate dataGridView2 with data from ThongKe
            PopulateThongKeData();
        }

        private void PopulateHoChanNuoiData()
        {
            try
            {
                con.Open();
                // Assuming you have a method to fetch data from HoChanNuoi table
                DataTable dataTable = FetchDataFromHoChanNuoi();
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void PopulateThongKeData()
        {
            try
            {
                con.Open();
                // Assuming you have a method to fetch data from ThongKe table
                DataTable dataTable = FetchDataFromThongKe();
                dataGridView2.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        // Implement methods to fetch data from your tables
        private DataTable FetchDataFromHoChanNuoi()
        {
            // Your logic to fetch data from HoChanNuoi table
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM HoChanNuoi", con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        private DataTable FetchDataFromThongKe()
        {
            // Your logic to fetch data from ThongKe table
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM ThongKe", con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Themthongke f = new Themthongke();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Themho b = new Themho();
            b.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Search for HoChanNuoi based on the value in textbox1
            string searchValue = textBox1.Text.Trim();
            if (!string.IsNullOrEmpty(searchValue))
            {
                SearchHoChanNuoi(searchValue);
            }
            else
            {
                MessageBox.Show("Vui long nhap IDho");
            }
        }

        private void SearchHoChanNuoi(string searchValue)
        {
            try
            {
                con.Open();
                // Your logic to search for data in HoChanNuoi based on the entered value
                SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM HoChanNuoi WHERE IDHo = '{searchValue}'", con);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Delete HoChanNuoi based on the value in textbox1
            string deleteValue = textBox1.Text.Trim();
            if (!string.IsNullOrEmpty(deleteValue))
            {
                DeleteHoChanNuoi(deleteValue);
                // After deletion, refresh the DataGridView
                PopulateHoChanNuoiData();
            }
            else
            {
                MessageBox.Show("Please enter a value to delete in HoChanNuoi.");
            }
        }

        private void DeleteHoChanNuoi(string deleteValue)
        {
            try
            {
                con.Open();
                // Your logic to delete data from HoChanNuoi based on the entered value
                SqlCommand command = new SqlCommand($"DELETE FROM HoChanNuoi WHERE IDho = '{deleteValue}'", con);
                command.ExecuteNonQuery();
                MessageBox.Show("Record deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Search for ThongKe based on the value in textbox2
            string searchValue = textBox2.Text.Trim();
            if (!string.IsNullOrEmpty(searchValue))
            {
                SearchThongKe(searchValue);
            }
            else
            {
                MessageBox.Show("Vui long nhap ID thong ke");
            }
        }

        private void SearchThongKe(string searchValue)
        {
            try
            {
                con.Open();
                // Your logic to search for data in ThongKe based on the entered value
                SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM ThongKe WHERE IDThongKe = '{searchValue}'", con);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView2.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Delete ThongKe based on the value in textbox2
            string deleteValue = textBox2.Text.Trim();
            if (!string.IsNullOrEmpty(deleteValue))
            {
                DeleteThongKe(deleteValue);
                // After deletion, refresh the DataGridView
                PopulateThongKeData();
            }
            else
            {
                MessageBox.Show("Vui Long nhap ID thong ke");
            }
        }

        private void DeleteThongKe(string deleteValue)
        {
            try
            {
                con.Open();
                // Your logic to delete data from ThongKe based on the entered value
                SqlCommand command = new SqlCommand($"DELETE FROM ThongKe WHERE IDThongKe = '{deleteValue}'", con);
                command.ExecuteNonQuery();
                MessageBox.Show("Record deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        // Handle CellClick event of dataGridView1
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the click is on a valid row index
            if (e.RowIndex >= 0)
            {
                // Get the IDHo from the selected row
                string selectedIDHo = dataGridView1.Rows[e.RowIndex].Cells["IDHo"].Value.ToString();

                // Call a method to fetch and display related ThongKe records
                DisplayRelatedThongKe(selectedIDHo);
            }
        }

        private void DisplayRelatedThongKe(string selectedIDHo)
        {
            try
            {
                con.Open();
                // Your logic to fetch data from ThongKe based on selectedIDHo
                SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM ThongKe WHERE IDHo = '{selectedIDHo}'", con);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView2.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                // Assuming you have a method to fetch data from HoChanNuoi table
                DataTable dataTable = FetchDataFromHoChanNuoi();
                dataGridView1.DataSource = dataTable;
                DataTable dataTable2 = FetchDataFromThongKe();
                dataGridView2.DataSource = dataTable2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
