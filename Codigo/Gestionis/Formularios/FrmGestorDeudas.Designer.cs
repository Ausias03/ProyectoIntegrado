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
            lblMeDebenTotal = new Label();
            lblDeboTotal = new Label();
            vpbMeDeben = new Controles.VerticalProgressBar();
            lblMeDeben = new Label();
            lblDeboBarra = new Label();
            vpbDebo = new Controles.VerticalProgressBar();
            lblResumen = new Label();
            lblSaldoValor = new Label();
            lblSaldo = new Label();
            label2 = new Label();
            label1 = new Label();
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
            roundGroupBox1.Location = new Point(308, 130);
            roundGroupBox1.Margin = new Padding(4, 2, 4, 2);
            roundGroupBox1.Name = "roundGroupBox1";
            roundGroupBox1.Padding = new Padding(4, 2, 4, 2);
            roundGroupBox1.Size = new Size(978, 655);
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
            chkDebo.Location = new Point(558, 250);
            chkDebo.Margin = new Padding(2);
            chkDebo.Name = "chkDebo";
            chkDebo.Size = new Size(91, 35);
            chkDebo.TabIndex = 19;
            chkDebo.Text = "Debo";
            chkDebo.UseVisualStyleBackColor = false;
            chkDebo.CheckedChanged += chkDebo_CheckedChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Location = new Point(54, 195);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(201, 31);
            lblTitulo.TabIndex = 18;
            lblTitulo.Text = "Introduce el título:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(262, 192);
            txtTitulo.Margin = new Padding(2);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(214, 38);
            txtTitulo.TabIndex = 12;
            // 
            // lblDeudasTotalesValor
            // 
            lblDeudasTotalesValor.AutoSize = true;
            lblDeudasTotalesValor.BackColor = Color.Transparent;
            lblDeudasTotalesValor.Location = new Point(236, 582);
            lblDeudasTotalesValor.Margin = new Padding(4, 0, 4, 0);
            lblDeudasTotalesValor.Name = "lblDeudasTotalesValor";
            lblDeudasTotalesValor.Size = new Size(38, 31);
            lblDeudasTotalesValor.TabIndex = 11;
            lblDeudasTotalesValor.Text = "99";
            // 
            // lblDeudasTotales
            // 
            lblDeudasTotales.AutoSize = true;
            lblDeudasTotales.BackColor = Color.Transparent;
            lblDeudasTotales.Location = new Point(62, 582);
            lblDeudasTotales.Margin = new Padding(4, 0, 4, 0);
            lblDeudasTotales.Name = "lblDeudasTotales";
            lblDeudasTotales.Size = new Size(171, 31);
            lblDeudasTotales.TabIndex = 10;
            lblDeudasTotales.Text = "Deudas totales:";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(178, 242, 187);
            btnBuscar.Location = new Point(54, 244);
            btnBuscar.Margin = new Padding(4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(170, 52);
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
            pnlInfoDeuda.Location = new Point(558, 39);
            pnlInfoDeuda.Margin = new Padding(4, 2, 4, 2);
            pnlInfoDeuda.Name = "pnlInfoDeuda";
            pnlInfoDeuda.Size = new Size(364, 141);
            pnlInfoDeuda.TabIndex = 9;
            // 
            // lblTipoValor
            // 
            lblTipoValor.AutoSize = true;
            lblTipoValor.BackColor = Color.Transparent;
            lblTipoValor.Location = new Point(180, 92);
            lblTipoValor.Margin = new Padding(4, 0, 4, 0);
            lblTipoValor.Name = "lblTipoValor";
            lblTipoValor.Size = new Size(64, 31);
            lblTipoValor.TabIndex = 17;
            lblTipoValor.Text = "Tipo:";
            // 
            // lblFechaLimiteValor
            // 
            lblFechaLimiteValor.AutoSize = true;
            lblFechaLimiteValor.BackColor = Color.Transparent;
            lblFechaLimiteValor.Location = new Point(180, 48);
            lblFechaLimiteValor.Margin = new Padding(4, 0, 4, 0);
            lblFechaLimiteValor.Name = "lblFechaLimiteValor";
            lblFechaLimiteValor.Size = new Size(64, 31);
            lblFechaLimiteValor.TabIndex = 16;
            lblFechaLimiteValor.Text = "Tipo:";
            // 
            // lblProximaDeudaValor
            // 
            lblProximaDeudaValor.AutoSize = true;
            lblProximaDeudaValor.BackColor = Color.Transparent;
            lblProximaDeudaValor.Location = new Point(180, 6);
            lblProximaDeudaValor.Margin = new Padding(4, 0, 4, 0);
            lblProximaDeudaValor.Name = "lblProximaDeudaValor";
            lblProximaDeudaValor.Size = new Size(64, 31);
            lblProximaDeudaValor.TabIndex = 15;
            lblProximaDeudaValor.Text = "Tipo:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.BackColor = Color.Transparent;
            lblTipo.Location = new Point(108, 90);
            lblTipo.Margin = new Padding(4, 0, 4, 0);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(64, 31);
            lblTipo.TabIndex = 14;
            lblTipo.Text = "Tipo:";
            // 
            // lblFechaLimite
            // 
            lblFechaLimite.AutoSize = true;
            lblFechaLimite.BackColor = Color.Transparent;
            lblFechaLimite.Location = new Point(30, 48);
            lblFechaLimite.Margin = new Padding(4, 0, 4, 0);
            lblFechaLimite.Name = "lblFechaLimite";
            lblFechaLimite.Size = new Size(142, 31);
            lblFechaLimite.TabIndex = 13;
            lblFechaLimite.Text = "Fecha límite:";
            // 
            // lblProximaDeuda
            // 
            lblProximaDeuda.AutoSize = true;
            lblProximaDeuda.BackColor = Color.Transparent;
            lblProximaDeuda.Location = new Point(-1, 6);
            lblProximaDeuda.Margin = new Padding(4, 0, 4, 0);
            lblProximaDeuda.Name = "lblProximaDeuda";
            lblProximaDeuda.Size = new Size(173, 31);
            lblProximaDeuda.TabIndex = 12;
            lblProximaDeuda.Text = "Próxima deuda:";
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(248, 248);
            cmbCategoria.Margin = new Padding(4);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(266, 39);
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
            dgvGastosIngresos.Location = new Point(31, 308);
            dgvGastosIngresos.Margin = new Padding(4);
            dgvGastosIngresos.Name = "dgvGastosIngresos";
            dgvGastosIngresos.ReadOnly = true;
            dgvGastosIngresos.RowHeadersWidth = 51;
            dgvGastosIngresos.Size = new Size(919, 261);
            dgvGastosIngresos.TabIndex = 7;
            // 
            // btnRestaurar
            // 
            btnRestaurar.BackColor = Color.FromArgb(178, 242, 187);
            btnRestaurar.Location = new Point(722, 244);
            btnRestaurar.Margin = new Padding(4);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(200, 52);
            btnRestaurar.TabIndex = 4;
            btnRestaurar.Text = "Mostrar Todo";
            btnRestaurar.UseVisualStyleBackColor = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnEliminarDeuda
            // 
            btnEliminarDeuda.BackColor = Color.FromArgb(178, 242, 187);
            btnEliminarDeuda.Location = new Point(76, 100);
            btnEliminarDeuda.Margin = new Padding(4);
            btnEliminarDeuda.Name = "btnEliminarDeuda";
            btnEliminarDeuda.Size = new Size(200, 44);
            btnEliminarDeuda.TabIndex = 2;
            btnEliminarDeuda.Text = "Eliminar Deuda";
            btnEliminarDeuda.UseVisualStyleBackColor = false;
            btnEliminarDeuda.Click += btnEliminarDeuda_Click;
            // 
            // btnAnyadirDeuda
            // 
            btnAnyadirDeuda.BackColor = Color.FromArgb(178, 242, 187);
            btnAnyadirDeuda.Location = new Point(76, 39);
            btnAnyadirDeuda.Margin = new Padding(4);
            btnAnyadirDeuda.Name = "btnAnyadirDeuda";
            btnAnyadirDeuda.Size = new Size(200, 44);
            btnAnyadirDeuda.TabIndex = 1;
            btnAnyadirDeuda.Text = "Añadir deuda";
            btnAnyadirDeuda.UseVisualStyleBackColor = false;
            btnAnyadirDeuda.Click += btnAnyadirDeuda_Click;
            // 
            // rgbResumen
            // 
            rgbResumen.Controls.Add(lblMeDebenTotal);
            rgbResumen.Controls.Add(lblDeboTotal);
            rgbResumen.Controls.Add(vpbMeDeben);
            rgbResumen.Controls.Add(lblMeDeben);
            rgbResumen.Controls.Add(lblDeboBarra);
            rgbResumen.Controls.Add(vpbDebo);
            rgbResumen.Controls.Add(lblResumen);
            rgbResumen.Controls.Add(lblSaldoValor);
            rgbResumen.Controls.Add(lblSaldo);
            rgbResumen.Controls.Add(label2);
            rgbResumen.Controls.Add(label1);
            rgbResumen.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rgbResumen.Location = new Point(1335, 169);
            rgbResumen.Margin = new Padding(4, 2, 4, 2);
            rgbResumen.Name = "rgbResumen";
            rgbResumen.Padding = new Padding(4, 2, 4, 2);
            rgbResumen.Size = new Size(362, 402);
            rgbResumen.TabIndex = 28;
            rgbResumen.TabStop = false;
            rgbResumen.Text = "roundGroupBox2";
            // 
            // lblMeDebenTotal
            // 
            lblMeDebenTotal.AutoSize = true;
            lblMeDebenTotal.BackColor = Color.Transparent;
            lblMeDebenTotal.Location = new Point(222, 272);
            lblMeDebenTotal.Margin = new Padding(4, 0, 4, 0);
            lblMeDebenTotal.Name = "lblMeDebenTotal";
            lblMeDebenTotal.Size = new Size(69, 31);
            lblMeDebenTotal.TabIndex = 34;
            lblMeDebenTotal.Text = "Debo";
            // 
            // lblDeboTotal
            // 
            lblDeboTotal.AutoSize = true;
            lblDeboTotal.BackColor = Color.Transparent;
            lblDeboTotal.Location = new Point(69, 272);
            lblDeboTotal.Margin = new Padding(4, 0, 4, 0);
            lblDeboTotal.Name = "lblDeboTotal";
            lblDeboTotal.Size = new Size(69, 31);
            lblDeboTotal.TabIndex = 33;
            lblDeboTotal.Text = "Debo";
            // 
            // vpbMeDeben
            // 
            vpbMeDeben.Location = new Point(208, 88);
            vpbMeDeben.Margin = new Padding(4);
            vpbMeDeben.Name = "vpbMeDeben";
            vpbMeDeben.Size = new Size(101, 184);
            vpbMeDeben.TabIndex = 32;
            // 
            // lblMeDeben
            // 
            lblMeDeben.AutoSize = true;
            lblMeDeben.BackColor = Color.Transparent;
            lblMeDeben.Location = new Point(195, 302);
            lblMeDeben.Margin = new Padding(4, 0, 4, 0);
            lblMeDeben.Name = "lblMeDeben";
            lblMeDeben.Size = new Size(118, 31);
            lblMeDeben.TabIndex = 16;
            lblMeDeben.Text = "Me deben";
            // 
            // lblDeboBarra
            // 
            lblDeboBarra.AutoSize = true;
            lblDeboBarra.BackColor = Color.Transparent;
            lblDeboBarra.Location = new Point(69, 302);
            lblDeboBarra.Margin = new Padding(4, 0, 4, 0);
            lblDeboBarra.Name = "lblDeboBarra";
            lblDeboBarra.Size = new Size(69, 31);
            lblDeboBarra.TabIndex = 15;
            lblDeboBarra.Text = "Debo";
            // 
            // vpbDebo
            // 
            vpbDebo.Location = new Point(55, 88);
            vpbDebo.Margin = new Padding(4);
            vpbDebo.Name = "vpbDebo";
            vpbDebo.Size = new Size(101, 184);
            vpbDebo.TabIndex = 31;
            // 
            // lblResumen
            // 
            lblResumen.AutoSize = true;
            lblResumen.BackColor = Color.Transparent;
            lblResumen.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResumen.Location = new Point(80, 16);
            lblResumen.Margin = new Padding(4, 0, 4, 0);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(194, 32);
            lblResumen.TabIndex = 12;
            lblResumen.Text = "RESUMEN TOTAL";
            // 
            // lblSaldoValor
            // 
            lblSaldoValor.AutoSize = true;
            lblSaldoValor.BackColor = Color.Transparent;
            lblSaldoValor.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblSaldoValor.Location = new Point(176, 351);
            lblSaldoValor.Margin = new Padding(4, 0, 4, 0);
            lblSaldoValor.Name = "lblSaldoValor";
            lblSaldoValor.Size = new Size(66, 32);
            lblSaldoValor.TabIndex = 20;
            lblSaldoValor.Text = "9999";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.BackColor = Color.Transparent;
            lblSaldo.Location = new Point(105, 351);
            lblSaldo.Margin = new Padding(4, 0, 4, 0);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(76, 31);
            lblSaldo.TabIndex = 19;
            lblSaldo.Text = "Saldo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(10, 31);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(334, 31);
            label2.TabIndex = 18;
            label2.Text = "________________________________";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(10, 316);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(334, 31);
            label1.TabIndex = 17;
            label1.Text = "________________________________";
            // 
            // barraSecundaria
            // 
            barraSecundaria.BackColor = Color.FromArgb(211, 208, 242);
            barraSecundaria.Dock = DockStyle.Top;
            barraSecundaria.Location = new Point(0, 40);
            barraSecundaria.Margin = new Padding(4);
            barraSecundaria.Name = "barraSecundaria";
            barraSecundaria.Size = new Size(1818, 44);
            barraSecundaria.TabIndex = 29;
            // 
            // barraLateral1
            // 
            barraLateral1.BackColor = Color.FromArgb(205, 213, 221);
            barraLateral1.Dock = DockStyle.Left;
            barraLateral1.Location = new Point(0, 84);
            barraLateral1.Margin = new Padding(4);
            barraLateral1.Name = "barraLateral1";
            barraLateral1.Size = new Size(289, 1016);
            barraLateral1.TabIndex = 30;
            // 
            // FrmGestorDeudas
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(233, 236, 239);
            ClientSize = new Size(1818, 1100);
            Controls.Add(barraLateral1);
            Controls.Add(barraSecundaria);
            Controls.Add(rgbResumen);
            Controls.Add(roundGroupBox1);
            Margin = new Padding(4, 2, 4, 2);
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
        private Controles.VerticalProgressBar vpbMeDeben;
        private Controles.VerticalProgressBar vpbDebo;
        private Label lblMeDebenTotal;
        private Label lblDeboTotal;
    }
}