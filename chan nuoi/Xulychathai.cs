﻿using System;
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
    public partial class Xulychathai : Form
    {
        public Xulychathai()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Csxs f = new Csxs();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cskn a = new Cskn();
        }
    }
}
