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
            roundGroupBox2 = new RoundGroupBox();
            lblNotasTotalesCount = new Label();
            lblNotasTotales = new Label();
            btnRestaurarFiltro = new Button();
            ckbAlarmaFiltro = new CheckBox();
            dtpFiltrarFecha = new DateTimePicker();
            btnFiltroColor = new Button();
            btnFiltrar = new Button();
            txtFiltro = new TextBox();
            dgvNotas = new DataGridView();
            cmbFiltrarPor = new ComboBox();
            lblFiltrarPor = new Label();
            btnNuevaNota = new Button();
            btnSalir = new Button();
            barraSecundaria1 = new BarraSecundaria();
            barraLateral1 = new BarraLateral();
            colorDialog1 = new ColorDialog();
            monthCalendar1 = new MonthCalendar();
            dgvNotasDia = new DataGridView();
            rgbNotasDia = new RoundGroupBox();
            lblNDTotales = new Label();
            lblNotasTotalesDia = new Label();
            lblNotasDia = new Label();
            roundGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNotas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvNotasDia).BeginInit();
            rgbNotasDia.SuspendLayout();
            SuspendLayout();
            // 
            // roundGroupBox2
            // 
            roundGroupBox2.Controls.Add(lblNotasTotalesCount);
            roundGroupBox2.Controls.Add(lblNotasTotales);
            roundGroupBox2.Controls.Add(btnRestaurarFiltro);
            roundGroupBox2.Controls.Add(ckbAlarmaFiltro);
            roundGroupBox2.Controls.Add(dtpFiltrarFecha);
            roundGroupBox2.Controls.Add(btnFiltroColor);
            roundGroupBox2.Controls.Add(btnFiltrar);
            roundGroupBox2.Controls.Add(txtFiltro);
            roundGroupBox2.Controls.Add(dgvNotas);
            roundGroupBox2.Controls.Add(cmbFiltrarPor);
            roundGroupBox2.Controls.Add(lblFiltrarPor);
            roundGroupBox2.Controls.Add(btnNuevaNota);
            roundGroupBox2.Location = new Point(381, 181);
            roundGroupBox2.Name = "roundGroupBox2";
            roundGroupBox2.Size = new Size(913, 640);
            roundGroupBox2.TabIndex = 7;
            roundGroupBox2.TabStop = false;
            roundGroupBox2.Text = "roundGroupBox2";
            // 
            // lblNotasTotalesCount
            // 
            lblNotasTotalesCount.AutoSize = true;
            lblNotasTotalesCount.BackColor = Color.Transparent;
            lblNotasTotalesCount.Font = new Font("Segoe UI", 14.05F);
            lblNotasTotalesCount.Location = new Point(149, 561);
            lblNotasTotalesCount.Name = "lblNotasTotalesCount";
            lblNotasTotalesCount.Size = new Size(105, 32);
            lblNotasTotalesCount.TabIndex = 20;
            lblNotasTotalesCount.Text = "TOTALES";
            // 
            // lblNotasTotales
            // 
            lblNotasTotales.AutoSize = true;
            lblNotasTotales.BackColor = Color.Transparent;
            lblNotasTotales.Font = new Font("Segoe UI", 14.05F);
            lblNotasTotales.Location = new Point(62, 561);
            lblNotasTotales.Name = "lblNotasTotales";
            lblNotasTotales.Size = new Size(88, 32);
            lblNotasTotales.TabIndex = 11;
            lblNotasTotales.Text = "Notas: ";
            // 
            // btnRestaurarFiltro
            // 
            btnRestaurarFiltro.BackColor = Color.FromArgb(178, 242, 187);
            btnRestaurarFiltro.FlatStyle = FlatStyle.Flat;
            btnRestaurarFiltro.Font = new Font("Segoe UI", 13.08F);
            btnRestaurarFiltro.Location = new Point(665, 180);
            btnRestaurarFiltro.Margin = new Padding(3, 4, 3, 4);
            btnRestaurarFiltro.Name = "btnRestaurarFiltro";
            btnRestaurarFiltro.Size = new Size(147, 47);
            btnRestaurarFiltro.TabIndex = 10;
            btnRestaurarFiltro.Text = "Restaurar";
            btnRestaurarFiltro.UseVisualStyleBackColor = false;
            btnRestaurarFiltro.Click += btnRestaurarFiltro_Click;
            // 
            // ckbAlarmaFiltro
            // 
            ckbAlarmaFiltro.AutoSize = true;
            ckbAlarmaFiltro.Location = new Point(414, 195);
            ckbAlarmaFiltro.Margin = new Padding(3, 4, 3, 4);
            ckbAlarmaFiltro.Name = "ckbAlarmaFiltro";
            ckbAlarmaFiltro.Size = new Size(18, 17);
            ckbAlarmaFiltro.TabIndex = 9;
            ckbAlarmaFiltro.UseVisualStyleBackColor = true;
            ckbAlarmaFiltro.Visible = false;
            // 
            // dtpFiltrarFecha
            // 
            dtpFiltrarFecha.Format = DateTimePickerFormat.Short;
            dtpFiltrarFecha.Location = new Point(363, 189);
            dtpFiltrarFecha.Name = "dtpFiltrarFecha";
            dtpFiltrarFecha.Size = new Size(125, 27);
            dtpFiltrarFecha.TabIndex = 8;
            dtpFiltrarFecha.Visible = false;
            // 
            // btnFiltroColor
            // 
            btnFiltroColor.Location = new Point(386, 191);
            btnFiltroColor.Name = "btnFiltroColor";
            btnFiltroColor.Size = new Size(82, 29);
            btnFiltroColor.TabIndex = 7;
            btnFiltroColor.UseVisualStyleBackColor = true;
            btnFiltroColor.Visible = false;
            btnFiltroColor.Click += btnFiltroColor_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = Color.FromArgb(178, 242, 187);
            btnFiltrar.FlatStyle = FlatStyle.Flat;
            btnFiltrar.Font = new Font("Segoe UI", 13.08F);
            btnFiltrar.Location = new Point(506, 181);
            btnFiltrar.Margin = new Padding(3, 4, 3, 4);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(152, 45);
            btnFiltrar.TabIndex = 6;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(363, 189);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(125, 27);
            txtFiltro.TabIndex = 5;
            txtFiltro.Visible = false;
            // 
            // dgvNotas
            // 
            dgvNotas.AllowUserToAddRows = false;
            dgvNotas.AllowUserToDeleteRows = false;
            dgvNotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNotas.BackgroundColor = SystemColors.Control;
            dgvNotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotas.Location = new Point(62, 283);
            dgvNotas.Name = "dgvNotas";
            dgvNotas.ReadOnly = true;
            dgvNotas.RowHeadersWidth = 51;
            dgvNotas.Size = new Size(751, 251);
            dgvNotas.TabIndex = 4;
            dgvNotas.CellContentClick += dgvNotas_CellContentClick;
            dgvNotas.CellFormatting += dgvNotas_CellFormatting;
            // 
            // cmbFiltrarPor
            // 
            cmbFiltrarPor.FormattingEnabled = true;
            cmbFiltrarPor.Location = new Point(181, 189);
            cmbFiltrarPor.Name = "cmbFiltrarPor";
            cmbFiltrarPor.Size = new Size(158, 28);
            cmbFiltrarPor.TabIndex = 3;
            cmbFiltrarPor.SelectedIndexChanged += cmbFiltrarPor_SelectedIndexChanged;
            // 
            // lblFiltrarPor
            // 
            lblFiltrarPor.AutoSize = true;
            lblFiltrarPor.BackColor = Color.Transparent;
            lblFiltrarPor.Font = new Font("Segoe UI", 14.25F);
            lblFiltrarPor.Location = new Point(62, 187);
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
            btnNuevaNota.Location = new Point(62, 55);
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
            btnSalir.Location = new Point(32758, 1387);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(174, 60);
            btnSalir.TabIndex = 16;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // barraSecundaria1
            // 
            barraSecundaria1.BackColor = Color.FromArgb(211, 208, 242);
            barraSecundaria1.Dock = DockStyle.Top;
            barraSecundaria1.Location = new Point(0, 40);
            barraSecundaria1.Name = "barraSecundaria1";
            barraSecundaria1.Size = new Size(1818, 44);
            barraSecundaria1.TabIndex = 17;
            // 
            // barraLateral1
            // 
            barraLateral1.BackColor = Color.FromArgb(205, 213, 221);
            barraLateral1.Dock = DockStyle.Left;
            barraLateral1.Location = new Point(0, 84);
            barraLateral1.Name = "barraLateral1";
            barraLateral1.Size = new Size(289, 1018);
            barraLateral1.TabIndex = 18;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(1550, 191);
            monthCalendar1.Margin = new Padding(10, 12, 10, 12);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 6;
            // 
            // dgvNotasDia
            // 
            dgvNotasDia.AllowUserToAddRows = false;
            dgvNotasDia.AllowUserToDeleteRows = false;
            dgvNotasDia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNotasDia.BackgroundColor = SystemColors.InactiveCaption;
            dgvNotasDia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotasDia.Location = new Point(7, 109);
            dgvNotasDia.Margin = new Padding(3, 4, 3, 4);
            dgvNotasDia.Name = "dgvNotasDia";
            dgvNotasDia.ReadOnly = true;
            dgvNotasDia.RowHeadersWidth = 51;
            dgvNotasDia.Size = new Size(368, 248);
            dgvNotasDia.TabIndex = 0;
            // 
            // rgbNotasDia
            // 
            rgbNotasDia.Controls.Add(lblNDTotales);
            rgbNotasDia.Controls.Add(lblNotasTotalesDia);
            rgbNotasDia.Controls.Add(lblNotasDia);
            rgbNotasDia.Controls.Add(dgvNotasDia);
            rgbNotasDia.Font = new Font("Segoe UI", 9F);
            rgbNotasDia.Location = new Point(1481, 469);
            rgbNotasDia.Margin = new Padding(3, 4, 3, 4);
            rgbNotasDia.Name = "rgbNotasDia";
            rgbNotasDia.Padding = new Padding(3, 4, 3, 4);
            rgbNotasDia.Size = new Size(382, 431);
            rgbNotasDia.TabIndex = 19;
            rgbNotasDia.TabStop = false;
            // 
            // lblNDTotales
            // 
            lblNDTotales.AutoSize = true;
            lblNDTotales.BackColor = Color.Transparent;
            lblNDTotales.Font = new Font("Segoe UI", 14.05F);
            lblNDTotales.Location = new Point(95, 377);
            lblNDTotales.Name = "lblNDTotales";
            lblNDTotales.Size = new Size(105, 32);
            lblNDTotales.TabIndex = 21;
            lblNDTotales.Text = "TOTALES";
            // 
            // lblNotasTotalesDia
            // 
            lblNotasTotalesDia.AutoSize = true;
            lblNotasTotalesDia.BackColor = Color.Transparent;
            lblNotasTotalesDia.Font = new Font("Segoe UI", 14.05F);
            lblNotasTotalesDia.Location = new Point(19, 377);
            lblNotasTotalesDia.Name = "lblNotasTotalesDia";
            lblNotasTotalesDia.Size = new Size(88, 32);
            lblNotasTotalesDia.TabIndex = 20;
            lblNotasTotalesDia.Text = "Notas: ";
            // 
            // lblNotasDia
            // 
            lblNotasDia.AutoSize = true;
            lblNotasDia.BackColor = Color.Transparent;
            lblNotasDia.Font = new Font("Segoe UI", 14.05F, FontStyle.Underline);
            lblNotasDia.Location = new Point(7, 25);
            lblNotasDia.Name = "lblNotasDia";
            lblNotasDia.Size = new Size(155, 32);
            lblNotasDia.TabIndex = 1;
            lblNotasDia.Text = "Notas del día";
            // 
            // frmNotas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1818, 1102);
            Controls.Add(rgbNotasDia);
            Controls.Add(monthCalendar1);
            Controls.Add(barraLateral1);
            Controls.Add(barraSecundaria1);
            Controls.Add(btnSalir);
            Controls.Add(roundGroupBox2);
            Name = "frmNotas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notas";
            WindowState = FormWindowState.Maximized;
            Activated += frmNotas_Activated;
            Load += frmNotas_Load;
            Controls.SetChildIndex(roundGroupBox2, 0);
            Controls.SetChildIndex(btnSalir, 0);
            Controls.SetChildIndex(barraSecundaria1, 0);
            Controls.SetChildIndex(barraLateral1, 0);
            Controls.SetChildIndex(monthCalendar1, 0);
            Controls.SetChildIndex(rgbNotasDia, 0);
            roundGroupBox2.ResumeLayout(false);
            roundGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNotas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvNotasDia).EndInit();
            rgbNotasDia.ResumeLayout(false);
            rgbNotasDia.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private RoundGroupBox roundGroupBox2;
        private Button btnNuevaNota;
        private DataGridView dgvNotas;
        private ComboBox cmbFiltrarPor;
        private Label lblFiltrarPor;
        private Button btnSalir;
        private BarraSecundaria barraSecundaria1;
        private BarraLateral barraLateral1;
        private Button btnFiltrar;
        private TextBox txtFiltro;
        private Button btnFiltroColor;
        private DateTimePicker dtpFiltrarFecha;
        private CheckBox ckbAlarmaFiltro;
        private Button btnRestaurarFiltro;
        private ColorDialog colorDialog1;
        private MonthCalendar monthCalendar1;
        private DataGridView dgvNotasDia;
        private RoundGroupBox rgbNotasDia;
        private Label lblNotasDia;
        private Label lblNotasTotales;
        private Label lblNotasTotalesDia;
        private Label lblNotasTotalesCount;
        private Label lblNDTotales;
    }
}