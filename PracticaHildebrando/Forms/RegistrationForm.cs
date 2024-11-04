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
        public void ConfirmTb()
        {
            if (string.IsNullOrEmpty(tbName.Text))
            {
                MessageBox.Show("Porfavor ingrese su nombre");
            }
            if (string.IsNullOrEmpty(tbLName.Text)) 
            {
                MessageBox.Show("Por favor ingrese su apellido");
            }
            if (string.IsNullOrEmpty(tbPwrd.Text)) 
            {
                MessageBox.Show("Porfavor ingrese su contraseña correctamente");
            }
            if (string.IsNullOrEmpty(tbEmail.Text)) 
            {
                MessageBox.Show("Porfavor ingrese su correo");
                
            }
            
        }
        private void ClearTb() 
        {
            tbName.Clear();
            tbLName.Clear();  
            tbPwrd.Clear();
            tbEmail.Clear();

        }


        private void button1_Click(object sender, EventArgs e)
        {
           ConfirmTb();
           ClearTb();
           if (tbEmail.Text.Contains("@")) 
           {
                MessageBox.Show("Registro hecho correctamente");
           }
           else
            {
                MessageBox.Show("Su correo no contiene el caracter '@'");
            }
        }
    }
}
