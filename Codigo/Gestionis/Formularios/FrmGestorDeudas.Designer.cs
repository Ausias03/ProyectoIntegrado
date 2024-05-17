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
            lblDeudasTotalesValor = new Label();
            lblDeudasTotales = new Label();
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
            btnBuscar = new Button();
            btnEliminarDeuda = new Button();
            btnAnyadirDeuda = new Button();
            roundGroupBox2 = new RoundGroupBox();
            label1 = new Label();
            barraSecundaria1 = new BarraSecundaria();
            barraLateral1 = new BarraLateral();
            roundGroupBox1.SuspendLayout();
            pnlInfoDeuda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGastosIngresos).BeginInit();
            roundGroupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // roundGroupBox1
            // 
            roundGroupBox1.Controls.Add(lblDeudasTotalesValor);
            roundGroupBox1.Controls.Add(lblDeudasTotales);
            roundGroupBox1.Controls.Add(pnlInfoDeuda);
            roundGroupBox1.Controls.Add(cmbCategoria);
            roundGroupBox1.Controls.Add(dgvGastosIngresos);
            roundGroupBox1.Controls.Add(btnRestaurar);
            roundGroupBox1.Controls.Add(btnBuscar);
            roundGroupBox1.Controls.Add(btnEliminarDeuda);
            roundGroupBox1.Controls.Add(btnAnyadirDeuda);
            roundGroupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundGroupBox1.Location = new Point(313, 104);
            roundGroupBox1.Margin = new Padding(3, 2, 3, 2);
            roundGroupBox1.Name = "roundGroupBox1";
            roundGroupBox1.Padding = new Padding(3, 2, 3, 2);
            roundGroupBox1.Size = new Size(609, 464);
            roundGroupBox1.TabIndex = 0;
            roundGroupBox1.TabStop = false;
            roundGroupBox1.Text = "rgpDeudas";
            // 
            // lblDeudasTotalesValor
            // 
            lblDeudasTotalesValor.AutoSize = true;
            lblDeudasTotalesValor.BackColor = Color.Transparent;
            lblDeudasTotalesValor.Location = new Point(192, 428);
            lblDeudasTotalesValor.Name = "lblDeudasTotalesValor";
            lblDeudasTotalesValor.Size = new Size(140, 25);
            lblDeudasTotalesValor.TabIndex = 11;
            lblDeudasTotalesValor.Text = "Deudas totales:";
            // 
            // lblDeudasTotales
            // 
            lblDeudasTotales.AutoSize = true;
            lblDeudasTotales.BackColor = Color.Transparent;
            lblDeudasTotales.Location = new Point(50, 428);
            lblDeudasTotales.Name = "lblDeudasTotales";
            lblDeudasTotales.Size = new Size(140, 25);
            lblDeudasTotales.TabIndex = 10;
            lblDeudasTotales.Text = "Deudas totales:";
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
            pnlInfoDeuda.Location = new Point(274, 31);
            pnlInfoDeuda.Margin = new Padding(3, 2, 3, 2);
            pnlInfoDeuda.Name = "pnlInfoDeuda";
            pnlInfoDeuda.Size = new Size(292, 113);
            pnlInfoDeuda.TabIndex = 9;
            // 
            // lblTipoValor
            // 
            lblTipoValor.AutoSize = true;
            lblTipoValor.BackColor = Color.Transparent;
            lblTipoValor.Location = new Point(178, 74);
            lblTipoValor.Name = "lblTipoValor";
            lblTipoValor.Size = new Size(53, 25);
            lblTipoValor.TabIndex = 17;
            lblTipoValor.Text = "Tipo:";
            // 
            // lblFechaLimiteValor
            // 
            lblFechaLimiteValor.AutoSize = true;
            lblFechaLimiteValor.BackColor = Color.Transparent;
            lblFechaLimiteValor.Location = new Point(178, 38);
            lblFechaLimiteValor.Name = "lblFechaLimiteValor";
            lblFechaLimiteValor.Size = new Size(53, 25);
            lblFechaLimiteValor.TabIndex = 16;
            lblFechaLimiteValor.Text = "Tipo:";
            // 
            // lblProximaDeudaValor
            // 
            lblProximaDeudaValor.AutoSize = true;
            lblProximaDeudaValor.BackColor = Color.Transparent;
            lblProximaDeudaValor.Location = new Point(178, 5);
            lblProximaDeudaValor.Name = "lblProximaDeudaValor";
            lblProximaDeudaValor.Size = new Size(53, 25);
            lblProximaDeudaValor.TabIndex = 15;
            lblProximaDeudaValor.Text = "Tipo:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.BackColor = Color.Transparent;
            lblTipo.Location = new Point(-1, 72);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(53, 25);
            lblTipo.TabIndex = 14;
            lblTipo.Text = "Tipo:";
            // 
            // lblFechaLimite
            // 
            lblFechaLimite.AutoSize = true;
            lblFechaLimite.BackColor = Color.Transparent;
            lblFechaLimite.Location = new Point(-1, 38);
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
            cmbCategoria.Location = new Point(196, 170);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(168, 33);
            cmbCategoria.TabIndex = 8;
            // 
            // dgvGastosIngresos
            // 
            dgvGastosIngresos.BackgroundColor = SystemColors.ControlLightLight;
            dgvGastosIngresos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGastosIngresos.GridColor = SystemColors.Window;
            dgvGastosIngresos.Location = new Point(42, 215);
            dgvGastosIngresos.Name = "dgvGastosIngresos";
            dgvGastosIngresos.RowHeadersWidth = 51;
            dgvGastosIngresos.Size = new Size(524, 209);
            dgvGastosIngresos.TabIndex = 7;
            // 
            // btnRestaurar
            // 
            btnRestaurar.BackColor = Color.FromArgb(178, 242, 187);
            btnRestaurar.Location = new Point(385, 167);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(160, 33);
            btnRestaurar.TabIndex = 4;
            btnRestaurar.Text = "Restaurar";
            btnRestaurar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(178, 242, 187);
            btnBuscar.Location = new Point(42, 167);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(136, 33);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
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
            // roundGroupBox2
            // 
            roundGroupBox2.Controls.Add(label1);
            roundGroupBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundGroupBox2.Location = new Point(1068, 135);
            roundGroupBox2.Margin = new Padding(3, 2, 3, 2);
            roundGroupBox2.Name = "roundGroupBox2";
            roundGroupBox2.Padding = new Padding(3, 2, 3, 2);
            roundGroupBox2.Size = new Size(290, 322);
            roundGroupBox2.TabIndex = 28;
            roundGroupBox2.TabStop = false;
            roundGroupBox2.Text = "roundGroupBox2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(63, 17);
            label1.Name = "label1";
            label1.Size = new Size(140, 25);
            label1.TabIndex = 12;
            label1.Text = "Deudas totales:";
            // 
            // barraSecundaria1
            // 
            barraSecundaria1.BackColor = Color.FromArgb(211, 208, 242);
            barraSecundaria1.Dock = DockStyle.Top;
            barraSecundaria1.Location = new Point(0, 40);
            barraSecundaria1.Name = "barraSecundaria1";
            barraSecundaria1.Size = new Size(1839, 33);
            barraSecundaria1.TabIndex = 29;
            // 
            // barraLateral1
            // 
            barraLateral1.BackColor = Color.FromArgb(205, 213, 221);
            barraLateral1.Dock = DockStyle.Left;
            barraLateral1.Location = new Point(0, 73);
            barraLateral1.Margin = new Padding(3, 2, 3, 2);
            barraLateral1.Name = "barraLateral1";
            barraLateral1.Size = new Size(253, 827);
            barraLateral1.TabIndex = 30;
            // 
            // FrmGestorDeudas
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(233, 236, 239);
            ClientSize = new Size(1839, 900);
            Controls.Add(barraLateral1);
            Controls.Add(barraSecundaria1);
            Controls.Add(roundGroupBox2);
            Controls.Add(roundGroupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmGestorDeudas";
            Text = "FrmGestorDeudas";
            Load += FrmGestorDeudas_Load;
            Controls.SetChildIndex(roundGroupBox1, 0);
            Controls.SetChildIndex(roundGroupBox2, 0);
            Controls.SetChildIndex(barraSecundaria1, 0);
            Controls.SetChildIndex(barraLateral1, 0);
            roundGroupBox1.ResumeLayout(false);
            roundGroupBox1.PerformLayout();
            pnlInfoDeuda.ResumeLayout(false);
            pnlInfoDeuda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGastosIngresos).EndInit();
            roundGroupBox2.ResumeLayout(false);
            roundGroupBox2.PerformLayout();
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
        private RoundGroupBox roundGroupBox2;
        private Label label1;
        private BarraSecundaria barraSecundaria1;
        private BarraLateral barraLateral1;
    }
}