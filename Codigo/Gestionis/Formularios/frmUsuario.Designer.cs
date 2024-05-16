namespace Gestionis
{
    partial class frmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            lblTuCuenta = new Label();
            grpCuenta = new GroupBox();
            btnConfirmarFoto = new Button();
            btnConfirmarApellidos = new Button();
            txtApellidos = new TextBox();
            btnCambiarApellidos = new Button();
            lblApellidos = new Label();
            btnConfirmarTel = new Button();
            btnConfirmarDir = new Button();
            btnConfirmarCorreo = new Button();
            btnConfirmarApodo = new Button();
            btnConfirmarNom = new Button();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtCorreo = new TextBox();
            txtApodo = new TextBox();
            txtNombre = new TextBox();
            btnCambiarFoto = new Button();
            btnCambiarTel = new Button();
            btnCambiarDir = new Button();
            btnCambiarCorreo = new Button();
            btnCambiarApodo = new Button();
            btnCambiarNom = new Button();
            lblNivel = new Label();
            lblTelefono = new Label();
            lblDireccion = new Label();
            lblCorreo = new Label();
            lblApodo = new Label();
            lblNombre = new Label();
            picFoto = new PictureBox();
            btnCerrarSesion = new Button();
            errorProvider1 = new ErrorProvider(components);
            barraSecundaria1 = new Herramientas.BarraSecundaria();
            barraLateral1 = new Herramientas.BarraLateral();
            grpCuenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTuCuenta
            // 
            lblTuCuenta.AutoSize = true;
            lblTuCuenta.Font = new Font("Microsoft Sans Serif", 24F);
            lblTuCuenta.Location = new Point(127, 80);
            lblTuCuenta.Name = "lblTuCuenta";
            lblTuCuenta.Size = new Size(160, 37);
            lblTuCuenta.TabIndex = 0;
            lblTuCuenta.Text = "Tu cuenta";
            // 
            // grpCuenta
            // 
            grpCuenta.Controls.Add(btnConfirmarFoto);
            grpCuenta.Controls.Add(btnConfirmarApellidos);
            grpCuenta.Controls.Add(txtApellidos);
            grpCuenta.Controls.Add(btnCambiarApellidos);
            grpCuenta.Controls.Add(lblApellidos);
            grpCuenta.Controls.Add(btnConfirmarTel);
            grpCuenta.Controls.Add(btnConfirmarDir);
            grpCuenta.Controls.Add(btnConfirmarCorreo);
            grpCuenta.Controls.Add(btnConfirmarApodo);
            grpCuenta.Controls.Add(btnConfirmarNom);
            grpCuenta.Controls.Add(txtTelefono);
            grpCuenta.Controls.Add(txtDireccion);
            grpCuenta.Controls.Add(txtCorreo);
            grpCuenta.Controls.Add(txtApodo);
            grpCuenta.Controls.Add(txtNombre);
            grpCuenta.Controls.Add(btnCambiarFoto);
            grpCuenta.Controls.Add(btnCambiarTel);
            grpCuenta.Controls.Add(btnCambiarDir);
            grpCuenta.Controls.Add(btnCambiarCorreo);
            grpCuenta.Controls.Add(btnCambiarApodo);
            grpCuenta.Controls.Add(btnCambiarNom);
            grpCuenta.Controls.Add(lblNivel);
            grpCuenta.Controls.Add(lblTelefono);
            grpCuenta.Controls.Add(lblDireccion);
            grpCuenta.Controls.Add(lblCorreo);
            grpCuenta.Controls.Add(lblApodo);
            grpCuenta.Controls.Add(lblNombre);
            grpCuenta.Controls.Add(picFoto);
            grpCuenta.Location = new Point(155, 119);
            grpCuenta.Name = "grpCuenta";
            grpCuenta.Size = new Size(956, 589);
            grpCuenta.TabIndex = 1;
            grpCuenta.TabStop = false;
            // 
            // btnConfirmarFoto
            // 
            btnConfirmarFoto.BackColor = Color.FromArgb(178, 242, 187);
            btnConfirmarFoto.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnConfirmarFoto.Location = new Point(281, 92);
            btnConfirmarFoto.Name = "btnConfirmarFoto";
            btnConfirmarFoto.Size = new Size(135, 52);
            btnConfirmarFoto.TabIndex = 26;
            btnConfirmarFoto.Text = "Confirmar";
            btnConfirmarFoto.UseVisualStyleBackColor = false;
            btnConfirmarFoto.Visible = false;
            btnConfirmarFoto.Click += btnConfirmarFoto_Click;
            // 
            // btnConfirmarApellidos
            // 
            btnConfirmarApellidos.BackColor = Color.FromArgb(178, 242, 187);
            btnConfirmarApellidos.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnConfirmarApellidos.Location = new Point(762, 279);
            btnConfirmarApellidos.Name = "btnConfirmarApellidos";
            btnConfirmarApellidos.Size = new Size(135, 52);
            btnConfirmarApellidos.TabIndex = 25;
            btnConfirmarApellidos.Text = "Confirmar";
            btnConfirmarApellidos.UseVisualStyleBackColor = false;
            btnConfirmarApellidos.Visible = false;
            btnConfirmarApellidos.Click += btnConfirmarApellidos_Click;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(191, 294);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.ReadOnly = true;
            txtApellidos.Size = new Size(533, 21);
            txtApellidos.TabIndex = 24;
            // 
            // btnCambiarApellidos
            // 
            btnCambiarApellidos.BackColor = Color.FromArgb(178, 242, 187);
            btnCambiarApellidos.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnCambiarApellidos.Location = new Point(770, 279);
            btnCambiarApellidos.Name = "btnCambiarApellidos";
            btnCambiarApellidos.Size = new Size(121, 52);
            btnCambiarApellidos.TabIndex = 23;
            btnCambiarApellidos.Text = "Cambiar";
            btnCambiarApellidos.UseVisualStyleBackColor = false;
            btnCambiarApellidos.Click += btnCambiarApellidos_Click;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Font = new Font("Microsoft Sans Serif", 12F);
            lblApellidos.Location = new Point(53, 292);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(77, 20);
            lblApellidos.TabIndex = 22;
            lblApellidos.Text = "Apellidos:";
            // 
            // btnConfirmarTel
            // 
            btnConfirmarTel.BackColor = Color.FromArgb(178, 242, 187);
            btnConfirmarTel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnConfirmarTel.Location = new Point(762, 508);
            btnConfirmarTel.Name = "btnConfirmarTel";
            btnConfirmarTel.Size = new Size(135, 52);
            btnConfirmarTel.TabIndex = 21;
            btnConfirmarTel.Text = "Confirmar";
            btnConfirmarTel.UseVisualStyleBackColor = false;
            btnConfirmarTel.Visible = false;
            btnConfirmarTel.Click += btnConfirmarTel_Click;
            // 
            // btnConfirmarDir
            // 
            btnConfirmarDir.BackColor = Color.FromArgb(178, 242, 187);
            btnConfirmarDir.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnConfirmarDir.Location = new Point(762, 450);
            btnConfirmarDir.Name = "btnConfirmarDir";
            btnConfirmarDir.Size = new Size(135, 52);
            btnConfirmarDir.TabIndex = 20;
            btnConfirmarDir.Text = "Confirmar";
            btnConfirmarDir.UseVisualStyleBackColor = false;
            btnConfirmarDir.Visible = false;
            btnConfirmarDir.Click += btnConfirmarDir_Click;
            // 
            // btnConfirmarCorreo
            // 
            btnConfirmarCorreo.BackColor = Color.FromArgb(178, 242, 187);
            btnConfirmarCorreo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnConfirmarCorreo.Location = new Point(762, 392);
            btnConfirmarCorreo.Name = "btnConfirmarCorreo";
            btnConfirmarCorreo.Size = new Size(135, 52);
            btnConfirmarCorreo.TabIndex = 19;
            btnConfirmarCorreo.Text = "Confirmar";
            btnConfirmarCorreo.UseVisualStyleBackColor = false;
            btnConfirmarCorreo.Visible = false;
            btnConfirmarCorreo.Click += btnConfirmarCorreo_Click;
            // 
            // btnConfirmarApodo
            // 
            btnConfirmarApodo.BackColor = Color.FromArgb(178, 242, 187);
            btnConfirmarApodo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnConfirmarApodo.Location = new Point(762, 337);
            btnConfirmarApodo.Name = "btnConfirmarApodo";
            btnConfirmarApodo.Size = new Size(135, 52);
            btnConfirmarApodo.TabIndex = 18;
            btnConfirmarApodo.Text = "Confirmar";
            btnConfirmarApodo.UseVisualStyleBackColor = false;
            btnConfirmarApodo.Visible = false;
            btnConfirmarApodo.Click += btnConfirmarApodo_Click;
            // 
            // btnConfirmarNom
            // 
            btnConfirmarNom.BackColor = Color.FromArgb(178, 242, 187);
            btnConfirmarNom.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnConfirmarNom.Location = new Point(762, 221);
            btnConfirmarNom.Name = "btnConfirmarNom";
            btnConfirmarNom.Size = new Size(135, 52);
            btnConfirmarNom.TabIndex = 17;
            btnConfirmarNom.Text = "Confirmar";
            btnConfirmarNom.UseVisualStyleBackColor = false;
            btnConfirmarNom.Visible = false;
            btnConfirmarNom.Click += btnConfirmarNom_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(179, 520);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.ReadOnly = true;
            txtTelefono.Size = new Size(545, 21);
            txtTelefono.TabIndex = 16;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(191, 465);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.ReadOnly = true;
            txtDireccion.Size = new Size(533, 21);
            txtDireccion.TabIndex = 15;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(295, 407);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.ReadOnly = true;
            txtCorreo.Size = new Size(429, 21);
            txtCorreo.TabIndex = 14;
            // 
            // txtApodo
            // 
            txtApodo.Location = new Point(143, 352);
            txtApodo.Name = "txtApodo";
            txtApodo.ReadOnly = true;
            txtApodo.Size = new Size(581, 21);
            txtApodo.TabIndex = 13;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(155, 236);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(569, 21);
            txtNombre.TabIndex = 12;
            // 
            // btnCambiarFoto
            // 
            btnCambiarFoto.BackColor = Color.FromArgb(178, 242, 187);
            btnCambiarFoto.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnCambiarFoto.Location = new Point(295, 92);
            btnCambiarFoto.Name = "btnCambiarFoto";
            btnCambiarFoto.Size = new Size(121, 52);
            btnCambiarFoto.TabIndex = 11;
            btnCambiarFoto.Text = "Cambiar";
            btnCambiarFoto.UseVisualStyleBackColor = false;
            btnCambiarFoto.Click += btnCambiarFoto_Click;
            // 
            // btnCambiarTel
            // 
            btnCambiarTel.BackColor = Color.FromArgb(178, 242, 187);
            btnCambiarTel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnCambiarTel.Location = new Point(770, 508);
            btnCambiarTel.Name = "btnCambiarTel";
            btnCambiarTel.Size = new Size(121, 52);
            btnCambiarTel.TabIndex = 10;
            btnCambiarTel.Text = "Cambiar";
            btnCambiarTel.UseVisualStyleBackColor = false;
            btnCambiarTel.Click += btnCambiarTel_Click;
            // 
            // btnCambiarDir
            // 
            btnCambiarDir.BackColor = Color.FromArgb(178, 242, 187);
            btnCambiarDir.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnCambiarDir.Location = new Point(770, 450);
            btnCambiarDir.Name = "btnCambiarDir";
            btnCambiarDir.Size = new Size(121, 52);
            btnCambiarDir.TabIndex = 9;
            btnCambiarDir.Text = "Cambiar";
            btnCambiarDir.UseVisualStyleBackColor = false;
            btnCambiarDir.Click += btnCambiarDir_Click;
            // 
            // btnCambiarCorreo
            // 
            btnCambiarCorreo.BackColor = Color.FromArgb(178, 242, 187);
            btnCambiarCorreo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnCambiarCorreo.Location = new Point(770, 392);
            btnCambiarCorreo.Name = "btnCambiarCorreo";
            btnCambiarCorreo.Size = new Size(121, 52);
            btnCambiarCorreo.TabIndex = 8;
            btnCambiarCorreo.Text = "Cambiar";
            btnCambiarCorreo.UseVisualStyleBackColor = false;
            btnCambiarCorreo.Click += btnCambiarCorreo_Click;
            // 
            // btnCambiarApodo
            // 
            btnCambiarApodo.BackColor = Color.FromArgb(178, 242, 187);
            btnCambiarApodo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnCambiarApodo.Location = new Point(770, 337);
            btnCambiarApodo.Name = "btnCambiarApodo";
            btnCambiarApodo.Size = new Size(121, 52);
            btnCambiarApodo.TabIndex = 7;
            btnCambiarApodo.Text = "Cambiar";
            btnCambiarApodo.UseVisualStyleBackColor = false;
            btnCambiarApodo.Click += btnCambiarApodo_Click;
            // 
            // btnCambiarNom
            // 
            btnCambiarNom.BackColor = Color.FromArgb(178, 242, 187);
            btnCambiarNom.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnCambiarNom.Location = new Point(770, 221);
            btnCambiarNom.Name = "btnCambiarNom";
            btnCambiarNom.Size = new Size(121, 52);
            btnCambiarNom.TabIndex = 4;
            btnCambiarNom.Text = "Cambiar";
            btnCambiarNom.UseVisualStyleBackColor = false;
            btnCambiarNom.Click += btnCambiarNom_Click;
            // 
            // lblNivel
            // 
            lblNivel.AutoSize = true;
            lblNivel.Font = new Font("Microsoft Sans Serif", 24F);
            lblNivel.Location = new Point(762, 72);
            lblNivel.Name = "lblNivel";
            lblNivel.Size = new Size(87, 37);
            lblNivel.TabIndex = 6;
            lblNivel.Text = "Nivel";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Microsoft Sans Serif", 12F);
            lblTelefono.Location = new Point(53, 521);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(75, 20);
            lblTelefono.TabIndex = 5;
            lblTelefono.Text = "Teléfono:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Microsoft Sans Serif", 12F);
            lblDireccion.Location = new Point(53, 463);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(79, 20);
            lblDireccion.TabIndex = 4;
            lblDireccion.Text = "Dirección:";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Microsoft Sans Serif", 12F);
            lblCorreo.Location = new Point(53, 405);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(144, 20);
            lblCorreo.TabIndex = 3;
            lblCorreo.Text = "Correo Electrónico:";
            // 
            // lblApodo
            // 
            lblApodo.AutoSize = true;
            lblApodo.Font = new Font("Microsoft Sans Serif", 12F);
            lblApodo.Location = new Point(53, 350);
            lblApodo.Name = "lblApodo";
            lblApodo.Size = new Size(60, 20);
            lblApodo.TabIndex = 2;
            lblApodo.Text = "Apodo:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Microsoft Sans Serif", 12F);
            lblNombre.Location = new Point(53, 234);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(69, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // picFoto
            // 
            picFoto.Location = new Point(77, 40);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(160, 160);
            picFoto.TabIndex = 0;
            picFoto.TabStop = false;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(170, 166, 202);
            btnCerrarSesion.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnCerrarSesion.Location = new Point(995, 729);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(198, 52);
            btnCerrarSesion.TabIndex = 2;
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // barraSecundaria1
            // 
            barraSecundaria1.BackColor = Color.FromArgb(211, 208, 242);
            barraSecundaria1.Dock = DockStyle.Top;
            barraSecundaria1.Location = new Point(0, 40);
            barraSecundaria1.Name = "barraSecundaria1";
            barraSecundaria1.Size = new Size(1839, 35);
            barraSecundaria1.TabIndex = 3;
            // 
            // barraLateral1
            // 
            barraLateral1.BackColor = Color.FromArgb(205, 213, 221);
            barraLateral1.Dock = DockStyle.Left;
            barraLateral1.Location = new Point(0, 75);
            barraLateral1.Name = "barraLateral1";
            barraLateral1.Size = new Size(231, 825);
            barraLateral1.TabIndex = 4;
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1839, 900);
            Controls.Add(barraLateral1);
            Controls.Add(barraSecundaria1);
            Controls.Add(btnCerrarSesion);
            Controls.Add(grpCuenta);
            Controls.Add(lblTuCuenta);
            Font = new Font("Microsoft Sans Serif", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmUsuario";
            Controls.SetChildIndex(lblTuCuenta, 0);
            Controls.SetChildIndex(grpCuenta, 0);
            Controls.SetChildIndex(btnCerrarSesion, 0);
            Controls.SetChildIndex(barraSecundaria1, 0);
            Controls.SetChildIndex(barraLateral1, 0);
            grpCuenta.ResumeLayout(false);
            grpCuenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTuCuenta;
        private GroupBox grpCuenta;
        private PictureBox picFoto;
        private Button btnCerrarSesion;
        private Label lblNombre;
        private Label lblCorreo;
        private Label lblApodo;
        private Label lblTelefono;
        private Label lblDireccion;
        private Button btnCambiarNom;
        private Label lblNivel;
        private Button btnCambiarFoto;
        private Button btnCambiarTel;
        private Button btnCambiarDir;
        private Button btnCambiarCorreo;
        private Button btnCambiarApodo;
        private Button btnConfirmarNom;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtCorreo;
        private TextBox txtApodo;
        private TextBox txtNombre;
        private ErrorProvider errorProvider1;
        private Button btnConfirmarTel;
        private Button btnConfirmarDir;
        private Button btnConfirmarCorreo;
        private Button btnConfirmarApodo;
        private Button btnConfirmarApellidos;
        private TextBox txtApellidos;
        private Button btnCambiarApellidos;
        private Label lblApellidos;
        private Button btnConfirmarFoto;
        private Herramientas.BarraLateral barraLateral1;
        private Herramientas.BarraSecundaria barraSecundaria1;
    }
}