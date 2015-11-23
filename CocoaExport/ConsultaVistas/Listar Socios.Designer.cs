namespace CocoaExport.Vistas
{
    partial class Listar
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.certificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListadataGridView = new System.Windows.Forms.DataGridView();
            this.DatoscomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ListatextBox = new System.Windows.Forms.TextBox();
            this.Listarbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(932, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sociosToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.certificacionesToolStripMenuItem});
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.listarToolStripMenuItem.Text = "Listar";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // sociosToolStripMenuItem
            // 
            this.sociosToolStripMenuItem.Name = "sociosToolStripMenuItem";
            this.sociosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sociosToolStripMenuItem.Text = "Socios";
            this.sociosToolStripMenuItem.Click += new System.EventHandler(this.sociosToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // certificacionesToolStripMenuItem
            // 
            this.certificacionesToolStripMenuItem.Name = "certificacionesToolStripMenuItem";
            this.certificacionesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.certificacionesToolStripMenuItem.Text = "Certificaciones";
            // 
            // ListadataGridView
            // 
            this.ListadataGridView.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.ListadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadataGridView.Location = new System.Drawing.Point(0, 77);
            this.ListadataGridView.Name = "ListadataGridView";
            this.ListadataGridView.Size = new System.Drawing.Size(932, 233);
            this.ListadataGridView.TabIndex = 1;
            // 
            // DatoscomboBox
            // 
            this.DatoscomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DatoscomboBox.FormattingEnabled = true;
            this.DatoscomboBox.Location = new System.Drawing.Point(92, 30);
            this.DatoscomboBox.Name = "DatoscomboBox";
            this.DatoscomboBox.Size = new System.Drawing.Size(191, 21);
            this.DatoscomboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Listar Por";
            // 
            // ListatextBox
            // 
            this.ListatextBox.Location = new System.Drawing.Point(299, 31);
            this.ListatextBox.Name = "ListatextBox";
            this.ListatextBox.Size = new System.Drawing.Size(452, 20);
            this.ListatextBox.TabIndex = 4;
            // 
            // Listarbutton
            // 
            this.Listarbutton.Image = global::CocoaExport.Properties.Resources._1443814210_fine_print;
            this.Listarbutton.Location = new System.Drawing.Point(780, 27);
            this.Listarbutton.Name = "Listarbutton";
            this.Listarbutton.Size = new System.Drawing.Size(111, 33);
            this.Listarbutton.TabIndex = 5;
            this.Listarbutton.UseVisualStyleBackColor = true;
            this.Listarbutton.Click += new System.EventHandler(this.Listarbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(811, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Listar";
            // 
            // Listar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(932, 310);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Listarbutton);
            this.Controls.Add(this.ListatextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DatoscomboBox);
            this.Controls.Add(this.ListadataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Listar";
            this.Text = "Listar";
            this.Load += new System.EventHandler(this.Listar_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem certificacionesToolStripMenuItem;
        private System.Windows.Forms.DataGridView ListadataGridView;
        private System.Windows.Forms.ComboBox DatoscomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ListatextBox;
        private System.Windows.Forms.Button Listarbutton;
        private System.Windows.Forms.Label label2;
    }
}