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
            dtpHoraAlarma = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Font = new Font("Segoe UI", 14.25F);
            lblDia.Location = new Point(26, 30);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(44, 25);
            lblDia.TabIndex = 0;
            lblDia.Text = "Día:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14.25F);
            lblTitulo.Location = new Point(26, 70);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(64, 25);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Título:";
            // 
            // lblAsunto
            // 
            lblAsunto.AutoSize = true;
            lblAsunto.Font = new Font("Segoe UI", 14.25F);
            lblAsunto.Location = new Point(26, 110);
            lblAsunto.Name = "lblAsunto";
            lblAsunto.Size = new Size(75, 25);
            lblAsunto.TabIndex = 2;
            lblAsunto.Text = "Asunto:";
            // 
            // lblAlarma
            // 
            lblAlarma.AutoSize = true;
            lblAlarma.Font = new Font("Segoe UI", 14.25F);
            lblAlarma.Location = new Point(26, 237);
            lblAlarma.Name = "lblAlarma";
            lblAlarma.Size = new Size(76, 25);
            lblAlarma.TabIndex = 3;
            lblAlarma.Text = "Alarma:";
            // 
            // txtAddAsunto
            // 
            txtAddAsunto.Location = new Point(26, 143);
            txtAddAsunto.Margin = new Padding(3, 2, 3, 2);
            txtAddAsunto.Multiline = true;
            txtAddAsunto.Name = "txtAddAsunto";
            txtAddAsunto.Size = new Size(305, 68);
            txtAddAsunto.TabIndex = 4;
            // 
            // btnAnotar
            // 
            btnAnotar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnotar.BackColor = Color.FromArgb(178, 242, 187);
            btnAnotar.FlatStyle = FlatStyle.Flat;
            btnAnotar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAnotar.Location = new Point(228, 309);
            btnAnotar.Name = "btnAnotar";
            btnAnotar.Size = new Size(120, 32);
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
            btnCancelar.Location = new Point(228, 272);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 32);
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
            btnBorrar.Location = new Point(28, 308);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(120, 32);
            btnBorrar.TabIndex = 6;
            btnBorrar.Text = "Eliminar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(299, 34);
            btnColor.Margin = new Padding(3, 2, 3, 2);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(32, 22);
            btnColor.TabIndex = 2;
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // txtAddTitulo
            // 
            txtAddTitulo.BackColor = SystemColors.Window;
            txtAddTitulo.Location = new Point(102, 74);
            txtAddTitulo.Margin = new Padding(3, 2, 3, 2);
            txtAddTitulo.Name = "txtAddTitulo";
            txtAddTitulo.Size = new Size(230, 23);
            txtAddTitulo.TabIndex = 3;
            // 
            // dtpAddDia
            // 
            dtpAddDia.Format = DateTimePickerFormat.Short;
            dtpAddDia.Location = new Point(79, 34);
            dtpAddDia.Margin = new Padding(3, 2, 3, 2);
            dtpAddDia.Name = "dtpAddDia";
            dtpAddDia.Size = new Size(136, 23);
            dtpAddDia.TabIndex = 1;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ckbAlarma
            // 
            ckbAlarma.AutoSize = true;
            ckbAlarma.Location = new Point(113, 244);
            ckbAlarma.Margin = new Padding(3, 2, 3, 2);
            ckbAlarma.Name = "ckbAlarma";
            ckbAlarma.Size = new Size(15, 14);
            ckbAlarma.TabIndex = 5;
            ckbAlarma.UseVisualStyleBackColor = true;
            ckbAlarma.CheckedChanged += ckbAlarma_CheckedChanged;
            // 
            // dtpHoraAlarma
            // 
            dtpHoraAlarma.Format = DateTimePickerFormat.Time;
            dtpHoraAlarma.Location = new Point(28, 272);
            dtpHoraAlarma.Name = "dtpHoraAlarma";
            dtpHoraAlarma.ShowUpDown = true;
            dtpHoraAlarma.Size = new Size(118, 23);
            dtpHoraAlarma.TabIndex = 9;
            dtpHoraAlarma.Value = new DateTime(2024, 5, 21, 11, 6, 0, 0);
            dtpHoraAlarma.Visible = false;
            // 
            // frmAddNota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 350);
            Controls.Add(dtpHoraAlarma);
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
            Margin = new Padding(3, 2, 3, 2);
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
        private DateTimePicker dtpHoraAlarma;
    }
}