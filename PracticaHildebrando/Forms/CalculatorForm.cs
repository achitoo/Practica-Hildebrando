﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaHildebrando.Forms
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
           
        }

        private void btnIncr_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(tbNumber1);
            double num2 = Convert.ToDouble(tbNumber2);

            double result = num1 + num2;
        }
    }
}
