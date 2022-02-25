﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa01_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double r = 0.0;
            double a = 0.0;
            double b = 0.0;

            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);

            if (rbSuma.Checked == true)
                r = a + b;

            if (rbResta.Checked == true)
                r = a - b;

            if (rbMultiplicasion.Checked == true)
                r = a * b;

            if (rbDivision.Checked == true)
                r = a / b;

            lblResultado.Text = r.ToString();

        }
    }
}
