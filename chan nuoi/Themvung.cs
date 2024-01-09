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
    public partial class Themvung : Form
    {
        public Themvung()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=NTRLORD; Initial Catalog=channuoi; Integrated Security=True;");
        private void button1_Click(object sender, EventArgs e)
        {
            string tinh = textBox1.Text;
            string quan = textBox2.Text;

            // Check if the required fields are not empty
            if (string.IsNullOrWhiteSpace(tinh) || string.IsNullOrWhiteSpace(quan))
            {
                MessageBox.Show("Vui long dien thong tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Open the database connection
                con.Open();

                // Insert data into the VungAnToan table
                string query = "INSERT INTO VungAnToan (Tinh, Quan) VALUES (@Tinh, @Quan)";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@Tinh", tinh);
                    command.Parameters.AddWithValue("@Quan", quan);

                    // Execute the SQL command
                    command.ExecuteNonQuery();

                    MessageBox.Show("Vùng an toàn added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the textboxes after successful insertion
                    textBox1.Clear();
                    textBox2.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the database connection
                con.Close();
            }
        }
    }
}
