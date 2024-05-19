namespace Gestionis
{
    partial class frmAnyadirGasto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnyadirGasto));
            txtNombreGasto = new TextBox();
            lblNombreGasto = new Label();
            lblCantidad = new Label();
            nudCantidad = new NumericUpDown();
            lblCategoria = new Label();
            cboCategoria = new ComboBox();
            lklAddCat = new LinkLabel();
            lblTipo = new Label();
            rdbFijo = new RadioButton();
            rdbVariable = new RadioButton();
            grpTipoGasto = new GroupBox();
            txtComentarios = new TextBox();
            lblComentarios = new Label();
            btnVolver = new Button();
            btnAddGasto = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            grpTipoGasto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtNombreGasto
            // 
            txtNombreGasto.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreGasto.Location = new Point(332, 13);
            txtNombreGasto.Margin = new Padding(3, 2, 3, 2);
            txtNombreGasto.Name = "txtNombreGasto";
            txtNombreGasto.Size = new Size(253, 32);
            txtNombreGasto.TabIndex = 1;
            // 
            // lblNombreGasto
            // 
            lblNombreGasto.AutoSize = true;
            lblNombreGasto.BackColor = SystemColors.Control;
            lblNombreGasto.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreGasto.Location = new Point(65, 10);
            lblNombreGasto.Name = "lblNombreGasto";
            lblNombreGasto.Padding = new Padding(4);
            lblNombreGasto.Size = new Size(198, 34);
            lblNombreGasto.TabIndex = 3;
            lblNombreGasto.Text = "Nombre de Gasto:";
            lblNombreGasto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.BackColor = SystemColors.Control;
            lblCantidad.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantidad.Location = new Point(20, 56);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Padding = new Padding(4);
            lblCantidad.Size = new Size(213, 34);
            lblCantidad.TabIndex = 4;
            lblCantidad.Text = "Cantidad de Dinero:";
            lblCantidad.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudCantidad
            // 
            nudCantidad.DecimalPlaces = 2;
            nudCantidad.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudCantidad.Location = new Point(332, 59);
            nudCantidad.Margin = new Padding(3, 2, 3, 2);
            nudCantidad.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(171, 32);
            nudCantidad.TabIndex = 2;
            nudCantidad.ThousandsSeparator = true;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.BackColor = SystemColors.Control;
            lblCategoria.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(154, 102);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Padding = new Padding(4);
            lblCategoria.Size = new Size(120, 34);
            lblCategoria.TabIndex = 6;
            lblCategoria.Text = "Categoria:";
            lblCategoria.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cboCategoria
            // 
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(332, 104);
            cboCategoria.Margin = new Padding(3, 2, 3, 2);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(171, 34);
            cboCategoria.TabIndex = 3;
            // 
            // lklAddCat
            // 
            lklAddCat.AutoSize = true;
            lklAddCat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lklAddCat.Location = new Point(509, 112);
            lklAddCat.Name = "lklAddCat";
            lklAddCat.Size = new Size(128, 20);
            lklAddCat.TabIndex = 9;
            lklAddCat.TabStop = true;
            lklAddCat.Text = "Añadir Categoria";
            lklAddCat.LinkClicked += lklAddCat_LinkClicked;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.BackColor = SystemColors.Control;
            lblTipo.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipo.Location = new Point(94, 151);
            lblTipo.Name = "lblTipo";
            lblTipo.Padding = new Padding(4);
            lblTipo.Size = new Size(161, 34);
            lblTipo.TabIndex = 9;
            lblTipo.Text = "Tipo de Gasto:";
            lblTipo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rdbFijo
            // 
            rdbFijo.AutoSize = true;
            rdbFijo.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbFijo.Location = new Point(11, 16);
            rdbFijo.Margin = new Padding(3, 2, 3, 2);
            rdbFijo.Name = "rdbFijo";
            rdbFijo.Size = new Size(59, 28);
            rdbFijo.TabIndex = 4;
            rdbFijo.Text = "Fijo";
            rdbFijo.UseVisualStyleBackColor = true;
            // 
            // rdbVariable
            // 
            rdbVariable.AutoSize = true;
            rdbVariable.Checked = true;
            rdbVariable.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbVariable.Location = new Point(91, 16);
            rdbVariable.Margin = new Padding(3, 2, 3, 2);
            rdbVariable.Name = "rdbVariable";
            rdbVariable.Size = new Size(97, 28);
            rdbVariable.TabIndex = 5;
            rdbVariable.TabStop = true;
            rdbVariable.Text = "Variable";
            rdbVariable.UseVisualStyleBackColor = true;
            // 
            // grpTipoGasto
            // 
            grpTipoGasto.Controls.Add(rdbFijo);
            grpTipoGasto.Controls.Add(rdbVariable);
            grpTipoGasto.Location = new Point(332, 141);
            grpTipoGasto.Margin = new Padding(3, 2, 3, 2);
            grpTipoGasto.Name = "grpTipoGasto";
            grpTipoGasto.Padding = new Padding(3, 2, 3, 2);
            grpTipoGasto.Size = new Size(224, 53);
            grpTipoGasto.TabIndex = 12;
            grpTipoGasto.TabStop = false;
            // 
            // txtComentarios
            // 
            txtComentarios.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtComentarios.Location = new Point(135, 234);
            txtComentarios.Margin = new Padding(3, 2, 3, 2);
            txtComentarios.Multiline = true;
            txtComentarios.Name = "txtComentarios";
            txtComentarios.ScrollBars = ScrollBars.Vertical;
            txtComentarios.Size = new Size(326, 122);
            txtComentarios.TabIndex = 6;
            // 
            // lblComentarios
            // 
            lblComentarios.AutoSize = true;
            lblComentarios.BackColor = SystemColors.Control;
            lblComentarios.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComentarios.Location = new Point(124, 195);
            lblComentarios.Name = "lblComentarios";
            lblComentarios.Padding = new Padding(4);
            lblComentarios.Size = new Size(150, 34);
            lblComentarios.TabIndex = 14;
            lblComentarios.Text = "Comentarios:";
            lblComentarios.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(211, 208, 242);
            btnVolver.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(506, 268);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(182, 40);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnAddGasto
            // 
            btnAddGasto.BackColor = Color.FromArgb(178, 242, 187);
            btnAddGasto.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddGasto.Location = new Point(506, 313);
            btnAddGasto.Margin = new Padding(3, 2, 3, 2);
            btnAddGasto.Name = "btnAddGasto";
            btnAddGasto.Size = new Size(182, 42);
            btnAddGasto.TabIndex = 7;
            btnAddGasto.Text = "Añadir Gasto";
            btnAddGasto.UseVisualStyleBackColor = false;
            btnAddGasto.Click += btnAddGasto_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // frmAnyadirGasto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 369);
            Controls.Add(btnAddGasto);
            Controls.Add(btnVolver);
            Controls.Add(txtComentarios);
            Controls.Add(lblComentarios);
            Controls.Add(grpTipoGasto);
            Controls.Add(lblTipo);
            Controls.Add(lklAddCat);
            Controls.Add(cboCategoria);
            Controls.Add(lblCategoria);
            Controls.Add(nudCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(txtNombreGasto);
            Controls.Add(lblNombreGasto);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmAnyadirGasto";
            Text = "Añadir Gasto";
            Activated += frmAnyadirGasto_Activated;
            Load += frmAnyadirGasto_Load;
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            grpTipoGasto.ResumeLayout(false);
            grpTipoGasto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreGasto;
        private Label lblNombreGasto;
        private Label lblCantidad;
        private NumericUpDown nudCantidad;
        private Label lblCategoria;
        private ComboBox cboCategoria;
        private LinkLabel lklAddCat;
        private Label lblTipo;
        private RadioButton rdbFijo;
        private RadioButton rdbVariable;
        private GroupBox grpTipoGasto;
        private TextBox txtComentarios;
        private Label lblComentarios;
        private Button btnVolver;
        private Button btnAddGasto;
        private ErrorProvider errorProvider1;
    }
}