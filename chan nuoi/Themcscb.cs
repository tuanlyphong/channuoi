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
    public partial class Themcscb : Form
    {
        SqlConnection con = new SqlConnection("Data source=NTRLORD; Initial Catalog=channuoi; Integrated Security=true;providerName=System.Data.SqlClient ");
        public Themcscb()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the connection
                con.Open();

                // Create a SQL command
                string sqlCommandText = "INSERT INTO CosoCB (TenCoso, ChuCoso, NgayThanhLap) VALUES (@TenCoso, @ChuCoso, @NgayThanhLap)";
                using (SqlCommand sqlCommand = new SqlCommand(sqlCommandText, con))
                {
                    // Add parameters
                    sqlCommand.Parameters.AddWithValue("@TenCoso", textBox1.Text);
                    sqlCommand.Parameters.AddWithValue("@ChuCoso", textBox2.Text);
                    sqlCommand.Parameters.AddWithValue("@NgayThanhLap", dateTimePicker1.Value);

                    // Execute the command
                    sqlCommand.ExecuteNonQuery();
                }

                // Display success message
                MessageBox.Show("Thêm cơ sở thành công.");

                // Clear the textboxes
                textBox1.Clear();
                textBox2.Clear();
                dateTimePicker1.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                // Close the connection
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
            }
    }
}
