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
            roundGroupBox1 = new RoundGroupBox();
            button1 = new Button();
            btnIngreso = new Button();
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
            roundGroupBox1.SuspendLayout();
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
            // roundGroupBox1
            // 
            roundGroupBox1.Controls.Add(button1);
            roundGroupBox1.Controls.Add(btnIngreso);
            roundGroupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundGroupBox1.Location = new Point(308, 96);
            roundGroupBox1.Name = "roundGroupBox1";
            roundGroupBox1.Size = new Size(696, 618);
            roundGroupBox1.TabIndex = 0;
            roundGroupBox1.TabStop = false;
            roundGroupBox1.Text = "rgpDeudas";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(178, 242, 187);
            button1.Location = new Point(92, 181);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(183, 60);
            button1.TabIndex = 2;
            button1.Text = "Nuevo Ingreso";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnIngreso
            // 
            btnIngreso.BackColor = Color.FromArgb(178, 242, 187);
            btnIngreso.Location = new Point(70, 62);
            btnIngreso.Margin = new Padding(3, 4, 3, 4);
            btnIngreso.Name = "btnIngreso";
            btnIngreso.Size = new Size(183, 60);
            btnIngreso.TabIndex = 1;
            btnIngreso.Text = "Nuevo Ingreso";
            btnIngreso.UseVisualStyleBackColor = false;
            // 
            // pbUsuario
            // 
            pbUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbUsuario.Location = new Point(1500, 5);
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
            pbNoticias.Location = new Point(1428, 5);
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
            pbTema.Location = new Point(130, 6);
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
            pbAyuda.Size = new Size(31, 30);
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
            pictureBox2.Location = new Point(2740, 5);
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
            pbHamburger.Location = new Point(12, 5);
            pbHamburger.Margin = new Padding(3, 4, 3, 4);
            pbHamburger.Name = "pbHamburger";
            pbHamburger.Size = new Size(31, 31);
            pbHamburger.SizeMode = PictureBoxSizeMode.StretchImage;
            pbHamburger.TabIndex = 17;
            pbHamburger.TabStop = false;
            // 
            // FrmGestorDeudas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1539, 701);
            Controls.Add(pnlBarra);
            Controls.Add(roundGroupBox1);
            Name = "FrmGestorDeudas";
            Text = "FrmGestorDeudas";
            Load += FrmGestorDeudas_Load;
            roundGroupBox1.ResumeLayout(false);
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
        private Button btnIngreso;
        private PictureBox pbUsuario;
        private PictureBox pbNotificaciones;
        private PictureBox pbNoticias;
        private Panel pnlBarra;
        private PictureBox pbAyuda;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pbHamburger;
        private Button button1;
        private PictureBox pbTema;
        private PictureBox pbSpain;
        private PictureBox pbEnglish;
    }
}