using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PracticaHildebrando.Forms;

namespace PracticaHildebrando
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            tbUser.Text = string.Empty;
            tbPass.Text = string.Empty;
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUser.Text == string.Empty && tbPass.Text == string.Empty)
            { 
                MessageBox.Show ("Porfavor digite su usuario y contraseña");
            }
            if (tbUser.Text == "admin" && tbPass.Text == "1234")
            {
                MessageBox.Show("Bienvenido al sistema");
                
                
            }
            LoginForm loginForm = new LoginForm();
            loginForm.Hide();

        }
    }
}
