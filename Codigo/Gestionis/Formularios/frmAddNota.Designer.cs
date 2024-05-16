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
            lblDia = new Label();
            lblTitulo = new Label();
            lblAsunto = new Label();
            lblAlarma = new Label();
            lblLinea = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            rdbAlarma = new RadioButton();
            btnSalir = new Button();
            button1 = new Button();
            button2 = new Button();
            colorDialog1 = new ColorDialog();
            btnColor = new Button();
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
            // lblLinea
            // 
            lblLinea.AutoSize = true;
            lblLinea.Font = new Font("Segoe UI", 14.25F);
            lblLinea.Location = new Point(90, 40);
            lblLinea.Name = "lblLinea";
            lblLinea.Size = new Size(164, 32);
            lblLinea.TabIndex = 4;
            lblLinea.Text = "_______________";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F);
            label5.Location = new Point(116, 93);
            label5.Name = "label5";
            label5.Size = new Size(164, 32);
            label5.TabIndex = 5;
            label5.Text = "_______________";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 191);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(348, 90);
            textBox1.TabIndex = 6;
            // 
            // rdbAlarma
            // 
            rdbAlarma.AutoSize = true;
            rdbAlarma.Location = new Point(129, 328);
            rdbAlarma.Name = "rdbAlarma";
            rdbAlarma.Size = new Size(17, 16);
            rdbAlarma.TabIndex = 7;
            rdbAlarma.TabStop = true;
            rdbAlarma.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.BackColor = Color.FromArgb(178, 242, 187);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(261, 412);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(137, 42);
            btnSalir.TabIndex = 17;
            btnSalir.Text = "Anotar";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(178, 242, 187);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(261, 362);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(137, 42);
            button1.TabIndex = 18;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(178, 242, 187);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(32, 411);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(137, 42);
            button2.TabIndex = 19;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(342, 46);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(36, 29);
            btnColor.TabIndex = 20;
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // frmAddNota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 467);
            Controls.Add(btnColor);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnSalir);
            Controls.Add(rdbAlarma);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(lblLinea);
            Controls.Add(lblAlarma);
            Controls.Add(lblAsunto);
            Controls.Add(lblTitulo);
            Controls.Add(lblDia);
            Name = "frmAddNota";
            Text = "AddNota";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDia;
        private Label lblTitulo;
        private Label lblAsunto;
        private Label lblAlarma;
        private Label lblLinea;
        private Label label5;
        private TextBox textBox1;
        private RadioButton rdbAlarma;
        private Button btnSalir;
        private Button button1;
        private Button button2;
        private ColorDialog colorDialog1;
        private Button btnColor;
    }
}