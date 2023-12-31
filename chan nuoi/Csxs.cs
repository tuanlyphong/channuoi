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
    public partial class Csxs : Form
    {
        public Csxs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Themcssx a = new Themcssx();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Xemcssx b = new Xemcssx();
            b.Show();
        }
    }
}
