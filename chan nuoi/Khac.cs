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
    public partial class Khac : Form
    {
        public Khac()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Chicucthuy a = new Chicucthuy();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Banthuoc b = new Banthuoc();
            b.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tieuhuy t = new Tieuhuy();
            t.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gietmo g = new Gietmo();
            g.Show();
        }
    }
}
