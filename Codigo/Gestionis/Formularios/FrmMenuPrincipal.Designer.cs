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
            rgbMenu = new RoundGroupBox();
            lblTotalValor = new Label();
            lblGastosValor = new Label();
            lblIngresosValor = new Label();
            lblTotal = new Label();
            lblGastos = new Label();
            lblIngresos = new Label();
            cmbCategoria = new ComboBox();
            cmbDinero = new ComboBox();
            cmbTipo = new ComboBox();
            txtNombre = new TextBox();
            dgvGastosIngresos = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dgvGastosIngresos).BeginInit();
            rgbCalendario.SuspendLayout();
            pnlNotas.SuspendLayout();
            SuspendLayout();
            // 
            // rgbMenu
            // 
            rgbMenu.AutoSize = true;
            rgbMenu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            rgbMenu.BackColor = Color.Transparent;
            rgbMenu.Controls.Add(lblTotalValor);
            rgbMenu.Controls.Add(lblGastosValor);
            rgbMenu.Controls.Add(lblIngresosValor);
            rgbMenu.Controls.Add(lblTotal);
            rgbMenu.Controls.Add(lblGastos);
            rgbMenu.Controls.Add(lblIngresos);
            rgbMenu.Controls.Add(cmbCategoria);
            rgbMenu.Controls.Add(cmbDinero);
            rgbMenu.Controls.Add(cmbTipo);
            rgbMenu.Controls.Add(txtNombre);
            rgbMenu.Controls.Add(dgvGastosIngresos);
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
            rgbMenu.Size = new Size(859, 465);
            rgbMenu.TabIndex = 3;
            rgbMenu.TabStop = false;
            // 
            // lblTotalValor
            // 
            lblTotalValor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalValor.AutoSize = true;
            lblTotalValor.Location = new Point(732, 111);
            lblTotalValor.Name = "lblTotalValor";
            lblTotalValor.Size = new Size(87, 25);
            lblTotalValor.TabIndex = 12;
            lblTotalValor.Text = "Ingresos:";
            // 
            // lblGastosValor
            // 
            lblGastosValor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblGastosValor.AutoSize = true;
            lblGastosValor.Location = new Point(732, 74);
            lblGastosValor.Name = "lblGastosValor";
            lblGastosValor.Size = new Size(87, 25);
            lblGastosValor.TabIndex = 11;
            lblGastosValor.Text = "Ingresos:";
            // 
            // lblIngresosValor
            // 
            lblIngresosValor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblIngresosValor.AutoSize = true;
            lblIngresosValor.Location = new Point(732, 38);
            lblIngresosValor.Name = "lblIngresosValor";
            lblIngresosValor.Size = new Size(87, 25);
            lblIngresosValor.TabIndex = 10;
            lblIngresosValor.Text = "Ingresos:";
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(640, 111);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(56, 25);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "Total:";
            // 
            // lblGastos
            // 
            lblGastos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblGastos.AutoSize = true;
            lblGastos.Location = new Point(640, 74);
            lblGastos.Name = "lblGastos";
            lblGastos.Size = new Size(72, 25);
            lblGastos.TabIndex = 8;
            lblGastos.Text = "Gastos:";
            // 
            // lblIngresos
            // 
            lblIngresos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblIngresos.AutoSize = true;
            lblIngresos.Location = new Point(640, 38);
            lblIngresos.Name = "lblIngresos";
            lblIngresos.Size = new Size(87, 25);
            lblIngresos.TabIndex = 7;
            lblIngresos.Text = "Ingresos:";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(437, 172);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(128, 33);
            cmbCategoria.TabIndex = 6;
            // 
            // cmbDinero
            // 
            cmbDinero.FormattingEnabled = true;
            cmbDinero.Location = new Point(329, 172);
            cmbDinero.Name = "cmbDinero";
            cmbDinero.Size = new Size(92, 33);
            cmbDinero.TabIndex = 5;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(251, 172);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(63, 33);
            cmbTipo.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(41, 172);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(198, 33);
            txtNombre.TabIndex = 3;
            // 
            // dgvGastosIngresos
            // 
            dgvGastosIngresos.BackgroundColor = SystemColors.ControlLightLight;
            dgvGastosIngresos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGastosIngresos.GridColor = SystemColors.Window;
            dgvGastosIngresos.Location = new Point(41, 225);
            dgvGastosIngresos.Name = "dgvGastosIngresos";
            dgvGastosIngresos.RowHeadersWidth = 51;
            dgvGastosIngresos.Size = new Size(524, 209);
            dgvGastosIngresos.TabIndex = 2;
            // 
            // btnGasto
            // 
            btnGasto.BackColor = Color.FromArgb(178, 242, 187);
            btnGasto.Location = new Point(53, 91);
            btnGasto.Name = "btnGasto";
            btnGasto.Size = new Size(160, 45);
            btnGasto.TabIndex = 1;
            btnGasto.Text = "Nuevo Gasto";
            btnGasto.UseVisualStyleBackColor = false;
            btnGasto.Click += btnGasto_Click;
            // 
            // btnIngreso
            // 
            btnIngreso.BackColor = Color.FromArgb(178, 242, 187);
            btnIngreso.Location = new Point(53, 38);
            btnIngreso.Name = "btnIngreso";
            btnIngreso.Size = new Size(160, 45);
            btnIngreso.TabIndex = 0;
            btnIngreso.Text = "Nuevo Ingreso";
            btnIngreso.UseVisualStyleBackColor = false;
            btnIngreso.Click += btnIngreso_Click;
            // 
            // lblLinea
            // 
            lblLinea.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLinea.AutoSize = true;
            lblLinea.Location = new Point(638, 42);
            lblLinea.Name = "lblLinea";
            lblLinea.Size = new Size(172, 25);
            lblLinea.TabIndex = 0;
            lblLinea.Text = "____________________";
            // 
            // lblLinea2
            // 
            lblLinea2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLinea2.AutoSize = true;
            lblLinea2.Location = new Point(640, 78);
            lblLinea2.Name = "lblLinea2";
            lblLinea2.Size = new Size(172, 25);
            lblLinea2.TabIndex = 14;
            lblLinea2.Text = "____________________";
            // 
            // lblLinea3
            // 
            lblLinea3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLinea3.AutoSize = true;
            lblLinea3.Location = new Point(639, 114);
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
            rgbCalendario.Location = new Point(7010, 147);
            rgbCalendario.Name = "rgbCalendario";
            rgbCalendario.Size = new Size(199, 103);
            rgbCalendario.TabIndex = 4;
            rgbCalendario.TabStop = false;
            // 
            // lblAdelante
            // 
            lblAdelante.AutoSize = true;
            lblAdelante.BackColor = Color.Transparent;
            lblAdelante.Location = new Point(134, 2);
            lblAdelante.Name = "lblAdelante";
            lblAdelante.Size = new Size(25, 25);
            lblAdelante.TabIndex = 3;
            lblAdelante.Text = ">";
            // 
            // lblAtras
            // 
            lblAtras.AutoSize = true;
            lblAtras.BackColor = Color.Transparent;
            lblAtras.Location = new Point(41, 2);
            lblAtras.Name = "lblAtras";
            lblAtras.Size = new Size(25, 25);
            lblAtras.TabIndex = 2;
            lblAtras.Text = "<";
            // 
            // lblMes
            // 
            lblMes.AutoSize = true;
            lblMes.BackColor = Color.Transparent;
            lblMes.Location = new Point(75, 2);
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
            btnSalir.Location = new Point(7095, 696);
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
            pnlNotas.Location = new Point(6975, 297);
            pnlNotas.Name = "pnlNotas";
            pnlNotas.Size = new Size(275, 181);
            pnlNotas.TabIndex = 16;
            // 
            // lblNotasValor
            // 
            lblNotasValor.AutoSize = true;
            lblNotasValor.BackColor = Color.Transparent;
            lblNotasValor.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNotasValor.Location = new Point(3, 39);
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
            lblNotas.Location = new Point(3, 1);
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
            barraSecundaria1.Size = new Size(1856, 35);
            barraSecundaria1.TabIndex = 17;
            // 
            // barraLateral1
            // 
            barraLateral1.BackColor = Color.FromArgb(205, 213, 221);
            barraLateral1.Dock = DockStyle.Left;
            barraLateral1.Location = new Point(0, 75);
            barraLateral1.Name = "barraLateral1";
            barraLateral1.Size = new Size(231, 704);
            barraLateral1.TabIndex = 18;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 236, 239);
            ClientSize = new Size(1856, 779);
            ControlBox = false;
            Controls.Add(barraLateral1);
            Controls.Add(barraSecundaria1);
            Controls.Add(pnlNotas);
            Controls.Add(btnSalir);
            Controls.Add(rgbCalendario);
            Controls.Add(rgbMenu);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmMenuPrincipal";
            Text = "Gestionis";
            Load += FrmMenuPrincipal_Load;
            Controls.SetChildIndex(rgbMenu, 0);
            Controls.SetChildIndex(rgbCalendario, 0);
            Controls.SetChildIndex(btnSalir, 0);
            Controls.SetChildIndex(pnlNotas, 0);
            Controls.SetChildIndex(barraSecundaria1, 0);
            Controls.SetChildIndex(barraLateral1, 0);
            rgbMenu.ResumeLayout(false);
            rgbMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGastosIngresos).EndInit();
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
        private DataGridView dgvGastosIngresos;
        private Label lblTotalValor;
        private Label lblGastosValor;
        private Label lblIngresosValor;
        private Label lblTotal;
        private Label lblGastos;
        private Label lblIngresos;
        private ComboBox cmbCategoria;
        private ComboBox cmbDinero;
        private ComboBox cmbTipo;
        private TextBox txtNombre;
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
    }
}