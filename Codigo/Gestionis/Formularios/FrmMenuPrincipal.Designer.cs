using Gestionis.Herramientas;

namespace Gestionis
{
    partial class FrmMenuPrincipal
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            rgbMenu = new RoundGroupBox();
            btnRestablecerIngresos = new Button();
            btnRestablecerGastos = new Button();
            nudDineroIngreso = new NumericUpDown();
            nudDineroGasto = new NumericUpDown();
            btnFiltrarIngresos = new Button();
            btnFiltrarGastos = new Button();
            dgvIngresos = new DataGridView();
            dgvGastos = new DataGridView();
            cmbCategoriaIngreso = new ComboBox();
            cmbTipoIngreso = new ComboBox();
            txtNombreIngreso = new TextBox();
            lblTotalValor = new Label();
            lblGastosValor = new Label();
            lblIngresosValor = new Label();
            lblTotal = new Label();
            lblGastos = new Label();
            lblIngresos = new Label();
            cmbCategoriaGasto = new ComboBox();
            cmbTipoGasto = new ComboBox();
            txtNombreGasto = new TextBox();
            btnGasto = new Button();
            btnIngreso = new Button();
            lblLinea = new Label();
            lblLinea2 = new Label();
            lblLinea3 = new Label();
            rgbCalendario = new RoundGroupBox();
            lblAdelante = new Label();
            lblAtras = new Label();
            lblMes = new Label();
            label3 = new Label();
            btnSalir = new Button();
            pnlNotas = new Panel();
            lblNotasValor = new Label();
            lblNotas = new Label();
            barraSecundaria1 = new BarraSecundaria();
            barraLateral1 = new BarraLateral();
            rgbMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDineroIngreso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDineroGasto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvIngresos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGastos).BeginInit();
            rgbCalendario.SuspendLayout();
            pnlNotas.SuspendLayout();
            SuspendLayout();
            // 
            // rgbMenu
            // 
            rgbMenu.AutoSize = true;
            rgbMenu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            rgbMenu.BackColor = Color.Transparent;
            rgbMenu.Controls.Add(btnRestablecerIngresos);
            rgbMenu.Controls.Add(btnRestablecerGastos);
            rgbMenu.Controls.Add(nudDineroIngreso);
            rgbMenu.Controls.Add(nudDineroGasto);
            rgbMenu.Controls.Add(btnFiltrarIngresos);
            rgbMenu.Controls.Add(btnFiltrarGastos);
            rgbMenu.Controls.Add(dgvIngresos);
            rgbMenu.Controls.Add(dgvGastos);
            rgbMenu.Controls.Add(cmbCategoriaIngreso);
            rgbMenu.Controls.Add(cmbTipoIngreso);
            rgbMenu.Controls.Add(txtNombreIngreso);
            rgbMenu.Controls.Add(lblTotalValor);
            rgbMenu.Controls.Add(lblGastosValor);
            rgbMenu.Controls.Add(lblIngresosValor);
            rgbMenu.Controls.Add(lblTotal);
            rgbMenu.Controls.Add(lblGastos);
            rgbMenu.Controls.Add(lblIngresos);
            rgbMenu.Controls.Add(cmbCategoriaGasto);
            rgbMenu.Controls.Add(cmbTipoGasto);
            rgbMenu.Controls.Add(txtNombreGasto);
            rgbMenu.Controls.Add(btnGasto);
            rgbMenu.Controls.Add(btnIngreso);
            rgbMenu.Controls.Add(lblLinea);
            rgbMenu.Controls.Add(lblLinea2);
            rgbMenu.Controls.Add(lblLinea3);
            rgbMenu.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rgbMenu.ForeColor = SystemColors.ControlText;
            rgbMenu.Location = new Point(248, 96);
            rgbMenu.Margin = new Padding(3, 2, 3, 2);
            rgbMenu.Name = "rgbMenu";
            rgbMenu.Padding = new Padding(3, 2, 3, 2);
            rgbMenu.Size = new Size(1190, 531);
            rgbMenu.TabIndex = 3;
            rgbMenu.TabStop = false;
            // 
            // btnRestablecerIngresos
            // 
            btnRestablecerIngresos.Location = new Point(899, 459);
            btnRestablecerIngresos.Name = "btnRestablecerIngresos";
            btnRestablecerIngresos.Size = new Size(138, 41);
            btnRestablecerIngresos.TabIndex = 26;
            btnRestablecerIngresos.Text = "Restablecer";
            btnRestablecerIngresos.UseVisualStyleBackColor = true;
            btnRestablecerIngresos.Click += btnRestablecerIngresos_Click;
            // 
            // btnRestablecerGastos
            // 
            btnRestablecerGastos.Location = new Point(325, 459);
            btnRestablecerGastos.Name = "btnRestablecerGastos";
            btnRestablecerGastos.Size = new Size(138, 41);
            btnRestablecerGastos.TabIndex = 25;
            btnRestablecerGastos.Text = "Restablecer";
            btnRestablecerGastos.UseVisualStyleBackColor = true;
            btnRestablecerGastos.Click += btnRestablecerGastos_Click;
            // 
            // nudDineroIngreso
            // 
            nudDineroIngreso.DecimalPlaces = 2;
            nudDineroIngreso.Location = new Point(914, 171);
            nudDineroIngreso.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudDineroIngreso.Name = "nudDineroIngreso";
            nudDineroIngreso.Size = new Size(112, 33);
            nudDineroIngreso.TabIndex = 24;
            // 
            // nudDineroGasto
            // 
            nudDineroGasto.DecimalPlaces = 2;
            nudDineroGasto.Location = new Point(342, 171);
            nudDineroGasto.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudDineroGasto.Name = "nudDineroGasto";
            nudDineroGasto.Size = new Size(112, 33);
            nudDineroGasto.TabIndex = 23;
            // 
            // btnFiltrarIngresos
            // 
            btnFiltrarIngresos.Location = new Point(1043, 459);
            btnFiltrarIngresos.Name = "btnFiltrarIngresos";
            btnFiltrarIngresos.Size = new Size(124, 41);
            btnFiltrarIngresos.TabIndex = 22;
            btnFiltrarIngresos.Text = "Filtrar";
            btnFiltrarIngresos.UseVisualStyleBackColor = true;
            btnFiltrarIngresos.Click += btnFiltrarIngresos_Click;
            // 
            // btnFiltrarGastos
            // 
            btnFiltrarGastos.Location = new Point(469, 459);
            btnFiltrarGastos.Name = "btnFiltrarGastos";
            btnFiltrarGastos.Size = new Size(124, 41);
            btnFiltrarGastos.TabIndex = 21;
            btnFiltrarGastos.Text = "Filtrar";
            btnFiltrarGastos.UseVisualStyleBackColor = true;
            btnFiltrarGastos.Click += btnFiltrarGastos_Click;
            // 
            // dgvIngresos
            // 
            dgvIngresos.BackgroundColor = SystemColors.Menu;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvIngresos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvIngresos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvIngresos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvIngresos.Location = new Point(615, 226);
            dgvIngresos.Name = "dgvIngresos";
            dgvIngresos.Size = new Size(552, 217);
            dgvIngresos.TabIndex = 20;
            // 
            // dgvGastos
            // 
            dgvGastos.BackgroundColor = SystemColors.Menu;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvGastos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvGastos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvGastos.DefaultCellStyle = dataGridViewCellStyle4;
            dgvGastos.Location = new Point(41, 226);
            dgvGastos.Name = "dgvGastos";
            dgvGastos.Size = new Size(552, 217);
            dgvGastos.TabIndex = 19;
            // 
            // cmbCategoriaIngreso
            // 
            cmbCategoriaIngreso.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoriaIngreso.FormattingEnabled = true;
            cmbCategoriaIngreso.Location = new Point(1032, 172);
            cmbCategoriaIngreso.Name = "cmbCategoriaIngreso";
            cmbCategoriaIngreso.Size = new Size(135, 33);
            cmbCategoriaIngreso.TabIndex = 19;
            // 
            // cmbTipoIngreso
            // 
            cmbTipoIngreso.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoIngreso.FormattingEnabled = true;
            cmbTipoIngreso.Location = new Point(793, 172);
            cmbTipoIngreso.Name = "cmbTipoIngreso";
            cmbTipoIngreso.Size = new Size(115, 33);
            cmbTipoIngreso.TabIndex = 17;
            // 
            // txtNombreIngreso
            // 
            txtNombreIngreso.Location = new Point(615, 172);
            txtNombreIngreso.Name = "txtNombreIngreso";
            txtNombreIngreso.Size = new Size(172, 33);
            txtNombreIngreso.TabIndex = 16;
            // 
            // lblTotalValor
            // 
            lblTotalValor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalValor.AutoSize = true;
            lblTotalValor.Location = new Point(1063, 111);
            lblTotalValor.Name = "lblTotalValor";
            lblTotalValor.Size = new Size(87, 25);
            lblTotalValor.TabIndex = 12;
            lblTotalValor.Text = "Ingresos:";
            // 
            // lblGastosValor
            // 
            lblGastosValor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblGastosValor.AutoSize = true;
            lblGastosValor.Location = new Point(1063, 74);
            lblGastosValor.Name = "lblGastosValor";
            lblGastosValor.Size = new Size(87, 25);
            lblGastosValor.TabIndex = 11;
            lblGastosValor.Text = "Ingresos:";
            // 
            // lblIngresosValor
            // 
            lblIngresosValor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblIngresosValor.AutoSize = true;
            lblIngresosValor.Location = new Point(1063, 38);
            lblIngresosValor.Name = "lblIngresosValor";
            lblIngresosValor.Size = new Size(87, 25);
            lblIngresosValor.TabIndex = 10;
            lblIngresosValor.Text = "Ingresos:";
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(971, 111);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(56, 25);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "Total:";
            // 
            // lblGastos
            // 
            lblGastos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblGastos.AutoSize = true;
            lblGastos.Location = new Point(971, 74);
            lblGastos.Name = "lblGastos";
            lblGastos.Size = new Size(72, 25);
            lblGastos.TabIndex = 8;
            lblGastos.Text = "Gastos:";
            // 
            // lblIngresos
            // 
            lblIngresos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblIngresos.AutoSize = true;
            lblIngresos.Location = new Point(971, 38);
            lblIngresos.Name = "lblIngresos";
            lblIngresos.Size = new Size(87, 25);
            lblIngresos.TabIndex = 7;
            lblIngresos.Text = "Ingresos:";
            // 
            // cmbCategoriaGasto
            // 
            cmbCategoriaGasto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoriaGasto.FormattingEnabled = true;
            cmbCategoriaGasto.Location = new Point(460, 171);
            cmbCategoriaGasto.Name = "cmbCategoriaGasto";
            cmbCategoriaGasto.Size = new Size(133, 33);
            cmbCategoriaGasto.TabIndex = 6;
            // 
            // cmbTipoGasto
            // 
            cmbTipoGasto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoGasto.FormattingEnabled = true;
            cmbTipoGasto.Location = new Point(221, 172);
            cmbTipoGasto.Name = "cmbTipoGasto";
            cmbTipoGasto.Size = new Size(115, 33);
            cmbTipoGasto.TabIndex = 4;
            // 
            // txtNombreGasto
            // 
            txtNombreGasto.Location = new Point(41, 172);
            txtNombreGasto.Name = "txtNombreGasto";
            txtNombreGasto.Size = new Size(172, 33);
            txtNombreGasto.TabIndex = 3;
            // 
            // btnGasto
            // 
            btnGasto.BackColor = Color.FromArgb(178, 242, 187);
            btnGasto.Location = new Point(58, 38);
            btnGasto.Name = "btnGasto";
            btnGasto.Size = new Size(200, 80);
            btnGasto.TabIndex = 1;
            btnGasto.Text = "Nuevo Gasto";
            btnGasto.UseVisualStyleBackColor = false;
            btnGasto.Click += btnGasto_Click;
            // 
            // btnIngreso
            // 
            btnIngreso.BackColor = Color.FromArgb(178, 242, 187);
            btnIngreso.Location = new Point(264, 38);
            btnIngreso.Name = "btnIngreso";
            btnIngreso.Size = new Size(200, 80);
            btnIngreso.TabIndex = 0;
            btnIngreso.Text = "Nuevo Ingreso";
            btnIngreso.UseVisualStyleBackColor = false;
            btnIngreso.Click += btnIngreso_Click;
            // 
            // lblLinea
            // 
            lblLinea.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLinea.AutoSize = true;
            lblLinea.Location = new Point(969, 42);
            lblLinea.Name = "lblLinea";
            lblLinea.Size = new Size(172, 25);
            lblLinea.TabIndex = 0;
            lblLinea.Text = "____________________";
            // 
            // lblLinea2
            // 
            lblLinea2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLinea2.AutoSize = true;
            lblLinea2.Location = new Point(971, 78);
            lblLinea2.Name = "lblLinea2";
            lblLinea2.Size = new Size(172, 25);
            lblLinea2.TabIndex = 14;
            lblLinea2.Text = "____________________";
            // 
            // lblLinea3
            // 
            lblLinea3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLinea3.AutoSize = true;
            lblLinea3.Location = new Point(970, 114);
            lblLinea3.Name = "lblLinea3";
            lblLinea3.Size = new Size(172, 25);
            lblLinea3.TabIndex = 13;
            lblLinea3.Text = "____________________";
            // 
            // rgbCalendario
            // 
            rgbCalendario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rgbCalendario.Controls.Add(lblAdelante);
            rgbCalendario.Controls.Add(lblAtras);
            rgbCalendario.Controls.Add(lblMes);
            rgbCalendario.Controls.Add(label3);
            rgbCalendario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rgbCalendario.Location = new Point(32767, 147);
            rgbCalendario.Name = "rgbCalendario";
            rgbCalendario.Size = new Size(199, 103);
            rgbCalendario.TabIndex = 4;
            rgbCalendario.TabStop = false;
            // 
            // lblAdelante
            // 
            lblAdelante.AutoSize = true;
            lblAdelante.BackColor = Color.Transparent;
            lblAdelante.Location = new Point(0, 2);
            lblAdelante.Name = "lblAdelante";
            lblAdelante.Size = new Size(25, 25);
            lblAdelante.TabIndex = 3;
            lblAdelante.Text = ">";
            // 
            // lblAtras
            // 
            lblAtras.AutoSize = true;
            lblAtras.BackColor = Color.Transparent;
            lblAtras.Location = new Point(0, 2);
            lblAtras.Name = "lblAtras";
            lblAtras.Size = new Size(25, 25);
            lblAtras.TabIndex = 2;
            lblAtras.Text = "<";
            // 
            // lblMes
            // 
            lblMes.AutoSize = true;
            lblMes.BackColor = Color.Transparent;
            lblMes.Location = new Point(0, 2);
            lblMes.Name = "lblMes";
            lblMes.Size = new Size(47, 25);
            lblMes.TabIndex = 1;
            lblMes.Text = "Mes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(-4, 6);
            label3.Name = "label3";
            label3.Size = new Size(212, 25);
            label3.TabIndex = 0;
            label3.Text = "_________________________";
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.BackColor = Color.FromArgb(178, 242, 187);
            btnSalir.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(32767, 745);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(152, 45);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // pnlNotas
            // 
            pnlNotas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlNotas.BackColor = Color.FromArgb(205, 213, 221);
            pnlNotas.Controls.Add(lblNotasValor);
            pnlNotas.Controls.Add(lblNotas);
            pnlNotas.Location = new Point(32767, 297);
            pnlNotas.Name = "pnlNotas";
            pnlNotas.Size = new Size(275, 181);
            pnlNotas.TabIndex = 16;
            // 
            // lblNotasValor
            // 
            lblNotasValor.AutoSize = true;
            lblNotasValor.BackColor = Color.Transparent;
            lblNotasValor.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNotasValor.Location = new Point(0, 39);
            lblNotasValor.Name = "lblNotasValor";
            lblNotasValor.Size = new Size(123, 25);
            lblNotasValor.TabIndex = 5;
            lblNotasValor.Text = "Notas del día";
            // 
            // lblNotas
            // 
            lblNotas.AutoSize = true;
            lblNotas.BackColor = Color.Transparent;
            lblNotas.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblNotas.Location = new Point(0, 1);
            lblNotas.Name = "lblNotas";
            lblNotas.Size = new Size(123, 25);
            lblNotas.TabIndex = 4;
            lblNotas.Text = "Notas del día";
            // 
            // barraSecundaria1
            // 
            barraSecundaria1.BackColor = Color.FromArgb(211, 208, 242);
            barraSecundaria1.Dock = DockStyle.Top;
            barraSecundaria1.Location = new Point(0, 40);
            barraSecundaria1.Name = "barraSecundaria1";
            barraSecundaria1.Size = new Size(1463, 35);
            barraSecundaria1.TabIndex = 17;
            // 
            // barraLateral1
            // 
            barraLateral1.BackColor = Color.FromArgb(205, 213, 221);
            barraLateral1.Dock = DockStyle.Left;
            barraLateral1.Location = new Point(0, 75);
            barraLateral1.Name = "barraLateral1";
            barraLateral1.Size = new Size(231, 753);
            barraLateral1.TabIndex = 18;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 236, 239);
            ClientSize = new Size(1463, 828);
            ControlBox = false;
            Controls.Add(barraLateral1);
            Controls.Add(barraSecundaria1);
            Controls.Add(pnlNotas);
            Controls.Add(btnSalir);
            Controls.Add(rgbCalendario);
            Controls.Add(rgbMenu);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestionis";
            WindowState = FormWindowState.Maximized;
            Activated += FrmMenuPrincipal_Activated;
            Load += FrmMenuPrincipal_Load;
            Controls.SetChildIndex(rgbMenu, 0);
            Controls.SetChildIndex(rgbCalendario, 0);
            Controls.SetChildIndex(btnSalir, 0);
            Controls.SetChildIndex(pnlNotas, 0);
            Controls.SetChildIndex(barraSecundaria1, 0);
            Controls.SetChildIndex(barraLateral1, 0);
            rgbMenu.ResumeLayout(false);
            rgbMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDineroIngreso).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDineroGasto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvIngresos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGastos).EndInit();
            rgbCalendario.ResumeLayout(false);
            rgbCalendario.PerformLayout();
            pnlNotas.ResumeLayout(false);
            pnlNotas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RoundGroupBox rgbMenu;
        private Button btnGasto;
        private Button btnIngreso;
        private Label lblTotalValor;
        private Label lblGastosValor;
        private Label lblIngresosValor;
        private Label lblTotal;
        private Label lblGastos;
        private Label lblIngresos;
        private ComboBox cmbCategoriaGasto;
        private ComboBox cmbTipoGasto;
        private TextBox txtNombreGasto;
        private RoundGroupBox rgbCalendario;
        private Label lblLinea;
        private Label lblLinea2;
        private Label lblLinea3;
        private Label label3;
        private Button btnSalir;
        private Panel pnlNotas;
        private Label lblAdelante;
        private Label lblAtras;
        private Label lblMes;
        private Label lblNotas;
        private Label lblNotasValor;
        private BarraSecundaria barraSecundaria1;
        private BarraLateral barraLateral1;
        private ComboBox cmbCategoriaIngreso;
        private ComboBox cmbTipoIngreso;
        private TextBox txtNombreIngreso;
        private DataGridView dgvIngresos;
        private DataGridView dgvGastos;
        private Button btnFiltrarIngresos;
        private Button btnFiltrarGastos;
        private NumericUpDown nudDineroIngreso;
        private NumericUpDown nudDineroGasto;
        private Button btnRestablecerIngresos;
        private Button btnRestablecerGastos;
    }
}