﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelGry;

namespace GraGUI
{
    public partial class Form1 : Form
    {
        private Gra g;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNowaGra_Click(object sender, EventArgs e)
        {
            groupBoxLosuj.Visible = true;
        }

        private void buttonLosuj_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBoxZakresOd.Text);
            int b = int.Parse(textBoxZakresDo.Text);

            textBoxZakresOd.Enabled = true;
            textBoxZakresDo.Enabled = false;

            g = new Gra(a, b);
        }
    }
}
