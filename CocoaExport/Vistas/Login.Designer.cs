namespace CocoaExport.Vistas
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.ContrasenatextBox = new System.Windows.Forms.TextBox();
            this.Clave = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.imagenpictureBox = new System.Windows.Forms.PictureBox();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Entrarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(87, 23);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(215, 20);
            this.NombretextBox.TabIndex = 0;
            // 
            // ContrasenatextBox
            // 
            this.ContrasenatextBox.Location = new System.Drawing.Point(87, 73);
            this.ContrasenatextBox.Name = "ContrasenatextBox";
            this.ContrasenatextBox.Size = new System.Drawing.Size(142, 20);
            this.ContrasenatextBox.TabIndex = 1;
            this.ContrasenatextBox.UseSystemPasswordChar = true;
            this.ContrasenatextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.ContrasenatextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ContrasenatextBox_KeyDown);
            // 
            // Clave
            // 
            this.Clave.AutoSize = true;
            this.Clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clave.Location = new System.Drawing.Point(12, 73);
            this.Clave.Name = "Clave";
            this.Clave.Size = new System.Drawing.Size(48, 16);
            this.Clave.TabIndex = 3;
            this.Clave.Text = "Clave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nuevo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Entrar";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // imagenpictureBox
            // 
            this.imagenpictureBox.Image = global::CocoaExport.Properties.Resources.Login_Manager;
            this.imagenpictureBox.Location = new System.Drawing.Point(322, 23);
            this.imagenpictureBox.Name = "imagenpictureBox";
            this.imagenpictureBox.Size = new System.Drawing.Size(102, 123);
            this.imagenpictureBox.TabIndex = 8;
            this.imagenpictureBox.TabStop = false;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::CocoaExport.Properties.Resources.plus_32;
            this.Nuevobutton.Location = new System.Drawing.Point(202, 129);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(100, 43);
            this.Nuevobutton.TabIndex = 3;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Entrarbutton
            // 
            this.Entrarbutton.Image = global::CocoaExport.Properties.Resources.businessman_person_web_login_friend_web_browser_32;
            this.Entrarbutton.Location = new System.Drawing.Point(87, 129);
            this.Entrarbutton.Name = "Entrarbutton";
            this.Entrarbutton.Size = new System.Drawing.Size(100, 43);
            this.Entrarbutton.TabIndex = 2;
            this.Entrarbutton.UseVisualStyleBackColor = true;
            this.Entrarbutton.Click += new System.EventHandler(this.Entrarbutton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(441, 238);
            this.Controls.Add(this.imagenpictureBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.ContrasenatextBox);
            this.Controls.Add(this.Clave);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.Entrarbutton);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Entrarbutton;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox ContrasenatextBox;
        private System.Windows.Forms.Label Clave;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.PictureBox imagenpictureBox;
    }
}