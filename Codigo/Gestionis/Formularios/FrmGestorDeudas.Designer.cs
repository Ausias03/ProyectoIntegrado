﻿using Gestionis.Herramientas;

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
            label1 = new Label();
            barraSecundaria1 = new BarraSecundaria();
            barraLateral1 = new BarraLateral();
            pnlInfoDeuda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGastosIngresos).BeginInit();
            SuspendLayout();
            // 
            // lblDeudasTotalesValor
            // 
            lblDeudasTotalesValor.AutoSize = true;
            lblDeudasTotalesValor.BackColor = Color.Transparent;
            lblDeudasTotalesValor.Location = new Point(220, 570);
            lblDeudasTotalesValor.Name = "lblDeudasTotalesValor";
            lblDeudasTotalesValor.Size = new Size(171, 31);
            lblDeudasTotalesValor.TabIndex = 11;
            lblDeudasTotalesValor.Text = "Deudas totales:";
            // 
            // lblDeudasTotales
            // 
            lblDeudasTotales.AutoSize = true;
            lblDeudasTotales.BackColor = Color.Transparent;
            lblDeudasTotales.Location = new Point(57, 570);
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
            pnlInfoDeuda.Location = new Point(313, 41);
            pnlInfoDeuda.Name = "pnlInfoDeuda";
            pnlInfoDeuda.Size = new Size(334, 150);
            pnlInfoDeuda.TabIndex = 9;
            // 
            // lblTipoValor
            // 
            lblTipoValor.AutoSize = true;
            lblTipoValor.BackColor = Color.Transparent;
            lblTipoValor.Location = new Point(203, 98);
            lblTipoValor.Name = "lblTipoValor";
            lblTipoValor.Size = new Size(42, 20);
            lblTipoValor.TabIndex = 17;
            lblTipoValor.Text = "Tipo:";
            // 
            // lblFechaLimiteValor
            // 
            lblFechaLimiteValor.AutoSize = true;
            lblFechaLimiteValor.BackColor = Color.Transparent;
            lblFechaLimiteValor.Location = new Point(203, 51);
            lblFechaLimiteValor.Name = "lblFechaLimiteValor";
            lblFechaLimiteValor.Size = new Size(42, 20);
            lblFechaLimiteValor.TabIndex = 16;
            lblFechaLimiteValor.Text = "Tipo:";
            // 
            // lblProximaDeudaValor
            // 
            lblProximaDeudaValor.AutoSize = true;
            lblProximaDeudaValor.BackColor = Color.Transparent;
            lblProximaDeudaValor.Location = new Point(203, 7);
            lblProximaDeudaValor.Name = "lblProximaDeudaValor";
            lblProximaDeudaValor.Size = new Size(42, 20);
            lblProximaDeudaValor.TabIndex = 15;
            lblProximaDeudaValor.Text = "Tipo:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.BackColor = Color.Transparent;
            lblTipo.Location = new Point(-1, 96);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(42, 20);
            lblTipo.TabIndex = 14;
            lblTipo.Text = "Tipo:";
            // 
            // lblFechaLimite
            // 
            lblFechaLimite.AutoSize = true;
            lblFechaLimite.BackColor = Color.Transparent;
            lblFechaLimite.Location = new Point(-1, 51);
            lblFechaLimite.Name = "lblFechaLimite";
            lblFechaLimite.Size = new Size(92, 20);
            lblFechaLimite.TabIndex = 13;
            lblFechaLimite.Text = "Fecha límite:";
            // 
            // lblProximaDeuda
            // 
            lblProximaDeuda.AutoSize = true;
            lblProximaDeuda.BackColor = Color.Transparent;
            lblProximaDeuda.Location = new Point(-1, 7);
            lblProximaDeuda.Name = "lblProximaDeuda";
            lblProximaDeuda.Size = new Size(112, 20);
            lblProximaDeuda.TabIndex = 12;
            lblProximaDeuda.Text = "Próxima deuda:";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(224, 227);
            cmbCategoria.Margin = new Padding(3, 4, 3, 4);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(192, 28);
            cmbCategoria.TabIndex = 8;
            // 
            // dgvGastosIngresos
            // 
            dgvGastosIngresos.BackgroundColor = SystemColors.ControlLightLight;
            dgvGastosIngresos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGastosIngresos.GridColor = SystemColors.Window;
            dgvGastosIngresos.Location = new Point(48, 287);
            dgvGastosIngresos.Margin = new Padding(3, 4, 3, 4);
            dgvGastosIngresos.Name = "dgvGastosIngresos";
            dgvGastosIngresos.RowHeadersWidth = 51;
            dgvGastosIngresos.Size = new Size(599, 279);
            dgvGastosIngresos.TabIndex = 7;
            // 
            // btnRestaurar
            // 
            btnRestaurar.BackColor = Color.FromArgb(178, 242, 187);
            btnRestaurar.Location = new Point(440, 223);
            btnRestaurar.Margin = new Padding(3, 4, 3, 4);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(183, 44);
            btnRestaurar.TabIndex = 4;
            btnRestaurar.Text = "Restaurar";
            btnRestaurar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(178, 242, 187);
            btnBuscar.Location = new Point(48, 223);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(155, 44);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnEliminarDeuda
            // 
            btnEliminarDeuda.BackColor = Color.FromArgb(178, 242, 187);
            btnEliminarDeuda.Location = new Point(70, 106);
            btnEliminarDeuda.Margin = new Padding(3, 4, 3, 4);
            btnEliminarDeuda.Name = "btnEliminarDeuda";
            btnEliminarDeuda.Size = new Size(183, 47);
            btnEliminarDeuda.TabIndex = 2;
            btnEliminarDeuda.Text = "Eliminar Deuda";
            btnEliminarDeuda.UseVisualStyleBackColor = false;
            // 
            // btnAnyadirDeuda
            // 
            btnAnyadirDeuda.BackColor = Color.FromArgb(178, 242, 187);
            btnAnyadirDeuda.Location = new Point(70, 41);
            btnAnyadirDeuda.Margin = new Padding(3, 4, 3, 4);
            btnAnyadirDeuda.Name = "btnAnyadirDeuda";
            btnAnyadirDeuda.Size = new Size(183, 47);
            btnAnyadirDeuda.TabIndex = 1;
            btnAnyadirDeuda.Text = "Añadir deuda";
            btnAnyadirDeuda.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(72, 23);
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
            barraSecundaria1.Margin = new Padding(3, 4, 3, 4);
            barraSecundaria1.Name = "barraSecundaria1";
            barraSecundaria1.Size = new Size(1818, 47);
            barraSecundaria1.TabIndex = 1;
            // 
            // barraLateral1
            // 
            barraLateral1.BackColor = Color.FromArgb(205, 213, 221);
            barraLateral1.Dock = DockStyle.Left;
            barraLateral1.Location = new Point(0, 87);
            barraLateral1.Margin = new Padding(3, 4, 3, 4);
            barraLateral1.Name = "barraLateral1";
            barraLateral1.Size = new Size(264, 1015);
            barraLateral1.TabIndex = 2;
            // 
            // FrmGestorDeudas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 236, 239);
            ClientSize = new Size(1818, 1102);
            Controls.Add(barraLateral1);
            Controls.Add(barraSecundaria1);
            Name = "FrmGestorDeudas";
            Text = "FrmGestorDeudas";
            Load += FrmGestorDeudas_Load;
            Controls.SetChildIndex(barraSecundaria1, 0);
            Controls.SetChildIndex(barraLateral1, 0);
            pnlInfoDeuda.ResumeLayout(false);
            pnlInfoDeuda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGastosIngresos).EndInit();
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