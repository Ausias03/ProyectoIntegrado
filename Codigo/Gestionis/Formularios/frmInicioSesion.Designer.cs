namespace Gestionis
{
    partial class frmInicioSesion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioSesion));
            lblInicioSesion = new Label();
            lblNombreUsuario = new Label();
            txtNombreUsuario = new TextBox();
            txtContrasenya = new TextBox();
            lblContrasenya = new Label();
            btnBorrar = new Button();
            btnEnviar = new Button();
            lklFaq = new LinkLabel();
            lklRegistro = new LinkLabel();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblInicioSesion
            // 
            lblInicioSesion.AutoSize = true;
            lblInicioSesion.BackColor = Color.FromArgb(211, 208, 242);
            lblInicioSesion.BorderStyle = BorderStyle.FixedSingle;
            lblInicioSesion.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInicioSesion.Location = new Point(214, 17);
            lblInicioSesion.Name = "lblInicioSesion";
            lblInicioSesion.Padding = new Padding(4);
            lblInicioSesion.Size = new Size(195, 39);
            lblInicioSesion.TabIndex = 0;
            lblInicioSesion.Text = "Inicio de Sesión";
            lblInicioSesion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.BackColor = SystemColors.Control;
            lblNombreUsuario.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreUsuario.Location = new Point(87, 76);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Padding = new Padding(4);
            lblNombreUsuario.Size = new Size(215, 34);
            lblNombreUsuario.TabIndex = 1;
            lblNombreUsuario.Text = "Nombre de Usuario:";
            lblNombreUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreUsuario.Location = new Point(310, 79);
            txtNombreUsuario.Margin = new Padding(3, 2, 3, 2);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(253, 32);
            txtNombreUsuario.TabIndex = 1;
            // 
            // txtContrasenya
            // 
            txtContrasenya.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContrasenya.Location = new Point(310, 125);
            txtContrasenya.Margin = new Padding(3, 2, 3, 2);
            txtContrasenya.Name = "txtContrasenya";
            txtContrasenya.Size = new Size(253, 32);
            txtContrasenya.TabIndex = 2;
            // 
            // lblContrasenya
            // 
            lblContrasenya.AutoSize = true;
            lblContrasenya.BackColor = SystemColors.Control;
            lblContrasenya.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContrasenya.Location = new Point(164, 123);
            lblContrasenya.Name = "lblContrasenya";
            lblContrasenya.Padding = new Padding(4);
            lblContrasenya.Size = new Size(138, 34);
            lblContrasenya.TabIndex = 3;
            lblContrasenya.Text = "Contraseña:";
            lblContrasenya.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.FromArgb(211, 208, 242);
            btnBorrar.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBorrar.Location = new Point(438, 208);
            btnBorrar.Margin = new Padding(3, 2, 3, 2);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(111, 40);
            btnBorrar.TabIndex = 4;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.FromArgb(178, 242, 187);
            btnEnviar.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEnviar.Location = new Point(570, 208);
            btnEnviar.Margin = new Padding(3, 2, 3, 2);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(111, 40);
            btnEnviar.TabIndex = 3;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // lklFaq
            // 
            lklFaq.AutoSize = true;
            lklFaq.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lklFaq.Location = new Point(10, 178);
            lklFaq.Name = "lklFaq";
            lklFaq.Size = new Size(192, 26);
            lklFaq.TabIndex = 5;
            lklFaq.TabStop = true;
            lklFaq.Text = "¿Algún Problema?";
            lklFaq.LinkClicked += lklFaq_LinkClicked;
            // 
            // lklRegistro
            // 
            lklRegistro.AutoSize = true;
            lklRegistro.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lklRegistro.Location = new Point(10, 219);
            lklRegistro.Name = "lklRegistro";
            lklRegistro.Size = new Size(210, 26);
            lklRegistro.TabIndex = 6;
            lklRegistro.TabStop = true;
            lklRegistro.Text = "¿No Tienes Cuenta?";
            lklRegistro.LinkClicked += lklRegistro_LinkClicked;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // frmInicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 265);
            Controls.Add(lklRegistro);
            Controls.Add(lklFaq);
            Controls.Add(btnEnviar);
            Controls.Add(btnBorrar);
            Controls.Add(txtContrasenya);
            Controls.Add(lblContrasenya);
            Controls.Add(txtNombreUsuario);
            Controls.Add(lblNombreUsuario);
            Controls.Add(lblInicioSesion);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmInicioSesion";
            Text = "Ge$tioni$";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInicioSesion;
        private Label lblNombreUsuario;
        private TextBox txtNombreUsuario;
        private TextBox txtContrasenya;
        private Label lblContrasenya;
        private Button btnBorrar;
        private Button btnEnviar;
        private LinkLabel lklFaq;
        private LinkLabel lklRegistro;
        private ErrorProvider errorProvider1;
    }
}
