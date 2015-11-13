namespace CocoaExport
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroSociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inspeccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDeLotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.registroToolStripMenuItem,
            this.inspeccionesToolStripMenuItem,
            this.controlDeLotesToolStripMenuItem,
            this.exportacionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(807, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.configuracionToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroSociosToolStripMenuItem,
            this.registroUsuariosToolStripMenuItem});
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.registroToolStripMenuItem.Text = "Registro";
            // 
            // registroSociosToolStripMenuItem
            // 
            this.registroSociosToolStripMenuItem.Name = "registroSociosToolStripMenuItem";
            this.registroSociosToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.registroSociosToolStripMenuItem.Text = "Registro Socios";
            this.registroSociosToolStripMenuItem.Click += new System.EventHandler(this.registroSociosToolStripMenuItem_Click);
            // 
            // inspeccionesToolStripMenuItem
            // 
            this.inspeccionesToolStripMenuItem.Name = "inspeccionesToolStripMenuItem";
            this.inspeccionesToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.inspeccionesToolStripMenuItem.Text = "Inspecciones";
            // 
            // registroUsuariosToolStripMenuItem
            // 
            this.registroUsuariosToolStripMenuItem.Name = "registroUsuariosToolStripMenuItem";
            this.registroUsuariosToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.registroUsuariosToolStripMenuItem.Text = "Registro Usuarios";
            this.registroUsuariosToolStripMenuItem.Click += new System.EventHandler(this.registroUsuariosToolStripMenuItem_Click);
            // 
            // controlDeLotesToolStripMenuItem
            // 
            this.controlDeLotesToolStripMenuItem.Name = "controlDeLotesToolStripMenuItem";
            this.controlDeLotesToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.controlDeLotesToolStripMenuItem.Text = "Control de Lotes";
            // 
            // exportacionToolStripMenuItem
            // 
            this.exportacionToolStripMenuItem.Name = "exportacionToolStripMenuItem";
            this.exportacionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.exportacionToolStripMenuItem.Text = "Exportacion";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.nuevoToolStripMenuItem.Text = "Configuracion";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.salirToolStripMenuItem.Text = "Mi perfil";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.configuracionToolStripMenuItem.Text = "Salir";
            this.configuracionToolStripMenuItem.Click += new System.EventHandler(this.configuracionToolStripMenuItem_Click);
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CocoaExport.Properties.Resources.img14132485a794a2fb51;
            this.pictureBox1.Location = new System.Drawing.Point(0, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(815, 200);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(807, 385);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroSociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inspeccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlDeLotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
    }
}

