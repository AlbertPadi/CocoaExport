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
    public partial class Listar : Form
    {
        Socios socios = new Socios();
        DataTable dt = new DataTable();
        public Listar()
        {
            InitializeComponent();
        }

        private void Listarbutton_Click(object sender, EventArgs e)
        {
            

            DatoscomboBox.DataSource = socios.Listar("SocioId, Nombre, Apellido, Direccion, Cedula, CertificacionId, CantidadTerreno, Fertilizantes", "1=1", "");
            DatoscomboBox.DisplayMember = "Nombre";
            DatoscomboBox.ValueMember = "SocioId";

            string Filtro = "1=1";
            if (DatoscomboBox.SelectedIndex == 0)
            {
                if (ListatextBox.Text.Trim().Length == 0)
                {
                    Filtro = "1=1";
                }
                else
                {
                    Filtro = "SocioId = " + ListatextBox.Text;
                }

                dt = socios.Listar("SocioId, Nombre, Apellido, Direccion, Cedula, CertificacionId, CantidadTerreno, Fertilizantes", Filtro, "");
                ListadataGridView.DataSource = dt;
            }
        }

        private void sociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Listar_Load(object sender, EventArgs e)
        {
            
        }
    }
}
