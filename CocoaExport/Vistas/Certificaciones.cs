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
    public partial class Certificaciones : Form
    {
        int IdBuscado;
        //BLL.Certificaciones registro = new BLL.Certificaciones();
        BLL.Certificaciones registro = new BLL.Certificaciones();

        public Certificaciones()
        {
            InitializeComponent();
        }

        private void Certificaciones_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IDtextBox.Text.Length == 0)
            {
                registro.Descripcion = DescripciontextBox.Text;

                if (registro.Insertar())
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
                registro.CertificacionID = Convert.ToInt32(IDtextBox.Text);

                registro.Descripcion = DescripciontextBox.Text;
     
                registro.Editar();

                if (registro.Editar())
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
            registro.CertificacionID = Convert.ToInt32(IDtextBox.Text);
            registro.Borrar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(IDtextBox.Text, out id);
            IdBuscado = id;
            if (registro.Buscar(IdBuscado))
            {
                registro.CertificacionID = IdBuscado;
                DescripciontextBox.Text = registro.Descripcion;
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            IDtextBox.Clear();
            DescripciontextBox.Clear();
        }
    }
}
