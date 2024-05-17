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
            roundGroupBox1.Controls.Add(chkDebo);
            roundGroupBox1.Controls.Add(lblTitulo);
            roundGroupBox1.Controls.Add(txtTitulo);
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
            roundGroupBox1.Location = new Point(308, 130);
            roundGroupBox1.Margin = new Padding(4, 2, 4, 2);
            roundGroupBox1.Name = "roundGroupBox1";
            roundGroupBox1.Padding = new Padding(4, 2, 4, 2);
            roundGroupBox1.Size = new Size(977, 655);
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
            chkDebo.Location = new Point(557, 250);
            chkDebo.Name = "chkDebo";
            chkDebo.Size = new Size(91, 35);
            chkDebo.TabIndex = 19;
            chkDebo.Text = "Debo";
            chkDebo.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Enabled = false;
            lblTitulo.Location = new Point(54, 195);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(201, 31);
            lblTitulo.TabIndex = 18;
            lblTitulo.Text = "Introduce el título:";
            // 
            // txtTitulo
            // 
            txtTitulo.Enabled = false;
            txtTitulo.Location = new Point(262, 193);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(214, 38);
            txtTitulo.TabIndex = 12;
            // 
            // lblDeudasTotalesValor
            // 
            lblDeudasTotalesValor.AutoSize = true;
            lblDeudasTotalesValor.BackColor = Color.Transparent;
            lblDeudasTotalesValor.Location = new Point(224, 582);
            lblDeudasTotalesValor.Margin = new Padding(4, 0, 4, 0);
            lblDeudasTotalesValor.Name = "lblDeudasTotalesValor";
            lblDeudasTotalesValor.Size = new Size(171, 31);
            lblDeudasTotalesValor.TabIndex = 11;
            lblDeudasTotalesValor.Text = "Deudas totales:";
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
            pnlInfoDeuda.Location = new Point(557, 39);
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
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(247, 248);
            cmbCategoria.Margin = new Padding(4);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(267, 39);
            cmbCategoria.TabIndex = 8;
            cmbCategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;
            // 
            // dgvGastosIngresos
            // 
            dgvGastosIngresos.AllowUserToAddRows = false;
            dgvGastosIngresos.AllowUserToDeleteRows = false;
            dgvGastosIngresos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGastosIngresos.BackgroundColor = Color.FromArgb(0, 115, 148);
            dgvGastosIngresos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGastosIngresos.GridColor = SystemColors.Window;
            dgvGastosIngresos.Location = new Point(31, 307);
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
            btnRestaurar.Location = new Point(721, 248);
            btnRestaurar.Margin = new Padding(4);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(200, 41);
            btnRestaurar.TabIndex = 4;
            btnRestaurar.Text = "Restaurar";
            btnRestaurar.UseVisualStyleBackColor = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(178, 242, 187);
            btnBuscar.Location = new Point(48, 248);
            btnBuscar.Margin = new Padding(4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(170, 41);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
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
            // roundGroupBox2
            // 
            roundGroupBox2.Controls.Add(label1);
            roundGroupBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundGroupBox2.Location = new Point(1335, 169);
            roundGroupBox2.Margin = new Padding(4, 2, 4, 2);
            roundGroupBox2.Name = "roundGroupBox2";
            roundGroupBox2.Padding = new Padding(4, 2, 4, 2);
            roundGroupBox2.Size = new Size(362, 402);
            roundGroupBox2.TabIndex = 28;
            roundGroupBox2.TabStop = false;
            roundGroupBox2.Text = "roundGroupBox2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(79, 21);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(171, 31);
            label1.TabIndex = 12;
            label1.Text = "Deudas totales:";
            // 
            // barraSecundaria1
            // 
            barraSecundaria1.BackColor = Color.FromArgb(211, 208, 242);
            barraSecundaria1.Dock = DockStyle.Top;
            barraSecundaria1.Location = new Point(0, 40);
            barraSecundaria1.Margin = new Padding(4);
            barraSecundaria1.Name = "barraSecundaria1";
            barraSecundaria1.Size = new Size(1818, 41);
            barraSecundaria1.TabIndex = 29;
            // 
            // barraLateral1
            // 
            barraLateral1.BackColor = Color.FromArgb(205, 213, 221);
            barraLateral1.Dock = DockStyle.Left;
            barraLateral1.Location = new Point(0, 81);
            barraLateral1.Margin = new Padding(4, 2, 4, 2);
            barraLateral1.Name = "barraLateral1";
            barraLateral1.Size = new Size(266, 819);
            barraLateral1.TabIndex = 30;
            // 
            // FrmGestorDeudas
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(233, 236, 239);
            ClientSize = new Size(1818, 900);
            Controls.Add(barraLateral1);
            Controls.Add(barraSecundaria1);
            Controls.Add(roundGroupBox2);
            Controls.Add(roundGroupBox1);
            Margin = new Padding(4, 2, 4, 2);
            Name = "FrmGestorDeudas";
            StartPosition = FormStartPosition.CenterScreen;
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
        private CheckBox chkDebo;
        private Label lblTitulo;
        private TextBox txtTitulo;
    }
}