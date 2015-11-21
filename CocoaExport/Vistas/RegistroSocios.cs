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
        double CantTerreno;
        int n;
        int IdBuscado;
        int socioId;
        BLL.Socios registro = new BLL.Socios();
        public RegistroSocios()
        {
            
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            BLL.Certificaciones registrocer = new BLL.Certificaciones();
            if (SocioIdtextBox.Text.Length == 0)
            {
                
                registro.Nombre = NombretextBox.Text;
                registro.Apellido = ApellidotextBox.Text;
                registro.Direccion = DirecciontextBox.Text;
                registro.Cedula = CedulatextBox.Text;
                registro.CertificacionId = (int)CertificacioncomboBox.SelectedValue;


                double.TryParse(TerrenotextBox.Text, out CantTerreno);

                registro.CantidadTerreno = CantTerreno;

                if (FertSiradioButton.Checked == true)
                {
                    n = 1;
                }

                if (FertNoradioButton.Checked == true)
                {
                    n = 0;
                }

                registro.Fertilizantes = n;
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
                int.TryParse(SocioIdtextBox.Text, out socioId);
                registro.SocioId = socioId;

                registro.Nombre = NombretextBox.Text;
                registro.Apellido = ApellidotextBox.Text;
                registro.Direccion = DirecciontextBox.Text;
                registro.Cedula = CedulatextBox.Text;

                double.TryParse(TerrenotextBox.Text, out CantTerreno);

                registro.CantidadTerreno = CantTerreno;


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
            int.TryParse(SocioIdtextBox.Text, out socioId);
            registro.SocioId = socioId;
            registro.Eliminar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int vari;
            int.TryParse(SocioIdtextBox.Text, out vari);
            IdBuscado = vari;
            if (registro.Buscar(IdBuscado))
            {
                registro.SocioId = IdBuscado;
                NombretextBox.Text = registro.Nombre;
                ApellidotextBox.Text = registro.Apellido;
                DirecciontextBox.Text = registro.Direccion;
                CedulatextBox.Text = registro.Cedula.ToString();
                TerrenotextBox.Text = registro.CantidadTerreno.ToString();

                if (registro.Fertilizantes == 1)
                {
                    FertSiradioButton.Checked = true;
                }
                if (registro.Fertilizantes == 0)
                {
                    FertNoradioButton.Checked = false;
                }
            }
            
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NombretextBox.Clear();
            ApellidotextBox.Clear();
            DirecciontextBox.Clear();
            CedulatextBox.Clear();
            SocioIdtextBox.Clear();
            TerrenotextBox.Clear();
            FertNoradioButton.Checked = false;
            FertSiradioButton.Checked = false;

            

           

        }
        DataTable table = new DataTable();
        DateTime date = DateTime.Now;

        private void RegistroSocios_Load(object sender, EventArgs e)
        {
            BLL.Certificaciones registroc = new BLL.Certificaciones();
            CertificacioncomboBox.DataSource = registroc.Listar("CertificacionId,Descripcion","1=1","");
            CertificacioncomboBox.DisplayMember = "Descripcion";
            CertificacioncomboBox.ValueMember = "CertificacionId";
            Socios socios = new Socios(); 

            RegistroSocios registro = new RegistroSocios ();
            
            table = socios.Listar("", "", "");

            chart.Series.Add("Socios");
            chart.Series["Series1"].XValueMember = "Fecha";
            chart.Series["Series1"].YValueMembers = "Monto";
            chart.DataSource = table;
            chart.DataBind();

        }

        private void NombretextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
             
           
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
                else
                {
                    e.Handled = true;
                MessageBox.Show("No acepta numeros este campo");
               
                }
            }

        private void CertificacioncomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
