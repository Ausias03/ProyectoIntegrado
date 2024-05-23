using Gestionis.Herramientas;

namespace Gestionis
{
    partial class frmMetodosAhorro
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
            lblIngresosMes = new Label();
            lblLinea = new Label();
            lblIngresoMesCont = new Label();
            dgvGastosFijos = new DataGridView();
            label1 = new Label();
            lblGastosFijos = new Label();
            label2 = new Label();
            label3 = new Label();
            dgvGastosVariables = new DataGridView();
            label4 = new Label();
            lblTotalValorFijo = new Label();
            lblPorcentajeFijo = new Label();
            pbDot = new PictureBox();
            pbArrow2 = new PictureBox();
            pbArrow4 = new PictureBox();
            pbDot2 = new PictureBox();
            lblPorcentajeVariable = new Label();
            lblTotalValorVariables = new Label();
            lblTotalGastosVariable = new Label();
            label5 = new Label();
            label6 = new Label();
            lblDineroRest = new Label();
            pbArrow5 = new PictureBox();
            lblPorcentajeRest = new Label();
            label7 = new Label();
            pnlBarra1 = new Panel();
            pnlContenedorOpc = new Panel();
            btnPersonalizado = new Button();
            btn503020 = new Button();
            btnHarvEker = new Button();
            btnSalir = new Button();
            lblKakebo = new Label();
            label15 = new Label();
            lblPorcentajes = new Label();
            label16 = new Label();
            barraSecundaria1 = new BarraSecundaria();
            lblLineaFijos = new Label();
            label8 = new Label();
            pnlGastoFijo = new RoundGroupBox();
            pnlGastoVariable = new RoundGroupBox();
            pnl503020 = new RoundGroupBox();
            label10 = new Label();
            label11 = new Label();
            lblAhorroPorDin = new Label();
            label18 = new Label();
            lblGPPorDin = new Label();
            pbArrow9 = new PictureBox();
            pbArrow8 = new PictureBox();
            pbArrow10 = new PictureBox();
            pbArrow7 = new PictureBox();
            label20 = new Label();
            pbArrow11 = new PictureBox();
            label21 = new Label();
            lblGPresValor = new Label();
            lblNecBasicasValor = new Label();
            lblAhorroDinValor = new Label();
            lblNecPresValor = new Label();
            lblGMNecPorDin = new Label();
            lblGMNecValor = new Label();
            label28 = new Label();
            lblAhoValor = new Label();
            pbArrow6 = new PictureBox();
            label30 = new Label();
            label31 = new Label();
            label32 = new Label();
            lblInfo = new Label();
            lblInfo2 = new Label();
            barraLateral2 = new BarraLateral();
            ((System.ComponentModel.ISupportInitialize)dgvGastosFijos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGastosVariables).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDot).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbArrow2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbArrow4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDot2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbArrow5).BeginInit();
            pnlContenedorOpc.SuspendLayout();
            pnlGastoFijo.SuspendLayout();
            pnlGastoVariable.SuspendLayout();
            pnl503020.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbArrow9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbArrow8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbArrow10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbArrow7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbArrow11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbArrow6).BeginInit();
            SuspendLayout();
            // 
            // lblIngresosMes
            // 
            lblIngresosMes.AutoSize = true;
            lblIngresosMes.Font = new Font("Segoe UI", 16F);
            lblIngresosMes.Location = new Point(859, 186);
            lblIngresosMes.Name = "lblIngresosMes";
            lblIngresosMes.Size = new Size(267, 37);
            lblIngresosMes.TabIndex = 20;
            lblIngresosMes.Text = "Ingresos  mensuales: ";
            // 
            // lblLinea
            // 
            lblLinea.AutoSize = true;
            lblLinea.BackColor = Color.Transparent;
            lblLinea.Font = new Font("Segoe UI", 16F);
            lblLinea.ForeColor = Color.FromArgb(0, 192, 0);
            lblLinea.Location = new Point(1106, 186);
            lblLinea.Name = "lblLinea";
            lblLinea.Size = new Size(127, 37);
            lblLinea.TabIndex = 21;
            lblLinea.Text = "__________";
            // 
            // lblIngresoMesCont
            // 
            lblIngresoMesCont.AutoSize = true;
            lblIngresoMesCont.Font = new Font("Segoe UI", 16F);
            lblIngresoMesCont.Location = new Point(1126, 181);
            lblIngresoMesCont.Name = "lblIngresoMesCont";
            lblIngresoMesCont.Size = new Size(94, 37);
            lblIngresoMesCont.TabIndex = 22;
            lblIngresoMesCont.Text = "dinero";
            // 
            // dgvGastosFijos
            // 
            dgvGastosFijos.AllowUserToAddRows = false;
            dgvGastosFijos.AllowUserToDeleteRows = false;
            dgvGastosFijos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGastosFijos.BackgroundColor = SystemColors.Control;
            dgvGastosFijos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGastosFijos.Location = new Point(365, 312);
            dgvGastosFijos.Name = "dgvGastosFijos";
            dgvGastosFijos.ReadOnly = true;
            dgvGastosFijos.RowHeadersWidth = 51;
            dgvGastosFijos.Size = new Size(538, 188);
            dgvGastosFijos.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(24, 11);
            label1.Name = "label1";
            label1.Size = new Size(144, 32);
            label1.TabIndex = 25;
            label1.Text = "_____________";
            // 
            // lblGastosFijos
            // 
            lblGastosFijos.AutoSize = true;
            lblGastosFijos.BackColor = Color.Transparent;
            lblGastosFijos.Font = new Font("Segoe UI", 14.25F);
            lblGastosFijos.Location = new Point(25, 5);
            lblGastosFijos.Name = "lblGastosFijos";
            lblGastosFijos.Size = new Size(140, 32);
            lblGastosFijos.TabIndex = 26;
            lblGastosFijos.Text = "Gastos fijos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(21, 1);
            label2.Name = "label2";
            label2.Size = new Size(189, 32);
            label2.TabIndex = 28;
            label2.Text = "Gastos variables:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(21, 5);
            label3.Name = "label3";
            label3.Size = new Size(194, 32);
            label3.TabIndex = 27;
            label3.Text = "__________________";
            // 
            // dgvGastosVariables
            // 
            dgvGastosVariables.AllowUserToAddRows = false;
            dgvGastosVariables.AllowUserToDeleteRows = false;
            dgvGastosVariables.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGastosVariables.BackgroundColor = SystemColors.Control;
            dgvGastosVariables.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGastosVariables.Location = new Point(366, 660);
            dgvGastosVariables.Name = "dgvGastosVariables";
            dgvGastosVariables.ReadOnly = true;
            dgvGastosVariables.RowHeadersWidth = 51;
            dgvGastosVariables.Size = new Size(538, 188);
            dgvGastosVariables.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(150, 248);
            label4.Name = "label4";
            label4.Size = new Size(65, 32);
            label4.TabIndex = 30;
            label4.Text = "Total";
            // 
            // lblTotalValorFijo
            // 
            lblTotalValorFijo.AutoSize = true;
            lblTotalValorFijo.BackColor = Color.Transparent;
            lblTotalValorFijo.Font = new Font("Segoe UI", 14.25F);
            lblTotalValorFijo.Location = new Point(286, 249);
            lblTotalValorFijo.Name = "lblTotalValorFijo";
            lblTotalValorFijo.Size = new Size(118, 32);
            lblTotalValorFijo.TabIndex = 31;
            lblTotalValorFijo.Text = "TotalValor";
            // 
            // lblPorcentajeFijo
            // 
            lblPorcentajeFijo.AutoSize = true;
            lblPorcentajeFijo.BackColor = Color.Transparent;
            lblPorcentajeFijo.Font = new Font("Segoe UI", 14.25F);
            lblPorcentajeFijo.Location = new Point(421, 248);
            lblPorcentajeFijo.Name = "lblPorcentajeFijo";
            lblPorcentajeFijo.Size = new Size(125, 32);
            lblPorcentajeFijo.TabIndex = 32;
            lblPorcentajeFijo.Text = "Porcentaje";
            // 
            // pbDot
            // 
            pbDot.BackColor = Color.Transparent;
            pbDot.Location = new Point(121, 248);
            pbDot.Name = "pbDot";
            pbDot.Size = new Size(29, 33);
            pbDot.TabIndex = 33;
            pbDot.TabStop = false;
            // 
            // pbArrow2
            // 
            pbArrow2.BackColor = Color.Transparent;
            pbArrow2.Location = new Point(209, 248);
            pbArrow2.Name = "pbArrow2";
            pbArrow2.Size = new Size(79, 33);
            pbArrow2.TabIndex = 34;
            pbArrow2.TabStop = false;
            // 
            // pbArrow4
            // 
            pbArrow4.BackColor = Color.Transparent;
            pbArrow4.Location = new Point(209, 247);
            pbArrow4.Name = "pbArrow4";
            pbArrow4.Size = new Size(79, 33);
            pbArrow4.TabIndex = 39;
            pbArrow4.TabStop = false;
            // 
            // pbDot2
            // 
            pbDot2.BackColor = Color.Transparent;
            pbDot2.Location = new Point(121, 247);
            pbDot2.Name = "pbDot2";
            pbDot2.Size = new Size(29, 33);
            pbDot2.TabIndex = 38;
            pbDot2.TabStop = false;
            // 
            // lblPorcentajeVariable
            // 
            lblPorcentajeVariable.AutoSize = true;
            lblPorcentajeVariable.BackColor = Color.Transparent;
            lblPorcentajeVariable.Font = new Font("Segoe UI", 14.25F);
            lblPorcentajeVariable.Location = new Point(423, 247);
            lblPorcentajeVariable.Name = "lblPorcentajeVariable";
            lblPorcentajeVariable.Size = new Size(125, 32);
            lblPorcentajeVariable.TabIndex = 37;
            lblPorcentajeVariable.Text = "Porcentaje";
            // 
            // lblTotalValorVariables
            // 
            lblTotalValorVariables.AutoSize = true;
            lblTotalValorVariables.BackColor = Color.Transparent;
            lblTotalValorVariables.Font = new Font("Segoe UI", 14.25F);
            lblTotalValorVariables.Location = new Point(294, 247);
            lblTotalValorVariables.Name = "lblTotalValorVariables";
            lblTotalValorVariables.Size = new Size(118, 32);
            lblTotalValorVariables.TabIndex = 36;
            lblTotalValorVariables.Text = "TotalValor";
            // 
            // lblTotalGastosVariable
            // 
            lblTotalGastosVariable.AutoSize = true;
            lblTotalGastosVariable.BackColor = Color.Transparent;
            lblTotalGastosVariable.Font = new Font("Segoe UI", 14.25F);
            lblTotalGastosVariable.Location = new Point(151, 247);
            lblTotalGastosVariable.Name = "lblTotalGastosVariable";
            lblTotalGastosVariable.Size = new Size(65, 32);
            lblTotalGastosVariable.TabIndex = 35;
            lblTotalGastosVariable.Text = "Total";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 14.25F);
            label5.Location = new Point(371, 964);
            label5.Name = "label5";
            label5.Size = new Size(184, 32);
            label5.TabIndex = 43;
            label5.Text = "Dinero restante:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 14.25F);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(368, 977);
            label6.Name = "label6";
            label6.Size = new Size(194, 32);
            label6.TabIndex = 42;
            label6.Text = "__________________";
            // 
            // lblDineroRest
            // 
            lblDineroRest.AutoSize = true;
            lblDineroRest.BackColor = Color.Transparent;
            lblDineroRest.Font = new Font("Segoe UI", 14.25F);
            lblDineroRest.Location = new Point(568, 963);
            lblDineroRest.Name = "lblDineroRest";
            lblDineroRest.Size = new Size(47, 32);
            lblDineroRest.TabIndex = 44;
            lblDineroRest.Text = "0 €";
            // 
            // pbArrow5
            // 
            pbArrow5.BackColor = Color.Transparent;
            pbArrow5.Location = new Point(644, 963);
            pbArrow5.Name = "pbArrow5";
            pbArrow5.Size = new Size(54, 33);
            pbArrow5.TabIndex = 45;
            pbArrow5.TabStop = false;
            // 
            // lblPorcentajeRest
            // 
            lblPorcentajeRest.AutoSize = true;
            lblPorcentajeRest.BackColor = Color.Transparent;
            lblPorcentajeRest.Font = new Font("Segoe UI", 14.25F);
            lblPorcentajeRest.Location = new Point(709, 963);
            lblPorcentajeRest.Name = "lblPorcentajeRest";
            lblPorcentajeRest.Size = new Size(54, 32);
            lblPorcentajeRest.TabIndex = 46;
            lblPorcentajeRest.Text = "0 %";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 14.25F);
            label7.ForeColor = Color.FromArgb(0, 192, 0);
            label7.Location = new Point(560, 977);
            label7.Name = "label7";
            label7.Size = new Size(254, 32);
            label7.TabIndex = 47;
            label7.Text = "________________________";
            // 
            // pnlBarra1
            // 
            pnlBarra1.BackColor = SystemColors.ActiveCaptionText;
            pnlBarra1.Location = new Point(1067, 259);
            pnlBarra1.Name = "pnlBarra1";
            pnlBarra1.Size = new Size(10, 700);
            pnlBarra1.TabIndex = 48;
            // 
            // pnlContenedorOpc
            // 
            pnlContenedorOpc.Controls.Add(btnPersonalizado);
            pnlContenedorOpc.Controls.Add(btn503020);
            pnlContenedorOpc.Controls.Add(btnHarvEker);
            pnlContenedorOpc.Location = new Point(1287, 240);
            pnlContenedorOpc.Name = "pnlContenedorOpc";
            pnlContenedorOpc.Size = new Size(435, 47);
            pnlContenedorOpc.TabIndex = 49;
            // 
            // btnPersonalizado
            // 
            btnPersonalizado.BackColor = Color.FromArgb(224, 224, 224);
            btnPersonalizado.Enabled = false;
            btnPersonalizado.FlatStyle = FlatStyle.Flat;
            btnPersonalizado.Font = new Font("Segoe UI", 14.25F);
            btnPersonalizado.Location = new Point(265, 0);
            btnPersonalizado.Name = "btnPersonalizado";
            btnPersonalizado.Size = new Size(170, 47);
            btnPersonalizado.TabIndex = 50;
            btnPersonalizado.Text = "Personalizado";
            btnPersonalizado.UseVisualStyleBackColor = false;
            // 
            // btn503020
            // 
            btn503020.BackColor = Color.FromArgb(178, 242, 187);
            btn503020.FlatStyle = FlatStyle.Flat;
            btn503020.Font = new Font("Segoe UI", 14.25F);
            btn503020.Location = new Point(0, 0);
            btn503020.Name = "btn503020";
            btn503020.Size = new Size(134, 47);
            btn503020.TabIndex = 50;
            btn503020.Text = "50/30/20";
            btn503020.UseVisualStyleBackColor = false;
            // 
            // btnHarvEker
            // 
            btnHarvEker.BackColor = Color.FromArgb(224, 224, 224);
            btnHarvEker.Enabled = false;
            btnHarvEker.FlatStyle = FlatStyle.Flat;
            btnHarvEker.Font = new Font("Segoe UI", 14.25F);
            btnHarvEker.Location = new Point(133, 0);
            btnHarvEker.Name = "btnHarvEker";
            btnHarvEker.Size = new Size(134, 47);
            btnHarvEker.TabIndex = 51;
            btnHarvEker.Text = "Harv Eker";
            btnHarvEker.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(211, 208, 242);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 14.25F);
            btnSalir.Location = new Point(1632, 965);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(171, 53);
            btnSalir.TabIndex = 80;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnVolver_Click;
            // 
            // lblKakebo
            // 
            lblKakebo.AutoSize = true;
            lblKakebo.Font = new Font("Segoe UI", 20F);
            lblKakebo.Location = new Point(535, 118);
            lblKakebo.Name = "lblKakebo";
            lblKakebo.Size = new Size(132, 46);
            lblKakebo.TabIndex = 81;
            lblKakebo.Text = "Kakebo";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI", 20F);
            label15.ForeColor = SystemColors.ActiveCaptionText;
            label15.Location = new Point(503, 125);
            label15.Name = "label15";
            label15.Size = new Size(202, 46);
            label15.TabIndex = 83;
            label15.Text = "_____________";
            // 
            // lblPorcentajes
            // 
            lblPorcentajes.AutoSize = true;
            lblPorcentajes.Font = new Font("Segoe UI", 20F);
            lblPorcentajes.Location = new Point(1434, 118);
            lblPorcentajes.Name = "lblPorcentajes";
            lblPorcentajes.Size = new Size(192, 46);
            lblPorcentajes.TabIndex = 84;
            lblPorcentajes.Text = "Porcentajes";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Segoe UI", 20F);
            label16.ForeColor = SystemColors.ActiveCaptionText;
            label16.Location = new Point(1406, 125);
            label16.Name = "label16";
            label16.Size = new Size(258, 46);
            label16.TabIndex = 85;
            label16.Text = "_________________";
            // 
            // barraSecundaria1
            // 
            barraSecundaria1.BackColor = Color.FromArgb(211, 208, 242);
            barraSecundaria1.Dock = DockStyle.Top;
            barraSecundaria1.Location = new Point(0, 40);
            barraSecundaria1.Name = "barraSecundaria1";
            barraSecundaria1.Size = new Size(1818, 44);
            barraSecundaria1.TabIndex = 86;
            // 
            // lblLineaFijos
            // 
            lblLineaFijos.AutoSize = true;
            lblLineaFijos.BackColor = Color.Transparent;
            lblLineaFijos.Font = new Font("Segoe UI", 14.25F);
            lblLineaFijos.ForeColor = Color.FromArgb(0, 192, 0);
            lblLineaFijos.Location = new Point(279, 257);
            lblLineaFijos.Name = "lblLineaFijos";
            lblLineaFijos.Size = new Size(264, 32);
            lblLineaFijos.TabIndex = 88;
            lblLineaFijos.Text = "_________________________";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 14.25F);
            label8.ForeColor = Color.FromArgb(0, 192, 0);
            label8.Location = new Point(285, 256);
            label8.Name = "label8";
            label8.Size = new Size(274, 32);
            label8.TabIndex = 89;
            label8.Text = "__________________________";
            // 
            // pnlGastoFijo
            // 
            pnlGastoFijo.Controls.Add(lblPorcentajeFijo);
            pnlGastoFijo.Controls.Add(pbArrow2);
            pnlGastoFijo.Controls.Add(lblTotalValorFijo);
            pnlGastoFijo.Controls.Add(lblGastosFijos);
            pnlGastoFijo.Controls.Add(label1);
            pnlGastoFijo.Controls.Add(pbDot);
            pnlGastoFijo.Controls.Add(label4);
            pnlGastoFijo.Controls.Add(lblLineaFijos);
            pnlGastoFijo.Location = new Point(339, 259);
            pnlGastoFijo.Margin = new Padding(3, 4, 3, 4);
            pnlGastoFijo.Name = "pnlGastoFijo";
            pnlGastoFijo.Padding = new Padding(3, 4, 3, 4);
            pnlGastoFijo.Size = new Size(605, 311);
            pnlGastoFijo.TabIndex = 90;
            pnlGastoFijo.TabStop = false;
            pnlGastoFijo.Text = "roundGroupBox1";
            // 
            // pnlGastoVariable
            // 
            pnlGastoVariable.Controls.Add(label2);
            pnlGastoVariable.Controls.Add(label3);
            pnlGastoVariable.Controls.Add(pbDot2);
            pnlGastoVariable.Controls.Add(lblTotalGastosVariable);
            pnlGastoVariable.Controls.Add(pbArrow4);
            pnlGastoVariable.Controls.Add(lblTotalValorVariables);
            pnlGastoVariable.Controls.Add(lblPorcentajeVariable);
            pnlGastoVariable.Controls.Add(label8);
            pnlGastoVariable.Location = new Point(339, 610);
            pnlGastoVariable.Margin = new Padding(3, 4, 3, 4);
            pnlGastoVariable.Name = "pnlGastoVariable";
            pnlGastoVariable.Padding = new Padding(3, 4, 3, 4);
            pnlGastoVariable.Size = new Size(605, 313);
            pnlGastoVariable.TabIndex = 91;
            pnlGastoVariable.TabStop = false;
            pnlGastoVariable.Text = "roundGroupBox2";
            // 
            // pnl503020
            // 
            pnl503020.BackColor = Color.FromArgb(205, 213, 221);
            pnl503020.Controls.Add(label10);
            pnl503020.Controls.Add(label11);
            pnl503020.Controls.Add(lblAhorroPorDin);
            pnl503020.Controls.Add(label18);
            pnl503020.Controls.Add(lblGPPorDin);
            pnl503020.Controls.Add(pbArrow9);
            pnl503020.Controls.Add(pbArrow8);
            pnl503020.Controls.Add(pbArrow10);
            pnl503020.Controls.Add(pbArrow7);
            pnl503020.Controls.Add(label20);
            pnl503020.Controls.Add(pbArrow11);
            pnl503020.Controls.Add(label21);
            pnl503020.Controls.Add(lblGPresValor);
            pnl503020.Controls.Add(lblNecBasicasValor);
            pnl503020.Controls.Add(lblAhorroDinValor);
            pnl503020.Controls.Add(lblNecPresValor);
            pnl503020.Controls.Add(lblGMNecPorDin);
            pnl503020.Controls.Add(lblGMNecValor);
            pnl503020.Controls.Add(label28);
            pnl503020.Controls.Add(lblAhoValor);
            pnl503020.Controls.Add(pbArrow6);
            pnl503020.Controls.Add(label30);
            pnl503020.Controls.Add(label31);
            pnl503020.Controls.Add(label32);
            pnl503020.Location = new Point(1182, 346);
            pnl503020.Margin = new Padding(3, 4, 3, 4);
            pnl503020.Name = "pnl503020";
            pnl503020.Padding = new Padding(3, 4, 3, 4);
            pnl503020.Size = new Size(621, 502);
            pnl503020.TabIndex = 92;
            pnl503020.TabStop = false;
            pnl503020.Text = "roundGroupBox3";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F);
            label10.ForeColor = Color.Purple;
            label10.Location = new Point(26, 348);
            label10.Name = "label10";
            label10.Size = new Size(221, 32);
            label10.TabIndex = 82;
            label10.Text = "20% para el ahorro:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F);
            label11.ForeColor = Color.Purple;
            label11.Location = new Point(26, 37);
            label11.Name = "label11";
            label11.Size = new Size(344, 32);
            label11.TabIndex = 80;
            label11.Text = "50% para necesidades básicas: ";
            // 
            // lblAhorroPorDin
            // 
            lblAhorroPorDin.AutoSize = true;
            lblAhorroPorDin.Font = new Font("Segoe UI", 14.25F);
            lblAhorroPorDin.Location = new Point(337, 432);
            lblAhorroPorDin.Name = "lblAhorroPorDin";
            lblAhorroPorDin.Size = new Size(54, 32);
            lblAhorroPorDin.TabIndex = 103;
            lblAhorroPorDin.Text = "0 %";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 14.25F);
            label18.ForeColor = Color.Purple;
            label18.Location = new Point(31, 196);
            label18.Name = "label18";
            label18.Size = new Size(339, 32);
            label18.TabIndex = 81;
            label18.Text = "30% para gastos prescindibles:";
            // 
            // lblGPPorDin
            // 
            lblGPPorDin.AutoSize = true;
            lblGPPorDin.Font = new Font("Segoe UI", 14.25F);
            lblGPPorDin.Location = new Point(465, 235);
            lblGPPorDin.Name = "lblGPPorDin";
            lblGPPorDin.Size = new Size(54, 32);
            lblGPPorDin.TabIndex = 100;
            lblGPPorDin.Text = "0 %";
            // 
            // pbArrow9
            // 
            pbArrow9.Location = new Point(26, 75);
            pbArrow9.Name = "pbArrow9";
            pbArrow9.Size = new Size(59, 33);
            pbArrow9.TabIndex = 83;
            pbArrow9.TabStop = false;
            // 
            // pbArrow8
            // 
            pbArrow8.Location = new Point(258, 431);
            pbArrow8.Name = "pbArrow8";
            pbArrow8.Size = new Size(59, 33);
            pbArrow8.TabIndex = 102;
            pbArrow8.TabStop = false;
            // 
            // pbArrow10
            // 
            pbArrow10.Location = new Point(31, 235);
            pbArrow10.Name = "pbArrow10";
            pbArrow10.Size = new Size(59, 33);
            pbArrow10.TabIndex = 84;
            pbArrow10.TabStop = false;
            // 
            // pbArrow7
            // 
            pbArrow7.Location = new Point(392, 233);
            pbArrow7.Name = "pbArrow7";
            pbArrow7.Size = new Size(59, 33);
            pbArrow7.TabIndex = 99;
            pbArrow7.TabStop = false;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 14.25F);
            label20.Location = new Point(90, 75);
            label20.Name = "label20";
            label20.Size = new Size(207, 32);
            label20.TabIndex = 86;
            label20.Text = "Gastado este mes:";
            // 
            // pbArrow11
            // 
            pbArrow11.Location = new Point(26, 388);
            pbArrow11.Name = "pbArrow11";
            pbArrow11.Size = new Size(59, 33);
            pbArrow11.TabIndex = 85;
            pbArrow11.TabStop = false;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 14.25F);
            label21.Location = new Point(95, 235);
            label21.Name = "label21";
            label21.Size = new Size(207, 32);
            label21.TabIndex = 87;
            label21.Text = "Gastado este mes:";
            // 
            // lblGPresValor
            // 
            lblGPresValor.AutoSize = true;
            lblGPresValor.Font = new Font("Segoe UI", 14.25F);
            lblGPresValor.Location = new Point(309, 233);
            lblGPresValor.Name = "lblGPresValor";
            lblGPresValor.Size = new Size(47, 32);
            lblGPresValor.TabIndex = 98;
            lblGPresValor.Text = "0 €";
            // 
            // lblNecBasicasValor
            // 
            lblNecBasicasValor.AutoSize = true;
            lblNecBasicasValor.Font = new Font("Segoe UI", 14.25F);
            lblNecBasicasValor.Location = new Point(368, 37);
            lblNecBasicasValor.Name = "lblNecBasicasValor";
            lblNecBasicasValor.Size = new Size(47, 32);
            lblNecBasicasValor.TabIndex = 89;
            lblNecBasicasValor.Text = "0 €";
            // 
            // lblAhorroDinValor
            // 
            lblAhorroDinValor.AutoSize = true;
            lblAhorroDinValor.Font = new Font("Segoe UI", 14.25F);
            lblAhorroDinValor.Location = new Point(155, 431);
            lblAhorroDinValor.Name = "lblAhorroDinValor";
            lblAhorroDinValor.Size = new Size(47, 32);
            lblAhorroDinValor.TabIndex = 101;
            lblAhorroDinValor.Text = "0 €";
            // 
            // lblNecPresValor
            // 
            lblNecPresValor.AutoSize = true;
            lblNecPresValor.Font = new Font("Segoe UI", 14.25F);
            lblNecPresValor.Location = new Point(369, 196);
            lblNecPresValor.Name = "lblNecPresValor";
            lblNecPresValor.Size = new Size(47, 32);
            lblNecPresValor.TabIndex = 90;
            lblNecPresValor.Text = "0 €";
            // 
            // lblGMNecPorDin
            // 
            lblGMNecPorDin.AutoSize = true;
            lblGMNecPorDin.Font = new Font("Segoe UI", 14.25F);
            lblGMNecPorDin.Location = new Point(461, 76);
            lblGMNecPorDin.Name = "lblGMNecPorDin";
            lblGMNecPorDin.Size = new Size(54, 32);
            lblGMNecPorDin.TabIndex = 97;
            lblGMNecPorDin.Text = "0 %";
            // 
            // lblGMNecValor
            // 
            lblGMNecValor.AutoSize = true;
            lblGMNecValor.Font = new Font("Segoe UI", 14.25F);
            lblGMNecValor.Location = new Point(304, 75);
            lblGMNecValor.Name = "lblGMNecValor";
            lblGMNecValor.Size = new Size(47, 32);
            lblGMNecValor.TabIndex = 95;
            lblGMNecValor.Text = "0 €";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 14.25F);
            label28.Location = new Point(90, 388);
            label28.Name = "label28";
            label28.Size = new Size(447, 32);
            label28.TabIndex = 88;
            label28.Text = "Dinero disponible para ahorrar este mes:";
            // 
            // lblAhoValor
            // 
            lblAhoValor.AutoSize = true;
            lblAhoValor.Font = new Font("Segoe UI", 14.25F);
            lblAhoValor.Location = new Point(247, 348);
            lblAhoValor.Name = "lblAhoValor";
            lblAhoValor.Size = new Size(47, 32);
            lblAhoValor.TabIndex = 91;
            lblAhoValor.Text = "0 €";
            // 
            // pbArrow6
            // 
            pbArrow6.BackColor = Color.FromArgb(205, 213, 221);
            pbArrow6.Location = new Point(389, 75);
            pbArrow6.Name = "pbArrow6";
            pbArrow6.Size = new Size(59, 33);
            pbArrow6.TabIndex = 96;
            pbArrow6.TabStop = false;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.BackColor = Color.Transparent;
            label30.Font = new Font("Segoe UI", 14.25F);
            label30.ForeColor = SystemColors.ActiveCaptionText;
            label30.Location = new Point(362, 43);
            label30.Name = "label30";
            label30.Size = new Size(104, 32);
            label30.TabIndex = 92;
            label30.Text = "_________";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.BackColor = Color.Transparent;
            label31.Font = new Font("Segoe UI", 14.25F);
            label31.ForeColor = SystemColors.ActiveCaptionText;
            label31.Location = new Point(362, 201);
            label31.Name = "label31";
            label31.Size = new Size(104, 32);
            label31.TabIndex = 93;
            label31.Text = "_________";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.BackColor = Color.Transparent;
            label32.Font = new Font("Segoe UI", 14.25F);
            label32.ForeColor = SystemColors.ActiveCaptionText;
            label32.Location = new Point(239, 353);
            label32.Name = "label32";
            label32.Size = new Size(104, 32);
            label32.TabIndex = 94;
            label32.Text = "_________";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfo.Location = new Point(1202, 861);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(494, 19);
            lblInfo.TabIndex = 95;
            lblInfo.Text = "Se consideran gastos de necesidades básicas las categorias Luz y Supermercado";
            // 
            // lblInfo2
            // 
            lblInfo2.AutoSize = true;
            lblInfo2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfo2.Location = new Point(1202, 880);
            lblInfo2.Name = "lblInfo2";
            lblInfo2.Size = new Size(412, 19);
            lblInfo2.TabIndex = 96;
            lblInfo2.Text = "Las demás categorías son consideradas como gastos prescindibles";
            // 
            // barraLateral2
            // 
            barraLateral2.BackColor = Color.FromArgb(205, 213, 221);
            barraLateral2.Dock = DockStyle.Left;
            barraLateral2.Location = new Point(0, 84);
            barraLateral2.Name = "barraLateral2";
            barraLateral2.Size = new Size(289, 1017);
            barraLateral2.TabIndex = 97;
            // 
            // frmMetodosAhorro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 236, 239);
            ClientSize = new Size(1818, 1101);
            Controls.Add(barraLateral2);
            Controls.Add(pbArrow5);
            Controls.Add(lblInfo2);
            Controls.Add(lblPorcentajeRest);
            Controls.Add(lblInfo);
            Controls.Add(lblDineroRest);
            Controls.Add(label7);
            Controls.Add(barraSecundaria1);
            Controls.Add(lblPorcentajes);
            Controls.Add(label16);
            Controls.Add(label5);
            Controls.Add(lblKakebo);
            Controls.Add(btnSalir);
            Controls.Add(pnlContenedorOpc);
            Controls.Add(pnlBarra1);
            Controls.Add(dgvGastosVariables);
            Controls.Add(dgvGastosFijos);
            Controls.Add(lblIngresoMesCont);
            Controls.Add(lblIngresosMes);
            Controls.Add(label15);
            Controls.Add(pnlGastoFijo);
            Controls.Add(pnlGastoVariable);
            Controls.Add(pnl503020);
            Controls.Add(label6);
            Controls.Add(lblLinea);
            Name = "frmMetodosAhorro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MetodosAhorro";
            WindowState = FormWindowState.Maximized;
            Load += MetodosAhorro_Load;
            Controls.SetChildIndex(lblLinea, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(pnl503020, 0);
            Controls.SetChildIndex(pnlGastoVariable, 0);
            Controls.SetChildIndex(pnlGastoFijo, 0);
            Controls.SetChildIndex(label15, 0);
            Controls.SetChildIndex(lblIngresosMes, 0);
            Controls.SetChildIndex(lblIngresoMesCont, 0);
            Controls.SetChildIndex(dgvGastosFijos, 0);
            Controls.SetChildIndex(dgvGastosVariables, 0);
            Controls.SetChildIndex(pnlBarra1, 0);
            Controls.SetChildIndex(pnlContenedorOpc, 0);
            Controls.SetChildIndex(btnSalir, 0);
            Controls.SetChildIndex(lblKakebo, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(label16, 0);
            Controls.SetChildIndex(lblPorcentajes, 0);
            Controls.SetChildIndex(barraSecundaria1, 0);
            Controls.SetChildIndex(label7, 0);
            Controls.SetChildIndex(lblDineroRest, 0);
            Controls.SetChildIndex(lblInfo, 0);
            Controls.SetChildIndex(lblPorcentajeRest, 0);
            Controls.SetChildIndex(lblInfo2, 0);
            Controls.SetChildIndex(pbArrow5, 0);
            Controls.SetChildIndex(barraLateral2, 0);
            ((System.ComponentModel.ISupportInitialize)dgvGastosFijos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGastosVariables).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDot).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbArrow2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbArrow4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDot2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbArrow5).EndInit();
            pnlContenedorOpc.ResumeLayout(false);
            pnlGastoFijo.ResumeLayout(false);
            pnlGastoFijo.PerformLayout();
            pnlGastoVariable.ResumeLayout(false);
            pnlGastoVariable.PerformLayout();
            pnl503020.ResumeLayout(false);
            pnl503020.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbArrow9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbArrow8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbArrow10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbArrow7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbArrow11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbArrow6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblIngresosMes;
        private Label lblLinea;
        private Label lblIngresoMesCont;
        private DataGridView dgvGastosFijos;
        private Label label1;
        private Label lblGastosFijos;
        private Label label2;
        private Label label3;
        private DataGridView dgvGastosVariables;
        private Label label4;
        private Label lblTotalValorFijo;
        private Label lblPorcentajeFijo;
        private PictureBox pbDot;
        private PictureBox pbArrow2;
        private PictureBox pbArrow4;
        private PictureBox pbDot2;
        private Label lblPorcentajeVariable;
        private Label lblTotalValorVariables;
        private Label lblTotalGastosVariable;
        private Label label5;
        private Label label6;
        private Label lblDineroRest;
        private PictureBox pbArrow5;
        private Label lblPorcentajeRest;
        private Label label7;
        private Panel pnlBarra1;
        private Panel pnlContenedorOpc;
        private Button btn503020;
        private Button btnPersonalizado;
        private Button btnHarvEker;
        private Button btnSalir;
        private Label lblKakebo;
        private Label label15;
        private Label lblPorcentajes;
        private Label label16;
        private BarraSecundaria barraSecundaria1;
        private BarraLateral barraLateral1;
        private Label lblLineaFijos;
        private Label label8;
        private RoundGroupBox pnlGastoFijo;
        private RoundGroupBox pnlGastoVariable;
        private RoundGroupBox pnl503020;
        private Label label10;
        private Label label11;
        private Label lblAhorroPorDin;
        private Label label18;
        private Label lblGPPorDin;
        private PictureBox pbArrow9;
        private PictureBox pbArrow8;
        private PictureBox pbArrow10;
        private PictureBox pbArrow7;
        private Label label20;
        private PictureBox pbArrow11;
        private Label label21;
        private Label lblGPresValor;
        private Label lblNecBasicasValor;
        private Label lblAhorroDinValor;
        private Label lblNecPresValor;
        private Label lblGMNecPorDin;
        private Label lblGMNecValor;
        private Label label28;
        private Label lblAhoValor;
        private PictureBox pbArrow6;
        private Label label30;
        private Label label31;
        private Label label32;
        private Label lblInfo;
        private Label lblInfo2;
        private BarraLateral barraLateral2;
    }
}