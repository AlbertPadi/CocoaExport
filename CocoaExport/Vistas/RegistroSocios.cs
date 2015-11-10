﻿using System;
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
        int IdBuscado;
        BLL.RegistrosSocios registro = new BLL.RegistrosSocios();
        public RegistroSocios()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CodigotextBox.Text.Length == 0)
            {
                registro.Nombre = NombretextBox.Text;
                registro.Apellido = ApellidotextBox.Text;
                registro.Direccion = DirecciontextBox.Text;
                registro.Cedula = Convert.ToDouble(CedulatextBox.Text);

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
                registro.SocioId = Convert.ToInt32(CodigotextBox.Text);

                registro.Nombre = NombretextBox.Text;
                registro.Apellido = ApellidotextBox.Text;
                registro.Direccion = DirecciontextBox.Text;
                registro.Cedula = Convert.ToDouble(CedulatextBox.Text);

                registro.Hectareas = Convert.ToDouble(HectareastextBox.Text);
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
            registro.SocioId = Convert.ToInt32(CodigotextBox.Text);
            registro.Borrar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IdBuscado = Convert.ToInt32(CodigotextBox.Text);
            if (registro.Buscar(IdBuscado))
            {
                registro.SocioId = IdBuscado;
                NombretextBox.Text = registro.Nombre;
                ApellidotextBox.Text = registro.Apellido;
                DirecciontextBox.Text = registro.Direccion;
                CedulatextBox.Text = registro.Cedula.ToString();
                CodigotextBox.Text = registro.Codigo.ToString();
                HectareastextBox.Text = registro.Hectareas.ToString();

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
            CodigotextBox.Clear();
            HectareastextBox.Clear();
            FertNoradioButton.Checked = false;
            FertSiradioButton.Checked = false;
        }
    }
}
