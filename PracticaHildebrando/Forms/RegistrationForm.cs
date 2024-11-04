using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaHildebrando.Forms
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            tbName.Text = string.Empty;
            tbLName.Text = string.Empty;
            tbPwrd.Text = string.Empty; 
            tbEmail.Text = string.Empty;


        }
        public void ConfirmName()
        {
            if (string.IsNullOrEmpty(tbName.Text))
            {

            }
            if (string.IsNullOrEmpty(tbLName.Text)) { }
            if (string.IsNullOrEmpty(tbPwrd.Text)) { }
            if (string.IsNullOrEmpty(tbEmail.Text)) 
            { }
        }


        private void button1_Click(object sender, EventArgs e)
        {
           
           if (tbName.Text.Contains("@")) 
           {
                
           }
        }
    }
}
