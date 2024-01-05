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
    public partial class Giaychungnhan : Form
    {
        public Giaychungnhan()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data source=NTRLORD; Initial Catalog=channuoi; Integrated Security=true ");
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int IDtochuc) && !string.IsNullOrEmpty(textBox2.Text))
            {
                // Assuming you have a valid DateTime selected in the DateTimePicker
                DateTime ngayCap = dateTimePicker1.Value;

                // Assuming you have a SqlConnection named 'con' already defined

                try
                {
                    con.Open();

                    // Insert data into GiayChungNhan table
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO GiayChungNhan (IDtochuc, SoGiayChungNhan, NgayCap) VALUES (@IDtochuc, @SoGiayChungNhan, @NgayCap)", con))
                    {
                        cmd.Parameters.AddWithValue("@IDtochuc", IDtochuc);
                        cmd.Parameters.AddWithValue("@SoGiayChungNhan", textBox2.Text);
                        cmd.Parameters.AddWithValue("@NgayCap", ngayCap);

                        cmd.ExecuteNonQuery();
                    }

                    // Refresh the DataGridView or perform any other necessary actions
                    XemGiayChungNhan();
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
            else
            {
                MessageBox.Show("xin thu lai voi gia tri phu hop");
            }
        }

        private void XemGiayChungNhan()
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data source=NTRLORD; Initial Catalog=channuoi; Integrated Security=true "))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM GiayChungNhan", con))
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

        private void button2_Click(object sender, EventArgs e)
        {
            Tochuccochungnhan x = new Tochuccochungnhan();
            x.Show();
        }

        private void Giaychungnhan_Load(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM GiayChungNhan", con))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }
    }
}
