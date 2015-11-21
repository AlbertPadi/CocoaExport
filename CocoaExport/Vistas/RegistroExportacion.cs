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
    public partial class RegistroExportacion : Form
    {
        BLL.Certificaciones certificacion = new BLL.Certificaciones();
        BLL.DestinosExportes destinos = new BLL.DestinosExportes();
       

        double toneladas;
        int exportacionId;
        string addlotes;
        public RegistroExportacion()
        {
            InitializeComponent();
        }

        private void RegistroExportacion_Load(object sender, EventArgs e)
        {
            Lotes lotes = new Lotes();
            LoteIdcomboBox.DataSource = lotes.Listar("*","1=1","");
            LoteIdcomboBox.DisplayMember = "CodigoLote";
            LoteIdcomboBox.ValueMember = "LoteId";
            addlotes = LoteIdcomboBox.Text;

            CertificacionIdcomboBox.DataSource = certificacion.Listar("CertificacionId,Descripcion", "1=1", "");
            CertificacionIdcomboBox.DisplayMember = "Descripcion";
            CertificacionIdcomboBox.ValueMember = "CertificacionId";

            DestinosIdcomboBox.DataSource = destinos.Listar("DestinosId, NombreDestino", "1=1", "");
            DestinosIdcomboBox.DisplayMember = "NombreDestino";
            DestinosIdcomboBox.ValueMember = "DestinosId";
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            BLL.Exportacion exportacion = new BLL.Exportacion();

            if (ExportacionIdtextBox.Text.Length == 0)
            {
                double.TryParse(CantidadtextBox.Text, out toneladas);
                exportacion.CantidadToneladas = toneladas;
                exportacion.Fecha = FechadateTimePicker.Text;
                exportacion.CertificacionId = (int)CertificacionIdcomboBox.SelectedValue;
                exportacion.ExportacionId = (int)DestinosIdcomboBox.SelectedValue;
                exportacion.Resumen = ResumenrichTextBox.Text;

                
                for (int i = 0; i < LoteslistBox.Items.Count; i++)
                {
                    Lotes lotes = new Lotes();
                    int id = (int)LoteIdcomboBox.SelectedValue;
                    
                    exportacion.AgregarLotess(id,"");
                }
                if (exportacion.Insertar())
                {
                    MessageBox.Show("Se guardaron los datos!");
                }
                else
                {
                    MessageBox.Show("No se han guardado los datos!");
                }

            }
            else
            {
                int.TryParse(ExportacionIdtextBox.Text, out exportacionId);
                exportacion.ExportacionId = exportacionId;

                double.TryParse(CantidadtextBox.Text, out toneladas);
                exportacion.CantidadToneladas = toneladas;
                exportacion.Fecha = FechadateTimePicker.Text;
                exportacion.CertificacionId = (int)CertificacionIdcomboBox.SelectedValue;
                exportacion.Resumen = ResumenrichTextBox.Text;


                if (exportacion.Editar())
                {
                    MessageBox.Show("Se han actualizado los datos!");
                }
                else
                {
                    MessageBox.Show("No se han guardado los datos!");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoteslistBox.Items.Add(LoteIdcomboBox.Text);
        }

        private void LotescomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
