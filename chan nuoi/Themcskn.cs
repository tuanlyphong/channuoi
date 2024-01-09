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
    public partial class Themcskn : Form
    {
        SqlConnection con = new SqlConnection("Data Source=NTRLORD; Initial Catalog=channuoi; Integrated Security=True;");
        public Themcskn()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("themcskn", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TenCS", SqlDbType.NVarChar).Value = textBox1.Text;
            cmd.Parameters.Add("@ChuCS", SqlDbType.NVarChar).Value = textBox2.Text;
            cmd.Parameters.Add("@Nthanhlap", SqlDbType.NVarChar).Value = dateTimePicker1.Value;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Them thanh cong");
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
