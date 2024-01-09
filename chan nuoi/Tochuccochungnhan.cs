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
    public partial class Tochuccochungnhan : Form
    {
        SqlConnection con = new SqlConnection("Data source=NTRLORD; Initial Catalog=channuoi; Integrated Security=true;providerName=System.Data.SqlClient ");
        public Tochuccochungnhan()
        {
            InitializeComponent();
            LoadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter($"SELECT Tochuc.IDtochuc, Tentochuc, SoGiayChungNhan, NgayCap FROM Tochuc LEFT JOIN GiayChungNhan ON Tochuc.IDtochuc = GiayChungNhan.IDToChuc WHERE Tochuc.IDtochuc = {textBox1.Text}", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"DELETE FROM Tochuc WHERE IDtochuc = {textBox1.Text}", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record deleted successfully!");
                LoadData(); // Refresh the data after deletion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void LoadData()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Tochuc.IDtochuc, Tentochuc, SoGiayChungNhan, NgayCap FROM Tochuc LEFT JOIN GiayChungNhan ON Tochuc.IDtochuc = GiayChungNhan.IDToChuc", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

    }
}

