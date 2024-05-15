using Gestionis.Herramientas;

namespace Gestionis
{
    partial class FrmGestorDeudas
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
            lblDeudasTotalesValor = new Label();
            lblDeudasTotales = new Label();
            pnlInfoDeuda = new Panel();
            lblTipoValor = new Label();
            lblFechaLimiteValor = new Label();
            lblProximaDeudaValor = new Label();
            lblTipo = new Label();
            lblFechaLimite = new Label();
            lblProximaDeuda = new Label();
            cmbCategoria = new ComboBox();
            dgvGastosIngresos = new DataGridView();
            btnRestaurar = new Button();
            btnBuscar = new Button();
            btnEliminarDeuda = new Button();
            btnAnyadirDeuda = new Button();
            pbUsuario = new PictureBox();
            pbNotificaciones = new PictureBox();
            pbNoticias = new PictureBox();
            pnlBarra = new Panel();
            pbSpain = new PictureBox();
            pbEnglish = new PictureBox();
            pbTema = new PictureBox();
            pbAyuda = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pbHamburger = new PictureBox();
            label1 = new Label();
            barraLateral1 = new BarraLateral();
            pnlInfoDeuda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGastosIngresos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNotificaciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNoticias).BeginInit();
            pnlBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSpain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEnglish).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTema).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAyuda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHamburger).BeginInit();
            SuspendLayout();
            // 
            // lblDeudasTotalesValor
            // 
            lblDeudasTotalesValor.AutoSize = true;
            lblDeudasTotalesValor.BackColor = Color.Transparent;
            lblDeudasTotalesValor.Location = new Point(220, 570);
            lblDeudasTotalesValor.Name = "lblDeudasTotalesValor";
            lblDeudasTotalesValor.Size = new Size(171, 31);
            lblDeudasTotalesValor.TabIndex = 11;
            lblDeudasTotalesValor.Text = "Deudas totales:";
            // 
            // lblDeudasTotales
            // 
            lblDeudasTotales.AutoSize = true;
            lblDeudasTotales.BackColor = Color.Transparent;
            lblDeudasTotales.Location = new Point(57, 570);
            lblDeudasTotales.Name = "lblDeudasTotales";
            lblDeudasTotales.Size = new Size(171, 31);
            lblDeudasTotales.TabIndex = 10;
            lblDeudasTotales.Text = "Deudas totales:";
            // 
            // pnlInfoDeuda
            // 
            pnlInfoDeuda.BackColor = Color.Transparent;
            pnlInfoDeuda.BorderStyle = BorderStyle.FixedSingle;
            pnlInfoDeuda.Controls.Add(lblTipoValor);
            pnlInfoDeuda.Controls.Add(lblFechaLimiteValor);
            pnlInfoDeuda.Controls.Add(lblProximaDeudaValor);
            pnlInfoDeuda.Controls.Add(lblTipo);
            pnlInfoDeuda.Controls.Add(lblFechaLimite);
            pnlInfoDeuda.Controls.Add(lblProximaDeuda);
            pnlInfoDeuda.Location = new Point(313, 41);
            pnlInfoDeuda.Name = "pnlInfoDeuda";
            pnlInfoDeuda.Size = new Size(334, 150);
            pnlInfoDeuda.TabIndex = 9;
            // 
            // lblTipoValor
            // 
            lblTipoValor.AutoSize = true;
            lblTipoValor.BackColor = Color.Transparent;
            lblTipoValor.Location = new Point(203, 98);
            lblTipoValor.Name = "lblTipoValor";
            lblTipoValor.Size = new Size(42, 20);
            lblTipoValor.TabIndex = 17;
            lblTipoValor.Text = "Tipo:";
            // 
            // lblFechaLimiteValor
            // 
            lblFechaLimiteValor.AutoSize = true;
            lblFechaLimiteValor.BackColor = Color.Transparent;
            lblFechaLimiteValor.Location = new Point(203, 51);
            lblFechaLimiteValor.Name = "lblFechaLimiteValor";
            lblFechaLimiteValor.Size = new Size(42, 20);
            lblFechaLimiteValor.TabIndex = 16;
            lblFechaLimiteValor.Text = "Tipo:";
            // 
            // lblProximaDeudaValor
            // 
            lblProximaDeudaValor.AutoSize = true;
            lblProximaDeudaValor.BackColor = Color.Transparent;
            lblProximaDeudaValor.Location = new Point(203, 7);
            lblProximaDeudaValor.Name = "lblProximaDeudaValor";
            lblProximaDeudaValor.Size = new Size(42, 20);
            lblProximaDeudaValor.TabIndex = 15;
            lblProximaDeudaValor.Text = "Tipo:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.BackColor = Color.Transparent;
            lblTipo.Location = new Point(-1, 96);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(42, 20);
            lblTipo.TabIndex = 14;
            lblTipo.Text = "Tipo:";
            // 
            // lblFechaLimite
            // 
            lblFechaLimite.AutoSize = true;
            lblFechaLimite.BackColor = Color.Transparent;
            lblFechaLimite.Location = new Point(-1, 51);
            lblFechaLimite.Name = "lblFechaLimite";
            lblFechaLimite.Size = new Size(92, 20);
            lblFechaLimite.TabIndex = 13;
            lblFechaLimite.Text = "Fecha límite:";
            // 
            // lblProximaDeuda
            // 
            lblProximaDeuda.AutoSize = true;
            lblProximaDeuda.BackColor = Color.Transparent;
            lblProximaDeuda.Location = new Point(-1, 7);
            lblProximaDeuda.Name = "lblProximaDeuda";
            lblProximaDeuda.Size = new Size(112, 20);
            lblProximaDeuda.TabIndex = 12;
            lblProximaDeuda.Text = "Próxima deuda:";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(224, 227);
            cmbCategoria.Margin = new Padding(3, 4, 3, 4);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(192, 28);
            cmbCategoria.TabIndex = 8;
            // 
            // dgvGastosIngresos
            // 
            dgvGastosIngresos.BackgroundColor = SystemColors.ControlLightLight;
            dgvGastosIngresos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGastosIngresos.GridColor = SystemColors.Window;
            dgvGastosIngresos.Location = new Point(48, 287);
            dgvGastosIngresos.Margin = new Padding(3, 4, 3, 4);
            dgvGastosIngresos.Name = "dgvGastosIngresos";
            dgvGastosIngresos.RowHeadersWidth = 51;
            dgvGastosIngresos.Size = new Size(599, 279);
            dgvGastosIngresos.TabIndex = 7;
            // 
            // btnRestaurar
            // 
            btnRestaurar.BackColor = Color.FromArgb(178, 242, 187);
            btnRestaurar.Location = new Point(440, 223);
            btnRestaurar.Margin = new Padding(3, 4, 3, 4);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(183, 44);
            btnRestaurar.TabIndex = 4;
            btnRestaurar.Text = "Restaurar";
            btnRestaurar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(178, 242, 187);
            btnBuscar.Location = new Point(48, 223);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(155, 44);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnEliminarDeuda
            // 
            btnEliminarDeuda.BackColor = Color.FromArgb(178, 242, 187);
            btnEliminarDeuda.Location = new Point(70, 106);
            btnEliminarDeuda.Margin = new Padding(3, 4, 3, 4);
            btnEliminarDeuda.Name = "btnEliminarDeuda";
            btnEliminarDeuda.Size = new Size(183, 47);
            btnEliminarDeuda.TabIndex = 2;
            btnEliminarDeuda.Text = "Eliminar Deuda";
            btnEliminarDeuda.UseVisualStyleBackColor = false;
            // 
            // btnAnyadirDeuda
            // 
            btnAnyadirDeuda.BackColor = Color.FromArgb(178, 242, 187);
            btnAnyadirDeuda.Location = new Point(70, 41);
            btnAnyadirDeuda.Margin = new Padding(3, 4, 3, 4);
            btnAnyadirDeuda.Name = "btnAnyadirDeuda";
            btnAnyadirDeuda.Size = new Size(183, 47);
            btnAnyadirDeuda.TabIndex = 1;
            btnAnyadirDeuda.Text = "Añadir deuda";
            btnAnyadirDeuda.UseVisualStyleBackColor = false;
            // 
            // pbUsuario
            // 
            pbUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbUsuario.Location = new Point(1499, 5);
            pbUsuario.Margin = new Padding(3, 4, 3, 4);
            pbUsuario.Name = "pbUsuario";
            pbUsuario.Size = new Size(27, 31);
            pbUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUsuario.TabIndex = 26;
            pbUsuario.TabStop = false;
            // 
            // pbNotificaciones
            // 
            pbNotificaciones.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbNotificaciones.Location = new Point(1466, 5);
            pbNotificaciones.Margin = new Padding(3, 4, 3, 4);
            pbNotificaciones.Name = "pbNotificaciones";
            pbNotificaciones.Size = new Size(27, 31);
            pbNotificaciones.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNotificaciones.TabIndex = 25;
            pbNotificaciones.TabStop = false;
            // 
            // pbNoticias
            // 
            pbNoticias.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbNoticias.Location = new Point(1429, 5);
            pbNoticias.Margin = new Padding(3, 4, 3, 4);
            pbNoticias.Name = "pbNoticias";
            pbNoticias.Size = new Size(31, 31);
            pbNoticias.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNoticias.TabIndex = 24;
            pbNoticias.TabStop = false;
            // 
            // pnlBarra
            // 
            pnlBarra.BackColor = Color.FromArgb(211, 208, 242);
            pnlBarra.Controls.Add(pbSpain);
            pnlBarra.Controls.Add(pbEnglish);
            pnlBarra.Controls.Add(pbTema);
            pnlBarra.Controls.Add(pbUsuario);
            pnlBarra.Controls.Add(pbAyuda);
            pnlBarra.Controls.Add(pbNotificaciones);
            pnlBarra.Controls.Add(pbNoticias);
            pnlBarra.Controls.Add(pictureBox1);
            pnlBarra.Controls.Add(pictureBox2);
            pnlBarra.Controls.Add(pictureBox3);
            pnlBarra.Controls.Add(pbHamburger);
            pnlBarra.Dock = DockStyle.Top;
            pnlBarra.Location = new Point(0, 0);
            pnlBarra.Name = "pnlBarra";
            pnlBarra.Size = new Size(1539, 41);
            pnlBarra.TabIndex = 27;
            pnlBarra.Paint += pnlBarra_Paint;
            // 
            // pbSpain
            // 
            pbSpain.Enabled = false;
            pbSpain.Location = new Point(91, 4);
            pbSpain.Margin = new Padding(3, 4, 3, 4);
            pbSpain.Name = "pbSpain";
            pbSpain.Size = new Size(33, 31);
            pbSpain.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSpain.TabIndex = 29;
            pbSpain.TabStop = false;
            pbSpain.Visible = false;
            pbSpain.Click += pbSpain_Click;
            // 
            // pbEnglish
            // 
            pbEnglish.Location = new Point(93, 4);
            pbEnglish.Margin = new Padding(3, 4, 3, 4);
            pbEnglish.Name = "pbEnglish";
            pbEnglish.Size = new Size(30, 31);
            pbEnglish.SizeMode = PictureBoxSizeMode.CenterImage;
            pbEnglish.TabIndex = 28;
            pbEnglish.TabStop = false;
            pbEnglish.Click += pbEnglish_Click;
            // 
            // pbTema
            // 
            pbTema.Location = new Point(130, 5);
            pbTema.Margin = new Padding(3, 4, 3, 4);
            pbTema.Name = "pbTema";
            pbTema.Size = new Size(32, 31);
            pbTema.SizeMode = PictureBoxSizeMode.StretchImage;
            pbTema.TabIndex = 27;
            pbTema.TabStop = false;
            // 
            // pbAyuda
            // 
            pbAyuda.Location = new Point(49, 5);
            pbAyuda.Margin = new Padding(3, 4, 3, 4);
            pbAyuda.Name = "pbAyuda";
            pbAyuda.Size = new Size(31, 29);
            pbAyuda.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAyuda.TabIndex = 18;
            pbAyuda.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Location = new Point(2774, 5);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Location = new Point(2741, 5);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.Location = new Point(2702, 5);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // pbHamburger
            // 
            pbHamburger.Location = new Point(11, 5);
            pbHamburger.Margin = new Padding(3, 4, 3, 4);
            pbHamburger.Name = "pbHamburger";
            pbHamburger.Size = new Size(31, 31);
            pbHamburger.SizeMode = PictureBoxSizeMode.StretchImage;
            pbHamburger.TabIndex = 17;
            pbHamburger.TabStop = false;
            pbHamburger.Click += pbHamburger_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(72, 23);
            label1.Name = "label1";
            label1.Size = new Size(171, 31);
            label1.TabIndex = 12;
            label1.Text = "Deudas totales:";
            // 
            // barraLateral1
            // 
            barraLateral1.BackColor = Color.FromArgb(205, 213, 221);
            barraLateral1.Dock = DockStyle.Left;
            barraLateral1.Location = new Point(0, 41);
            barraLateral1.Name = "barraLateral1";
            barraLateral1.Size = new Size(331, 1014);
            barraLateral1.TabIndex = 28;
            // 
            // FrmGestorDeudas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 236, 239);
            ClientSize = new Size(1539, 1055);
            Controls.Add(barraLateral1);
            Controls.Add(pnlBarra);
            Name = "FrmGestorDeudas";
            Text = "FrmGestorDeudas";
            Load += FrmGestorDeudas_Load;
            pnlInfoDeuda.ResumeLayout(false);
            pnlInfoDeuda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGastosIngresos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNotificaciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNoticias).EndInit();
            pnlBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbSpain).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEnglish).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbTema).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAyuda).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHamburger).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RoundGroupBox roundGroupBox1;
        private Button btnAnyadirDeuda;
        private PictureBox pbUsuario;
        private PictureBox pbNotificaciones;
        private PictureBox pbNoticias;
        private Panel pnlBarra;
        private PictureBox pbAyuda;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pbHamburger;
        private Button btnEliminarDeuda;
        private PictureBox pbTema;
        private PictureBox pbSpain;
        private PictureBox pbEnglish;
        private Button btnRestaurar;
        private Button btnBuscar;
        private ComboBox cmbCategoria;
        private DataGridView dgvGastosIngresos;
        private Label lblDeudasTotalesValor;
        private Label lblDeudasTotales;
        private Panel pnlInfoDeuda;
        private Label lblProximaDeuda;
        private Label lblTipoValor;
        private Label lblFechaLimiteValor;
        private Label lblProximaDeudaValor;
        private Label lblTipo;
        private Label lblFechaLimite;
        private RoundGroupBox roundGroupBox2;
        private Label label1;
        private BarraLateral barraLateral1;
    }
}