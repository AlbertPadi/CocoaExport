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
    public partial class ControldeLotes : Form
    {
        Recepcion recepcion = new Recepcion();
        BLL.Certificaciones certificacion = new BLL.Certificaciones();
        public ControldeLotes()
        {
            InitializeComponent();
        }

        private void ControldeLotes_Load(object sender, EventArgs e)
        {
            RecepLotescomboBox.DataSource = recepcion.Listar("*", "1=1", "");

            RecepLotescomboBox.DisplayMember = "RecibidoPor";
            RecepLotescomboBox.ValueMember = "RecepcionId";

            CertificacionescomboBox.DataSource = certificacion.Listar("*", "1=1", "");

            CertificacionescomboBox.DisplayMember = "Descripcion";
            CertificacionescomboBox.ValueMember = "CertificacionId";
            
        }

        private void RecepLotescomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
