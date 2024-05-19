namespace Gestionis
{
    partial class frmAddCategoria
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
            txtNombreCat = new TextBox();
            lblNombreCat = new Label();
            colorDialog1 = new ColorDialog();
            lblColorCat = new Label();
            btnColorCat = new Button();
            btnVolver = new Button();
            btnAddCategoria = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtNombreCat
            // 
            txtNombreCat.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreCat.Location = new Point(144, 12);
            txtNombreCat.Margin = new Padding(3, 2, 3, 2);
            txtNombreCat.Name = "txtNombreCat";
            txtNombreCat.Size = new Size(223, 28);
            txtNombreCat.TabIndex = 4;
            // 
            // lblNombreCat
            // 
            lblNombreCat.AutoSize = true;
            lblNombreCat.BackColor = SystemColors.Control;
            lblNombreCat.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreCat.Location = new Point(10, 7);
            lblNombreCat.Name = "lblNombreCat";
            lblNombreCat.Padding = new Padding(4);
            lblNombreCat.Size = new Size(104, 34);
            lblNombreCat.TabIndex = 5;
            lblNombreCat.Text = "Nombre:";
            lblNombreCat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblColorCat
            // 
            lblColorCat.AutoSize = true;
            lblColorCat.BackColor = SystemColors.Control;
            lblColorCat.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblColorCat.Location = new Point(25, 42);
            lblColorCat.Name = "lblColorCat";
            lblColorCat.Padding = new Padding(4);
            lblColorCat.Size = new Size(78, 34);
            lblColorCat.TabIndex = 6;
            lblColorCat.Text = "Color:";
            lblColorCat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnColorCat
            // 
            btnColorCat.BackColor = Color.White;
            btnColorCat.Location = new Point(144, 51);
            btnColorCat.Margin = new Padding(3, 2, 3, 2);
            btnColorCat.Name = "btnColorCat";
            btnColorCat.Size = new Size(94, 25);
            btnColorCat.TabIndex = 8;
            btnColorCat.UseVisualStyleBackColor = false;
            btnColorCat.Click += btnColorCat_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(211, 208, 242);
            btnVolver.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(151, 85);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(105, 36);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnAddCategoria
            // 
            btnAddCategoria.BackColor = Color.FromArgb(178, 242, 187);
            btnAddCategoria.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddCategoria.Location = new Point(262, 85);
            btnAddCategoria.Margin = new Padding(3, 2, 3, 2);
            btnAddCategoria.Name = "btnAddCategoria";
            btnAddCategoria.Size = new Size(104, 36);
            btnAddCategoria.TabIndex = 10;
            btnAddCategoria.Text = "Añadir";
            btnAddCategoria.UseVisualStyleBackColor = false;
            btnAddCategoria.Click += btnAddCategoria_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // frmAddCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 128);
            Controls.Add(btnAddCategoria);
            Controls.Add(btnVolver);
            Controls.Add(btnColorCat);
            Controls.Add(lblColorCat);
            Controls.Add(txtNombreCat);
            Controls.Add(lblNombreCat);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmAddCategoria";
            Text = "FrmAddCategoria";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreCat;
        private Label lblNombreCat;
        private ColorDialog colorDialog1;
        private Label lblColorCat;
        private Button btnColorCat;
        private Button btnVolver;
        private Button btnAddCategoria;
        private ErrorProvider errorProvider1;
    }
}