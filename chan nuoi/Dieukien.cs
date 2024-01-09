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
    public partial class Dieukien : Form
    {
        SqlConnection con = new SqlConnection("Data Source=NTRLORD; Initial Catalog=channuoi; Integrated Security=True;");
        public Dieukien()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các controls trên form
            string tenDieuKien = textBox2.Text;
            float nhietDo = float.Parse(textBox3.Text);
            float doAm = float.Parse(textBox4.Text);
            float luongMua = float.Parse(textBox5.Text);

            // Thực hiện câu lệnh SQL để thêm điều kiện vào CSDL
            ThemDieuKien(tenDieuKien, nhietDo, doAm, luongMua);

            // Refresh DataGridView sau khi thêm
            XemDanhSachDieuKien();
        }

        private void ThemDieuKien(string tenDieuKien, float nhietDo, float doAm, float luongMua)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=NTRLORD; Initial Catalog=channuoi; Integrated Security=True;"))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("INSERT INTO DieuKienChanNuoi (TenDieuKien, NhietDo, DoAm, LuongMua) VALUES (@TenDieuKien, @NhietDo, @DoAm, @LuongMua)", con))
                    {
                        cmd.Parameters.AddWithValue("@TenDieuKien", tenDieuKien);
                        cmd.Parameters.AddWithValue("@NhietDo", nhietDo);
                        cmd.Parameters.AddWithValue("@DoAm", doAm);
                        cmd.Parameters.AddWithValue("@LuongMua", luongMua);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void XemDanhSachDieuKien()
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=NTRLORD; Initial Catalog=channuoi; Integrated Security=True;"))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM DieuKienChanNuoi", con))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Dieukien_Load(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM DieuKienChanNuoi", con))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }
    }
}
