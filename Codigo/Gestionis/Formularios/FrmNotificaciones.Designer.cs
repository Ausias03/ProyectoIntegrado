namespace Gestionis
{
    partial class FrmNotificaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotificaciones));
            lblNotificaciones = new Label();
            flpNotificaciones = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // lblNotificaciones
            // 
            lblNotificaciones.AutoSize = true;
            lblNotificaciones.BackColor = Color.FromArgb(211, 208, 242);
            lblNotificaciones.BorderStyle = BorderStyle.FixedSingle;
            lblNotificaciones.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNotificaciones.Location = new Point(135, 19);
            lblNotificaciones.Name = "lblNotificaciones";
            lblNotificaciones.Padding = new Padding(4);
            lblNotificaciones.Size = new Size(175, 39);
            lblNotificaciones.TabIndex = 1;
            lblNotificaciones.Text = "Notificaciones";
            lblNotificaciones.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flpNotificaciones
            // 
            flpNotificaciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpNotificaciones.AutoScroll = true;
            flpNotificaciones.AutoSize = true;
            flpNotificaciones.FlowDirection = FlowDirection.TopDown;
            flpNotificaciones.Location = new Point(12, 74);
            flpNotificaciones.Name = "flpNotificaciones";
            flpNotificaciones.Size = new Size(431, 322);
            flpNotificaciones.TabIndex = 2;
            flpNotificaciones.WrapContents = false;
            // 
            // FrmNotificaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 450);
            Controls.Add(flpNotificaciones);
            Controls.Add(lblNotificaciones);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmNotificaciones";
            Text = "Ge$tioni$";
            Load += FrmNotificaciones_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNotificaciones;
        private FlowLayoutPanel flpNotificaciones;
    }
}