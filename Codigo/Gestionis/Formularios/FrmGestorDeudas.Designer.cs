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
            roundGroupBox1 = new RoundGroupBox();
            chkDebo = new CheckBox();
            lblTitulo = new Label();
            txtTitulo = new TextBox();
            lblDeudasTotalesValor = new Label();
            lblDeudasTotales = new Label();
            btnBuscar = new Button();
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
            btnEliminarDeuda = new Button();
            btnAnyadirDeuda = new Button();
            rgbResumen = new RoundGroupBox();
            lblResumen = new Label();
            lblSaldoValor = new Label();
            lblSaldo = new Label();
            label2 = new Label();
            label1 = new Label();
            lblMeDeben = new Label();
            lblDeboBarra = new Label();
            barraSecundaria = new BarraSecundaria();
            barraLateral1 = new BarraLateral();
            roundGroupBox1.SuspendLayout();
            pnlInfoDeuda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGastosIngresos).BeginInit();
            rgbResumen.SuspendLayout();
            SuspendLayout();
            // 
            // roundGroupBox1
            // 
            roundGroupBox1.Controls.Add(chkDebo);
            roundGroupBox1.Controls.Add(lblTitulo);
            roundGroupBox1.Controls.Add(txtTitulo);
            roundGroupBox1.Controls.Add(lblDeudasTotalesValor);
            roundGroupBox1.Controls.Add(lblDeudasTotales);
            roundGroupBox1.Controls.Add(btnBuscar);
            roundGroupBox1.Controls.Add(pnlInfoDeuda);
            roundGroupBox1.Controls.Add(cmbCategoria);
            roundGroupBox1.Controls.Add(dgvGastosIngresos);
            roundGroupBox1.Controls.Add(btnRestaurar);
            roundGroupBox1.Controls.Add(btnEliminarDeuda);
            roundGroupBox1.Controls.Add(btnAnyadirDeuda);
            roundGroupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundGroupBox1.Location = new Point(246, 104);
            roundGroupBox1.Margin = new Padding(3, 2, 3, 2);
            roundGroupBox1.Name = "roundGroupBox1";
            roundGroupBox1.Padding = new Padding(3, 2, 3, 2);
            roundGroupBox1.Size = new Size(782, 524);
            roundGroupBox1.TabIndex = 0;
            roundGroupBox1.TabStop = false;
            roundGroupBox1.Text = "rgpDeudas";
            // 
            // chkDebo
            // 
            chkDebo.AutoSize = true;
            chkDebo.BackColor = Color.Transparent;
            chkDebo.Checked = true;
            chkDebo.CheckState = CheckState.Checked;
            chkDebo.Location = new Point(446, 200);
            chkDebo.Margin = new Padding(2);
            chkDebo.Name = "chkDebo";
            chkDebo.Size = new Size(76, 29);
            chkDebo.TabIndex = 19;
            chkDebo.Text = "Debo";
            chkDebo.UseVisualStyleBackColor = false;
            chkDebo.CheckedChanged += chkDebo_CheckedChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Enabled = false;
            lblTitulo.Location = new Point(43, 156);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(166, 25);
            lblTitulo.TabIndex = 18;
            lblTitulo.Text = "Introduce el título:";
            // 
            // txtTitulo
            // 
            txtTitulo.Enabled = false;
            txtTitulo.Location = new Point(210, 154);
            txtTitulo.Margin = new Padding(2);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(172, 32);
            txtTitulo.TabIndex = 12;
            // 
            // lblDeudasTotalesValor
            // 
            lblDeudasTotalesValor.AutoSize = true;
            lblDeudasTotalesValor.BackColor = Color.Transparent;
            lblDeudasTotalesValor.Location = new Point(184, 466);
            lblDeudasTotalesValor.Name = "lblDeudasTotalesValor";
            lblDeudasTotalesValor.Size = new Size(140, 25);
            lblDeudasTotalesValor.TabIndex = 11;
            lblDeudasTotalesValor.Text = "Deudas totales:";
            // 
            // lblDeudasTotales
            // 
            lblDeudasTotales.AutoSize = true;
            lblDeudasTotales.BackColor = Color.Transparent;
            lblDeudasTotales.Location = new Point(50, 466);
            lblDeudasTotales.Name = "lblDeudasTotales";
            lblDeudasTotales.Size = new Size(140, 25);
            lblDeudasTotales.TabIndex = 10;
            lblDeudasTotales.Text = "Deudas totales:";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(178, 242, 187);
            btnBuscar.Location = new Point(43, 195);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(136, 42);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
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
            pnlInfoDeuda.Location = new Point(446, 31);
            pnlInfoDeuda.Margin = new Padding(3, 2, 3, 2);
            pnlInfoDeuda.Name = "pnlInfoDeuda";
            pnlInfoDeuda.Size = new Size(292, 113);
            pnlInfoDeuda.TabIndex = 9;
            // 
            // lblTipoValor
            // 
            lblTipoValor.AutoSize = true;
            lblTipoValor.BackColor = Color.Transparent;
            lblTipoValor.Location = new Point(144, 74);
            lblTipoValor.Name = "lblTipoValor";
            lblTipoValor.Size = new Size(53, 25);
            lblTipoValor.TabIndex = 17;
            lblTipoValor.Text = "Tipo:";
            // 
            // lblFechaLimiteValor
            // 
            lblFechaLimiteValor.AutoSize = true;
            lblFechaLimiteValor.BackColor = Color.Transparent;
            lblFechaLimiteValor.Location = new Point(144, 38);
            lblFechaLimiteValor.Name = "lblFechaLimiteValor";
            lblFechaLimiteValor.Size = new Size(53, 25);
            lblFechaLimiteValor.TabIndex = 16;
            lblFechaLimiteValor.Text = "Tipo:";
            // 
            // lblProximaDeudaValor
            // 
            lblProximaDeudaValor.AutoSize = true;
            lblProximaDeudaValor.BackColor = Color.Transparent;
            lblProximaDeudaValor.Location = new Point(144, 5);
            lblProximaDeudaValor.Name = "lblProximaDeudaValor";
            lblProximaDeudaValor.Size = new Size(53, 25);
            lblProximaDeudaValor.TabIndex = 15;
            lblProximaDeudaValor.Text = "Tipo:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.BackColor = Color.Transparent;
            lblTipo.Location = new Point(86, 72);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(53, 25);
            lblTipo.TabIndex = 14;
            lblTipo.Text = "Tipo:";
            // 
            // lblFechaLimite
            // 
            lblFechaLimite.AutoSize = true;
            lblFechaLimite.BackColor = Color.Transparent;
            lblFechaLimite.Location = new Point(24, 38);
            lblFechaLimite.Name = "lblFechaLimite";
            lblFechaLimite.Size = new Size(117, 25);
            lblFechaLimite.TabIndex = 13;
            lblFechaLimite.Text = "Fecha límite:";
            // 
            // lblProximaDeuda
            // 
            lblProximaDeuda.AutoSize = true;
            lblProximaDeuda.BackColor = Color.Transparent;
            lblProximaDeuda.Location = new Point(-1, 5);
            lblProximaDeuda.Name = "lblProximaDeuda";
            lblProximaDeuda.Size = new Size(143, 25);
            lblProximaDeuda.TabIndex = 12;
            lblProximaDeuda.Text = "Próxima deuda:";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(198, 198);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(214, 33);
            cmbCategoria.TabIndex = 8;
            cmbCategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;
            // 
            // dgvGastosIngresos
            // 
            dgvGastosIngresos.AllowUserToAddRows = false;
            dgvGastosIngresos.AllowUserToDeleteRows = false;
            dgvGastosIngresos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGastosIngresos.BackgroundColor = Color.White;
            dgvGastosIngresos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGastosIngresos.GridColor = SystemColors.InfoText;
            dgvGastosIngresos.Location = new Point(25, 246);
            dgvGastosIngresos.Name = "dgvGastosIngresos";
            dgvGastosIngresos.ReadOnly = true;
            dgvGastosIngresos.RowHeadersWidth = 51;
            dgvGastosIngresos.Size = new Size(735, 209);
            dgvGastosIngresos.TabIndex = 7;
            // 
            // btnRestaurar
            // 
            btnRestaurar.BackColor = Color.FromArgb(178, 242, 187);
            btnRestaurar.Location = new Point(578, 195);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(160, 42);
            btnRestaurar.TabIndex = 4;
            btnRestaurar.Text = "Restaurar";
            btnRestaurar.UseVisualStyleBackColor = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnEliminarDeuda
            // 
            btnEliminarDeuda.BackColor = Color.FromArgb(178, 242, 187);
            btnEliminarDeuda.Location = new Point(61, 80);
            btnEliminarDeuda.Name = "btnEliminarDeuda";
            btnEliminarDeuda.Size = new Size(160, 35);
            btnEliminarDeuda.TabIndex = 2;
            btnEliminarDeuda.Text = "Eliminar Deuda";
            btnEliminarDeuda.UseVisualStyleBackColor = false;
            btnEliminarDeuda.Click += btnEliminarDeuda_Click;
            // 
            // btnAnyadirDeuda
            // 
            btnAnyadirDeuda.BackColor = Color.FromArgb(178, 242, 187);
            btnAnyadirDeuda.Location = new Point(61, 31);
            btnAnyadirDeuda.Name = "btnAnyadirDeuda";
            btnAnyadirDeuda.Size = new Size(160, 35);
            btnAnyadirDeuda.TabIndex = 1;
            btnAnyadirDeuda.Text = "Añadir deuda";
            btnAnyadirDeuda.UseVisualStyleBackColor = false;
            btnAnyadirDeuda.Click += btnAnyadirDeuda_Click;
            // 
            // rgbResumen
            // 
            rgbResumen.Controls.Add(lblResumen);
            rgbResumen.Controls.Add(lblSaldoValor);
            rgbResumen.Controls.Add(lblSaldo);
            rgbResumen.Controls.Add(label2);
            rgbResumen.Controls.Add(label1);
            rgbResumen.Controls.Add(lblMeDeben);
            rgbResumen.Controls.Add(lblDeboBarra);
            rgbResumen.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rgbResumen.Location = new Point(1068, 135);
            rgbResumen.Margin = new Padding(3, 2, 3, 2);
            rgbResumen.Name = "rgbResumen";
            rgbResumen.Padding = new Padding(3, 2, 3, 2);
            rgbResumen.Size = new Size(290, 322);
            rgbResumen.TabIndex = 28;
            rgbResumen.TabStop = false;
            rgbResumen.Text = "roundGroupBox2";
            // 
            // lblResumen
            // 
            lblResumen.AutoSize = true;
            lblResumen.BackColor = Color.Transparent;
            lblResumen.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResumen.Location = new Point(64, 20);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(154, 25);
            lblResumen.TabIndex = 12;
            lblResumen.Text = "RESUMEN TOTAL";
            // 
            // lblSaldoValor
            // 
            lblSaldoValor.AutoSize = true;
            lblSaldoValor.BackColor = Color.Transparent;
            lblSaldoValor.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblSaldoValor.Location = new Point(119, 278);
            lblSaldoValor.Name = "lblSaldoValor";
            lblSaldoValor.Size = new Size(101, 25);
            lblSaldoValor.TabIndex = 20;
            lblSaldoValor.Text = "Me deben:";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.BackColor = Color.Transparent;
            lblSaldo.Location = new Point(64, 278);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(63, 25);
            lblSaldo.TabIndex = 19;
            lblSaldo.Text = "Saldo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(8, 32);
            label2.Name = "label2";
            label2.Size = new Size(268, 25);
            label2.TabIndex = 18;
            label2.Text = "________________________________";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(8, 241);
            label1.Name = "label1";
            label1.Size = new Size(268, 25);
            label1.TabIndex = 17;
            label1.Text = "________________________________";
            // 
            // lblMeDeben
            // 
            lblMeDeben.AutoSize = true;
            lblMeDeben.BackColor = Color.Transparent;
            lblMeDeben.Location = new Point(8, 196);
            lblMeDeben.Name = "lblMeDeben";
            lblMeDeben.Size = new Size(101, 25);
            lblMeDeben.TabIndex = 16;
            lblMeDeben.Text = "Me deben:";
            // 
            // lblDeboBarra
            // 
            lblDeboBarra.AutoSize = true;
            lblDeboBarra.BackColor = Color.Transparent;
            lblDeboBarra.Location = new Point(8, 104);
            lblDeboBarra.Name = "lblDeboBarra";
            lblDeboBarra.Size = new Size(61, 25);
            lblDeboBarra.TabIndex = 15;
            lblDeboBarra.Text = "Debo:";
            // 
            // barraSecundaria
            // 
            barraSecundaria.BackColor = Color.FromArgb(211, 208, 242);
            barraSecundaria.Dock = DockStyle.Top;
            barraSecundaria.Location = new Point(0, 40);
            barraSecundaria.Name = "barraSecundaria";
            barraSecundaria.Size = new Size(1839, 35);
            barraSecundaria.TabIndex = 29;
            // 
            // barraLateral1
            // 
            barraLateral1.BackColor = Color.FromArgb(205, 213, 221);
            barraLateral1.Dock = DockStyle.Left;
            barraLateral1.Location = new Point(0, 75);
            barraLateral1.Name = "barraLateral1";
            barraLateral1.Size = new Size(210, 830);
            barraLateral1.TabIndex = 30;
            // 
            // FrmGestorDeudas
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(233, 236, 239);
            ClientSize = new Size(1839, 905);
            Controls.Add(barraLateral1);
            Controls.Add(barraSecundaria);
            Controls.Add(rgbResumen);
            Controls.Add(roundGroupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmGestorDeudas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmGestorDeudas";
            WindowState = FormWindowState.Maximized;
            Load += FrmGestorDeudas_Load;
            Controls.SetChildIndex(roundGroupBox1, 0);
            Controls.SetChildIndex(rgbResumen, 0);
            Controls.SetChildIndex(barraSecundaria, 0);
            Controls.SetChildIndex(barraLateral1, 0);
            roundGroupBox1.ResumeLayout(false);
            roundGroupBox1.PerformLayout();
            pnlInfoDeuda.ResumeLayout(false);
            pnlInfoDeuda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGastosIngresos).EndInit();
            rgbResumen.ResumeLayout(false);
            rgbResumen.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RoundGroupBox roundGroupBox1;
        private Button btnAnyadirDeuda;
        private Button btnEliminarDeuda;
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
        private RoundGroupBox rgbResumen;
        private Label lblResumen;
        private CheckBox chkDebo;
        private Label lblTitulo;
        private TextBox txtTitulo;
        private Label lblDeboBarra;
        private Label lblSaldoValor;
        private Label lblSaldo;
        private Label label2;
        private Label label1;
        private Label lblMeDeben;
        private BarraSecundaria barraSecundaria;
        private BarraLateral barraLateral1;
    }
}