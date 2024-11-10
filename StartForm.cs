﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcPropeller
{
    public partial class StartForm : Form
    {
        CalcController calcController = new CalcController();
        public StartForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double step = Convert.ToDouble(textBox1.Text);
            double diameter = Convert.ToDouble(textBox2.Text);
            calcController.Start(step, diameter);
        }

        private void textBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
    }
}
