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
    public partial class RegistroUsuarios : Form
    {
        Usuarios Registro = new Usuarios();

        int usuarioId;
        public RegistroUsuarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegistroUsuarios_Load(object sender, EventArgs e)
        {

        }
       
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            
            
            int.TryParse(UsuarioIdtextBox.Text, out usuarioId);
            if (UsuarioIdtextBox.Text.Length == 0)
            {
                Registro.Nombre = NombretextBox.Text;
                Registro.Apellido = ApellidotextBox.Text;
                Registro.Direccion = DirecciontextBox.Text;
                Registro.NombreUsuario = NomUsuariotextBox.Text;
                Registro.Contrasena = ContraseñatextBox.Text;
                Registro.Contrasena1 = Contrasena1textBox.Text;
                if (ContraseñatextBox.Text.Trim() != Contrasena1textBox.Text.Trim())
                {
                    errorProvider.SetError(ContraseñatextBox, "Las contraseña no son identicas");
                    errorProvider.SetError(Contrasena1textBox, "Las contraseña no son identicas");
                    Contrasena1textBox.Clear();
                }
                else
                {
                    if (Registro.Insertar())
                    {
                        MessageBox.Show("Se insertaron los datos correctamente!");
                    }
                    else
                    {
                        MessageBox.Show("No se han podido guardar los datos!");
                    }
                }
                
            }
            else
            {
                Registro.UsuarioId = usuarioId;

                Registro.Nombre = NombretextBox.Text;
                Registro.Apellido = ApellidotextBox.Text;
                Registro.Direccion = DirecciontextBox.Text;
                Registro.NombreUsuario = NomUsuariotextBox.Text;
                Registro.Contrasena = ContraseñatextBox.Text;

                if (ContraseñatextBox.Text.Trim() != Contrasena1textBox.Text.Trim())
                {
                    errorProvider.SetError(ContraseñatextBox, "Las contraseña no son identicas");
                    errorProvider.SetError(Contrasena1textBox, "Las contraseña no son identicas");
                    Contrasena1textBox.Clear();
                }
                else
                {
                    if (Registro.Insertar())
                    {
                        MessageBox.Show("Se insertaron los datos correctamente!");
                    }
                    else
                    {
                        MessageBox.Show("No se han podido guardar los datos!");
                    }
                }
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NombretextBox.Clear();
            ApellidotextBox.Clear();
            DirecciontextBox.Clear();
            NomUsuariotextBox.Clear();
            ContraseñatextBox.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int.TryParse(UsuarioIdtextBox.Text, out usuarioId);
            Registro.UsuarioId = usuarioId;
            if (Registro.Eliminar())
            {
                MessageBox.Show("Se eliminaron los datos!");
            }
            else
            {
                MessageBox.Show("Error al eliminar los datos!");
            }
             
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int.TryParse(UsuarioIdtextBox.Text, out usuarioId);
            int IdBuscado;
            IdBuscado = usuarioId;
            if (Registro.Buscar(IdBuscado))
            {
                NombretextBox.Text = Registro.Nombre;
                ApellidotextBox.Text = Registro.Apellido;
                DirecciontextBox.Text = Registro.Direccion;
                ContraseñatextBox.Text = Registro.Contrasena;
                NomUsuariotextBox.Text = Registro.NombreUsuario;
                Contrasena1textBox.Text = Registro.Contrasena1;
            }
        }
    }
}
