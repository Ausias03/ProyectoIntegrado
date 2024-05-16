namespace Gestionis
{
    partial class frmTablaClasificación
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTablaClasificación));
            dtgTabla = new DataGridView();
            lblTabla = new Label();
            btnSalir = new Button();
            pnlBarra = new Panel();
            v = new PictureBox();
            pbSpain = new PictureBox();
            g = new PictureBox();
            w = new PictureBox();
            pbAyuda = new PictureBox();
            u = new PictureBox();
            a = new PictureBox();
            p = new PictureBox();
            pbTema = new PictureBox();
            pbEnglish = new PictureBox();
            pbHamburger = new PictureBox();
            pbUsuario = new PictureBox();
            pbNotificaciones = new PictureBox();
            pbNoticias = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dtgTabla).BeginInit();
            pnlBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)v).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSpain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)g).BeginInit();
            ((System.ComponentModel.ISupportInitialize)w).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAyuda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)u).BeginInit();
            ((System.ComponentModel.ISupportInitialize)a).BeginInit();
            ((System.ComponentModel.ISupportInitialize)p).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTema).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEnglish).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHamburger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNotificaciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNoticias).BeginInit();
            SuspendLayout();
            // 
            // dtgTabla
            // 
            dtgTabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgTabla.Location = new Point(73, 117);
            dtgTabla.Name = "dtgTabla";
            dtgTabla.RowHeadersWidth = 51;
            dtgTabla.Size = new Size(1280, 534);
            dtgTabla.TabIndex = 0;
            // 
            // lblTabla
            // 
            lblTabla.AutoSize = true;
            lblTabla.Font = new Font("Roboto Mono", 22.2F, FontStyle.Bold);
            lblTabla.Location = new Point(444, 54);
            lblTabla.Name = "lblTabla";
            lblTabla.Size = new Size(528, 49);
            lblTabla.TabIndex = 1;
            lblTabla.Text = "Top 10 usuarios del mes";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(170, 166, 202);
            btnSalir.Font = new Font("Roboto Mono", 12F);
            btnSalir.Location = new Point(1259, 668);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(124, 40);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // pnlBarra
            // 
            pnlBarra.BackColor = Color.FromArgb(211, 208, 242);
            pnlBarra.Controls.Add(pbUsuario);
            pnlBarra.Controls.Add(pbNotificaciones);
            pnlBarra.Controls.Add(pbNoticias);
            pnlBarra.Controls.Add(v);
            pnlBarra.Controls.Add(pbSpain);
            pnlBarra.Controls.Add(g);
            pnlBarra.Controls.Add(w);
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
            pnlBarra.Size = new Size(1417, 51);
            pnlBarra.TabIndex = 4;

            // 
            // v
            // 
            v.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            v.Location = new Point(2438, 5);
            v.Margin = new Padding(3, 4, 3, 4);
            v.Name = "v";
            v.Size = new Size(27, 31);
            v.SizeMode = PictureBoxSizeMode.StretchImage;
            v.TabIndex = 26;
            v.TabStop = false;
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
            // g
            // 
            g.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            g.Location = new Point(2404, 5);
            g.Margin = new Padding(3, 4, 3, 4);
            g.Name = "g";
            g.Size = new Size(27, 31);
            g.SizeMode = PictureBoxSizeMode.StretchImage;
            g.TabIndex = 25;
            g.TabStop = false;
            // 
            // w
            // 
            w.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            w.Location = new Point(2366, 5);
            w.Margin = new Padding(3, 4, 3, 4);
            w.Name = "w";
            w.Size = new Size(31, 31);
            w.SizeMode = PictureBoxSizeMode.StretchImage;
            w.TabIndex = 24;
            w.TabStop = false;
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
            u.Location = new Point(3710, 5);
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
            a.Location = new Point(3676, 5);
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
            p.Location = new Point(3638, 5);
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
            // pbUsuario
            // 
            pbUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbUsuario.Location = new Point(1380, 6);
            pbUsuario.Margin = new Padding(3, 4, 3, 4);
            pbUsuario.Name = "pbUsuario";
            pbUsuario.Size = new Size(27, 31);
            pbUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUsuario.TabIndex = 29;
            pbUsuario.TabStop = false;
            // 
            // pbNotificaciones
            // 
            pbNotificaciones.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbNotificaciones.Location = new Point(1346, 6);
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
            pbNoticias.Location = new Point(1308, 6);
            pbNoticias.Margin = new Padding(3, 4, 3, 4);
            pbNoticias.Name = "pbNoticias";
            pbNoticias.Size = new Size(31, 31);
            pbNoticias.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNoticias.TabIndex = 27;
            pbNoticias.TabStop = false;
            // 
            // frmTablaClasificación
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1417, 729);
            Controls.Add(pnlBarra);
            Controls.Add(btnSalir);
            Controls.Add(lblTabla);
            Controls.Add(dtgTabla);
            Font = new Font("Roboto Mono", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmTablaClasificación";
            Text = "Ge$tioni$";
            ((System.ComponentModel.ISupportInitialize)dtgTabla).EndInit();
            pnlBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)v).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSpain).EndInit();
            ((System.ComponentModel.ISupportInitialize)g).EndInit();
            ((System.ComponentModel.ISupportInitialize)w).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAyuda).EndInit();
            ((System.ComponentModel.ISupportInitialize)u).EndInit();
            ((System.ComponentModel.ISupportInitialize)a).EndInit();
            ((System.ComponentModel.ISupportInitialize)p).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbTema).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEnglish).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHamburger).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNotificaciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNoticias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgTabla;
        private Label lblTabla;
        private Button btnSalir;
        private Panel pnlBarra;
        private PictureBox v;
        private PictureBox pbSpain;
        private PictureBox g;
        private PictureBox w;
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