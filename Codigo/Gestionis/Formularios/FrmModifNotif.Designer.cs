namespace Gestionis.Formularios
{
    partial class FrmModifNotif
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModifNotif));
            lblTitulo = new Label();
            cboCategorias = new ComboBox();
            lblCategoria = new Label();
            lblLimiteCategoria = new Label();
            nudLimite = new NumericUpDown();
            btnModificar = new Button();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)nudLimite).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.FromArgb(211, 208, 242);
            lblTitulo.BorderStyle = BorderStyle.FixedSingle;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(143, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(199, 34);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Modificar Limites";
            // 
            // cboCategorias
            // 
            cboCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategorias.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboCategorias.FormattingEnabled = true;
            cboCategorias.Location = new Point(249, 79);
            cboCategorias.Margin = new Padding(3, 2, 3, 2);
            cboCategorias.Name = "cboCategorias";
            cboCategorias.Size = new Size(192, 33);
            cboCategorias.TabIndex = 1;
            cboCategorias.TextChanged += cboCategorias_TextChanged;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(18, 81);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(205, 25);
            lblCategoria.TabIndex = 2;
            lblCategoria.Text = "Categoria Notificacion:";
            // 
            // lblLimiteCategoria
            // 
            lblLimiteCategoria.AutoSize = true;
            lblLimiteCategoria.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLimiteCategoria.Location = new Point(88, 136);
            lblLimiteCategoria.Name = "lblLimiteCategoria";
            lblLimiteCategoria.Size = new Size(128, 25);
            lblLimiteCategoria.TabIndex = 3;
            lblLimiteCategoria.Text = "Limite Gastos:";
            // 
            // nudLimite
            // 
            nudLimite.DecimalPlaces = 2;
            nudLimite.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudLimite.Location = new Point(248, 134);
            nudLimite.Margin = new Padding(3, 2, 3, 2);
            nudLimite.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudLimite.Name = "nudLimite";
            nudLimite.Size = new Size(192, 32);
            nudLimite.TabIndex = 4;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(178, 242, 187);
            btnModificar.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModificar.Location = new Point(264, 183);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(123, 40);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(211, 208, 242);
            btnVolver.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(107, 183);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(111, 40);
            btnVolver.TabIndex = 6;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // FrmModifNotif
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 246);
            Controls.Add(btnModificar);
            Controls.Add(btnVolver);
            Controls.Add(nudLimite);
            Controls.Add(lblLimiteCategoria);
            Controls.Add(lblCategoria);
            Controls.Add(cboCategorias);
            Controls.Add(lblTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmModifNotif";
            Text = "Modificar Límite Gastos";
            Load += FrmModifNotif_Load;
            ((System.ComponentModel.ISupportInitialize)nudLimite).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private ComboBox cboCategorias;
        private Label lblCategoria;
        private Label lblLimiteCategoria;
        private NumericUpDown nudLimite;
        private Button btnModificar;
        private Button btnVolver;
    }
}