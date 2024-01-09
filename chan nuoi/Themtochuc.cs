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
    public partial class Themtochuc : Form
    {
        SqlConnection con = new SqlConnection("Data Source=NTRLORD; Initial Catalog=channuoi; Integrated Security=True;");
        public Themtochuc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Attempt to convert the text input to an integer
                int idToChuc = Convert.ToInt32(textBox1.Text);

                con.Open();
                SqlCommand cmd = new SqlCommand("Themtochuc", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IDtochuc", SqlDbType.Int).Value = idToChuc;
                cmd.Parameters.Add("@Tentochuc", SqlDbType.NVarChar).Value = textBox2.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");
                con.Close();
                textBox1.Text = "";
                textBox2.Text = "";
            }
            catch (FormatException)
            {
                // Display an error message if the input is not a valid integer
                MessageBox.Show("Vui lòng nhập một số nguyên cho ID tổ chức.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

