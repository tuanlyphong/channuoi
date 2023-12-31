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
    public partial class Xemcskn : Form
    {
        SqlConnection con = new SqlConnection("Data source=NTRLORD; Initial Catalog=channuoi; Integrated Security=true ");
        public Xemcskn()
        {
            InitializeComponent();
        }
        private void Xemcskn_Load_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Xemcosokn", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TenCS", SqlDbType.NVarChar).Value = "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Xemcosokn", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TenCS", SqlDbType.NVarChar).Value = textBox1.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Xoacskn", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TenCS", SqlDbType.NVarChar).Value = textBox1.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
