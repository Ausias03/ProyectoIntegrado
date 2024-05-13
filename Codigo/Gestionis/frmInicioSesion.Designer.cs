namespace Gestionis
{
    partial class frmInicioSesion
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
            lblInicioSesion = new Label();
            SuspendLayout();
            // 
            // lblInicioSesion
            // 
            lblInicioSesion.AutoSize = true;
            lblInicioSesion.BackColor = Color.FromArgb(211, 208, 242);
            lblInicioSesion.BorderStyle = BorderStyle.FixedSingle;
            lblInicioSesion.Font = new Font("Roboto Mono", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInicioSesion.Location = new Point(260, 29);
            lblInicioSesion.Name = "lblInicioSesion";
            lblInicioSesion.Padding = new Padding(5);
            lblInicioSesion.Size = new Size(317, 51);
            lblInicioSesion.TabIndex = 0;
            lblInicioSesion.Text = "Inicio de Sesión";
            lblInicioSesion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmInicioSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblInicioSesion);
            Name = "frmInicioSesion";
            Text = "Iniciar Sesión";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInicioSesion;
    }
}
