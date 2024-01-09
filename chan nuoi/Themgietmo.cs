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
    public partial class Themgietmo : Form
    {
        SqlConnection con = new SqlConnection("Data source=NTRLORD; Initial Catalog=channuoi; Integrated Security=true;providerName=System.Data.SqlClient ");

        public Themgietmo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                // Insert data into the CoSoGietMo table
                string query = "INSERT INTO CoSoGietMo (TenCoSo, TenChu, DiaChi) VALUES (@TenCoSo, @TenChu, @DiaChi)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@TenCoSo", textBox1.Text);
                    cmd.Parameters.AddWithValue("@TenChu", textBox2.Text);
                    cmd.Parameters.AddWithValue("@DiaChi", textBox3.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Cơ sở giết mổ đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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