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
            pbArrow = new PictureBox();
            pbArrow2 = new PictureBox();
            pbArrow4 = new PictureBox();
            pbArrow3 = new PictureBox();
            lblPorcentajeVariable = new Label();
            lblTotalGastosVariables = new Label();
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
            lblNecesidadesBasicas = new Label();
            lblGastosPrescin = new Label();
            lblAhorro = new Label();
            pbArrow6 = new PictureBox();
            pbArrow7 = new PictureBox();
            pbArrow8 = new PictureBox();
            lblGastadoEsteMes = new Label();
            lblGastoEsteMes = new Label();
            label9 = new Label();
            lblNecBasicasValor = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            lblGMNecBasicasDinValor = new Label();
            pbArrow9 = new PictureBox();
            lblGMNecPorDin = new Label();
            lblGPPorDin = new Label();
            pbArrow10 = new PictureBox();
            lblGPDineroValor = new Label();
            lblAhorroPorDin = new Label();
            pbArrow11 = new PictureBox();
            lblAhorroDinValor = new Label();
            pnl503020 = new Panel();
            rgbPersonalizado = new RoundGroupBox();
            lblPDinero = new Label();
            lblLineaSeparaciones3 = new Label();
            lblLineasSeparacines2 = new Label();
            lblLineaSeparaciones1 = new Label();
            cmbCategorias = new ComboBox();
            txtPNombre = new TextBox();
            txtPPorcentaje = new TextBox();
            lblPPorAsignar = new Label();
            lblPPor = new Label();
            lblLineaPpor = new Label();
            pnlPersonalizado = new Panel();
            btnPAgregar = new Button();
            btnSalir = new Button();
            lblKakebo = new Label();
            label15 = new Label();
            lblPorcentajes = new Label();
            label16 = new Label();
            barraSecundaria1 = new BarraSecundaria();
            barraLateral1 = new BarraLateral();
            ((System.ComponentModel.ISupportInitialize)dgvGastosFijos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGastosVariables).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbArrow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbArrow2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbArrow4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbArrow3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbArrow5).BeginInit();
            pnlContenedorOpc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbArrow6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbArrow7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbArrow8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbArrow9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbArrow10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbArrow11).BeginInit();
            pnl503020.SuspendLayout();
            rgbPersonalizado.SuspendLayout();
            pnlPersonalizado.SuspendLayout();
            SuspendLayout();
            // 
            // lblIngresosMes
            // 
            lblIngresosMes.AutoSize = true;
            lblIngresosMes.Font = new Font("Segoe UI", 14.25F);
            lblIngresosMes.Location = new Point(805, 181);
            lblIngresosMes.Name = "lblIngresosMes";
            lblIngresosMes.Size = new Size(242, 32);
            lblIngresosMes.TabIndex = 20;
            lblIngresosMes.Text = "Ingresos  mensuales: ";
            // 
            // lblLinea
            // 
            lblLinea.AutoSize = true;
            lblLinea.BackColor = Color.Transparent;
            lblLinea.Font = new Font("Segoe UI", 14.25F);
            lblLinea.ForeColor = Color.FromArgb(0, 192, 0);
            lblLinea.Location = new Point(1051, 181);
            lblLinea.Name = "lblLinea";
            lblLinea.Size = new Size(114, 32);
            lblLinea.TabIndex = 21;
            lblLinea.Text = "__________";
            // 
            // lblIngresoMesCont
            // 
            lblIngresoMesCont.AutoSize = true;
            lblIngresoMesCont.Font = new Font("Segoe UI", 14.25F);
            lblIngresoMesCont.Location = new Point(1066, 175);
            lblIngresoMesCont.Name = "lblIngresoMesCont";
            lblIngresoMesCont.Size = new Size(83, 32);
            lblIngresoMesCont.TabIndex = 22;
            lblIngresoMesCont.Text = "dinero";
            // 
            // dgvGastosFijos
            // 
            dgvGastosFijos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGastosFijos.BackgroundColor = SystemColors.Control;
            dgvGastosFijos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGastosFijos.Location = new Point(353, 275);
            dgvGastosFijos.Name = "dgvGastosFijos";
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
            label1.Location = new Point(353, 229);
            label1.Name = "label1";
            label1.Size = new Size(144, 32);
            label1.TabIndex = 25;
            label1.Text = "_____________";
            // 
            // lblGastosFijos
            // 
            lblGastosFijos.AutoSize = true;
            lblGastosFijos.Font = new Font("Segoe UI", 14.25F);
            lblGastosFijos.Location = new Point(354, 223);
            lblGastosFijos.Name = "lblGastosFijos";
            lblGastosFijos.Size = new Size(140, 32);
            lblGastosFijos.TabIndex = 26;
            lblGastosFijos.Text = "Gastos fijos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(353, 518);
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
            label3.Location = new Point(352, 523);
            label3.Name = "label3";
            label3.Size = new Size(194, 32);
            label3.TabIndex = 27;
            label3.Text = "__________________";
            // 
            // dgvGastosVariables
            // 
            dgvGastosVariables.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGastosVariables.BackgroundColor = SystemColors.Control;
            dgvGastosVariables.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGastosVariables.Location = new Point(354, 569);
            dgvGastosVariables.Name = "dgvGastosVariables";
            dgvGastosVariables.RowHeadersWidth = 51;
            dgvGastosVariables.Size = new Size(538, 188);
            dgvGastosVariables.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(414, 469);
            label4.Name = "label4";
            label4.Size = new Size(65, 32);
            label4.TabIndex = 30;
            label4.Text = "Total";
            // 
            // lblTotalValorFijo
            // 
            lblTotalValorFijo.AutoSize = true;
            lblTotalValorFijo.Font = new Font("Segoe UI", 14.25F);
            lblTotalValorFijo.Location = new Point(635, 469);
            lblTotalValorFijo.Name = "lblTotalValorFijo";
            lblTotalValorFijo.Size = new Size(118, 32);
            lblTotalValorFijo.TabIndex = 31;
            lblTotalValorFijo.Text = "TotalValor";
            // 
            // lblPorcentajeFijo
            // 
            lblPorcentajeFijo.AutoSize = true;
            lblPorcentajeFijo.Font = new Font("Segoe UI", 14.25F);
            lblPorcentajeFijo.Location = new Point(773, 469);
            lblPorcentajeFijo.Name = "lblPorcentajeFijo";
            lblPorcentajeFijo.Size = new Size(125, 32);
            lblPorcentajeFijo.TabIndex = 32;
            lblPorcentajeFijo.Text = "Porcentaje";
            // 
            // pbArrow
            // 
            pbArrow.Location = new Point(354, 469);
            pbArrow.Name = "pbArrow";
            pbArrow.Size = new Size(54, 33);
            pbArrow.TabIndex = 33;
            pbArrow.TabStop = false;
            // 
            // pbArrow2
            // 
            pbArrow2.Location = new Point(485, 469);
            pbArrow2.Name = "pbArrow2";
            pbArrow2.Size = new Size(145, 33);
            pbArrow2.TabIndex = 34;
            pbArrow2.TabStop = false;
            // 
            // pbArrow4
            // 
            pbArrow4.Location = new Point(485, 765);
            pbArrow4.Name = "pbArrow4";
            pbArrow4.Size = new Size(145, 33);
            pbArrow4.TabIndex = 39;
            pbArrow4.TabStop = false;
            // 
            // pbArrow3
            // 
            pbArrow3.Location = new Point(354, 765);
            pbArrow3.Name = "pbArrow3";
            pbArrow3.Size = new Size(54, 33);
            pbArrow3.TabIndex = 38;
            pbArrow3.TabStop = false;
            // 
            // lblPorcentajeVariable
            // 
            lblPorcentajeVariable.AutoSize = true;
            lblPorcentajeVariable.Font = new Font("Segoe UI", 14.25F);
            lblPorcentajeVariable.Location = new Point(773, 765);
            lblPorcentajeVariable.Name = "lblPorcentajeVariable";
            lblPorcentajeVariable.Size = new Size(125, 32);
            lblPorcentajeVariable.TabIndex = 37;
            lblPorcentajeVariable.Text = "Porcentaje";
            // 
            // lblTotalGastosVariables
            // 
            lblTotalGastosVariables.AutoSize = true;
            lblTotalGastosVariables.Font = new Font("Segoe UI", 14.25F);
            lblTotalGastosVariables.Location = new Point(635, 765);
            lblTotalGastosVariables.Name = "lblTotalGastosVariables";
            lblTotalGastosVariables.Size = new Size(118, 32);
            lblTotalGastosVariables.TabIndex = 36;
            lblTotalGastosVariables.Text = "TotalValor";
            // 
            // lblTotalGastosVariable
            // 
            lblTotalGastosVariable.AutoSize = true;
            lblTotalGastosVariable.Font = new Font("Segoe UI", 14.25F);
            lblTotalGastosVariable.Location = new Point(414, 765);
            lblTotalGastosVariable.Name = "lblTotalGastosVariable";
            lblTotalGastosVariable.Size = new Size(65, 32);
            lblTotalGastosVariable.TabIndex = 35;
            lblTotalGastosVariable.Text = "Total";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F);
            label5.Location = new Point(357, 813);
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
            label6.Location = new Point(357, 817);
            label6.Name = "label6";
            label6.Size = new Size(194, 32);
            label6.TabIndex = 42;
            label6.Text = "__________________";
            // 
            // lblDineroRest
            // 
            lblDineroRest.AutoSize = true;
            lblDineroRest.Font = new Font("Segoe UI", 14.25F);
            lblDineroRest.Location = new Point(571, 813);
            lblDineroRest.Name = "lblDineroRest";
            lblDineroRest.Size = new Size(58, 32);
            lblDineroRest.TabIndex = 44;
            lblDineroRest.Text = "Rest";
            // 
            // pbArrow5
            // 
            pbArrow5.Location = new Point(643, 813);
            pbArrow5.Name = "pbArrow5";
            pbArrow5.Size = new Size(54, 33);
            pbArrow5.TabIndex = 45;
            pbArrow5.TabStop = false;
            // 
            // lblPorcentajeRest
            // 
            lblPorcentajeRest.AutoSize = true;
            lblPorcentajeRest.Font = new Font("Segoe UI", 14.25F);
            lblPorcentajeRest.Location = new Point(725, 813);
            lblPorcentajeRest.Name = "lblPorcentajeRest";
            lblPorcentajeRest.Size = new Size(48, 32);
            lblPorcentajeRest.TabIndex = 46;
            lblPorcentajeRest.Text = "Por";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 14.25F);
            label7.ForeColor = Color.FromArgb(0, 192, 0);
            label7.Location = new Point(561, 818);
            label7.Name = "label7";
            label7.Size = new Size(224, 32);
            label7.TabIndex = 47;
            label7.Text = "_____________________";
            // 
            // pnlBarra1
            // 
            pnlBarra1.BackColor = SystemColors.ActiveCaptionText;
            pnlBarra1.Location = new Point(1037, 229);
            pnlBarra1.Name = "pnlBarra1";
            pnlBarra1.Size = new Size(10, 620);
            pnlBarra1.TabIndex = 48;
            // 
            // pnlContenedorOpc
            // 
            pnlContenedorOpc.Controls.Add(btnPersonalizado);
            pnlContenedorOpc.Controls.Add(btn503020);
            pnlContenedorOpc.Controls.Add(btnHarvEker);
            pnlContenedorOpc.Location = new Point(1187, 233);
            pnlContenedorOpc.Name = "pnlContenedorOpc";
            pnlContenedorOpc.Size = new Size(435, 47);
            pnlContenedorOpc.TabIndex = 49;
            // 
            // btnPersonalizado
            // 
            btnPersonalizado.BackColor = Color.FromArgb(178, 242, 187);
            btnPersonalizado.FlatStyle = FlatStyle.Flat;
            btnPersonalizado.Font = new Font("Segoe UI", 14.25F);
            btnPersonalizado.Location = new Point(265, 0);
            btnPersonalizado.Name = "btnPersonalizado";
            btnPersonalizado.Size = new Size(170, 47);
            btnPersonalizado.TabIndex = 50;
            btnPersonalizado.Text = "Personalizado";
            btnPersonalizado.UseVisualStyleBackColor = false;
            btnPersonalizado.Click += btnPersonalizado_Click;
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
            btn503020.Click += btn503020_Click;
            // 
            // btnHarvEker
            // 
            btnHarvEker.BackColor = Color.FromArgb(178, 242, 187);
            btnHarvEker.FlatStyle = FlatStyle.Flat;
            btnHarvEker.Font = new Font("Segoe UI", 14.25F);
            btnHarvEker.Location = new Point(133, 0);
            btnHarvEker.Name = "btnHarvEker";
            btnHarvEker.Size = new Size(134, 47);
            btnHarvEker.TabIndex = 51;
            btnHarvEker.Text = "Harv Eker";
            btnHarvEker.UseVisualStyleBackColor = false;
            // 
            // lblNecesidadesBasicas
            // 
            lblNecesidadesBasicas.AutoSize = true;
            lblNecesidadesBasicas.Font = new Font("Segoe UI", 14.25F);
            lblNecesidadesBasicas.ForeColor = Color.Purple;
            lblNecesidadesBasicas.Location = new Point(21, 21);
            lblNecesidadesBasicas.Name = "lblNecesidadesBasicas";
            lblNecesidadesBasicas.Size = new Size(344, 32);
            lblNecesidadesBasicas.TabIndex = 21;
            lblNecesidadesBasicas.Text = "50% para necesidades básicas: ";
            // 
            // lblGastosPrescin
            // 
            lblGastosPrescin.AutoSize = true;
            lblGastosPrescin.Font = new Font("Segoe UI", 14.25F);
            lblGastosPrescin.ForeColor = Color.Purple;
            lblGastosPrescin.Location = new Point(21, 165);
            lblGastosPrescin.Name = "lblGastosPrescin";
            lblGastosPrescin.Size = new Size(339, 32);
            lblGastosPrescin.TabIndex = 50;
            lblGastosPrescin.Text = "30% para gastos prescindibles:";
            // 
            // lblAhorro
            // 
            lblAhorro.AutoSize = true;
            lblAhorro.Font = new Font("Segoe UI", 14.25F);
            lblAhorro.ForeColor = Color.Purple;
            lblAhorro.Location = new Point(21, 309);
            lblAhorro.Name = "lblAhorro";
            lblAhorro.Size = new Size(221, 32);
            lblAhorro.TabIndex = 51;
            lblAhorro.Text = "20% para el ahorro:";
            // 
            // pbArrow6
            // 
            pbArrow6.Location = new Point(21, 59);
            pbArrow6.Name = "pbArrow6";
            pbArrow6.Size = new Size(59, 33);
            pbArrow6.TabIndex = 52;
            pbArrow6.TabStop = false;
            // 
            // pbArrow7
            // 
            pbArrow7.Location = new Point(21, 204);
            pbArrow7.Name = "pbArrow7";
            pbArrow7.Size = new Size(59, 33);
            pbArrow7.TabIndex = 53;
            pbArrow7.TabStop = false;
            // 
            // pbArrow8
            // 
            pbArrow8.Location = new Point(21, 349);
            pbArrow8.Name = "pbArrow8";
            pbArrow8.Size = new Size(59, 33);
            pbArrow8.TabIndex = 54;
            pbArrow8.TabStop = false;
            // 
            // lblGastadoEsteMes
            // 
            lblGastadoEsteMes.AutoSize = true;
            lblGastadoEsteMes.Font = new Font("Segoe UI", 14.25F);
            lblGastadoEsteMes.Location = new Point(85, 59);
            lblGastadoEsteMes.Name = "lblGastadoEsteMes";
            lblGastadoEsteMes.Size = new Size(207, 32);
            lblGastadoEsteMes.TabIndex = 55;
            lblGastadoEsteMes.Text = "Gastado este mes:";
            // 
            // lblGastoEsteMes
            // 
            lblGastoEsteMes.AutoSize = true;
            lblGastoEsteMes.Font = new Font("Segoe UI", 14.25F);
            lblGastoEsteMes.Location = new Point(85, 204);
            lblGastoEsteMes.Name = "lblGastoEsteMes";
            lblGastoEsteMes.Size = new Size(207, 32);
            lblGastoEsteMes.TabIndex = 56;
            lblGastoEsteMes.Text = "Gastado este mes:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F);
            label9.Location = new Point(85, 349);
            label9.Name = "label9";
            label9.Size = new Size(447, 32);
            label9.TabIndex = 57;
            label9.Text = "Dinero disponible para ahorrar este mes:";
            // 
            // lblNecBasicasValor
            // 
            lblNecBasicasValor.AutoSize = true;
            lblNecBasicasValor.Font = new Font("Segoe UI", 14.25F);
            lblNecBasicasValor.Location = new Point(365, 21);
            lblNecBasicasValor.Name = "lblNecBasicasValor";
            lblNecBasicasValor.Size = new Size(86, 32);
            lblNecBasicasValor.TabIndex = 58;
            lblNecBasicasValor.Text = "Dinero";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F);
            label10.Location = new Point(365, 165);
            label10.Name = "label10";
            label10.Size = new Size(86, 32);
            label10.TabIndex = 59;
            label10.Text = "Dinero";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F);
            label11.Location = new Point(247, 309);
            label11.Name = "label11";
            label11.Size = new Size(86, 32);
            label11.TabIndex = 60;
            label11.Text = "Dinero";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 14.25F);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(353, 27);
            label12.Name = "label12";
            label12.Size = new Size(104, 32);
            label12.TabIndex = 61;
            label12.Text = "_________";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 14.25F);
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(357, 171);
            label13.Name = "label13";
            label13.Size = new Size(104, 32);
            label13.TabIndex = 62;
            label13.Text = "_________";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI", 14.25F);
            label14.ForeColor = SystemColors.ActiveCaptionText;
            label14.Location = new Point(238, 315);
            label14.Name = "label14";
            label14.Size = new Size(104, 32);
            label14.TabIndex = 63;
            label14.Text = "_________";
            // 
            // lblGMNecBasicasDinValor
            // 
            lblGMNecBasicasDinValor.AutoSize = true;
            lblGMNecBasicasDinValor.Font = new Font("Segoe UI", 14.25F);
            lblGMNecBasicasDinValor.Location = new Point(298, 59);
            lblGMNecBasicasDinValor.Name = "lblGMNecBasicasDinValor";
            lblGMNecBasicasDinValor.Size = new Size(86, 32);
            lblGMNecBasicasDinValor.TabIndex = 64;
            lblGMNecBasicasDinValor.Text = "Dinero";
            // 
            // pbArrow9
            // 
            pbArrow9.Location = new Point(390, 59);
            pbArrow9.Name = "pbArrow9";
            pbArrow9.Size = new Size(59, 33);
            pbArrow9.TabIndex = 65;
            pbArrow9.TabStop = false;
            // 
            // lblGMNecPorDin
            // 
            lblGMNecPorDin.AutoSize = true;
            lblGMNecPorDin.Font = new Font("Segoe UI", 14.25F);
            lblGMNecPorDin.Location = new Point(455, 60);
            lblGMNecPorDin.Name = "lblGMNecPorDin";
            lblGMNecPorDin.Size = new Size(114, 32);
            lblGMNecPorDin.TabIndex = 66;
            lblGMNecPorDin.Text = "por/diner";
            // 
            // lblGPPorDin
            // 
            lblGPPorDin.AutoSize = true;
            lblGPPorDin.Font = new Font("Segoe UI", 14.25F);
            lblGPPorDin.Location = new Point(455, 204);
            lblGPPorDin.Name = "lblGPPorDin";
            lblGPPorDin.Size = new Size(114, 32);
            lblGPPorDin.TabIndex = 69;
            lblGPPorDin.Text = "por/diner";
            // 
            // pbArrow10
            // 
            pbArrow10.Location = new Point(390, 203);
            pbArrow10.Name = "pbArrow10";
            pbArrow10.Size = new Size(59, 33);
            pbArrow10.TabIndex = 68;
            pbArrow10.TabStop = false;
            // 
            // lblGPDineroValor
            // 
            lblGPDineroValor.AutoSize = true;
            lblGPDineroValor.Font = new Font("Segoe UI", 14.25F);
            lblGPDineroValor.Location = new Point(298, 203);
            lblGPDineroValor.Name = "lblGPDineroValor";
            lblGPDineroValor.Size = new Size(86, 32);
            lblGPDineroValor.TabIndex = 67;
            lblGPDineroValor.Text = "Dinero";
            // 
            // lblAhorroPorDin
            // 
            lblAhorroPorDin.AutoSize = true;
            lblAhorroPorDin.Font = new Font("Segoe UI", 14.25F);
            lblAhorroPorDin.Location = new Point(321, 393);
            lblAhorroPorDin.Name = "lblAhorroPorDin";
            lblAhorroPorDin.Size = new Size(114, 32);
            lblAhorroPorDin.TabIndex = 72;
            lblAhorroPorDin.Text = "por/diner";
            // 
            // pbArrow11
            // 
            pbArrow11.Location = new Point(256, 392);
            pbArrow11.Name = "pbArrow11";
            pbArrow11.Size = new Size(59, 33);
            pbArrow11.TabIndex = 71;
            pbArrow11.TabStop = false;
            // 
            // lblAhorroDinValor
            // 
            lblAhorroDinValor.AutoSize = true;
            lblAhorroDinValor.Font = new Font("Segoe UI", 14.25F);
            lblAhorroDinValor.Location = new Point(165, 392);
            lblAhorroDinValor.Name = "lblAhorroDinValor";
            lblAhorroDinValor.Size = new Size(86, 32);
            lblAhorroDinValor.TabIndex = 70;
            lblAhorroDinValor.Text = "Dinero";
            // 
            // pnl503020
            // 
            pnl503020.BackColor = Color.Transparent;
            pnl503020.Controls.Add(lblAhorro);
            pnl503020.Controls.Add(lblNecesidadesBasicas);
            pnl503020.Controls.Add(lblAhorroPorDin);
            pnl503020.Controls.Add(label13);
            pnl503020.Controls.Add(label12);
            pnl503020.Controls.Add(label14);
            pnl503020.Controls.Add(lblGastosPrescin);
            pnl503020.Controls.Add(lblGPPorDin);
            pnl503020.Controls.Add(pbArrow6);
            pnl503020.Controls.Add(pbArrow11);
            pnl503020.Controls.Add(pbArrow7);
            pnl503020.Controls.Add(pbArrow10);
            pnl503020.Controls.Add(lblGastadoEsteMes);
            pnl503020.Controls.Add(pbArrow8);
            pnl503020.Controls.Add(lblGastoEsteMes);
            pnl503020.Controls.Add(lblGPDineroValor);
            pnl503020.Controls.Add(lblNecBasicasValor);
            pnl503020.Controls.Add(lblAhorroDinValor);
            pnl503020.Controls.Add(label10);
            pnl503020.Controls.Add(lblGMNecPorDin);
            pnl503020.Controls.Add(lblGMNecBasicasDinValor);
            pnl503020.Controls.Add(label9);
            pnl503020.Controls.Add(label11);
            pnl503020.Controls.Add(pbArrow9);
            pnl503020.Location = new Point(1187, 319);
            pnl503020.Name = "pnl503020";
            pnl503020.Size = new Size(584, 443);
            pnl503020.TabIndex = 73;
            // 
            // rgbPersonalizado
            // 
            rgbPersonalizado.Controls.Add(lblPDinero);
            rgbPersonalizado.Controls.Add(lblLineaSeparaciones3);
            rgbPersonalizado.Controls.Add(lblLineasSeparacines2);
            rgbPersonalizado.Controls.Add(lblLineaSeparaciones1);
            rgbPersonalizado.Controls.Add(cmbCategorias);
            rgbPersonalizado.Controls.Add(txtPNombre);
            rgbPersonalizado.Controls.Add(txtPPorcentaje);
            rgbPersonalizado.Location = new Point(23, 79);
            rgbPersonalizado.Name = "rgbPersonalizado";
            rgbPersonalizado.Size = new Size(613, 121);
            rgbPersonalizado.TabIndex = 74;
            rgbPersonalizado.TabStop = false;
            rgbPersonalizado.Text = "roundGroupBox1";
            // 
            // lblPDinero
            // 
            lblPDinero.AutoSize = true;
            lblPDinero.BackColor = Color.Transparent;
            lblPDinero.Location = new Point(143, 31);
            lblPDinero.Name = "lblPDinero";
            lblPDinero.Size = new Size(54, 20);
            lblPDinero.TabIndex = 46;
            lblPDinero.Text = "Dinero";
            // 
            // lblLineaSeparaciones3
            // 
            lblLineaSeparaciones3.AutoSize = true;
            lblLineaSeparaciones3.BackColor = Color.Transparent;
            lblLineaSeparaciones3.Font = new Font("Segoe UI", 14.25F);
            lblLineaSeparaciones3.ForeColor = SystemColors.ActiveCaptionText;
            lblLineaSeparaciones3.Location = new Point(201, 15);
            lblLineaSeparaciones3.Name = "lblLineaSeparaciones3";
            lblLineaSeparaciones3.Size = new Size(54, 32);
            lblLineaSeparaciones3.TabIndex = 45;
            lblLineaSeparaciones3.Text = "____";
            // 
            // lblLineasSeparacines2
            // 
            lblLineasSeparacines2.AutoSize = true;
            lblLineasSeparacines2.BackColor = Color.Transparent;
            lblLineasSeparacines2.Font = new Font("Segoe UI", 14.25F);
            lblLineasSeparacines2.ForeColor = SystemColors.ActiveCaptionText;
            lblLineasSeparacines2.Location = new Point(376, 13);
            lblLineasSeparacines2.Name = "lblLineasSeparacines2";
            lblLineasSeparacines2.Size = new Size(64, 32);
            lblLineasSeparacines2.TabIndex = 44;
            lblLineasSeparacines2.Text = "_____";
            // 
            // lblLineaSeparaciones1
            // 
            lblLineaSeparaciones1.AutoSize = true;
            lblLineaSeparaciones1.BackColor = Color.Transparent;
            lblLineaSeparaciones1.Font = new Font("Segoe UI", 14.25F);
            lblLineaSeparaciones1.ForeColor = SystemColors.ActiveCaptionText;
            lblLineaSeparaciones1.Location = new Point(85, 15);
            lblLineaSeparaciones1.Name = "lblLineaSeparaciones1";
            lblLineaSeparaciones1.Size = new Size(54, 32);
            lblLineaSeparaciones1.TabIndex = 43;
            lblLineaSeparaciones1.Text = "____";
            // 
            // cmbCategorias
            // 
            cmbCategorias.FormattingEnabled = true;
            cmbCategorias.Location = new Point(445, 27);
            cmbCategorias.Name = "cmbCategorias";
            cmbCategorias.Size = new Size(151, 28);
            cmbCategorias.TabIndex = 2;
            // 
            // txtPNombre
            // 
            txtPNombre.Location = new Point(271, 28);
            txtPNombre.Name = "txtPNombre";
            txtPNombre.Size = new Size(100, 27);
            txtPNombre.TabIndex = 1;
            // 
            // txtPPorcentaje
            // 
            txtPPorcentaje.Location = new Point(18, 27);
            txtPPorcentaje.Name = "txtPPorcentaje";
            txtPPorcentaje.Size = new Size(59, 27);
            txtPPorcentaje.TabIndex = 0;
            // 
            // lblPPorAsignar
            // 
            lblPPorAsignar.AutoSize = true;
            lblPPorAsignar.BackColor = Color.Transparent;
            lblPPorAsignar.Font = new Font("Segoe UI", 14.25F);
            lblPPorAsignar.ForeColor = Color.Purple;
            lblPPorAsignar.Location = new Point(185, 21);
            lblPPorAsignar.Name = "lblPPorAsignar";
            lblPPorAsignar.Size = new Size(170, 32);
            lblPPorAsignar.TabIndex = 75;
            lblPPorAsignar.Text = "% Por asignar: ";
            // 
            // lblPPor
            // 
            lblPPor.AutoSize = true;
            lblPPor.BackColor = Color.Transparent;
            lblPPor.Font = new Font("Segoe UI", 14.25F);
            lblPPor.ForeColor = Color.Purple;
            lblPPor.Location = new Point(352, 21);
            lblPPor.Name = "lblPPor";
            lblPPor.Size = new Size(48, 32);
            lblPPor.TabIndex = 76;
            lblPPor.Text = "Por";
            // 
            // lblLineaPpor
            // 
            lblLineaPpor.AutoSize = true;
            lblLineaPpor.BackColor = Color.Transparent;
            lblLineaPpor.Font = new Font("Segoe UI", 14.25F);
            lblLineaPpor.ForeColor = Color.Purple;
            lblLineaPpor.Location = new Point(342, 27);
            lblLineaPpor.Name = "lblLineaPpor";
            lblLineaPpor.Size = new Size(74, 32);
            lblLineaPpor.TabIndex = 77;
            lblLineaPpor.Text = "______";
            // 
            // pnlPersonalizado
            // 
            pnlPersonalizado.BackColor = Color.Transparent;
            pnlPersonalizado.Controls.Add(rgbPersonalizado);
            pnlPersonalizado.Controls.Add(lblPPor);
            pnlPersonalizado.Controls.Add(lblPPorAsignar);
            pnlPersonalizado.Controls.Add(lblLineaPpor);
            pnlPersonalizado.Location = new Point(1142, 302);
            pnlPersonalizado.Name = "pnlPersonalizado";
            pnlPersonalizado.Size = new Size(655, 219);
            pnlPersonalizado.TabIndex = 78;
            pnlPersonalizado.Visible = false;
            // 
            // btnPAgregar
            // 
            btnPAgregar.BackColor = Color.FromArgb(178, 242, 187);
            btnPAgregar.FlatStyle = FlatStyle.Flat;
            btnPAgregar.Font = new Font("Segoe UI", 14.25F);
            btnPAgregar.Location = new Point(1426, 801);
            btnPAgregar.Name = "btnPAgregar";
            btnPAgregar.Size = new Size(171, 53);
            btnPAgregar.TabIndex = 79;
            btnPAgregar.Text = "Añadir %";
            btnPAgregar.UseVisualStyleBackColor = false;
            btnPAgregar.Visible = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(211, 208, 242);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 14.25F);
            btnSalir.Location = new Point(1626, 801);
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
            lblKakebo.Font = new Font("Segoe UI", 16F);
            lblKakebo.Location = new Point(561, 122);
            lblKakebo.Name = "lblKakebo";
            lblKakebo.Size = new Size(106, 37);
            lblKakebo.TabIndex = 81;
            lblKakebo.Text = "Kakebo";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI", 14.25F);
            label15.ForeColor = SystemColors.ActiveCaptionText;
            label15.Location = new Point(544, 132);
            label15.Name = "label15";
            label15.Size = new Size(144, 32);
            label15.TabIndex = 83;
            label15.Text = "_____________";
            // 
            // lblPorcentajes
            // 
            lblPorcentajes.AutoSize = true;
            lblPorcentajes.Font = new Font("Segoe UI", 16F);
            lblPorcentajes.Location = new Point(1301, 122);
            lblPorcentajes.Name = "lblPorcentajes";
            lblPorcentajes.Size = new Size(152, 37);
            lblPorcentajes.TabIndex = 84;
            lblPorcentajes.Text = "Porcentajes";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Segoe UI", 14.25F);
            label16.ForeColor = SystemColors.ActiveCaptionText;
            label16.Location = new Point(1282, 132);
            label16.Name = "label16";
            label16.Size = new Size(184, 32);
            label16.TabIndex = 85;
            label16.Text = "_________________";
            // 
            // barraSecundaria1
            // 
            barraSecundaria1.BackColor = Color.FromArgb(211, 208, 242);
            barraSecundaria1.Dock = DockStyle.Top;
            barraSecundaria1.Location = new Point(0, 40);
            barraSecundaria1.Name = "barraSecundaria1";
            barraSecundaria1.Size = new Size(1509, 44);
            barraSecundaria1.TabIndex = 86;
            // 
            // barraLateral1
            // 
            barraLateral1.BackColor = Color.FromArgb(205, 213, 221);
            barraLateral1.Dock = DockStyle.Left;
            barraLateral1.Location = new Point(0, 84);
            barraLateral1.Name = "barraLateral1";
            barraLateral1.Size = new Size(237, 787);
            barraLateral1.TabIndex = 87;
            // 
            // frmMetodosAhorro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 236, 239);
            ClientSize = new Size(1509, 871);
            Controls.Add(barraLateral1);
            Controls.Add(barraSecundaria1);
            Controls.Add(lblPorcentajes);
            Controls.Add(label16);
            Controls.Add(lblKakebo);
            Controls.Add(btnSalir);
            Controls.Add(btnPAgregar);
            Controls.Add(pnlPersonalizado);
            Controls.Add(pnl503020);
            Controls.Add(pnlContenedorOpc);
            Controls.Add(pnlBarra1);
            Controls.Add(lblPorcentajeRest);
            Controls.Add(pbArrow5);
            Controls.Add(lblDineroRest);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(pbArrow4);
            Controls.Add(pbArrow3);
            Controls.Add(lblPorcentajeVariable);
            Controls.Add(lblTotalGastosVariables);
            Controls.Add(lblTotalGastosVariable);
            Controls.Add(pbArrow2);
            Controls.Add(pbArrow);
            Controls.Add(lblPorcentajeFijo);
            Controls.Add(lblTotalValorFijo);
            Controls.Add(label4);
            Controls.Add(dgvGastosVariables);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(lblGastosFijos);
            Controls.Add(label1);
            Controls.Add(dgvGastosFijos);
            Controls.Add(lblIngresoMesCont);
            Controls.Add(lblLinea);
            Controls.Add(lblIngresosMes);
            Controls.Add(label7);
            Controls.Add(label15);
            Name = "frmMetodosAhorro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MetodosAhorro";
            WindowState = FormWindowState.Maximized;
            Load += MetodosAhorro_Load;
            Controls.SetChildIndex(label15, 0);
            Controls.SetChildIndex(label7, 0);
            Controls.SetChildIndex(lblIngresosMes, 0);
            Controls.SetChildIndex(lblLinea, 0);
            Controls.SetChildIndex(lblIngresoMesCont, 0);
            Controls.SetChildIndex(dgvGastosFijos, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(lblGastosFijos, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(dgvGastosVariables, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(lblTotalValorFijo, 0);
            Controls.SetChildIndex(lblPorcentajeFijo, 0);
            Controls.SetChildIndex(pbArrow, 0);
            Controls.SetChildIndex(pbArrow2, 0);
            Controls.SetChildIndex(lblTotalGastosVariable, 0);
            Controls.SetChildIndex(lblTotalGastosVariables, 0);
            Controls.SetChildIndex(lblPorcentajeVariable, 0);
            Controls.SetChildIndex(pbArrow3, 0);
            Controls.SetChildIndex(pbArrow4, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(lblDineroRest, 0);
            Controls.SetChildIndex(pbArrow5, 0);
            Controls.SetChildIndex(lblPorcentajeRest, 0);
            Controls.SetChildIndex(pnlBarra1, 0);
            Controls.SetChildIndex(pnlContenedorOpc, 0);
            Controls.SetChildIndex(pnl503020, 0);
            Controls.SetChildIndex(pnlPersonalizado, 0);
            Controls.SetChildIndex(btnPAgregar, 0);
            Controls.SetChildIndex(btnSalir, 0);
            Controls.SetChildIndex(lblKakebo, 0);
            Controls.SetChildIndex(label16, 0);
            Controls.SetChildIndex(lblPorcentajes, 0);
            Controls.SetChildIndex(barraSecundaria1, 0);
            Controls.SetChildIndex(barraLateral1, 0);
            ((System.ComponentModel.ISupportInitialize)dgvGastosFijos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGastosVariables).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbArrow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbArrow2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbArrow4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbArrow3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbArrow5).EndInit();
            pnlContenedorOpc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbArrow6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbArrow7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbArrow8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbArrow9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbArrow10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbArrow11).EndInit();
            pnl503020.ResumeLayout(false);
            pnl503020.PerformLayout();
            rgbPersonalizado.ResumeLayout(false);
            rgbPersonalizado.PerformLayout();
            pnlPersonalizado.ResumeLayout(false);
            pnlPersonalizado.PerformLayout();
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
        private PictureBox pbArrow;
        private PictureBox pbArrow2;
        private PictureBox pbArrow4;
        private PictureBox pbArrow3;
        private Label lblPorcentajeVariable;
        private Label lblTotalGastosVariables;
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
        private Label lblNecesidadesBasicas;
        private Label lblGastosPrescin;
        private Label lblAhorro;
        private PictureBox pbArrow6;
        private PictureBox pbArrow7;
        private PictureBox pbArrow8;
        private Label lblGastadoEsteMes;
        private Label lblGastoEsteMes;
        private Label label9;
        private Label lblNecBasicasValor;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label lblGMNecBasicasDinValor;
        private PictureBox pbArrow9;
        private Label lblGMNecPorDin;
        private Label lblGPPorDin;
        private PictureBox pbArrow10;
        private Label lblGPDineroValor;
        private Label lblAhorroPorDin;
        private PictureBox pbArrow11;
        private Label lblAhorroDinValor;
        private Panel pnl503020;
        private RoundGroupBox rgbPersonalizado;
        private TextBox txtPPorcentaje;
        private ComboBox cmbCategorias;
        private TextBox txtPNombre;
        private Label lblLineaSeparaciones1;
        private Label lblLineasSeparacines2;
        private Label lblLineaSeparaciones3;
        private Label lblPDinero;
        private Label lblPPorAsignar;
        private Label lblPPor;
        private Label lblLineaPpor;
        private Panel pnlPersonalizado;
        private Button btnPAgregar;
        private Button btnSalir;
        private Label lblKakebo;
        private Label label15;
        private Label lblPorcentajes;
        private Label label16;
        private BarraSecundaria barraSecundaria1;
        private BarraLateral barraLateral1;
    }
}