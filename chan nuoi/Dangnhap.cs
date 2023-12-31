using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
namespace chan_nuoi
{
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data source=NTRLORD; Initial Catalog=channuoi; Integrated Security=true ");
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open(); 
            SqlCommand cmd = new SqlCommand("sp_login", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = textBox1.Text;
            cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = textBox2.Text;
            SqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read())
            {
                Trangchu d = new Trangchu();
                d.Show();
                this.Hide();
            }
                else
            {
                MessageBox.Show("dang nhap that bai");
            }
                con.Close();
        }
    }
}
