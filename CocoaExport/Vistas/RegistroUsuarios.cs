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
            RegistroDeUsuarios Regis = new RegistroDeUsuarios();
            Regis.Nombre = NombretextBox.Text;
            Regis.Apellido = ApellidotextBox.Text;
            Regis.Direccion = DirecciontextBox.Text;
            Regis.NombreUsuario = NomUsuariotextBox.Text;
            Regis.Contrasena = ContraseñatextBox.Text;
            Regis.Insertar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NombretextBox.Clear();
            ApellidotextBox.Clear();
            DirecciontextBox.Clear();
            NomUsuariotextBox.Clear();
            ContraseñatextBox.Clear();
        }
    }
}
