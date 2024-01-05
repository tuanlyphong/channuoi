using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chan_nuoi
{
    public partial class Trangchu : Form
    {
        public Trangchu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Xulychathai f = new Xulychathai();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cosochannuoi c = new Cosochannuoi();
            c.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Khac z = new Khac();
            z.Show();   
        }
    }
}
