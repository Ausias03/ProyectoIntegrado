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
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.FromArgb(211, 208, 242);
            lblTitulo.BorderStyle = BorderStyle.FixedSingle;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(82, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(275, 34);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Modificar Notificaciones";
            // 
            // ModifNotif
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 450);
            Controls.Add(lblTitulo);
            Name = "ModifNotif";
            Text = "ModifNotif";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
    }
}