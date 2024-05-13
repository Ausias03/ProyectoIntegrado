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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            lblTuCuenta = new Label();
            grpCuenta = new GroupBox();
            btnCambiarNom = new Button();
            lblNivel = new Label();
            lblTelefono = new Label();
            lblDireccion = new Label();
            lblCorreo = new Label();
            lblApodo = new Label();
            lblNombreApellidos = new Label();
            picFoto = new PictureBox();
            btnCerrarSesion = new Button();
            grpBotones = new GroupBox();
            picTema = new PictureBox();
            picAyuda = new PictureBox();
            cmbIdiomas = new ComboBox();
            picMenuLateral = new PictureBox();
            picNoticias = new PictureBox();
            picNotificaciones = new PictureBox();
            picCuenta = new PictureBox();
            btnCambiarApodo = new Button();
            btnCambiarCorreo = new Button();
            btnCambiarDir = new Button();
            btnCambiarTel = new Button();
            btnCambiarFoto = new Button();
            grpCuenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            grpBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTema).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAyuda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMenuLateral).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picNoticias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picNotificaciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCuenta).BeginInit();
            SuspendLayout();
            // 
            // lblTuCuenta
            // 
            lblTuCuenta.AutoSize = true;
            lblTuCuenta.Font = new Font("Roboto Mono", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblTuCuenta.Location = new Point(31, 39);
            lblTuCuenta.Name = "lblTuCuenta";
            lblTuCuenta.Size = new Size(239, 53);
            lblTuCuenta.TabIndex = 0;
            lblTuCuenta.Text = "Tu cuenta";
            // 
            // grpCuenta
            // 
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
            grpCuenta.Controls.Add(lblNombreApellidos);
            grpCuenta.Controls.Add(picFoto);
            grpCuenta.Location = new Point(105, 95);
            grpCuenta.Name = "grpCuenta";
            grpCuenta.Size = new Size(998, 543);
            grpCuenta.TabIndex = 1;
            grpCuenta.TabStop = false;
            // 
            // btnCambiarNom
            // 
            btnCambiarNom.BackColor = Color.FromArgb(178, 242, 187);
            btnCambiarNom.Font = new Font("Roboto Mono", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCambiarNom.Location = new Point(771, 221);
            btnCambiarNom.Name = "btnCambiarNom";
            btnCambiarNom.Size = new Size(121, 52);
            btnCambiarNom.TabIndex = 4;
            btnCambiarNom.Text = "Cambiar";
            btnCambiarNom.UseVisualStyleBackColor = false;
            // 
            // lblNivel
            // 
            lblNivel.AutoSize = true;
            lblNivel.Font = new Font("Roboto Mono", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblNivel.Location = new Point(762, 72);
            lblNivel.Name = "lblNivel";
            lblNivel.Size = new Size(143, 53);
            lblNivel.TabIndex = 6;
            lblNivel.Text = "Nivel";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Roboto Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTelefono.Location = new Point(53, 460);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(120, 26);
            lblTelefono.TabIndex = 5;
            lblTelefono.Text = "Teléfono:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Roboto Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDireccion.Location = new Point(53, 402);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(132, 26);
            lblDireccion.TabIndex = 4;
            lblDireccion.Text = "Dirección:";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Roboto Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCorreo.Location = new Point(53, 344);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(240, 26);
            lblCorreo.TabIndex = 3;
            lblCorreo.Text = "Correo Electrónico:";
            // 
            // lblApodo
            // 
            lblApodo.AutoSize = true;
            lblApodo.Font = new Font("Roboto Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblApodo.Location = new Point(53, 289);
            lblApodo.Name = "lblApodo";
            lblApodo.Size = new Size(84, 26);
            lblApodo.TabIndex = 2;
            lblApodo.Text = "Apodo:";
            // 
            // lblNombreApellidos
            // 
            lblNombreApellidos.AutoSize = true;
            lblNombreApellidos.Font = new Font("Roboto Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreApellidos.Location = new Point(53, 234);
            lblNombreApellidos.Name = "lblNombreApellidos";
            lblNombreApellidos.Size = new Size(240, 26);
            lblNombreApellidos.TabIndex = 1;
            lblNombreApellidos.Text = "Nombre y Apellidos:";
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
            btnCerrarSesion.BackColor = Color.FromArgb(178, 242, 187);
            btnCerrarSesion.Font = new Font("Roboto Mono", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrarSesion.Location = new Point(980, 647);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(198, 52);
            btnCerrarSesion.TabIndex = 2;
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // grpBotones
            // 
            grpBotones.BackColor = Color.FromArgb(211, 208, 242);
            grpBotones.Controls.Add(picTema);
            grpBotones.Controls.Add(picAyuda);
            grpBotones.Controls.Add(cmbIdiomas);
            grpBotones.Controls.Add(picMenuLateral);
            grpBotones.Controls.Add(picNoticias);
            grpBotones.Controls.Add(picNotificaciones);
            grpBotones.Controls.Add(picCuenta);
            grpBotones.Location = new Point(-12, -16);
            grpBotones.Name = "grpBotones";
            grpBotones.Size = new Size(1372, 52);
            grpBotones.TabIndex = 3;
            grpBotones.TabStop = false;
            // 
            // picTema
            // 
            picTema.Location = new Point(134, 26);
            picTema.Name = "picTema";
            picTema.Size = new Size(20, 20);
            picTema.TabIndex = 8;
            picTema.TabStop = false;
            // 
            // picAyuda
            // 
            picAyuda.Location = new Point(50, 26);
            picAyuda.Name = "picAyuda";
            picAyuda.Size = new Size(20, 20);
            picAyuda.TabIndex = 8;
            picAyuda.TabStop = false;
            // 
            // cmbIdiomas
            // 
            cmbIdiomas.FormattingEnabled = true;
            cmbIdiomas.Items.AddRange(new object[] { "ES", "VAL", "EN" });
            cmbIdiomas.Location = new Point(76, 22);
            cmbIdiomas.Name = "cmbIdiomas";
            cmbIdiomas.Size = new Size(52, 28);
            cmbIdiomas.TabIndex = 4;
            cmbIdiomas.Text = "ES";
            // 
            // picMenuLateral
            // 
            picMenuLateral.Location = new Point(24, 26);
            picMenuLateral.Name = "picMenuLateral";
            picMenuLateral.Size = new Size(20, 20);
            picMenuLateral.TabIndex = 8;
            picMenuLateral.TabStop = false;
            // 
            // picNoticias
            // 
            picNoticias.Location = new Point(1140, 26);
            picNoticias.Name = "picNoticias";
            picNoticias.Size = new Size(20, 20);
            picNoticias.TabIndex = 8;
            picNoticias.TabStop = false;
            // 
            // picNotificaciones
            // 
            picNotificaciones.Location = new Point(1166, 26);
            picNotificaciones.Name = "picNotificaciones";
            picNotificaciones.Size = new Size(20, 20);
            picNotificaciones.TabIndex = 8;
            picNotificaciones.TabStop = false;
            // 
            // picCuenta
            // 
            picCuenta.Location = new Point(1192, 26);
            picCuenta.Name = "picCuenta";
            picCuenta.Size = new Size(20, 20);
            picCuenta.TabIndex = 7;
            picCuenta.TabStop = false;
            // 
            // btnCambiarApodo
            // 
            btnCambiarApodo.BackColor = Color.FromArgb(178, 242, 187);
            btnCambiarApodo.Font = new Font("Roboto Mono", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCambiarApodo.Location = new Point(771, 276);
            btnCambiarApodo.Name = "btnCambiarApodo";
            btnCambiarApodo.Size = new Size(121, 52);
            btnCambiarApodo.TabIndex = 7;
            btnCambiarApodo.Text = "Cambiar";
            btnCambiarApodo.UseVisualStyleBackColor = false;
            // 
            // btnCambiarCorreo
            // 
            btnCambiarCorreo.BackColor = Color.FromArgb(178, 242, 187);
            btnCambiarCorreo.Font = new Font("Roboto Mono", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCambiarCorreo.Location = new Point(771, 331);
            btnCambiarCorreo.Name = "btnCambiarCorreo";
            btnCambiarCorreo.Size = new Size(121, 52);
            btnCambiarCorreo.TabIndex = 8;
            btnCambiarCorreo.Text = "Cambiar";
            btnCambiarCorreo.UseVisualStyleBackColor = false;
            // 
            // btnCambiarDir
            // 
            btnCambiarDir.BackColor = Color.FromArgb(178, 242, 187);
            btnCambiarDir.Font = new Font("Roboto Mono", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCambiarDir.Location = new Point(771, 389);
            btnCambiarDir.Name = "btnCambiarDir";
            btnCambiarDir.Size = new Size(121, 52);
            btnCambiarDir.TabIndex = 9;
            btnCambiarDir.Text = "Cambiar";
            btnCambiarDir.UseVisualStyleBackColor = false;
            // 
            // btnCambiarTel
            // 
            btnCambiarTel.BackColor = Color.FromArgb(178, 242, 187);
            btnCambiarTel.Font = new Font("Roboto Mono", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCambiarTel.Location = new Point(771, 447);
            btnCambiarTel.Name = "btnCambiarTel";
            btnCambiarTel.Size = new Size(121, 52);
            btnCambiarTel.TabIndex = 10;
            btnCambiarTel.Text = "Cambiar";
            btnCambiarTel.UseVisualStyleBackColor = false;
            // 
            // btnCambiarFoto
            // 
            btnCambiarFoto.BackColor = Color.FromArgb(178, 242, 187);
            btnCambiarFoto.Font = new Font("Roboto Mono", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCambiarFoto.Location = new Point(295, 92);
            btnCambiarFoto.Name = "btnCambiarFoto";
            btnCambiarFoto.Size = new Size(121, 52);
            btnCambiarFoto.TabIndex = 11;
            btnCambiarFoto.Text = "Cambiar";
            btnCambiarFoto.UseVisualStyleBackColor = false;
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 711);
            Controls.Add(grpBotones);
            Controls.Add(btnCerrarSesion);
            Controls.Add(grpCuenta);
            Controls.Add(lblTuCuenta);
            Font = new Font("Roboto Mono", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmUsuario";
            Text = "Ge$tioni$";
            grpCuenta.ResumeLayout(false);
            grpCuenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            grpBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picTema).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAyuda).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMenuLateral).EndInit();
            ((System.ComponentModel.ISupportInitialize)picNoticias).EndInit();
            ((System.ComponentModel.ISupportInitialize)picNotificaciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCuenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTuCuenta;
        private GroupBox grpCuenta;
        private PictureBox picFoto;
        private Button btnCerrarSesion;
        private Label lblNombreApellidos;
        private GroupBox grpBotones;
        private Label lblCorreo;
        private Label lblApodo;
        private Label lblTelefono;
        private Label lblDireccion;
        private Button btnCambiarNom;
        private Label lblNivel;
        private PictureBox picAyuda;
        private ComboBox cmbIdiomas;
        private PictureBox picMenuLateral;
        private PictureBox picNoticias;
        private PictureBox picNotificaciones;
        private PictureBox picCuenta;
        private PictureBox picTema;
        private Button btnCambiarFoto;
        private Button btnCambiarTel;
        private Button btnCambiarDir;
        private Button btnCambiarCorreo;
        private Button btnCambiarApodo;
    }
}