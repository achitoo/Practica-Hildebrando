using System;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrationForm frm = new RegistrationForm();
            frm.ShowDialog();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CalculatorForm frm = new CalculatorForm();
            frm.ShowDialog();
            this.Hide();

        }
    }
}
