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
    public partial class Tochuccanhan : Form
    {
        public Tochuccanhan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Themtochuc f = new Themtochuc();
            f.Show();
        }
        SqlConnection con = new SqlConnection("Data source=NTRLORD; Initial Catalog=channuoi; Integrated Security=true;providerName=System.Data.SqlClient ");
        private void Xemtochuc()
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data source=NTRLORD; Initial Catalog=channuoi; Integrated Security=true;providerName=System.Data.SqlClient "))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("Xemtochuc", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Create a new SqlDataAdapter and DataTable for displaying organizations
                        SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                        DataTable dt1 = new DataTable();
                        da1.Fill(dt1);
                        dataGridView1.DataSource = dt1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Tochuccanhan_Load(object sender, EventArgs e)
        {
            Xemtochuc();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Themcanhan a = new Themcanhan();
            a.Show();
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Get the selected organization ID from the selected row in dataGridView1
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int IDtochucduocchon = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["IDtochuc"].Value);

                // Call the stored procedure to load individuals for the selected organization
                Xemcanhancuamottochuc(IDtochucduocchon);
            }
        }

        private void Xemcanhancuamottochuc(int IDtochucduocchon)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Xemcanhancuamottochuc", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // Add organization ID as a parameter
                cmd.Parameters.Add("@IDtochuc", SqlDbType.Int).Value = IDtochucduocchon;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            con.Close();
        }
        private void Timkiemtochuc(int IDtochuc)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Timkiemtochuc", con);
                cmd.CommandType = CommandType.StoredProcedure;
                // Add organization ID as a parameter
                cmd.Parameters.Add("@IDtochuc", SqlDbType.Int).Value = IDtochuc;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            con.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            // Load organization by ID when the button is clicked
            if (!string.IsNullOrEmpty(textBox1.Text) && int.TryParse(textBox1.Text, out int IDtochuc))
            {
                Timkiemtochuc(IDtochuc);
            }
            else
            {
                MessageBox.Show("ID to chuc khong ton tai");
            }
        }
        private void Timkiemcanhan(int IDcanhan)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Timkiemcanhan", con);
                cmd.CommandType = CommandType.StoredProcedure;
                // Add individual ID as a parameter
                cmd.Parameters.Add("@IDcanhan", SqlDbType.Int).Value = IDcanhan;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            con.Close();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            // Load individual by ID when the button is clicked
            if (!string.IsNullOrEmpty(textBox2.Text) && int.TryParse(textBox2.Text, out int IDcanhan))
            {
                Timkiemcanhan(IDcanhan);
            }
            else
            {
                MessageBox.Show("ID ca nhan khong ton tai");
            }
        }
        private void Xoatochuc(int IDtochuc)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data source=NTRLORD; Initial Catalog=channuoi; Integrated Security=true;providerName=System.Data.SqlClient "))
                {
                    con.Open();

                    // Delete individuals first
                    using (SqlCommand cmdDeleteIndividuals = new SqlCommand("DELETE FROM Canhan WHERE IDtochuc = @IDtochuc", con))
                    {
                        cmdDeleteIndividuals.Parameters.Add("@IDtochuc", SqlDbType.Int).Value = IDtochuc;
                        cmdDeleteIndividuals.ExecuteNonQuery();
                    }

                    // Then delete the organization
                    using (SqlCommand cmdDeleteOrganization = new SqlCommand("DELETE FROM Tochuc WHERE IDtochuc = @IDtochuc", con))
                    {
                        cmdDeleteOrganization.Parameters.Add("@IDtochuc", SqlDbType.Int).Value = IDtochuc;
                        cmdDeleteOrganization.ExecuteNonQuery();
                    }

                    // Refresh dataGridView1 after deletion
                    Xemtochuc();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Delete organization by ID when the button is clicked
            if (!string.IsNullOrEmpty(textBox1.Text) && int.TryParse(textBox1.Text, out int IDtochuc))
            {
                Xoatochuc(IDtochuc);
            }
            else
            {
                MessageBox.Show("to chuc khong ton tai");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Xemtochuc();
        }
        private void XoaCanhanTheoTochuc(int IDtochuc, int IDcanhan)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("XoaCanhanTheoTochuc", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // Add organization ID and individual ID as parameters
                cmd.Parameters.Add("@IDtochuc", SqlDbType.Int).Value = IDtochuc;
                cmd.Parameters.Add("@IDcanhan", SqlDbType.Int).Value = IDcanhan;

                // Execute the stored procedure
                cmd.ExecuteNonQuery();
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
        private void button5_Click(object sender, EventArgs e)
        {
            // Delete individual by ID when the button is clicked
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView2.SelectedRows.Count > 0)
            {
                int IDtochucduocchon = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["IDtochuc"].Value);

                // Check if any individual is selected in dataGridView2
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    int IDcanhan = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["IDcanhan"].Value);

                    // Delete individual based on organization ID and individual ID
                    XoaCanhanTheoTochuc(IDtochucduocchon, IDcanhan);

                    // Refresh dataGridView2 after deletion
                    Xemcanhancuamottochuc(IDtochucduocchon);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một cá nhân để xóa.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tổ chức và một cá nhân để xóa.");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Honhole z = new Honhole();
            z.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
        }
    }
}
