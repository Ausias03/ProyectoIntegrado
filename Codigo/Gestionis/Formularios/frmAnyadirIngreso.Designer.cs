namespace Gestionis
{
    partial class frmAnyadirIngreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnyadirIngreso));
            btnAddIngreso = new Button();
            btnVolver = new Button();
            txtComentarios = new TextBox();
            lblComentarios = new Label();
            grpTipoGasto = new GroupBox();
            rdbSalario = new RadioButton();
            rdbExtra = new RadioButton();
            lblTipo = new Label();
            cboCategoria = new ComboBox();
            lblCategoria = new Label();
            nudCantidad = new NumericUpDown();
            lblCantidad = new Label();
            txtNombreIngreso = new TextBox();
            lblNombreIngreso = new Label();
            errorProvider1 = new ErrorProvider(components);
            grpTipoGasto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnAddIngreso
            // 
            btnAddIngreso.BackColor = Color.FromArgb(178, 242, 187);
            btnAddIngreso.Font = new Font("Roboto Mono", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddIngreso.Location = new Point(547, 419);
            btnAddIngreso.Name = "btnAddIngreso";
            btnAddIngreso.Size = new Size(236, 56);
            btnAddIngreso.TabIndex = 22;
            btnAddIngreso.Text = "Añadir Ingreso";
            btnAddIngreso.UseVisualStyleBackColor = false;
            btnAddIngreso.Click += btnAddIngreso_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(211, 208, 242);
            btnVolver.Font = new Font("Roboto Mono", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(547, 360);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(236, 53);
            btnVolver.TabIndex = 23;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click_1;
            // 
            // txtComentarios
            // 
            txtComentarios.Font = new Font("Roboto Mono", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtComentarios.Location = new Point(151, 314);
            txtComentarios.Multiline = true;
            txtComentarios.Name = "txtComentarios";
            txtComentarios.ScrollBars = ScrollBars.Vertical;
            txtComentarios.Size = new Size(372, 161);
            txtComentarios.TabIndex = 20;
            // 
            // lblComentarios
            // 
            lblComentarios.AutoSize = true;
            lblComentarios.BackColor = SystemColors.Control;
            lblComentarios.Font = new Font("Roboto Mono", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComentarios.Location = new Point(139, 262);
            lblComentarios.Name = "lblComentarios";
            lblComentarios.Padding = new Padding(5);
            lblComentarios.Size = new Size(231, 47);
            lblComentarios.TabIndex = 27;
            lblComentarios.Text = "Comentarios:";
            lblComentarios.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpTipoGasto
            // 
            grpTipoGasto.Controls.Add(rdbSalario);
            grpTipoGasto.Controls.Add(rdbExtra);
            grpTipoGasto.Location = new Point(376, 129);
            grpTipoGasto.Name = "grpTipoGasto";
            grpTipoGasto.Size = new Size(265, 71);
            grpTipoGasto.TabIndex = 26;
            grpTipoGasto.TabStop = false;
            // 
            // rdbSalario
            // 
            rdbSalario.AutoSize = true;
            rdbSalario.Font = new Font("Roboto Mono", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbSalario.Location = new Point(13, 21);
            rdbSalario.Name = "rdbSalario";
            rdbSalario.Size = new Size(132, 34);
            rdbSalario.TabIndex = 4;
            rdbSalario.Text = "Salario";
            rdbSalario.UseVisualStyleBackColor = true;
            // 
            // rdbExtra
            // 
            rdbExtra.AutoSize = true;
            rdbExtra.Checked = true;
            rdbExtra.Font = new Font("Roboto Mono", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbExtra.Location = new Point(156, 21);
            rdbExtra.Name = "rdbExtra";
            rdbExtra.Size = new Size(104, 34);
            rdbExtra.TabIndex = 5;
            rdbExtra.TabStop = true;
            rdbExtra.Text = "Extra";
            rdbExtra.UseVisualStyleBackColor = true;
            rdbExtra.CheckedChanged += rdbExtra_CheckedChanged;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.BackColor = SystemColors.Control;
            lblTipo.Font = new Font("Roboto Mono", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipo.Location = new Point(105, 142);
            lblTipo.Name = "lblTipo";
            lblTipo.Padding = new Padding(5);
            lblTipo.Size = new Size(265, 47);
            lblTipo.TabIndex = 24;
            lblTipo.Text = "Tipo de Gasto:";
            lblTipo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cboCategoria
            // 
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.Font = new Font("Roboto Mono", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(376, 209);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(195, 43);
            cboCategoria.TabIndex = 17;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.BackColor = SystemColors.Control;
            lblCategoria.Font = new Font("Roboto Mono", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(173, 206);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Padding = new Padding(5);
            lblCategoria.Size = new Size(197, 47);
            lblCategoria.TabIndex = 21;
            lblCategoria.Text = "Categoria:";
            lblCategoria.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudCantidad
            // 
            nudCantidad.DecimalPlaces = 2;
            nudCantidad.Font = new Font("Roboto Mono", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudCantidad.Location = new Point(376, 81);
            nudCantidad.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(195, 43);
            nudCantidad.TabIndex = 16;
            nudCantidad.ThousandsSeparator = true;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.BackColor = SystemColors.Control;
            lblCantidad.Font = new Font("Roboto Mono", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantidad.Location = new Point(20, 77);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Padding = new Padding(5);
            lblCantidad.Size = new Size(350, 47);
            lblCantidad.TabIndex = 19;
            lblCantidad.Text = "Cantidad de Dinero:";
            lblCantidad.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNombreIngreso
            // 
            txtNombreIngreso.Font = new Font("Roboto Mono", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreIngreso.Location = new Point(376, 19);
            txtNombreIngreso.Name = "txtNombreIngreso";
            txtNombreIngreso.Size = new Size(289, 43);
            txtNombreIngreso.TabIndex = 15;
            // 
            // lblNombreIngreso
            // 
            lblNombreIngreso.AutoSize = true;
            lblNombreIngreso.BackColor = SystemColors.Control;
            lblNombreIngreso.Font = new Font("Roboto Mono", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreIngreso.Location = new Point(37, 16);
            lblNombreIngreso.Name = "lblNombreIngreso";
            lblNombreIngreso.Padding = new Padding(5);
            lblNombreIngreso.Size = new Size(333, 47);
            lblNombreIngreso.TabIndex = 18;
            lblNombreIngreso.Text = "Nombre de Ingreso:";
            lblNombreIngreso.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // frmAnyadirIngreso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 492);
            Controls.Add(btnAddIngreso);
            Controls.Add(btnVolver);
            Controls.Add(txtComentarios);
            Controls.Add(lblComentarios);
            Controls.Add(grpTipoGasto);
            Controls.Add(lblTipo);
            Controls.Add(cboCategoria);
            Controls.Add(lblCategoria);
            Controls.Add(nudCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(txtNombreIngreso);
            Controls.Add(lblNombreIngreso);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAnyadirIngreso";
            Text = "Añadir Ingreso";
            Load += frmAnyadirIngreso_Load;
            grpTipoGasto.ResumeLayout(false);
            grpTipoGasto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddIngreso;
        private Button btnVolver;
        private TextBox txtComentarios;
        private Label lblComentarios;
        private GroupBox grpTipoGasto;
        private RadioButton rdbSalario;
        private RadioButton rdbExtra;
        private Label lblTipo;
        private ComboBox cboCategoria;
        private Label lblCategoria;
        private NumericUpDown nudCantidad;
        private Label lblCantidad;
        private TextBox txtNombreIngreso;
        private Label lblNombreIngreso;
        private ErrorProvider errorProvider1;
    }
}