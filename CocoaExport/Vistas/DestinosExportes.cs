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
    public partial class DestinosExportes : Form
    {
    
        int IdBuscado;
        int CodigoPost;
        int DestinoId;
        BLL.DestinosExportes destino = new BLL.DestinosExportes();
        public DestinosExportes()
        {
            InitializeComponent();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (DestinoIdtextBox.Text.Length == 0)
            {
                destino.Pais = PaistextBox.Text;
                destino.CodigoDestino = CodigoDesttextBox.Text;
                destino.NombreDestino = NombreDesttextBox.Text;
                destino.Direccion = DireccionDesttextBox.Text;
                int.TryParse(CodigoDesttextBox.Text, out CodigoPost);
                destino.CodigoPostal = CodigoPost;


                if (destino.Insertar())
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
                int.TryParse(DestinoIdtextBox.Text, out DestinoId);
                destino.DestinosId = DestinoId;
                destino.Pais = PaistextBox.Text;
                destino.CodigoDestino = CodigoDesttextBox.Text;
                destino.NombreDestino = NombreDesttextBox.Text;
                destino.Direccion = DireccionDesttextBox.Text;
                destino.CodigoPostal = Convert.ToInt32(CodigoPosttextBox.Text);


                if (destino.Editar())
                {
                    MessageBox.Show("Se actualizado los datos!");
                }
                else
                {
                    MessageBox.Show("No se han actualizado los datos!");
                }
            }
            

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int.TryParse(DestinoIdtextBox.Text, out DestinoId);
            destino.DestinosId = DestinoId;
            if (destino.Eliminar())
            {
                MessageBox.Show("Se han borrado los datos");
            }
            else
            {
                MessageBox.Show("Error al borrar los datos");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int idBus;
            int.TryParse(DestinoIdtextBox.Text, out idBus);
            IdBuscado = idBus;

            if (destino.Buscar(IdBuscado))
            {
                destino.DestinosId = IdBuscado;
                PaistextBox.Text = destino.Pais;
                CodigoDesttextBox.Text = destino.CodigoDestino;
                NombreDesttextBox.Text = destino.NombreDestino;
                DireccionDesttextBox.Text = destino.Direccion;
                CodigoPosttextBox.Text = destino.CodigoPostal.ToString();
                
            }
        }

        private void DestinosExportes_Load(object sender, EventArgs e)
        {
            

        }
    }
}
