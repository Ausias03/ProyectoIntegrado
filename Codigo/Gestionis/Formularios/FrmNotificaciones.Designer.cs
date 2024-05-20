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
            btnVolver = new Button();
            SuspendLayout();
            // 
            // lblNotificaciones
            // 
            lblNotificaciones.AutoSize = true;
            lblNotificaciones.BackColor = Color.FromArgb(211, 208, 242);
            lblNotificaciones.BorderStyle = BorderStyle.FixedSingle;
            lblNotificaciones.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNotificaciones.Location = new Point(154, 25);
            lblNotificaciones.Name = "lblNotificaciones";
            lblNotificaciones.Padding = new Padding(5, 5, 5, 5);
            lblNotificaciones.Size = new Size(214, 48);
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
            flpNotificaciones.Location = new Point(14, 99);
            flpNotificaciones.Margin = new Padding(3, 4, 3, 4);
            flpNotificaciones.Name = "flpNotificaciones";
            flpNotificaciones.Size = new Size(493, 434);
            flpNotificaciones.TabIndex = 2;
            flpNotificaciones.WrapContents = false;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(211, 208, 242);
            btnVolver.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(333, 542);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(174, 53);
            btnVolver.TabIndex = 24;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // FrmNotificaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 605);
            Controls.Add(btnVolver);
            Controls.Add(flpNotificaciones);
            Controls.Add(lblNotificaciones);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmNotificaciones";
            Text = "Ge$tioni$";
            Load += FrmNotificaciones_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNotificaciones;
        private FlowLayoutPanel flpNotificaciones;
        private Button btnVolver;
    }
}