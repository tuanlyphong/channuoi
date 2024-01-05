using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace chan_nuoi
{
    public partial class Thembanthuoc : Form
    {
        SqlConnection con = new SqlConnection("Data source=NTRLORD; Initial Catalog=channuoi; Integrated Security=true ");

        public Thembanthuoc()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                // Insert data into the DaiLyBanThuoc table
                string query = "INSERT INTO DaiLyBanThuoc (TenDaiLy, TenChu, DiaChi) VALUES (@TenDaiLy, @TenChu, @DiaChi)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@TenDaiLy", textBox1.Text);
                    cmd.Parameters.AddWithValue("@TenChu", textBox2.Text);
                    cmd.Parameters.AddWithValue("@DiaChi", textBox3.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Đại lý bán thuốc đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

