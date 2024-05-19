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
            pnlBarra.Margin = new Padding(3, 2, 3, 2);
            pnlBarra.Name = "pnlBarra";
            pnlBarra.Size = new Size(1110, 31);
            pnlBarra.TabIndex = 3;
            // 
            // pbSpain
            // 
            pbSpain.Enabled = false;
            pbSpain.Location = new Point(80, 4);
            pbSpain.Name = "pbSpain";
            pbSpain.Size = new Size(29, 23);
            pbSpain.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSpain.TabIndex = 24;
            pbSpain.TabStop = false;
            // 
            // pbAyuda
            // 
            pbAyuda.Location = new Point(43, 4);
            pbAyuda.Name = "pbAyuda";
            pbAyuda.Size = new Size(27, 22);
            pbAyuda.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAyuda.TabIndex = 18;
            pbAyuda.TabStop = false;
            // 
            // pbUsuario
            // 
            pbUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbUsuario.Location = new Point(2190, 4);
            pbUsuario.Name = "pbUsuario";
            pbUsuario.Size = new Size(24, 23);
            pbUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUsuario.TabIndex = 23;
            pbUsuario.TabStop = false;
            // 
            // pbNotificaciones
            // 
            pbNotificaciones.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbNotificaciones.Location = new Point(2160, 4);
            pbNotificaciones.Name = "pbNotificaciones";
            pbNotificaciones.Size = new Size(24, 23);
            pbNotificaciones.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNotificaciones.TabIndex = 22;
            pbNotificaciones.TabStop = false;
            // 
            // pbNoticias
            // 
            pbNoticias.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbNoticias.Location = new Point(2127, 4);
            pbNoticias.Name = "pbNoticias";
            pbNoticias.Size = new Size(27, 23);
            pbNoticias.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNoticias.TabIndex = 21;
            pbNoticias.TabStop = false;
            // 
            // pbTema
            // 
            pbTema.Location = new Point(118, 4);
            pbTema.Name = "pbTema";
            pbTema.Size = new Size(28, 23);
            pbTema.SizeMode = PictureBoxSizeMode.StretchImage;
            pbTema.TabIndex = 20;
            pbTema.TabStop = false;
            // 
            // pbEnglish
            // 
            pbEnglish.Location = new Point(82, 4);
            pbEnglish.Name = "pbEnglish";
            pbEnglish.Size = new Size(26, 23);
            pbEnglish.SizeMode = PictureBoxSizeMode.CenterImage;
            pbEnglish.TabIndex = 19;
            pbEnglish.TabStop = false;
            // 
            // pbHamburger
            // 
            pbHamburger.Location = new Point(10, 4);
            pbHamburger.Name = "pbHamburger";
            pbHamburger.Size = new Size(27, 23);
            pbHamburger.SizeMode = PictureBoxSizeMode.StretchImage;
            pbHamburger.TabIndex = 17;
            pbHamburger.TabStop = false;
            // 
            // grbNotasDia
            // 
            grbNotasDia.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline);
            grbNotasDia.Location = new Point(821, 304);
            grbNotasDia.Margin = new Padding(3, 2, 3, 2);
            grbNotasDia.Name = "grbNotasDia";
            grbNotasDia.Padding = new Padding(3, 2, 3, 2);
            grbNotasDia.Size = new Size(218, 132);
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
            roundGroupBox1.Location = new Point(821, 71);
            roundGroupBox1.Margin = new Padding(3, 2, 3, 2);
            roundGroupBox1.Name = "roundGroupBox1";
            roundGroupBox1.Padding = new Padding(3, 2, 3, 2);
            roundGroupBox1.Size = new Size(218, 121);
            roundGroupBox1.TabIndex = 6;
            roundGroupBox1.TabStop = false;
            roundGroupBox1.Text = "roundGroupBox1";
            // 
            // lblAdelante
            // 
            lblAdelante.AutoSize = true;
            lblAdelante.BackColor = Color.Transparent;
            lblAdelante.Font = new Font("Segoe UI", 14.25F);
            lblAdelante.Location = new Point(139, 8);
            lblAdelante.Name = "lblAdelante";
            lblAdelante.Size = new Size(25, 25);
            lblAdelante.TabIndex = 5;
            lblAdelante.Text = ">";
            // 
            // lblAtras
            // 
            lblAtras.AutoSize = true;
            lblAtras.BackColor = Color.Transparent;
            lblAtras.Font = new Font("Segoe UI", 14.25F);
            lblAtras.Location = new Point(48, 8);
            lblAtras.Name = "lblAtras";
            lblAtras.Size = new Size(25, 25);
            lblAtras.TabIndex = 4;
            lblAtras.Text = "<";
            // 
            // lblMes
            // 
            lblMes.AutoSize = true;
            lblMes.BackColor = Color.Transparent;
            lblMes.Font = new Font("Segoe UI", 14.25F);
            lblMes.Location = new Point(83, 8);
            lblMes.Name = "lblMes";
            lblMes.Size = new Size(47, 25);
            lblMes.TabIndex = 3;
            lblMes.Text = "Mes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(-7, 13);
            label3.Name = "label3";
            label3.Size = new Size(212, 25);
            label3.TabIndex = 2;
            label3.Text = "_________________________";
            // 
            // roundGroupBox2
            // 
            roundGroupBox2.Controls.Add(dtgNotas);
            roundGroupBox2.Controls.Add(cmbFiltrarPor);
            roundGroupBox2.Controls.Add(lblFiltrarPor);
            roundGroupBox2.Controls.Add(btnNuevaNota);
            roundGroupBox2.Location = new Point(82, 71);
            roundGroupBox2.Margin = new Padding(3, 2, 3, 2);
            roundGroupBox2.Name = "roundGroupBox2";
            roundGroupBox2.Padding = new Padding(3, 2, 3, 2);
            roundGroupBox2.Size = new Size(585, 364);
            roundGroupBox2.TabIndex = 7;
            roundGroupBox2.TabStop = false;
            roundGroupBox2.Text = "roundGroupBox2";
            // 
            // dtgNotas
            // 
            dtgNotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgNotas.Location = new Point(47, 186);
            dtgNotas.Margin = new Padding(3, 2, 3, 2);
            dtgNotas.Name = "dtgNotas";
            dtgNotas.RowHeadersWidth = 51;
            dtgNotas.Size = new Size(456, 141);
            dtgNotas.TabIndex = 4;
            // 
            // cmbFiltrarPor
            // 
            cmbFiltrarPor.FormattingEnabled = true;
            cmbFiltrarPor.Location = new Point(211, 130);
            cmbFiltrarPor.Margin = new Padding(3, 2, 3, 2);
            cmbFiltrarPor.Name = "cmbFiltrarPor";
            cmbFiltrarPor.Size = new Size(139, 23);
            cmbFiltrarPor.TabIndex = 3;
            // 
            // lblFiltrarPor
            // 
            lblFiltrarPor.AutoSize = true;
            lblFiltrarPor.BackColor = Color.Transparent;
            lblFiltrarPor.Font = new Font("Segoe UI", 14.25F);
            lblFiltrarPor.Location = new Point(47, 127);
            lblFiltrarPor.Name = "lblFiltrarPor";
            lblFiltrarPor.Size = new Size(98, 25);
            lblFiltrarPor.TabIndex = 2;
            lblFiltrarPor.Text = "Filtrar Por:";
            // 
            // btnNuevaNota
            // 
            btnNuevaNota.BackColor = Color.FromArgb(178, 242, 187);
            btnNuevaNota.FlatStyle = FlatStyle.Flat;
            btnNuevaNota.Font = new Font("Segoe UI", 14.25F);
            btnNuevaNota.Location = new Point(47, 46);
            btnNuevaNota.Name = "btnNuevaNota";
            btnNuevaNota.Size = new Size(160, 45);
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
            btnSalir.Location = new Point(892, 456);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(152, 45);
            btnSalir.TabIndex = 16;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmNotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 511);
            Controls.Add(btnSalir);
            Controls.Add(roundGroupBox2);
            Controls.Add(roundGroupBox1);
            Controls.Add(grbNotasDia);
            Controls.Add(pnlBarra);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmNotas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notas";
            WindowState = FormWindowState.Maximized;
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