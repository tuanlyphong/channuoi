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
    public partial class Themkhu : Form
    {
        SqlConnection con = new SqlConnection("Data source=NTRLORD; Initial Catalog=channuoi; Integrated Security=true;providerName=System.Data.SqlClient ");

        public Themkhu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                // Insert data into the KhuTamGiu table
                string query = "INSERT INTO KhuTamGiu (TenKhu, TenChu, DiaChi) VALUES (@TenKhu, @TenChu, @DiaChi)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@TenKhu", textBox1.Text);
                    cmd.Parameters.AddWithValue("@TenChu", textBox2.Text);
                    cmd.Parameters.AddWithValue("@DiaChi", textBox3.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Khu tạm giữ đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
