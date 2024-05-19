namespace Gestionis
{
    partial class frmTablaClasificación
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTablaClasificación));
            dgvTabla = new DataGridView();
            lblTabla = new Label();
            btnSalir = new Button();
            barraSecundaria1 = new Herramientas.BarraSecundaria();
            barraLateral1 = new Herramientas.BarraLateral();
            ((System.ComponentModel.ISupportInitialize)dgvTabla).BeginInit();
            SuspendLayout();
            // 
            // dgvTabla
            // 
            dgvTabla.AllowUserToAddRows = false;
            dgvTabla.AllowUserToDeleteRows = false;
            dgvTabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTabla.Location = new Point(349, 178);
            dgvTabla.Name = "dgvTabla";
            dgvTabla.ReadOnly = true;
            dgvTabla.RowHeadersWidth = 51;
            dgvTabla.Size = new Size(1149, 534);
            dgvTabla.TabIndex = 0;
            // 
            // lblTabla
            // 
            lblTabla.AutoSize = true;
            lblTabla.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold);
            lblTabla.Location = new Point(720, 115);
            lblTabla.Name = "lblTabla";
            lblTabla.Size = new Size(364, 36);
            lblTabla.TabIndex = 1;
            lblTabla.Text = "Top 10 usuarios del mes";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(170, 166, 202);
            btnSalir.Font = new Font("Microsoft Sans Serif", 12F);
            btnSalir.Location = new Point(1483, 753);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(124, 40);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // barraSecundaria1
            // 
            barraSecundaria1.BackColor = Color.FromArgb(211, 208, 242);
            barraSecundaria1.Dock = DockStyle.Top;
            barraSecundaria1.Location = new Point(0, 40);
            barraSecundaria1.Name = "barraSecundaria1";
            barraSecundaria1.Size = new Size(1667, 44);
            barraSecundaria1.TabIndex = 3;
            // 
            // barraLateral1
            // 
            barraLateral1.BackColor = Color.FromArgb(205, 213, 221);
            barraLateral1.Dock = DockStyle.Left;
            barraLateral1.Location = new Point(0, 84);
            barraLateral1.Name = "barraLateral1";
            barraLateral1.Size = new Size(289, 818);
            barraLateral1.TabIndex = 4;
            // 
            // frmTablaClasificación
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1667, 902);
            Controls.Add(barraLateral1);
            Controls.Add(barraSecundaria1);
            Controls.Add(btnSalir);
            Controls.Add(lblTabla);
            Controls.Add(dgvTabla);
            Font = new Font("Microsoft Sans Serif", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmTablaClasificación";
            Load += frmTablaClasificación_Load;
            Controls.SetChildIndex(dgvTabla, 0);
            Controls.SetChildIndex(lblTabla, 0);
            Controls.SetChildIndex(btnSalir, 0);
            Controls.SetChildIndex(barraSecundaria1, 0);
            Controls.SetChildIndex(barraLateral1, 0);
            ((System.ComponentModel.ISupportInitialize)dgvTabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTabla;
        private Label lblTabla;
        private Button btnSalir;
        private Herramientas.BarraSecundaria barraSecundaria1;
        private Herramientas.BarraLateral barraLateral1;
    }
}