namespace Historial
{
    partial class frmHistorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistorial));
            vScrollBar1 = new VScrollBar();
            lblHistorial = new Label();
            grpBotones = new GroupBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            comboBox1 = new ComboBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            dgvHistorial = new DataGridView();
            lblFecha = new Label();
            txtBuscar = new TextBox();
            picBuscar = new PictureBox();
            lblBuscar = new Label();
            lblMetodo = new Label();
            cmbMetodo = new ComboBox();
            dtpBuscaFecha = new DateTimePicker();
            lblBuscaFecha = new Label();
            picBuscaFecha = new PictureBox();
            grpBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBuscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBuscaFecha).BeginInit();
            SuspendLayout();
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(1491, 9);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(26, 698);
            vScrollBar1.TabIndex = 0;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Font = new Font("Roboto Mono", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblHistorial.Location = new Point(33, 51);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(239, 53);
            lblHistorial.TabIndex = 1;
            lblHistorial.Text = "Historial";
            // 
            // grpBotones
            // 
            grpBotones.BackColor = Color.FromArgb(211, 208, 242);
            grpBotones.Controls.Add(pictureBox1);
            grpBotones.Controls.Add(pictureBox2);
            grpBotones.Controls.Add(comboBox1);
            grpBotones.Controls.Add(pictureBox3);
            grpBotones.Controls.Add(pictureBox4);
            grpBotones.Controls.Add(pictureBox5);
            grpBotones.Controls.Add(pictureBox6);
            grpBotones.Location = new Point(-17, -19);
            grpBotones.Name = "grpBotones";
            grpBotones.Size = new Size(1401, 57);
            grpBotones.TabIndex = 16;
            grpBotones.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(134, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(50, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 20);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ES", "VAL", "EN" });
            comboBox1.Location = new Point(76, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(52, 28);
            comboBox1.TabIndex = 4;
            comboBox1.Text = "ES";
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(24, 26);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(20, 20);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(1275, 26);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(20, 20);
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(1301, 26);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(20, 20);
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(1327, 26);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(20, 20);
            pictureBox6.TabIndex = 7;
            pictureBox6.TabStop = false;
            // 
            // dgvHistorial
            // 
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Location = new Point(59, 183);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.RowHeadersWidth = 51;
            dgvHistorial.RowTemplate.Height = 29;
            dgvHistorial.Size = new Size(1018, 494);
            dgvHistorial.TabIndex = 17;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Roboto Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.Location = new Point(59, 154);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(48, 26);
            lblFecha.TabIndex = 18;
            lblFecha.Text = "Hoy";
            lblFecha.Visible = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Roboto Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscar.Location = new Point(1083, 183);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(181, 34);
            txtBuscar.TabIndex = 19;
            // 
            // picBuscar
            // 
            picBuscar.Location = new Point(1270, 183);
            picBuscar.Name = "picBuscar";
            picBuscar.Size = new Size(34, 34);
            picBuscar.TabIndex = 9;
            picBuscar.TabStop = false;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Roboto Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBuscar.Location = new Point(1083, 154);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(120, 26);
            lblBuscar.TabIndex = 20;
            lblBuscar.Text = "Buscador:";
            lblBuscar.Visible = false;
            // 
            // lblMetodo
            // 
            lblMetodo.AutoSize = true;
            lblMetodo.Font = new Font("Roboto Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMetodo.Location = new Point(1083, 220);
            lblMetodo.Name = "lblMetodo";
            lblMetodo.Size = new Size(96, 26);
            lblMetodo.TabIndex = 21;
            lblMetodo.Text = "Metodo:";
            lblMetodo.Visible = false;
            // 
            // cmbMetodo
            // 
            cmbMetodo.Font = new Font("Roboto Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbMetodo.FormattingEnabled = true;
            cmbMetodo.Items.AddRange(new object[] { "Tipo", "Cantidad", "Nombre" });
            cmbMetodo.Location = new Point(1083, 249);
            cmbMetodo.Name = "cmbMetodo";
            cmbMetodo.Size = new Size(181, 34);
            cmbMetodo.TabIndex = 22;
            cmbMetodo.Text = "Tipo";
            // 
            // dtpBuscaFecha
            // 
            dtpBuscaFecha.Font = new Font("Roboto Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpBuscaFecha.Format = DateTimePickerFormat.Short;
            dtpBuscaFecha.Location = new Point(1083, 340);
            dtpBuscaFecha.Name = "dtpBuscaFecha";
            dtpBuscaFecha.Size = new Size(180, 34);
            dtpBuscaFecha.TabIndex = 23;
            // 
            // lblBuscaFecha
            // 
            lblBuscaFecha.AutoSize = true;
            lblBuscaFecha.Font = new Font("Roboto Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBuscaFecha.Location = new Point(1083, 311);
            lblBuscaFecha.Name = "lblBuscaFecha";
            lblBuscaFecha.Size = new Size(240, 26);
            lblBuscaFecha.TabIndex = 24;
            lblBuscaFecha.Text = "Buscador por Fecha:";
            lblBuscaFecha.Visible = false;
            // 
            // picBuscaFecha
            // 
            picBuscaFecha.Location = new Point(1270, 340);
            picBuscaFecha.Name = "picBuscaFecha";
            picBuscaFecha.Size = new Size(34, 34);
            picBuscaFecha.TabIndex = 25;
            picBuscaFecha.TabStop = false;
            // 
            // frmHistorial
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1340, 703);
            Controls.Add(picBuscaFecha);
            Controls.Add(lblBuscaFecha);
            Controls.Add(dtpBuscaFecha);
            Controls.Add(cmbMetodo);
            Controls.Add(lblMetodo);
            Controls.Add(lblBuscar);
            Controls.Add(picBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(lblFecha);
            Controls.Add(dgvHistorial);
            Controls.Add(grpBotones);
            Controls.Add(lblHistorial);
            Controls.Add(vScrollBar1);
            Font = new Font("Roboto Mono", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmHistorial";
            Text = "Ge$tioni$";
            grpBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBuscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBuscaFecha).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private VScrollBar vScrollBar1;
        private Label lblHistorial;
        private GroupBox grpBotones;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ComboBox comboBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private DataGridView dgvHistorial;
        private Label lblFecha;
        private TextBox txtBuscar;
        private PictureBox picBuscar;
        private Label lblBuscar;
        private Label lblMetodo;
        private ComboBox cmbMetodo;
        private DateTimePicker dtpBuscaFecha;
        private Label lblBuscaFecha;
        private PictureBox picBuscaFecha;
    }
}