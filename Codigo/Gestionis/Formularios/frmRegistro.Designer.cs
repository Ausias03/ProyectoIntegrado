namespace Gestionis
{
    partial class frmRegistro
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
            components = new System.ComponentModel.Container();
            lklInicioSesion = new LinkLabel();
            lklFaq = new LinkLabel();
            btnEnviar = new Button();
            btnBorrar = new Button();
            txtContrasenya = new TextBox();
            lblContrasenya = new Label();
            txtApodo = new TextBox();
            lblApodo = new Label();
            lblRegistro = new Label();
            txtCorreo = new TextBox();
            lblCorreo = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtApellidos = new TextBox();
            lblApellidos = new Label();
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lklInicioSesion
            // 
            lklInicioSesion.AutoSize = true;
            lklInicioSesion.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lklInicioSesion.Location = new Point(16, 437);
            lklInicioSesion.Name = "lklInicioSesion";
            lklInicioSesion.Size = new Size(210, 26);
            lklInicioSesion.TabIndex = 11;
            lklInicioSesion.TabStop = true;
            lklInicioSesion.Text = "¿Ya Tienes Cuenta?";
            lklInicioSesion.LinkClicked += lklInicioSesion_LinkClicked;
            // 
            // lklFaq
            // 
            lklFaq.AutoSize = true;
            lklFaq.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lklFaq.Location = new Point(16, 396);
            lklFaq.Name = "lklFaq";
            lklFaq.Size = new Size(192, 26);
            lklFaq.TabIndex = 10;
            lklFaq.TabStop = true;
            lklFaq.Text = "¿Algún Problema?";
            lklFaq.LinkClicked += lklFaq_LinkClicked;
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.FromArgb(178, 242, 187);
            btnEnviar.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEnviar.Location = new Point(576, 427);
            btnEnviar.Margin = new Padding(3, 2, 3, 2);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(111, 40);
            btnEnviar.TabIndex = 8;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.FromArgb(211, 208, 242);
            btnBorrar.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBorrar.Location = new Point(444, 427);
            btnBorrar.Margin = new Padding(3, 2, 3, 2);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(111, 40);
            btnBorrar.TabIndex = 9;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // txtContrasenya
            // 
            txtContrasenya.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContrasenya.Location = new Point(276, 248);
            txtContrasenya.Margin = new Padding(3, 2, 3, 2);
            txtContrasenya.Name = "txtContrasenya";
            txtContrasenya.Size = new Size(253, 32);
            txtContrasenya.TabIndex = 5;
            // 
            // lblContrasenya
            // 
            lblContrasenya.AutoSize = true;
            lblContrasenya.BackColor = SystemColors.Control;
            lblContrasenya.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContrasenya.Location = new Point(134, 245);
            lblContrasenya.Name = "lblContrasenya";
            lblContrasenya.Padding = new Padding(4, 4, 4, 4);
            lblContrasenya.Size = new Size(138, 34);
            lblContrasenya.TabIndex = 12;
            lblContrasenya.Text = "Contraseña:";
            lblContrasenya.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtApodo
            // 
            txtApodo.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApodo.Location = new Point(276, 68);
            txtApodo.Margin = new Padding(3, 2, 3, 2);
            txtApodo.Name = "txtApodo";
            txtApodo.Size = new Size(253, 32);
            txtApodo.TabIndex = 1;
            // 
            // lblApodo
            // 
            lblApodo.AutoSize = true;
            lblApodo.BackColor = SystemColors.Control;
            lblApodo.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApodo.Location = new Point(183, 65);
            lblApodo.Name = "lblApodo";
            lblApodo.Padding = new Padding(4, 4, 4, 4);
            lblApodo.Size = new Size(89, 34);
            lblApodo.TabIndex = 10;
            lblApodo.Text = "Apodo:";
            lblApodo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.BackColor = Color.FromArgb(211, 208, 242);
            lblRegistro.BorderStyle = BorderStyle.FixedSingle;
            lblRegistro.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegistro.Location = new Point(275, 14);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Padding = new Padding(4, 4, 4, 4);
            lblRegistro.Size = new Size(114, 39);
            lblRegistro.TabIndex = 9;
            lblRegistro.Text = "Registro";
            lblRegistro.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(276, 113);
            txtCorreo.Margin = new Padding(3, 2, 3, 2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(253, 32);
            txtCorreo.TabIndex = 2;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.BackColor = SystemColors.Control;
            lblCorreo.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCorreo.Location = new Point(180, 110);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Padding = new Padding(4, 4, 4, 4);
            lblCorreo.Size = new Size(92, 34);
            lblCorreo.TabIndex = 18;
            lblCorreo.Text = "Correo:";
            lblCorreo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(276, 158);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(253, 32);
            txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = SystemColors.Control;
            lblNombre.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(168, 155);
            lblNombre.Name = "lblNombre";
            lblNombre.Padding = new Padding(4, 4, 4, 4);
            lblNombre.Size = new Size(104, 34);
            lblNombre.TabIndex = 20;
            lblNombre.Text = "Nombre:";
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtApellidos
            // 
            txtApellidos.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidos.Location = new Point(276, 203);
            txtApellidos.Margin = new Padding(3, 2, 3, 2);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(253, 32);
            txtApellidos.TabIndex = 4;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.BackColor = SystemColors.Control;
            lblApellidos.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellidos.Location = new Point(157, 200);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Padding = new Padding(4, 4, 4, 4);
            lblApellidos.Size = new Size(115, 34);
            lblApellidos.TabIndex = 22;
            lblApellidos.Text = "Apellidos:";
            lblApellidos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDireccion.Location = new Point(276, 293);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(253, 32);
            txtDireccion.TabIndex = 6;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.BackColor = SystemColors.Control;
            lblDireccion.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDireccion.Location = new Point(155, 290);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Padding = new Padding(4, 4, 4, 4);
            lblDireccion.Size = new Size(117, 34);
            lblDireccion.TabIndex = 24;
            lblDireccion.Text = "Dirección:";
            lblDireccion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(276, 338);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(253, 32);
            txtTelefono.TabIndex = 7;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BackColor = SystemColors.Control;
            lblTelefono.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(163, 335);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Padding = new Padding(4, 4, 4, 4);
            lblTelefono.Size = new Size(109, 34);
            lblTelefono.TabIndex = 26;
            lblTelefono.Text = "Teléfono:";
            lblTelefono.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 479);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(txtApellidos);
            Controls.Add(lblApellidos);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtCorreo);
            Controls.Add(lblCorreo);
            Controls.Add(lklInicioSesion);
            Controls.Add(lklFaq);
            Controls.Add(btnEnviar);
            Controls.Add(btnBorrar);
            Controls.Add(txtContrasenya);
            Controls.Add(lblContrasenya);
            Controls.Add(txtApodo);
            Controls.Add(lblApodo);
            Controls.Add(lblRegistro);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmRegistro";
            Text = "frmRegistro";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel lklInicioSesion;
        private LinkLabel lklFaq;
        private Button btnEnviar;
        private Button btnBorrar;
        private TextBox txtContrasenya;
        private Label lblContrasenya;
        private TextBox txtApodo;
        private Label lblApodo;
        private Label lblRegistro;
        private TextBox txtCorreo;
        private Label lblCorreo;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtApellidos;
        private Label lblApellidos;
        private TextBox txtDireccion;
        private Label lblDireccion;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private ErrorProvider errorProvider1;
    }
}