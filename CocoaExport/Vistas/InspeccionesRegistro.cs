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
    public partial class InspeccionesRegistro : Form
    {
        int IdBuscado;
        int Num;
        BLL.Inspeciones Registro = new BLL.Inspeciones();

        public InspeccionesRegistro()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //uhuhhy
        }

        private void Inspecciones_Load(object sender, EventArgs e)
        {
            BLL.Inspeciones RegistroInsp = new BLL.Inspeciones();
            IdSociocomboBox.DataSource = RegistroInsp.Listar("SocioId, Nombre", "1=1");
            IdSociocomboBox.DisplayMember = "Nombre";
            IdSociocomboBox.ValueMember = "SocioId";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            BLL.Inspeciones RegistroInsp = new BLL.Inspeciones();
            if (IdInsptextBox.Text.Length == 0)
            {
                Registro.Fecha = FechadateTimePicker.Text;
                Registro.MaterialSiembra = MaterialSiembratextBox.Text;
                Registro.ControlPlagas = ControlPlagastextBox.Text;
                Registro.ResumenInspeccion = ResumenInsprichTextBox.Text;

                if (FertSiradioButton.Checked == true)
                {
                    Num = 1;
                }

                if (FertNoradioButton.Checked == true)
                {
                    Num = 0;
                }

                if (CrianzaSiradioButton.Checked == true)
                {
                    Num = 1;
                }

                if(CrianzaNoradioButton.Checked == true)
                {
                    Num = 0;
                }

                Registro.Fertilizantes = Num;
                if (Registro.Insertar())
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
                Registro.InspeccionId = Convert.ToInt32(IdInsptextBox.Text);

                Registro.Fecha = FechadateTimePicker.Text;
                Registro.MaterialSiembra = MaterialSiembratextBox.Text;
                Registro.ControlPlagas = ControlPlagastextBox.Text;
                Registro.ResumenInspeccion = ResumenInsprichTextBox.Text;

                Registro.Editar();

                if (Registro.Editar())
                {
                    MessageBox.Show("Se han actualizado los datos!");
                }
                else
                {
                    MessageBox.Show("No se han guardado los datos!");
                }
            } 
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            IdInsptextBox.Clear();
            MaterialSiembratextBox.Clear();
            ControlPlagastextBox.Clear();
            ResumenInsprichTextBox.Clear();
            CrianzaNoradioButton.Checked = false;
            CrianzaSiradioButton.Checked = false;
            FertNoradioButton.Checked = false;
            FertSiradioButton.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IdBuscado = Convert.ToInt32(IdInsptextBox.Text);
            if (Registro.Buscar(IdBuscado))
            {
                Registro.InspeccionId = IdBuscado;
                FechadateTimePicker.Text = Registro.Fecha;
                MaterialSiembratextBox.Text = Registro.MaterialSiembra;
                ControlPlagastextBox.Text = Registro.ControlPlagas;
                ResumenInsprichTextBox.Text = Registro.ResumenInspeccion;
                

                if (Registro.Fertilizantes == 1)
                {
                    FertSiradioButton.Checked = true;
                }
                if (Registro.Fertilizantes == 0)
                {
                    FertNoradioButton.Checked = false;
                }

                if(Registro.CrianzaAnimales == 1)
                {
                    CrianzaSiradioButton.Checked = true;
                }

                if(Registro.CrianzaAnimales == 0)
                {
                    CrianzaNoradioButton.Checked = false;
                }
            } 
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            Registro.InspeccionId = Convert.ToInt32(IdInsptextBox.Text);
            Registro.Borrar();
        }
    }
}
