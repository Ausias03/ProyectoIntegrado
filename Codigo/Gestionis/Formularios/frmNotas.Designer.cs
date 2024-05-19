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
            grbNotasDia = new GroupBox();
            roundGroupBox2 = new RoundGroupBox();
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
            roundGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNotas).BeginInit();
            SuspendLayout();
            // 
            // grbNotasDia
            // 
            grbNotasDia.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline);
            grbNotasDia.Location = new Point(1056, 366);
            grbNotasDia.Margin = new Padding(3, 2, 3, 2);
            grbNotasDia.Name = "grbNotasDia";
            grbNotasDia.Padding = new Padding(3, 2, 3, 2);
            grbNotasDia.Size = new Size(322, 197);
            grbNotasDia.TabIndex = 5;
            grbNotasDia.TabStop = false;
            grbNotasDia.Text = "Notas del día";
            // 
            // roundGroupBox2
            // 
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
            roundGroupBox2.Location = new Point(291, 134);
            roundGroupBox2.Margin = new Padding(3, 2, 3, 2);
            roundGroupBox2.Name = "roundGroupBox2";
            roundGroupBox2.Padding = new Padding(3, 2, 3, 2);
            roundGroupBox2.Size = new Size(585, 364);
            roundGroupBox2.TabIndex = 7;
            roundGroupBox2.TabStop = false;
            roundGroupBox2.Text = "roundGroupBox2";
            // 
            // btnRestaurarFiltro
            // 
            btnRestaurarFiltro.BackColor = Color.FromArgb(178, 242, 187);
            btnRestaurarFiltro.Font = new Font("Segoe UI", 9F);
            btnRestaurarFiltro.Location = new Point(416, 158);
            btnRestaurarFiltro.Name = "btnRestaurarFiltro";
            btnRestaurarFiltro.Size = new Size(88, 23);
            btnRestaurarFiltro.TabIndex = 10;
            btnRestaurarFiltro.Text = "Restaurar";
            btnRestaurarFiltro.UseVisualStyleBackColor = false;
            btnRestaurarFiltro.Click += btnRestaurarFiltro_Click;
            // 
            // ckbAlarmaFiltro
            // 
            ckbAlarmaFiltro.AutoSize = true;
            ckbAlarmaFiltro.Location = new Point(340, 137);
            ckbAlarmaFiltro.Name = "ckbAlarmaFiltro";
            ckbAlarmaFiltro.Size = new Size(15, 14);
            ckbAlarmaFiltro.TabIndex = 9;
            ckbAlarmaFiltro.UseVisualStyleBackColor = true;
            ckbAlarmaFiltro.Visible = false;
            // 
            // dtpFiltrarFecha
            // 
            dtpFiltrarFecha.Format = DateTimePickerFormat.Short;
            dtpFiltrarFecha.Location = new Point(303, 132);
            dtpFiltrarFecha.Margin = new Padding(3, 2, 3, 2);
            dtpFiltrarFecha.Name = "dtpFiltrarFecha";
            dtpFiltrarFecha.Size = new Size(110, 23);
            dtpFiltrarFecha.TabIndex = 8;
            dtpFiltrarFecha.Visible = false;
            // 
            // btnFiltroColor
            // 
            btnFiltroColor.Location = new Point(340, 132);
            btnFiltroColor.Margin = new Padding(3, 2, 3, 2);
            btnFiltroColor.Name = "btnFiltroColor";
            btnFiltroColor.Size = new Size(31, 22);
            btnFiltroColor.TabIndex = 7;
            btnFiltroColor.UseVisualStyleBackColor = true;
            btnFiltroColor.Visible = false;
            btnFiltroColor.Click += btnFiltroColor_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = Color.FromArgb(178, 242, 187);
            btnFiltrar.Font = new Font("Segoe UI", 9F);
            btnFiltrar.Location = new Point(416, 132);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(88, 23);
            btnFiltrar.TabIndex = 6;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(303, 131);
            txtFiltro.Margin = new Padding(3, 2, 3, 2);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(110, 23);
            txtFiltro.TabIndex = 5;
            txtFiltro.Visible = false;
            // 
            // dgvNotas
            // 
            dgvNotas.AllowUserToDeleteRows = false;
            dgvNotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotas.Location = new Point(47, 186);
            dgvNotas.Margin = new Padding(3, 2, 3, 2);
            dgvNotas.Name = "dgvNotas";
            dgvNotas.ReadOnly = true;
            dgvNotas.RowHeadersWidth = 51;
            dgvNotas.Size = new Size(456, 141);
            dgvNotas.TabIndex = 4;
            // 
            // cmbFiltrarPor
            // 
            cmbFiltrarPor.FormattingEnabled = true;
            cmbFiltrarPor.Location = new Point(158, 132);
            cmbFiltrarPor.Margin = new Padding(3, 2, 3, 2);
            cmbFiltrarPor.Name = "cmbFiltrarPor";
            cmbFiltrarPor.Size = new Size(139, 23);
            cmbFiltrarPor.TabIndex = 3;
            cmbFiltrarPor.SelectedIndexChanged += cmbFiltrarPor_SelectedIndexChanged;
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
            btnSalir.Location = new Point(32767, 612);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(152, 45);
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
            barraSecundaria1.Margin = new Padding(3, 2, 3, 2);
            barraSecundaria1.Name = "barraSecundaria1";
            barraSecundaria1.Size = new Size(1485, 33);
            barraSecundaria1.TabIndex = 17;
            // 
            // barraLateral1
            // 
            barraLateral1.BackColor = Color.FromArgb(205, 213, 221);
            barraLateral1.Dock = DockStyle.Left;
            barraLateral1.Location = new Point(0, 73);
            barraLateral1.Margin = new Padding(3, 2, 3, 2);
            barraLateral1.Name = "barraLateral1";
            barraLateral1.Size = new Size(253, 603);
            barraLateral1.TabIndex = 18;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(1056, 134);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 6;
            // 
            // frmNotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1485, 676);
            Controls.Add(monthCalendar1);
            Controls.Add(barraLateral1);
            Controls.Add(barraSecundaria1);
            Controls.Add(btnSalir);
            Controls.Add(roundGroupBox2);
            Controls.Add(grbNotasDia);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmNotas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notas";
            WindowState = FormWindowState.Maximized;
            Activated += frmNotas_Activated;
            Load += frmNotas_Load;
            Controls.SetChildIndex(grbNotasDia, 0);
            Controls.SetChildIndex(roundGroupBox2, 0);
            Controls.SetChildIndex(btnSalir, 0);
            Controls.SetChildIndex(barraSecundaria1, 0);
            Controls.SetChildIndex(barraLateral1, 0);
            Controls.SetChildIndex(monthCalendar1, 0);
            roundGroupBox2.ResumeLayout(false);
            roundGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNotas).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox grbNotasDia;
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
    }
}