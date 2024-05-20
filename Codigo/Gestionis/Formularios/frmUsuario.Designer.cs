using Gestionis.Herramientas;

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
            lblTuCuenta = new Label();
            btnCerrarSesion = new Button();
            errorProvider1 = new ErrorProvider(components);
            grpCuenta = new RoundGroupBox();
            lblNivel = new Label();
            lblExp = new Label();
            prbExperiencia = new ProgressBar();
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
            lblTelefono = new Label();
            lblDireccion = new Label();
            lblCorreo = new Label();
            lblApodo = new Label();
            lblNombre = new Label();
            picFoto = new PictureBox();
            barraSecundaria1 = new BarraSecundaria();
            barraLateral1 = new BarraLateral();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            grpCuenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            SuspendLayout();
            // 
            // lblTuCuenta
            // 
            lblTuCuenta.AutoSize = true;
            lblTuCuenta.Font = new Font("Microsoft Sans Serif", 24F);
            lblTuCuenta.Location = new Point(309, 102);
            lblTuCuenta.Name = "lblTuCuenta";
            lblTuCuenta.Size = new Size(197, 46);
            lblTuCuenta.TabIndex = 0;
            lblTuCuenta.Text = "Tu cuenta";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(170, 166, 202);
            btnCerrarSesion.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnCerrarSesion.Location = new Point(1271, 753);
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
            // grpCuenta
            // 
            grpCuenta.BackColor = Color.Transparent;
            grpCuenta.Controls.Add(lblNivel);
            grpCuenta.Controls.Add(lblExp);
            grpCuenta.Controls.Add(prbExperiencia);
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
            grpCuenta.Controls.Add(lblTelefono);
            grpCuenta.Controls.Add(lblDireccion);
            grpCuenta.Controls.Add(lblCorreo);
            grpCuenta.Controls.Add(lblApodo);
            grpCuenta.Controls.Add(lblNombre);
            grpCuenta.Controls.Add(picFoto);
            grpCuenta.ForeColor = SystemColors.ControlText;
            grpCuenta.Location = new Point(383, 168);
            grpCuenta.Name = "grpCuenta";
            grpCuenta.Size = new Size(963, 579);
            grpCuenta.TabIndex = 4;
            grpCuenta.TabStop = false;
            grpCuenta.Text = "roundGroupBox1";
            // 
            // lblNivel
            // 
            lblNivel.AutoSize = true;
            lblNivel.Font = new Font("Microsoft Sans Serif", 24F);
            lblNivel.Location = new Point(747, 60);
            lblNivel.Name = "lblNivel";
            lblNivel.Size = new Size(42, 46);
            lblNivel.TabIndex = 34;
            lblNivel.Text = "5";
            // 
            // lblExp
            // 
            lblExp.AutoSize = true;
            lblExp.Font = new Font("Microsoft Sans Serif", 12F);
            lblExp.Location = new Point(622, 121);
            lblExp.Name = "lblExp";
            lblExp.Size = new Size(52, 25);
            lblExp.TabIndex = 56;
            lblExp.Text = "Exp:";
            // 
            // prbExperiencia
            // 
            prbExperiencia.Location = new Point(685, 124);
            prbExperiencia.Name = "prbExperiencia";
            prbExperiencia.Size = new Size(174, 19);
            prbExperiencia.TabIndex = 55;
            // 
            // btnConfirmarFoto
            // 
            btnConfirmarFoto.BackColor = Color.FromArgb(178, 242, 187);
            btnConfirmarFoto.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnConfirmarFoto.Location = new Point(283, 81);
            btnConfirmarFoto.Name = "btnConfirmarFoto";
            btnConfirmarFoto.Size = new Size(135, 52);
            btnConfirmarFoto.TabIndex = 54;
            btnConfirmarFoto.Text = "Confirmar";
            btnConfirmarFoto.UseVisualStyleBackColor = false;
            btnConfirmarFoto.Visible = false;
            btnConfirmarFoto.Click += btnConfirmarFoto_Click;
            // 
            // btnConfirmarApellidos
            // 
            btnConfirmarApellidos.BackColor = Color.FromArgb(178, 242, 187);
            btnConfirmarApellidos.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnConfirmarApellidos.Location = new Point(764, 268);
            btnConfirmarApellidos.Name = "btnConfirmarApellidos";
            btnConfirmarApellidos.Size = new Size(135, 52);
            btnConfirmarApellidos.TabIndex = 53;
            btnConfirmarApellidos.Text = "Confirmar";
            btnConfirmarApellidos.UseVisualStyleBackColor = false;
            btnConfirmarApellidos.Visible = false;
            btnConfirmarApellidos.Click += BtnConfirmarApellidos_Click;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(193, 283);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.ReadOnly = true;
            txtApellidos.Size = new Size(533, 24);
            txtApellidos.TabIndex = 52;
            // 
            // btnCambiarApellidos
            // 
            btnCambiarApellidos.BackColor = Color.FromArgb(178, 242, 187);
            btnCambiarApellidos.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnCambiarApellidos.Location = new Point(772, 268);
            btnCambiarApellidos.Name = "btnCambiarApellidos";
            btnCambiarApellidos.Size = new Size(121, 52);
            btnCambiarApellidos.TabIndex = 51;
            btnCambiarApellidos.Text = "Cambiar";
            btnCambiarApellidos.UseVisualStyleBackColor = false;
            btnCambiarApellidos.Click += BtnCambiarApellidos_Click;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Font = new Font("Microsoft Sans Serif", 12F);
            lblApellidos.Location = new Point(55, 281);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(98, 25);
            lblApellidos.TabIndex = 50;
            lblApellidos.Text = "Apellidos:";
            // 
            // btnConfirmarTel
            // 
            btnConfirmarTel.BackColor = Color.FromArgb(178, 242, 187);
            btnConfirmarTel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnConfirmarTel.Location = new Point(764, 497);
            btnConfirmarTel.Name = "btnConfirmarTel";
            btnConfirmarTel.Size = new Size(135, 52);
            btnConfirmarTel.TabIndex = 49;
            btnConfirmarTel.Text = "Confirmar";
            btnConfirmarTel.UseVisualStyleBackColor = false;
            btnConfirmarTel.Visible = false;
            btnConfirmarTel.Click += BtnConfirmarTel_Click;
            // 
            // btnConfirmarDir
            // 
            btnConfirmarDir.BackColor = Color.FromArgb(178, 242, 187);
            btnConfirmarDir.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnConfirmarDir.Location = new Point(764, 439);
            btnConfirmarDir.Name = "btnConfirmarDir";
            btnConfirmarDir.Size = new Size(135, 52);
            btnConfirmarDir.TabIndex = 48;
            btnConfirmarDir.Text = "Confirmar";
            btnConfirmarDir.UseVisualStyleBackColor = false;
            btnConfirmarDir.Visible = false;
            btnConfirmarDir.Click += BtnConfirmarDir_Click;
            // 
            // btnConfirmarCorreo
            // 
            btnConfirmarCorreo.BackColor = Color.FromArgb(178, 242, 187);
            btnConfirmarCorreo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnConfirmarCorreo.Location = new Point(764, 381);
            btnConfirmarCorreo.Name = "btnConfirmarCorreo";
            btnConfirmarCorreo.Size = new Size(135, 52);
            btnConfirmarCorreo.TabIndex = 47;
            btnConfirmarCorreo.Text = "Confirmar";
            btnConfirmarCorreo.UseVisualStyleBackColor = false;
            btnConfirmarCorreo.Visible = false;
            btnConfirmarCorreo.Click += BtnConfirmarCorreo_Click;
            // 
            // btnConfirmarApodo
            // 
            btnConfirmarApodo.BackColor = Color.FromArgb(178, 242, 187);
            btnConfirmarApodo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnConfirmarApodo.Location = new Point(764, 326);
            btnConfirmarApodo.Name = "btnConfirmarApodo";
            btnConfirmarApodo.Size = new Size(135, 52);
            btnConfirmarApodo.TabIndex = 46;
            btnConfirmarApodo.Text = "Confirmar";
            btnConfirmarApodo.UseVisualStyleBackColor = false;
            btnConfirmarApodo.Visible = false;
            btnConfirmarApodo.Click += BtnConfirmarApodo_Click;
            // 
            // btnConfirmarNom
            // 
            btnConfirmarNom.BackColor = Color.FromArgb(178, 242, 187);
            btnConfirmarNom.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnConfirmarNom.Location = new Point(764, 210);
            btnConfirmarNom.Name = "btnConfirmarNom";
            btnConfirmarNom.Size = new Size(135, 52);
            btnConfirmarNom.TabIndex = 45;
            btnConfirmarNom.Text = "Confirmar";
            btnConfirmarNom.UseVisualStyleBackColor = false;
            btnConfirmarNom.Visible = false;
            btnConfirmarNom.Click += btnConfirmarNom_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(181, 509);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.ReadOnly = true;
            txtTelefono.Size = new Size(545, 24);
            txtTelefono.TabIndex = 44;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(193, 454);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.ReadOnly = true;
            txtDireccion.Size = new Size(533, 24);
            txtDireccion.TabIndex = 43;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(297, 396);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.ReadOnly = true;
            txtCorreo.Size = new Size(429, 24);
            txtCorreo.TabIndex = 42;
            // 
            // txtApodo
            // 
            txtApodo.Location = new Point(145, 341);
            txtApodo.Name = "txtApodo";
            txtApodo.ReadOnly = true;
            txtApodo.Size = new Size(581, 24);
            txtApodo.TabIndex = 41;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(157, 225);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(569, 24);
            txtNombre.TabIndex = 40;
            // 
            // btnCambiarFoto
            // 
            btnCambiarFoto.BackColor = Color.FromArgb(178, 242, 187);
            btnCambiarFoto.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnCambiarFoto.Location = new Point(297, 81);
            btnCambiarFoto.Name = "btnCambiarFoto";
            btnCambiarFoto.Size = new Size(121, 52);
            btnCambiarFoto.TabIndex = 39;
            btnCambiarFoto.Text = "Cambiar";
            btnCambiarFoto.UseVisualStyleBackColor = false;
            btnCambiarFoto.Click += btnCambiarFoto_Click;
            // 
            // btnCambiarTel
            // 
            btnCambiarTel.BackColor = Color.FromArgb(178, 242, 187);
            btnCambiarTel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnCambiarTel.Location = new Point(772, 497);
            btnCambiarTel.Name = "btnCambiarTel";
            btnCambiarTel.Size = new Size(121, 52);
            btnCambiarTel.TabIndex = 38;
            btnCambiarTel.Text = "Cambiar";
            btnCambiarTel.UseVisualStyleBackColor = false;
            btnCambiarTel.Click += btnCambiarTel_Click;
            // 
            // btnCambiarDir
            // 
            btnCambiarDir.BackColor = Color.FromArgb(178, 242, 187);
            btnCambiarDir.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnCambiarDir.Location = new Point(772, 439);
            btnCambiarDir.Name = "btnCambiarDir";
            btnCambiarDir.Size = new Size(121, 52);
            btnCambiarDir.TabIndex = 37;
            btnCambiarDir.Text = "Cambiar";
            btnCambiarDir.UseVisualStyleBackColor = false;
            btnCambiarDir.Click += btnCambiarDir_Click;
            // 
            // btnCambiarCorreo
            // 
            btnCambiarCorreo.BackColor = Color.FromArgb(178, 242, 187);
            btnCambiarCorreo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnCambiarCorreo.Location = new Point(772, 381);
            btnCambiarCorreo.Name = "btnCambiarCorreo";
            btnCambiarCorreo.Size = new Size(121, 52);
            btnCambiarCorreo.TabIndex = 36;
            btnCambiarCorreo.Text = "Cambiar";
            btnCambiarCorreo.UseVisualStyleBackColor = false;
            btnCambiarCorreo.Click += btnCambiarCorreo_Click;
            // 
            // btnCambiarApodo
            // 
            btnCambiarApodo.BackColor = Color.FromArgb(178, 242, 187);
            btnCambiarApodo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnCambiarApodo.Location = new Point(772, 326);
            btnCambiarApodo.Name = "btnCambiarApodo";
            btnCambiarApodo.Size = new Size(121, 52);
            btnCambiarApodo.TabIndex = 35;
            btnCambiarApodo.Text = "Cambiar";
            btnCambiarApodo.UseVisualStyleBackColor = false;
            btnCambiarApodo.Click += btnCambiarApodo_Click;
            // 
            // btnCambiarNom
            // 
            btnCambiarNom.BackColor = Color.FromArgb(178, 242, 187);
            btnCambiarNom.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnCambiarNom.Location = new Point(772, 210);
            btnCambiarNom.Name = "btnCambiarNom";
            btnCambiarNom.Size = new Size(121, 52);
            btnCambiarNom.TabIndex = 32;
            btnCambiarNom.Text = "Cambiar";
            btnCambiarNom.UseVisualStyleBackColor = false;
            btnCambiarNom.Click += btnCambiarNom_Click;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Microsoft Sans Serif", 12F);
            lblTelefono.Location = new Point(55, 510);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(95, 25);
            lblTelefono.TabIndex = 33;
            lblTelefono.Text = "Teléfono:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Microsoft Sans Serif", 12F);
            lblDireccion.Location = new Point(55, 452);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(99, 25);
            lblDireccion.TabIndex = 31;
            lblDireccion.Text = "Dirección:";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Microsoft Sans Serif", 12F);
            lblCorreo.Location = new Point(55, 394);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(179, 25);
            lblCorreo.TabIndex = 30;
            lblCorreo.Text = "Correo Electrónico:";
            // 
            // lblApodo
            // 
            lblApodo.AutoSize = true;
            lblApodo.Font = new Font("Microsoft Sans Serif", 12F);
            lblApodo.Location = new Point(55, 339);
            lblApodo.Name = "lblApodo";
            lblApodo.Size = new Size(76, 25);
            lblApodo.TabIndex = 29;
            lblApodo.Text = "Apodo:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Microsoft Sans Serif", 12F);
            lblNombre.Location = new Point(55, 223);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(87, 25);
            lblNombre.TabIndex = 28;
            lblNombre.Text = "Nombre:";
            // 
            // picFoto
            // 
            picFoto.Location = new Point(79, 29);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(160, 160);
            picFoto.TabIndex = 27;
            picFoto.TabStop = false;
            // 
            // barraSecundaria1
            // 
            barraSecundaria1.BackColor = Color.FromArgb(211, 208, 242);
            barraSecundaria1.Dock = DockStyle.Top;
            barraSecundaria1.Location = new Point(0, 40);
            barraSecundaria1.Name = "barraSecundaria1";
            barraSecundaria1.Size = new Size(1818, 44);
            barraSecundaria1.TabIndex = 5;
            // 
            // barraLateral1
            // 
            barraLateral1.BackColor = Color.FromArgb(205, 213, 221);
            barraLateral1.Dock = DockStyle.Left;
            barraLateral1.Location = new Point(0, 84);
            barraLateral1.Name = "barraLateral1";
            barraLateral1.Size = new Size(289, 753);
            barraLateral1.TabIndex = 6;
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 236, 239);
            ClientSize = new Size(1818, 837);
            Controls.Add(barraLateral1);
            Controls.Add(barraSecundaria1);
            Controls.Add(grpCuenta);
            Controls.Add(btnCerrarSesion);
            Controls.Add(lblTuCuenta);
            Font = new Font("Microsoft Sans Serif", 9F);
            Name = "frmUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += frmUsuario_Load;
            Controls.SetChildIndex(lblTuCuenta, 0);
            Controls.SetChildIndex(btnCerrarSesion, 0);
            Controls.SetChildIndex(grpCuenta, 0);
            Controls.SetChildIndex(barraSecundaria1, 0);
            Controls.SetChildIndex(barraLateral1, 0);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            grpCuenta.ResumeLayout(false);
            grpCuenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnConfirmarApodo_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnConfirmarCorreo_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnConfirmarDir_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnConfirmarTel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnCambiarApellidos_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnConfirmarApellidos_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblTuCuenta;
        private Button btnCerrarSesion;
        private ErrorProvider errorProvider1;
        private RoundGroupBox grpCuenta;
        private Button btnConfirmarFoto;
        private Button btnConfirmarApellidos;
        private TextBox txtApellidos;
        private Button btnCambiarApellidos;
        private Label lblApellidos;
        private Button btnConfirmarTel;
        private Button btnConfirmarDir;
        private Button btnConfirmarCorreo;
        private Button btnConfirmarApodo;
        private Button btnConfirmarNom;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtCorreo;
        private TextBox txtApodo;
        private TextBox txtNombre;
        private Button btnCambiarFoto;
        private Button btnCambiarTel;
        private Button btnCambiarDir;
        private Button btnCambiarCorreo;
        private Button btnCambiarApodo;
        private Button btnCambiarNom;
        private Label lblTelefono;
        private Label lblDireccion;
        private Label lblCorreo;
        private Label lblApodo;
        private Label lblNombre;
        private PictureBox picFoto;
        private BarraLateral barraLateral1;
        private BarraSecundaria barraSecundaria1;
        private ProgressBar prbExperiencia;
        private Label lblExp;
        private Label lblNivel;
    }
}