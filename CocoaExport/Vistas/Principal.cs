﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CocoaExport.Vistas;

namespace CocoaExport
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void RegistrarSbutton_Click(object sender, EventArgs e)
        {
            
        }

        private void Registrarbutton_Click(object sender, EventArgs e)
        {
            
        }

        private void CentrosAcpbutton_Click(object sender, EventArgs e)
        {

        }

        private void registroUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroUsuarios re = new RegistroUsuarios();
            re.Show();
        }

        private void RegistrarSbutton_Click_1(object sender, EventArgs e)
        {

        }

        private void Registrarbutton_Click_1(object sender, EventArgs e)
        {

        }

        private void registroSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroSocios registro = new RegistroSocios();
            registro.Show();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
