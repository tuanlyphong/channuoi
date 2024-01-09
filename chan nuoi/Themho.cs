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
    public partial class Themho : Form
    {
        SqlConnection con = new SqlConnection("Data Source=NTRLORD; Initial Catalog=channuoi; Integrated Security=True;");
        public Themho()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input data
                if (!int.TryParse(textBox1.Text, out int IDHo) || IDHo < 0)
                {
                    MessageBox.Show("ID hộ không hợp lệ.");
                    return;
                }

                // Open the connection
                con.Open();

                // Create a SQL command
                string sqlCommandText = "INSERT INTO HoChanNuoi (IDHo, TenChuHo, DiaChi) VALUES (@IDHo, @TenChuHo, @DiaChi)";
                using (SqlCommand sqlCommand = new SqlCommand(sqlCommandText, con))
                {
                    // Add parameters
                    sqlCommand.Parameters.AddWithValue("@IDHo", IDHo);
                    sqlCommand.Parameters.AddWithValue("@TenChuHo", textBox2.Text);
                    sqlCommand.Parameters.AddWithValue("@DiaChi", textBox3.Text);

                    // Execute the command
                    sqlCommand.ExecuteNonQuery();
                }

                // Display success message
                MessageBox.Show("Thêm thông tin thành công.");

                // Clear the textboxes
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                // Close the connection
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            }
    }
}
