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
    public partial class RegistroSocios : Form
    {
        int n;
        BLL.RegistroSocios registro = new BLL.RegistroSocios();
        public RegistroSocios()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            registro.Nombre = NombretextBox.Text;
            registro.Apellido = ApellidotextBox.Text;
            registro.Direccion = DirecciontextBox.Text;
            registro.Cedula = Convert.ToDouble(CedulatextBox.Text);
            registro.Codigo = Convert.ToInt32(CodigotextBox.Text);
            registro.Hectareas = Convert.ToDouble(HectareastextBox.Text);
            
            if (FertSiradioButton.Checked == true)
            {
                n = 1;
            }

            if (FertNoradioButton.Checked == true)
            {
                n = 0;
            }

            registro.Fertilizantes = n;

            registro.Insertar();
        }
    }
}
