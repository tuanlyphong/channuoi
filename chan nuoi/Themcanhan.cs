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

    public partial class Themcanhan : Form
    {
        SqlConnection con = new SqlConnection("Data Source=NTRLORD; Initial Catalog=channuoi; Integrated Security=True;");
        public Themcanhan()
        {
            InitializeComponent();
            con.InfoMessage += Con_InfoMessage;
        }
        private void Con_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            // Display each message in a MessageBox or another UI element
            foreach (SqlError error in e.Errors)
            {
                MessageBox.Show(error.Message, "SQL Server Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Themcanhan", con);
            cmd.CommandType = CommandType.StoredProcedure;

            // Add parameters
            cmd.Parameters.Add("@IDcanhan", SqlDbType.Int).Value = int.Parse(textBox1.Text);
            cmd.Parameters.Add("@Tencanhan", SqlDbType.NVarChar).Value = textBox2.Text;
            cmd.Parameters.Add("@IDtochuc", SqlDbType.Int).Value = int.Parse(textBox3.Text);

            // Execute the stored procedure
            cmd.ExecuteNonQuery();

            con.Close();
        }

        // Your other form methods...


    }
}
