namespace Gestionis
{
    partial class frmAddNota
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
            lblDia = new Label();
            lblTitulo = new Label();
            lblAsunto = new Label();
            lblAlarma = new Label();
            txtAddAsunto = new TextBox();
            btnAnotar = new Button();
            btnCancelar = new Button();
            btnBorrar = new Button();
            colorDialog1 = new ColorDialog();
            btnColor = new Button();
            txtAddTitulo = new TextBox();
            dtpAddDia = new DateTimePicker();
            errorProvider1 = new ErrorProvider(components);
            ckbAlarma = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Font = new Font("Segoe UI", 14.25F);
            lblDia.Location = new Point(30, 40);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(54, 32);
            lblDia.TabIndex = 0;
            lblDia.Text = "Día:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14.25F);
            lblTitulo.Location = new Point(30, 93);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(80, 32);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Título:";
            // 
            // lblAsunto
            // 
            lblAsunto.AutoSize = true;
            lblAsunto.Font = new Font("Segoe UI", 14.25F);
            lblAsunto.Location = new Point(30, 146);
            lblAsunto.Name = "lblAsunto";
            lblAsunto.Size = new Size(94, 32);
            lblAsunto.TabIndex = 2;
            lblAsunto.Text = "Asunto:";
            // 
            // lblAlarma
            // 
            lblAlarma.AutoSize = true;
            lblAlarma.Font = new Font("Segoe UI", 14.25F);
            lblAlarma.Location = new Point(30, 316);
            lblAlarma.Name = "lblAlarma";
            lblAlarma.Size = new Size(93, 32);
            lblAlarma.TabIndex = 3;
            lblAlarma.Text = "Alarma:";
            // 
            // txtAddAsunto
            // 
            txtAddAsunto.Location = new Point(30, 191);
            txtAddAsunto.Multiline = true;
            txtAddAsunto.Name = "txtAddAsunto";
            txtAddAsunto.Size = new Size(348, 90);
            txtAddAsunto.TabIndex = 4;
            // 
            // btnAnotar
            // 
            btnAnotar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnotar.BackColor = Color.FromArgb(178, 242, 187);
            btnAnotar.FlatStyle = FlatStyle.Flat;
            btnAnotar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAnotar.Location = new Point(261, 412);
            btnAnotar.Margin = new Padding(3, 4, 3, 4);
            btnAnotar.Name = "btnAnotar";
            btnAnotar.Size = new Size(137, 42);
            btnAnotar.TabIndex = 8;
            btnAnotar.Text = "Anotar";
            btnAnotar.UseVisualStyleBackColor = false;
            btnAnotar.Click += btnAnotar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.FromArgb(178, 242, 187);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(261, 362);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(137, 42);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBorrar.BackColor = Color.FromArgb(178, 242, 187);
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBorrar.Location = new Point(32, 411);
            btnBorrar.Margin = new Padding(3, 4, 3, 4);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(137, 42);
            btnBorrar.TabIndex = 6;
            btnBorrar.Text = "Eliminar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(342, 46);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(36, 29);
            btnColor.TabIndex = 2;
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // txtAddTitulo
            // 
            txtAddTitulo.BackColor = SystemColors.Window;
            txtAddTitulo.Location = new Point(116, 98);
            txtAddTitulo.Name = "txtAddTitulo";
            txtAddTitulo.Size = new Size(262, 27);
            txtAddTitulo.TabIndex = 3;
            // 
            // dtpAddDia
            // 
            dtpAddDia.Format = DateTimePickerFormat.Short;
            dtpAddDia.Location = new Point(90, 45);
            dtpAddDia.Name = "dtpAddDia";
            dtpAddDia.Size = new Size(155, 27);
            dtpAddDia.TabIndex = 1;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ckbAlarma
            // 
            ckbAlarma.AutoSize = true;
            ckbAlarma.Location = new Point(129, 325);
            ckbAlarma.Name = "ckbAlarma";
            ckbAlarma.Size = new Size(18, 17);
            ckbAlarma.TabIndex = 5;
            ckbAlarma.UseVisualStyleBackColor = true;
            // 
            // frmAddNota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 467);
            Controls.Add(ckbAlarma);
            Controls.Add(dtpAddDia);
            Controls.Add(txtAddTitulo);
            Controls.Add(btnColor);
            Controls.Add(btnBorrar);
            Controls.Add(btnCancelar);
            Controls.Add(btnAnotar);
            Controls.Add(txtAddAsunto);
            Controls.Add(lblAlarma);
            Controls.Add(lblAsunto);
            Controls.Add(lblTitulo);
            Controls.Add(lblDia);
            Name = "frmAddNota";
            Text = "AddNota";
            Load += frmAddNota_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDia;
        private Label lblTitulo;
        private Label lblAsunto;
        private Label lblAlarma;
        private TextBox txtAddAsunto;
        private Button btnAnotar;
        private Button btnCancelar;
        private Button btnBorrar;
        private ColorDialog colorDialog1;
        private Button btnColor;
        private TextBox txtAddTitulo;
        private DateTimePicker dtpAddDia;
        private ErrorProvider errorProvider1;
        private CheckBox ckbAlarma;
    }
}