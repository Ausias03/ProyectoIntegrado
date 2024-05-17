namespace Gestionis.Formularios
{
    partial class FrmEliminarDeuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEliminarDeuda));
            txtTitulo = new TextBox();
            btnEliminar = new Button();
            btnCancelar = new Button();
            rtbDescrip = new RichTextBox();
            lblFechVencimiento = new Label();
            lblFechDeuda = new Label();
            lblEstado = new Label();
            lblDescrip = new Label();
            lblCantAdeudada = new Label();
            lblTitulo = new Label();
            btnBuscar = new Button();
            lblCantidadAdeudadaValor = new Label();
            lblTipo = new Label();
            lblTipoValor = new Label();
            lblFechaDeudaValor = new Label();
            lblFechaVencimientoValor = new Label();
            roundGroupBox1 = new Herramientas.RoundGroupBox();
            btnRestablecer = new Button();
            roundGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitulo.Location = new Point(149, 30);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(292, 38);
            txtTitulo.TabIndex = 38;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(178, 242, 187);
            btnEliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(357, 708);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(146, 46);
            btnEliminar.TabIndex = 37;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(178, 242, 187);
            btnCancelar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(26, 707);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(146, 46);
            btnCancelar.TabIndex = 36;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // rtbDescrip
            // 
            rtbDescrip.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbDescrip.Location = new Point(24, 119);
            rtbDescrip.Name = "rtbDescrip";
            rtbDescrip.ReadOnly = true;
            rtbDescrip.Size = new Size(388, 141);
            rtbDescrip.TabIndex = 30;
            rtbDescrip.Text = "";
            // 
            // lblFechVencimiento
            // 
            lblFechVencimiento.AutoSize = true;
            lblFechVencimiento.BackColor = Color.Transparent;
            lblFechVencimiento.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechVencimiento.Location = new Point(18, 446);
            lblFechVencimiento.Name = "lblFechVencimiento";
            lblFechVencimiento.Size = new Size(241, 31);
            lblFechVencimiento.TabIndex = 29;
            lblFechVencimiento.Text = "Fecha de vencimiento:";
            // 
            // lblFechDeuda
            // 
            lblFechDeuda.AutoSize = true;
            lblFechDeuda.BackColor = Color.Transparent;
            lblFechDeuda.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechDeuda.Location = new Point(16, 393);
            lblFechDeuda.Name = "lblFechDeuda";
            lblFechDeuda.Size = new Size(205, 31);
            lblFechDeuda.TabIndex = 28;
            lblFechDeuda.Text = "Fecha de la deuda:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.BackColor = Color.Transparent;
            lblEstado.Font = new Font("Segoe UI", 13.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(24, 276);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(243, 31);
            lblEstado.TabIndex = 27;
            lblEstado.Text = "ESTADO DE LA DEUDA";
            // 
            // lblDescrip
            // 
            lblDescrip.AutoSize = true;
            lblDescrip.BackColor = Color.Transparent;
            lblDescrip.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescrip.Location = new Point(24, 85);
            lblDescrip.Name = "lblDescrip";
            lblDescrip.Size = new Size(139, 31);
            lblDescrip.TabIndex = 26;
            lblDescrip.Text = "Descripción:";
            // 
            // lblCantAdeudada
            // 
            lblCantAdeudada.AutoSize = true;
            lblCantAdeudada.BackColor = Color.Transparent;
            lblCantAdeudada.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantAdeudada.Location = new Point(24, 38);
            lblCantAdeudada.Name = "lblCantAdeudada";
            lblCantAdeudada.Size = new Size(221, 31);
            lblCantAdeudada.TabIndex = 25;
            lblCantAdeudada.Text = "Cantidad adeudada:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(53, 26);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(77, 31);
            lblTitulo.TabIndex = 24;
            lblTitulo.Text = "Título:";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(178, 242, 187);
            btnBuscar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(295, 92);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(146, 46);
            btnBuscar.TabIndex = 43;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblCantidadAdeudadaValor
            // 
            lblCantidadAdeudadaValor.AutoSize = true;
            lblCantidadAdeudadaValor.BackColor = Color.Transparent;
            lblCantidadAdeudadaValor.Font = new Font("Segoe UI", 13.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblCantidadAdeudadaValor.Location = new Point(238, 38);
            lblCantidadAdeudadaValor.Name = "lblCantidadAdeudadaValor";
            lblCantidadAdeudadaValor.Size = new Size(221, 31);
            lblCantidadAdeudadaValor.TabIndex = 44;
            lblCantidadAdeudadaValor.Text = "Cantidad adeudada:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.BackColor = Color.Transparent;
            lblTipo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipo.Location = new Point(34, 332);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(64, 31);
            lblTipo.TabIndex = 45;
            lblTipo.Text = "Tipo:";
            // 
            // lblTipoValor
            // 
            lblTipoValor.AutoSize = true;
            lblTipoValor.BackColor = Color.Transparent;
            lblTipoValor.Font = new Font("Segoe UI", 13.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTipoValor.Location = new Point(103, 332);
            lblTipoValor.Name = "lblTipoValor";
            lblTipoValor.Size = new Size(64, 31);
            lblTipoValor.TabIndex = 46;
            lblTipoValor.Text = "Tipo:";
            // 
            // lblFechaDeudaValor
            // 
            lblFechaDeudaValor.AutoSize = true;
            lblFechaDeudaValor.BackColor = Color.Transparent;
            lblFechaDeudaValor.Font = new Font("Segoe UI", 13.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblFechaDeudaValor.Location = new Point(216, 393);
            lblFechaDeudaValor.Name = "lblFechaDeudaValor";
            lblFechaDeudaValor.Size = new Size(205, 31);
            lblFechaDeudaValor.TabIndex = 47;
            lblFechaDeudaValor.Text = "Fecha de la deuda:";
            // 
            // lblFechaVencimientoValor
            // 
            lblFechaVencimientoValor.AutoSize = true;
            lblFechaVencimientoValor.BackColor = Color.Transparent;
            lblFechaVencimientoValor.Font = new Font("Segoe UI", 13.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblFechaVencimientoValor.Location = new Point(258, 446);
            lblFechaVencimientoValor.Name = "lblFechaVencimientoValor";
            lblFechaVencimientoValor.Size = new Size(205, 31);
            lblFechaVencimientoValor.TabIndex = 48;
            lblFechaVencimientoValor.Text = "Fecha de la deuda:";
            // 
            // roundGroupBox1
            // 
            roundGroupBox1.Controls.Add(lblCantAdeudada);
            roundGroupBox1.Controls.Add(lblFechaVencimientoValor);
            roundGroupBox1.Controls.Add(lblDescrip);
            roundGroupBox1.Controls.Add(lblFechaDeudaValor);
            roundGroupBox1.Controls.Add(lblEstado);
            roundGroupBox1.Controls.Add(lblTipoValor);
            roundGroupBox1.Controls.Add(lblFechDeuda);
            roundGroupBox1.Controls.Add(lblTipo);
            roundGroupBox1.Controls.Add(lblFechVencimiento);
            roundGroupBox1.Controls.Add(lblCantidadAdeudadaValor);
            roundGroupBox1.Controls.Add(rtbDescrip);
            roundGroupBox1.Location = new Point(31, 163);
            roundGroupBox1.Name = "roundGroupBox1";
            roundGroupBox1.Size = new Size(472, 516);
            roundGroupBox1.TabIndex = 49;
            roundGroupBox1.TabStop = false;
            roundGroupBox1.Text = "roundGroupBox1";
            // 
            // btnRestablecer
            // 
            btnRestablecer.BackColor = Color.FromArgb(178, 242, 187);
            btnRestablecer.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRestablecer.Location = new Point(90, 92);
            btnRestablecer.Name = "btnRestablecer";
            btnRestablecer.Size = new Size(146, 46);
            btnRestablecer.TabIndex = 50;
            btnRestablecer.Text = "Restablecer";
            btnRestablecer.UseVisualStyleBackColor = false;
            btnRestablecer.Click += btnRestablecer_Click;
            // 
            // FrmEliminarDeuda
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 766);
            Controls.Add(btnRestablecer);
            Controls.Add(roundGroupBox1);
            Controls.Add(btnBuscar);
            Controls.Add(txtTitulo);
            Controls.Add(btnEliminar);
            Controls.Add(btnCancelar);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "FrmEliminarDeuda";
            Load += FrmEliminarDeuda_Load;
            roundGroupBox1.ResumeLayout(false);
            roundGroupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkRecordatorio;
        private DateTimePicker dtpVencimiento;
        private DateTimePicker dtpDeuda;
        private TextBox txtTitulo;
        private Button btnEliminar;
        private Button btnCancelar;
        private Label label2;
        private RichTextBox rtbDescrip;
        private Label lblFechVencimiento;
        private Label lblFechDeuda;
        private Label lblEstado;
        private Label lblDescrip;
        private Label lblCantAdeudada;
        private Label lblTitulo;
        private Button btnBuscar;
        private Label lblCantidadAdeudadaValor;
        private Label lblTipo;
        private Label lblTipoValor;
        private Label lblFechaDeudaValor;
        private Label lblFechaVencimientoValor;
        private Herramientas.RoundGroupBox roundGroupBox1;
        private Button btnRestablecer;
    }
}