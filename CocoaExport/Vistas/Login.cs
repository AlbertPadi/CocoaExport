using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace CocoaExport.Vistas
{
    public partial class Login : Form
    {
        Usuarios registro = new Usuarios();
        
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Entrarbutton_Click(object sender, EventArgs e)
        {
            registro.NombreUsuario = NombretextBox.Text;
            registro.Contrasena = ContrasenatextBox.Text;

            if (registro.Login())
            {
                if (NombretextBox.Text == registro.NombreUsuario && ContrasenatextBox.Text == registro.Contrasena)
                {

                    Principal principal = new Principal();
                    principal.Show();
                }
                
            }
            else 
            {

                    errorProvider.SetError(NombretextBox, "Usuario Incorrecto");
                    errorProvider.SetError(ContrasenatextBox, "Contrasena Incorrecta");


            }

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            NombretextBox.Clear();
            ContrasenatextBox.Clear();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void ContrasenatextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               registro.NombreUsuario = NombretextBox.Text;
                registro.Contrasena = ContrasenatextBox.Text;

                if (registro.Login())
                {
                    if (NombretextBox.Text == registro.NombreUsuario && ContrasenatextBox.Text == registro.Contrasena)
                    {
                        Principal principal = new Principal();
                        principal.Show();
                    }

                }
                else
                {

                    errorProvider.SetError(NombretextBox, "Usuario Incorrecto");
                    errorProvider.SetError(ContrasenatextBox, "Contrasena Incorrecta");


                }
            }
        }

        private void NombretextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ErrorProvider error = new ErrorProvider();
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
                
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            
            else if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                error.SetError(NombretextBox, "No acepta numeros");
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("No acepta numeros este campo");

            }
        }
    }
}
