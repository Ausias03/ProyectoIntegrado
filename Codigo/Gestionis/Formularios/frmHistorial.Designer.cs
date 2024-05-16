namespace Gestionis
{
    partial class frmHistorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistorial));
            vScrollBar1 = new VScrollBar();
            lblHistorial = new Label();
            dgvHistorial = new DataGridView();
            lblFecha = new Label();
            txtBuscar = new TextBox();
            picBuscar = new PictureBox();
            lblBuscar = new Label();
            lblMetodo = new Label();
            cmbMetodo = new ComboBox();
            dtpBuscaFecha = new DateTimePicker();
            lblBuscaFecha = new Label();
            picBuscaFecha = new PictureBox();
            pnlBarra = new Panel();
            pbUsuario = new PictureBox();
            s = new PictureBox();
            pbNotificaciones = new PictureBox();
            pbNoticias = new PictureBox();
            pbSpain = new PictureBox();
            c = new PictureBox();
            d = new PictureBox();
            pbAyuda = new PictureBox();
            u = new PictureBox();
            a = new PictureBox();
            p = new PictureBox();
            pbTema = new PictureBox();
            pbEnglish = new PictureBox();
            pbHamburger = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBuscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBuscaFecha).BeginInit();
            pnlBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)s).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNotificaciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNoticias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSpain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c).BeginInit();
            ((System.ComponentModel.ISupportInitialize)d).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAyuda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)u).BeginInit();
            ((System.ComponentModel.ISupportInitialize)a).BeginInit();
            ((System.ComponentModel.ISupportInitialize)p).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTema).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEnglish).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHamburger).BeginInit();
            SuspendLayout();
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(1491, 9);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(26, 698);
            vScrollBar1.TabIndex = 0;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Font = new Font("Roboto Mono", 24F);
            lblHistorial.Location = new Point(152, 48);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(239, 53);
            lblHistorial.TabIndex = 1;
            lblHistorial.Text = "Historial";
            // 
            // dgvHistorial
            // 
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Location = new Point(164, 181);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.RowHeadersWidth = 51;
            dgvHistorial.Size = new Size(1018, 494);
            dgvHistorial.TabIndex = 17;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Roboto Mono", 12F);
            lblFecha.Location = new Point(164, 152);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(48, 26);
            lblFecha.TabIndex = 18;
            lblFecha.Text = "Hoy";
            lblFecha.Visible = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Roboto Mono", 12F);
            txtBuscar.Location = new Point(1188, 181);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(181, 34);
            txtBuscar.TabIndex = 19;
            // 
            // picBuscar
            // 
            picBuscar.Location = new Point(1375, 181);
            picBuscar.Name = "picBuscar";
            picBuscar.Size = new Size(34, 34);
            picBuscar.TabIndex = 9;
            picBuscar.TabStop = false;
            picBuscar.Click += picBuscar_Click;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Roboto Mono", 12F);
            lblBuscar.Location = new Point(1188, 152);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(120, 26);
            lblBuscar.TabIndex = 20;
            lblBuscar.Text = "Buscador:";
            lblBuscar.Visible = false;
            // 
            // lblMetodo
            // 
            lblMetodo.AutoSize = true;
            lblMetodo.Font = new Font("Roboto Mono", 12F);
            lblMetodo.Location = new Point(1188, 218);
            lblMetodo.Name = "lblMetodo";
            lblMetodo.Size = new Size(96, 26);
            lblMetodo.TabIndex = 21;
            lblMetodo.Text = "Metodo:";
            lblMetodo.Visible = false;
            // 
            // cmbMetodo
            // 
            cmbMetodo.Font = new Font("Roboto Mono", 12F);
            cmbMetodo.FormattingEnabled = true;
            cmbMetodo.Items.AddRange(new object[] { "Tipo", "Cantidad", "Nombre" });
            cmbMetodo.Location = new Point(1188, 247);
            cmbMetodo.Name = "cmbMetodo";
            cmbMetodo.Size = new Size(181, 34);
            cmbMetodo.TabIndex = 22;
            cmbMetodo.Text = "Tipo";
            // 
            // dtpBuscaFecha
            // 
            dtpBuscaFecha.Font = new Font("Roboto Mono", 12F);
            dtpBuscaFecha.Format = DateTimePickerFormat.Short;
            dtpBuscaFecha.Location = new Point(1188, 338);
            dtpBuscaFecha.Name = "dtpBuscaFecha";
            dtpBuscaFecha.Size = new Size(180, 34);
            dtpBuscaFecha.TabIndex = 23;
            // 
            // lblBuscaFecha
            // 
            lblBuscaFecha.AutoSize = true;
            lblBuscaFecha.Font = new Font("Roboto Mono", 12F);
            lblBuscaFecha.Location = new Point(1188, 309);
            lblBuscaFecha.Name = "lblBuscaFecha";
            lblBuscaFecha.Size = new Size(240, 26);
            lblBuscaFecha.TabIndex = 24;
            lblBuscaFecha.Text = "Buscador por Fecha:";
            lblBuscaFecha.Visible = false;
            // 
            // picBuscaFecha
            // 
            picBuscaFecha.Location = new Point(1375, 338);
            picBuscaFecha.Name = "picBuscaFecha";
            picBuscaFecha.Size = new Size(34, 34);
            picBuscaFecha.TabIndex = 25;
            picBuscaFecha.TabStop = false;
            picBuscaFecha.Click += picBuscaFecha_Click;
            // 
            // pnlBarra
            // 
            pnlBarra.BackColor = Color.FromArgb(211, 208, 242);
            pnlBarra.Controls.Add(pbUsuario);
            pnlBarra.Controls.Add(s);
            pnlBarra.Controls.Add(pbNotificaciones);
            pnlBarra.Controls.Add(pbNoticias);
            pnlBarra.Controls.Add(pbSpain);
            pnlBarra.Controls.Add(c);
            pnlBarra.Controls.Add(d);
            pnlBarra.Controls.Add(pbAyuda);
            pnlBarra.Controls.Add(u);
            pnlBarra.Controls.Add(a);
            pnlBarra.Controls.Add(p);
            pnlBarra.Controls.Add(pbTema);
            pnlBarra.Controls.Add(pbEnglish);
            pnlBarra.Controls.Add(pbHamburger);
            pnlBarra.Dock = DockStyle.Top;
            pnlBarra.Location = new Point(0, 0);
            pnlBarra.Name = "pnlBarra";
            pnlBarra.Size = new Size(1454, 45);
            pnlBarra.TabIndex = 26;
            // 
            // pbUsuario
            // 
            pbUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbUsuario.Location = new Point(1418, 6);
            pbUsuario.Margin = new Padding(3, 4, 3, 4);
            pbUsuario.Name = "pbUsuario";
            pbUsuario.Size = new Size(27, 31);
            pbUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUsuario.TabIndex = 29;
            pbUsuario.TabStop = false;
            // 
            // s
            // 
            s.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            s.Location = new Point(2475, 5);
            s.Margin = new Padding(3, 4, 3, 4);
            s.Name = "s";
            s.Size = new Size(27, 31);
            s.SizeMode = PictureBoxSizeMode.StretchImage;
            s.TabIndex = 26;
            s.TabStop = false;
            // 
            // pbNotificaciones
            // 
            pbNotificaciones.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbNotificaciones.Location = new Point(1384, 6);
            pbNotificaciones.Margin = new Padding(3, 4, 3, 4);
            pbNotificaciones.Name = "pbNotificaciones";
            pbNotificaciones.Size = new Size(27, 31);
            pbNotificaciones.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNotificaciones.TabIndex = 28;
            pbNotificaciones.TabStop = false;
            // 
            // pbNoticias
            // 
            pbNoticias.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbNoticias.Location = new Point(1346, 6);
            pbNoticias.Margin = new Padding(3, 4, 3, 4);
            pbNoticias.Name = "pbNoticias";
            pbNoticias.Size = new Size(31, 31);
            pbNoticias.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNoticias.TabIndex = 27;
            pbNoticias.TabStop = false;
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
            // c
            // 
            c.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            c.Location = new Point(2441, 5);
            c.Margin = new Padding(3, 4, 3, 4);
            c.Name = "c";
            c.Size = new Size(27, 31);
            c.SizeMode = PictureBoxSizeMode.StretchImage;
            c.TabIndex = 25;
            c.TabStop = false;
            // 
            // d
            // 
            d.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            d.Location = new Point(2403, 5);
            d.Margin = new Padding(3, 4, 3, 4);
            d.Name = "d";
            d.Size = new Size(31, 31);
            d.SizeMode = PictureBoxSizeMode.StretchImage;
            d.TabIndex = 24;
            d.TabStop = false;
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
            // u
            // 
            u.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            u.Location = new Point(3747, 5);
            u.Margin = new Padding(3, 4, 3, 4);
            u.Name = "u";
            u.Size = new Size(27, 31);
            u.SizeMode = PictureBoxSizeMode.StretchImage;
            u.TabIndex = 23;
            u.TabStop = false;
            // 
            // a
            // 
            a.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            a.Location = new Point(3713, 5);
            a.Margin = new Padding(3, 4, 3, 4);
            a.Name = "a";
            a.Size = new Size(27, 31);
            a.SizeMode = PictureBoxSizeMode.StretchImage;
            a.TabIndex = 22;
            a.TabStop = false;
            // 
            // p
            // 
            p.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            p.Location = new Point(3675, 5);
            p.Margin = new Padding(3, 4, 3, 4);
            p.Name = "p";
            p.Size = new Size(31, 31);
            p.SizeMode = PictureBoxSizeMode.StretchImage;
            p.TabIndex = 21;
            p.TabStop = false;
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
            // frmHistorial
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1454, 703);
            Controls.Add(pnlBarra);
            Controls.Add(picBuscaFecha);
            Controls.Add(lblBuscaFecha);
            Controls.Add(dtpBuscaFecha);
            Controls.Add(cmbMetodo);
            Controls.Add(lblMetodo);
            Controls.Add(lblBuscar);
            Controls.Add(picBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(lblFecha);
            Controls.Add(dgvHistorial);
            Controls.Add(lblHistorial);
            Controls.Add(vScrollBar1);
            Font = new Font("Roboto Mono", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmHistorial";
            Text = "Ge$tioni$";
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBuscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBuscaFecha).EndInit();
            pnlBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)s).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNotificaciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNoticias).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSpain).EndInit();
            ((System.ComponentModel.ISupportInitialize)c).EndInit();
            ((System.ComponentModel.ISupportInitialize)d).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAyuda).EndInit();
            ((System.ComponentModel.ISupportInitialize)u).EndInit();
            ((System.ComponentModel.ISupportInitialize)a).EndInit();
            ((System.ComponentModel.ISupportInitialize)p).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbTema).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEnglish).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHamburger).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private VScrollBar vScrollBar1;
        private Label lblHistorial;
        private DataGridView dgvHistorial;
        private Label lblFecha;
        private TextBox txtBuscar;
        private PictureBox picBuscar;
        private Label lblBuscar;
        private Label lblMetodo;
        private ComboBox cmbMetodo;
        private DateTimePicker dtpBuscaFecha;
        private Label lblBuscaFecha;
        private PictureBox picBuscaFecha;
        private Panel pnlBarra;
        private PictureBox s;
        private PictureBox pbSpain;
        private PictureBox c;
        private PictureBox d;
        private PictureBox pbAyuda;
        private PictureBox u;
        private PictureBox a;
        private PictureBox p;
        private PictureBox pbTema;
        private PictureBox pbEnglish;
        private PictureBox pbHamburger;
        private PictureBox pbUsuario;
        private PictureBox pbNotificaciones;
        private PictureBox pbNoticias;
    }
}