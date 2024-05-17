namespace Gestionis.Formularios
{
    partial class FrmAnyadirDeuda
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnyadirDeuda));
            lblTitulo = new Label();
            lblCantAdeudada = new Label();
            lblDescrip = new Label();
            lblEstado = new Label();
            lblFechDeuda = new Label();
            lblFechVencimiento = new Label();
            rtbDescrip = new RichTextBox();
            rdbDeben = new RadioButton();
            rdbDebo = new RadioButton();
            lblDeben = new Label();
            label1 = new Label();
            label2 = new Label();
            btnCancelar = new Button();
            btnCrear = new Button();
            txtTitulo = new TextBox();
            nudCantidadAdeudada = new NumericUpDown();
            dtpDeuda = new DateTimePicker();
            dtpVencimiento = new DateTimePicker();
            chkRecordatorio = new CheckBox();
            lblEuro = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)nudCantidadAdeudada).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(44, 27);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(64, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Título:";
            // 
            // lblCantAdeudada
            // 
            lblCantAdeudada.AutoSize = true;
            lblCantAdeudada.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantAdeudada.Location = new Point(44, 68);
            lblCantAdeudada.Name = "lblCantAdeudada";
            lblCantAdeudada.Size = new Size(181, 25);
            lblCantAdeudada.TabIndex = 1;
            lblCantAdeudada.Text = "Cantidad adeudada:";
            // 
            // lblDescrip
            // 
            lblDescrip.AutoSize = true;
            lblDescrip.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescrip.Location = new Point(44, 104);
            lblDescrip.Name = "lblDescrip";
            lblDescrip.Size = new Size(115, 25);
            lblDescrip.TabIndex = 2;
            lblDescrip.Text = "Descripción:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 13.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(44, 247);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(201, 25);
            lblEstado.TabIndex = 3;
            lblEstado.Text = "ESTADO DE LA DEUDA";
            // 
            // lblFechDeuda
            // 
            lblFechDeuda.AutoSize = true;
            lblFechDeuda.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechDeuda.Location = new Point(38, 341);
            lblFechDeuda.Name = "lblFechDeuda";
            lblFechDeuda.Size = new Size(169, 25);
            lblFechDeuda.TabIndex = 4;
            lblFechDeuda.Text = "Fecha de la deuda:";
            // 
            // lblFechVencimiento
            // 
            lblFechVencimiento.AutoSize = true;
            lblFechVencimiento.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechVencimiento.Location = new Point(38, 374);
            lblFechVencimiento.Name = "lblFechVencimiento";
            lblFechVencimiento.Size = new Size(199, 25);
            lblFechVencimiento.TabIndex = 5;
            lblFechVencimiento.Text = "Fecha de vencimiento:";
            // 
            // rtbDescrip
            // 
            rtbDescrip.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbDescrip.Location = new Point(44, 129);
            rtbDescrip.Margin = new Padding(3, 2, 3, 2);
            rtbDescrip.Name = "rtbDescrip";
            rtbDescrip.Size = new Size(340, 107);
            rtbDescrip.TabIndex = 2;
            rtbDescrip.Text = "";
            // 
            // rdbDeben
            // 
            rdbDeben.AutoSize = true;
            rdbDeben.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbDeben.Location = new Point(148, 293);
            rdbDeben.Margin = new Padding(3, 2, 3, 2);
            rdbDeben.Name = "rdbDeben";
            rdbDeben.Size = new Size(14, 13);
            rdbDeben.TabIndex = 3;
            rdbDeben.TabStop = true;
            rdbDeben.UseVisualStyleBackColor = true;
            // 
            // rdbDebo
            // 
            rdbDebo.AutoSize = true;
            rdbDebo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbDebo.Location = new Point(261, 293);
            rdbDebo.Margin = new Padding(3, 2, 3, 2);
            rdbDebo.Name = "rdbDebo";
            rdbDebo.Size = new Size(14, 13);
            rdbDebo.TabIndex = 4;
            rdbDebo.TabStop = true;
            rdbDebo.UseVisualStyleBackColor = true;
            // 
            // lblDeben
            // 
            lblDeben.AutoSize = true;
            lblDeben.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDeben.Location = new Point(44, 286);
            lblDeben.Name = "lblDeben";
            lblDeben.Size = new Size(97, 25);
            lblDeben.TabIndex = 10;
            lblDeben.Text = "Me deben";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(200, 286);
            label1.Name = "label1";
            label1.Size = new Size(57, 25);
            label1.TabIndex = 11;
            label1.Text = "Debo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 404);
            label2.Name = "label2";
            label2.Size = new Size(178, 25);
            label2.TabIndex = 12;
            label2.Text = "Añadir recordatorio";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(178, 242, 187);
            btnCancelar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(52, 455);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(128, 34);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.FromArgb(178, 242, 187);
            btnCrear.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCrear.Location = new Point(261, 455);
            btnCrear.Margin = new Padding(3, 2, 3, 2);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(128, 34);
            btnCrear.TabIndex = 8;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitulo.Location = new Point(128, 30);
            txtTitulo.Margin = new Padding(3, 2, 3, 2);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(256, 32);
            txtTitulo.TabIndex = 0;
            // 
            // nudCantidadAdeudada
            // 
            nudCantidadAdeudada.DecimalPlaces = 2;
            nudCantidadAdeudada.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudCantidadAdeudada.Location = new Point(225, 68);
            nudCantidadAdeudada.Margin = new Padding(3, 2, 3, 2);
            nudCantidadAdeudada.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudCantidadAdeudada.Name = "nudCantidadAdeudada";
            nudCantidadAdeudada.Size = new Size(131, 32);
            nudCantidadAdeudada.TabIndex = 1;
            nudCantidadAdeudada.TextAlign = HorizontalAlignment.Right;
            // 
            // dtpDeuda
            // 
            dtpDeuda.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDeuda.Format = DateTimePickerFormat.Short;
            dtpDeuda.Location = new Point(252, 341);
            dtpDeuda.Margin = new Padding(3, 2, 3, 2);
            dtpDeuda.MaxDate = new DateTime(2200, 12, 31, 0, 0, 0, 0);
            dtpDeuda.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpDeuda.Name = "dtpDeuda";
            dtpDeuda.Size = new Size(141, 32);
            dtpDeuda.TabIndex = 5;
            // 
            // dtpVencimiento
            // 
            dtpVencimiento.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpVencimiento.Format = DateTimePickerFormat.Short;
            dtpVencimiento.Location = new Point(252, 374);
            dtpVencimiento.Margin = new Padding(3, 2, 3, 2);
            dtpVencimiento.MaxDate = new DateTime(2200, 12, 31, 0, 0, 0, 0);
            dtpVencimiento.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpVencimiento.Name = "dtpVencimiento";
            dtpVencimiento.Size = new Size(141, 32);
            dtpVencimiento.TabIndex = 5;
            // 
            // chkRecordatorio
            // 
            chkRecordatorio.AutoSize = true;
            chkRecordatorio.Location = new Point(253, 412);
            chkRecordatorio.Margin = new Padding(3, 2, 3, 2);
            chkRecordatorio.Name = "chkRecordatorio";
            chkRecordatorio.Size = new Size(15, 14);
            chkRecordatorio.TabIndex = 7;
            chkRecordatorio.UseVisualStyleBackColor = true;
            // 
            // lblEuro
            // 
            lblEuro.AutoSize = true;
            lblEuro.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEuro.Location = new Point(357, 67);
            lblEuro.Name = "lblEuro";
            lblEuro.Size = new Size(24, 30);
            lblEuro.TabIndex = 14;
            lblEuro.Text = "€";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmAnyadirDeuda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 236, 239);
            ClientSize = new Size(439, 508);
            Controls.Add(lblEuro);
            Controls.Add(chkRecordatorio);
            Controls.Add(dtpVencimiento);
            Controls.Add(dtpDeuda);
            Controls.Add(nudCantidadAdeudada);
            Controls.Add(txtTitulo);
            Controls.Add(btnCrear);
            Controls.Add(btnCancelar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblDeben);
            Controls.Add(rdbDebo);
            Controls.Add(rdbDeben);
            Controls.Add(rtbDescrip);
            Controls.Add(lblFechVencimiento);
            Controls.Add(lblFechDeuda);
            Controls.Add(lblEstado);
            Controls.Add(lblDescrip);
            Controls.Add(lblCantAdeudada);
            Controls.Add(lblTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmAnyadirDeuda";
            Load += FrmAnyadirDeuda_Load;
            ((System.ComponentModel.ISupportInitialize)nudCantidadAdeudada).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblCantAdeudada;
        private Label lblDescrip;
        private Label lblEstado;
        private Label lblFechDeuda;
        private Label lblFechVencimiento;
        private RichTextBox rtbDescrip;
        private RadioButton rdbDeben;
        private RadioButton rdbDebo;
        private Label lblDeben;
        private Label label1;
        private Label label2;
        private Button btnCancelar;
        private Button btnCrear;
        private TextBox txtTitulo;
        private NumericUpDown nudCantidadAdeudada;
        private DateTimePicker dtpDeuda;
        private DateTimePicker dtpVencimiento;
        private CheckBox chkRecordatorio;
        private Label lblEuro;
        private ErrorProvider errorProvider1;
    }
}