using Gestionis.Herramientas;

namespace Gestionis
{
    partial class frmNotas
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
            pnlBarra = new Panel();
            pbSpain = new PictureBox();
            pbAyuda = new PictureBox();
            pbUsuario = new PictureBox();
            pbNotificaciones = new PictureBox();
            pbNoticias = new PictureBox();
            pbTema = new PictureBox();
            pbEnglish = new PictureBox();
            pbHamburger = new PictureBox();
            grbNotasDia = new GroupBox();
            roundGroupBox1 = new RoundGroupBox();
            lblAdelante = new Label();
            lblAtras = new Label();
            lblMes = new Label();
            label3 = new Label();
            roundGroupBox2 = new RoundGroupBox();
            dtgNotas = new DataGridView();
            cmbFiltrarPor = new ComboBox();
            lblFiltrarPor = new Label();
            btnNuevaNota = new Button();
            btnSalir = new Button();
            pnlBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSpain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAyuda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNotificaciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNoticias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTema).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEnglish).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHamburger).BeginInit();
            roundGroupBox1.SuspendLayout();
            roundGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgNotas).BeginInit();
            SuspendLayout();
            // 
            // pnlBarra
            // 
            pnlBarra.BackColor = Color.FromArgb(211, 208, 242);
            pnlBarra.Controls.Add(pbSpain);
            pnlBarra.Controls.Add(pbAyuda);
            pnlBarra.Controls.Add(pbUsuario);
            pnlBarra.Controls.Add(pbNotificaciones);
            pnlBarra.Controls.Add(pbNoticias);
            pnlBarra.Controls.Add(pbTema);
            pnlBarra.Controls.Add(pbEnglish);
            pnlBarra.Controls.Add(pbHamburger);
            pnlBarra.Dock = DockStyle.Top;
            pnlBarra.Location = new Point(0, 0);
            pnlBarra.Name = "pnlBarra";
            pnlBarra.Size = new Size(1268, 41);
            pnlBarra.TabIndex = 3;
            // 
            // pbSpain
            // 
            pbSpain.Enabled = false;
            pbSpain.Location = new Point(91, 6);
            pbSpain.Margin = new Padding(3, 4, 3, 4);
            pbSpain.Name = "pbSpain";
            pbSpain.Size = new Size(33, 31);
            pbSpain.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSpain.TabIndex = 24;
            pbSpain.TabStop = false;
            // 
            // pbAyuda
            // 
            pbAyuda.Location = new Point(49, 5);
            pbAyuda.Margin = new Padding(3, 4, 3, 4);
            pbAyuda.Name = "pbAyuda";
            pbAyuda.Size = new Size(31, 30);
            pbAyuda.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAyuda.TabIndex = 18;
            pbAyuda.TabStop = false;
            // 
            // pbUsuario
            // 
            pbUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbUsuario.Location = new Point(2503, 5);
            pbUsuario.Margin = new Padding(3, 4, 3, 4);
            pbUsuario.Name = "pbUsuario";
            pbUsuario.Size = new Size(27, 31);
            pbUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUsuario.TabIndex = 23;
            pbUsuario.TabStop = false;
            // 
            // pbNotificaciones
            // 
            pbNotificaciones.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbNotificaciones.Location = new Point(2469, 5);
            pbNotificaciones.Margin = new Padding(3, 4, 3, 4);
            pbNotificaciones.Name = "pbNotificaciones";
            pbNotificaciones.Size = new Size(27, 31);
            pbNotificaciones.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNotificaciones.TabIndex = 22;
            pbNotificaciones.TabStop = false;
            // 
            // pbNoticias
            // 
            pbNoticias.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbNoticias.Location = new Point(2431, 5);
            pbNoticias.Margin = new Padding(3, 4, 3, 4);
            pbNoticias.Name = "pbNoticias";
            pbNoticias.Size = new Size(31, 31);
            pbNoticias.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNoticias.TabIndex = 21;
            pbNoticias.TabStop = false;
            // 
            // pbTema
            // 
            pbTema.Location = new Point(135, 5);
            pbTema.Margin = new Padding(3, 4, 3, 4);
            pbTema.Name = "pbTema";
            pbTema.Size = new Size(32, 31);
            pbTema.SizeMode = PictureBoxSizeMode.StretchImage;
            pbTema.TabIndex = 20;
            pbTema.TabStop = false;
            // 
            // pbEnglish
            // 
            pbEnglish.Location = new Point(94, 5);
            pbEnglish.Margin = new Padding(3, 4, 3, 4);
            pbEnglish.Name = "pbEnglish";
            pbEnglish.Size = new Size(30, 31);
            pbEnglish.SizeMode = PictureBoxSizeMode.CenterImage;
            pbEnglish.TabIndex = 19;
            pbEnglish.TabStop = false;
            // 
            // pbHamburger
            // 
            pbHamburger.Location = new Point(12, 5);
            pbHamburger.Margin = new Padding(3, 4, 3, 4);
            pbHamburger.Name = "pbHamburger";
            pbHamburger.Size = new Size(31, 31);
            pbHamburger.SizeMode = PictureBoxSizeMode.StretchImage;
            pbHamburger.TabIndex = 17;
            pbHamburger.TabStop = false;
            // 
            // grbNotasDia
            // 
            grbNotasDia.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline);
            grbNotasDia.Location = new Point(938, 405);
            grbNotasDia.Name = "grbNotasDia";
            grbNotasDia.Size = new Size(249, 176);
            grbNotasDia.TabIndex = 5;
            grbNotasDia.TabStop = false;
            grbNotasDia.Text = "Notas del día";
            // 
            // roundGroupBox1
            // 
            roundGroupBox1.Controls.Add(lblAdelante);
            roundGroupBox1.Controls.Add(lblAtras);
            roundGroupBox1.Controls.Add(lblMes);
            roundGroupBox1.Controls.Add(label3);
            roundGroupBox1.Font = new Font("Segoe UI", 14.25F);
            roundGroupBox1.Location = new Point(938, 95);
            roundGroupBox1.Name = "roundGroupBox1";
            roundGroupBox1.Size = new Size(249, 161);
            roundGroupBox1.TabIndex = 6;
            roundGroupBox1.TabStop = false;
            roundGroupBox1.Text = "roundGroupBox1";
            // 
            // lblAdelante
            // 
            lblAdelante.AutoSize = true;
            lblAdelante.BackColor = Color.Transparent;
            lblAdelante.Font = new Font("Segoe UI", 14.25F);
            lblAdelante.Location = new Point(159, 10);
            lblAdelante.Name = "lblAdelante";
            lblAdelante.Size = new Size(30, 32);
            lblAdelante.TabIndex = 5;
            lblAdelante.Text = ">";
            // 
            // lblAtras
            // 
            lblAtras.AutoSize = true;
            lblAtras.BackColor = Color.Transparent;
            lblAtras.Font = new Font("Segoe UI", 14.25F);
            lblAtras.Location = new Point(55, 10);
            lblAtras.Name = "lblAtras";
            lblAtras.Size = new Size(30, 32);
            lblAtras.TabIndex = 4;
            lblAtras.Text = "<";
            // 
            // lblMes
            // 
            lblMes.AutoSize = true;
            lblMes.BackColor = Color.Transparent;
            lblMes.Font = new Font("Segoe UI", 14.25F);
            lblMes.Location = new Point(95, 11);
            lblMes.Name = "lblMes";
            lblMes.Size = new Size(59, 32);
            lblMes.TabIndex = 3;
            lblMes.Text = "Mes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(-8, 17);
            label3.Name = "label3";
            label3.Size = new Size(264, 32);
            label3.TabIndex = 2;
            label3.Text = "_________________________";
            // 
            // roundGroupBox2
            // 
            roundGroupBox2.Controls.Add(dtgNotas);
            roundGroupBox2.Controls.Add(cmbFiltrarPor);
            roundGroupBox2.Controls.Add(lblFiltrarPor);
            roundGroupBox2.Controls.Add(btnNuevaNota);
            roundGroupBox2.Location = new Point(94, 95);
            roundGroupBox2.Name = "roundGroupBox2";
            roundGroupBox2.Size = new Size(669, 486);
            roundGroupBox2.TabIndex = 7;
            roundGroupBox2.TabStop = false;
            roundGroupBox2.Text = "roundGroupBox2";
            // 
            // dtgNotas
            // 
            dtgNotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgNotas.Location = new Point(54, 248);
            dtgNotas.Name = "dtgNotas";
            dtgNotas.RowHeadersWidth = 51;
            dtgNotas.Size = new Size(521, 188);
            dtgNotas.TabIndex = 4;
            // 
            // cmbFiltrarPor
            // 
            cmbFiltrarPor.FormattingEnabled = true;
            cmbFiltrarPor.Location = new Point(241, 173);
            cmbFiltrarPor.Name = "cmbFiltrarPor";
            cmbFiltrarPor.Size = new Size(158, 28);
            cmbFiltrarPor.TabIndex = 3;
            // 
            // lblFiltrarPor
            // 
            lblFiltrarPor.AutoSize = true;
            lblFiltrarPor.BackColor = Color.Transparent;
            lblFiltrarPor.Font = new Font("Segoe UI", 14.25F);
            lblFiltrarPor.Location = new Point(54, 169);
            lblFiltrarPor.Name = "lblFiltrarPor";
            lblFiltrarPor.Size = new Size(120, 32);
            lblFiltrarPor.TabIndex = 2;
            lblFiltrarPor.Text = "Filtrar Por:";
            // 
            // btnNuevaNota
            // 
            btnNuevaNota.BackColor = Color.FromArgb(178, 242, 187);
            btnNuevaNota.FlatStyle = FlatStyle.Flat;
            btnNuevaNota.Font = new Font("Segoe UI", 14.25F);
            btnNuevaNota.Location = new Point(54, 62);
            btnNuevaNota.Margin = new Padding(3, 4, 3, 4);
            btnNuevaNota.Name = "btnNuevaNota";
            btnNuevaNota.Size = new Size(183, 60);
            btnNuevaNota.TabIndex = 1;
            btnNuevaNota.Text = "Nueva Nota";
            btnNuevaNota.UseVisualStyleBackColor = false;
            btnNuevaNota.Click += btnNuevaNota_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.BackColor = Color.FromArgb(178, 242, 187);
            btnSalir.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(1020, 608);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(174, 60);
            btnSalir.TabIndex = 16;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmNotas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 681);
            Controls.Add(btnSalir);
            Controls.Add(roundGroupBox2);
            Controls.Add(roundGroupBox1);
            Controls.Add(grbNotasDia);
            Controls.Add(pnlBarra);
            Name = "frmNotas";
            Text = "Notas";
            pnlBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbSpain).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAyuda).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNotificaciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNoticias).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbTema).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEnglish).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHamburger).EndInit();
            roundGroupBox1.ResumeLayout(false);
            roundGroupBox1.PerformLayout();
            roundGroupBox2.ResumeLayout(false);
            roundGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgNotas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBarra;
        private PictureBox pbSpain;
        private PictureBox pbAyuda;
        private PictureBox pbUsuario;
        private PictureBox pbNotificaciones;
        private PictureBox pbNoticias;
        private PictureBox pbTema;
        private PictureBox pbEnglish;
        private PictureBox pbHamburger;
        private GroupBox grbNotasDia;
        private RoundGroupBox roundGroupBox1;
        private RoundGroupBox roundGroupBox2;
        private Label lblMes;
        private Label label3;
        private Label lblAdelante;
        private Label lblAtras;
        private Button btnNuevaNota;
        private DataGridView dtgNotas;
        private ComboBox cmbFiltrarPor;
        private Label lblFiltrarPor;
        private Button btnSalir;
    }
}