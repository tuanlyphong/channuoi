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
    public partial class Cskn : Form
    {
        public Cskn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Themcskn a = new Themcskn();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Xemcskn b = new Xemcskn();
            b.Show();
        }
    }
}
