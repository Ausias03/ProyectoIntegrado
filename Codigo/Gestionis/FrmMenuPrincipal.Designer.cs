namespace Gestionis
{
    partial class FrmMenuPrincipal
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
            pnlBarra = new Panel();
            pbSpain = new PictureBox();
            pbAyuda = new PictureBox();
            pbUsuario = new PictureBox();
            pbNotificaciones = new PictureBox();
            pbNoticias = new PictureBox();
            pbTema = new PictureBox();
            pbEnglish = new PictureBox();
            pbHamburger = new PictureBox();
            rgbMenu = new RoundGroupBox();
            lblTotalValor = new Label();
            lblGastosValor = new Label();
            lblIngresosValor = new Label();
            lblTotal = new Label();
            lblGastos = new Label();
            lblIngresos = new Label();
            cmbCategoria = new ComboBox();
            cmbDinero = new ComboBox();
            cmbTipo = new ComboBox();
            txtNombre = new TextBox();
            dgvGastosIngresos = new DataGridView();
            btnGasto = new Button();
            btnIngreso = new Button();
            lblLinea = new Label();
            lblLinea2 = new Label();
            lblLinea3 = new Label();
            rgbCalendario = new RoundGroupBox();
            lblAdelante = new Label();
            lblAtras = new Label();
            lblMes = new Label();
            label3 = new Label();
            btnSalir = new Button();
            pnlNotas = new Panel();
            lblNotasValor = new Label();
            lblNotas = new Label();
            flpBarraLateral = new FlowLayoutPanel();
            btnInicio = new Button();
            btnInversiones = new Button();
            btnMetodoAhorro = new Button();
            btnDeudas = new Button();
            btnPatrimonio = new Button();
            btnNotas = new Button();
            btnTabalClasif = new Button();
            btnHistorial = new Button();
            btnNotificaciones = new Button();
            btnPaginaWeb = new Button();
            btnAyuda = new Button();
            transicionBarraLateral = new System.Windows.Forms.Timer(components);
            pnlBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSpain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAyuda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNotificaciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNoticias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTema).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEnglish).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHamburger).BeginInit();
            rgbMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGastosIngresos).BeginInit();
            rgbCalendario.SuspendLayout();
            pnlNotas.SuspendLayout();
            flpBarraLateral.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBarra
            // 
            pnlBarra.BackColor = Color.FromArgb(211, 208, 242);
            pnlBarra.Controls.Add(pbSpain);
            pnlBarra.Controls.Add(pbAyuda);
            pnlBarra.Controls.Add(pbUsuario);
            pnlBarra.Controls.Add(pbNotificaciones);
            pnlBarra.Controls.Add(pbNoticias);
            pnlBarra.Controls.Add(pbTema);
            pnlBarra.Controls.Add(pbEnglish);
            pnlBarra.Controls.Add(pbHamburger);
            pnlBarra.Dock = DockStyle.Top;
            pnlBarra.Location = new Point(0, 0);
            pnlBarra.Margin = new Padding(3, 2, 3, 2);
            pnlBarra.Name = "pnlBarra";
            pnlBarra.Size = new Size(1713, 31);
            pnlBarra.TabIndex = 2;
            pnlBarra.Paint += pnlBarra_Paint;
            // 
            // pbSpain
            // 
            pbSpain.Enabled = false;
            pbSpain.Location = new Point(80, 4);
            pbSpain.Name = "pbSpain";
            pbSpain.Size = new Size(29, 23);
            pbSpain.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSpain.TabIndex = 24;
            pbSpain.TabStop = false;
            pbSpain.Visible = false;
            pbSpain.Click += pbSpain_Click;
            // 
            // pbAyuda
            // 
            pbAyuda.Location = new Point(43, 4);
            pbAyuda.Name = "pbAyuda";
            pbAyuda.Size = new Size(27, 22);
            pbAyuda.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAyuda.TabIndex = 18;
            pbAyuda.TabStop = false;
            // 
            // pbUsuario
            // 
            pbUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbUsuario.Location = new Point(1676, 4);
            pbUsuario.Name = "pbUsuario";
            pbUsuario.Size = new Size(24, 23);
            pbUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUsuario.TabIndex = 23;
            pbUsuario.TabStop = false;
            // 
            // pbNotificaciones
            // 
            pbNotificaciones.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbNotificaciones.Location = new Point(1646, 4);
            pbNotificaciones.Name = "pbNotificaciones";
            pbNotificaciones.Size = new Size(24, 23);
            pbNotificaciones.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNotificaciones.TabIndex = 22;
            pbNotificaciones.TabStop = false;
            // 
            // pbNoticias
            // 
            pbNoticias.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbNoticias.Location = new Point(1613, 4);
            pbNoticias.Name = "pbNoticias";
            pbNoticias.Size = new Size(27, 23);
            pbNoticias.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNoticias.TabIndex = 21;
            pbNoticias.TabStop = false;
            // 
            // pbTema
            // 
            pbTema.Location = new Point(118, 4);
            pbTema.Name = "pbTema";
            pbTema.Size = new Size(28, 23);
            pbTema.SizeMode = PictureBoxSizeMode.StretchImage;
            pbTema.TabIndex = 20;
            pbTema.TabStop = false;
            // 
            // pbEnglish
            // 
            pbEnglish.Location = new Point(82, 4);
            pbEnglish.Name = "pbEnglish";
            pbEnglish.Size = new Size(26, 23);
            pbEnglish.SizeMode = PictureBoxSizeMode.CenterImage;
            pbEnglish.TabIndex = 19;
            pbEnglish.TabStop = false;
            pbEnglish.Click += pbEnglish_Click;
            // 
            // pbHamburger
            // 
            pbHamburger.Location = new Point(10, 4);
            pbHamburger.Name = "pbHamburger";
            pbHamburger.Size = new Size(27, 23);
            pbHamburger.SizeMode = PictureBoxSizeMode.StretchImage;
            pbHamburger.TabIndex = 17;
            pbHamburger.TabStop = false;
            pbHamburger.Click += pbHamburger_Click;
            // 
            // rgbMenu
            // 
            rgbMenu.AutoSize = true;
            rgbMenu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            rgbMenu.BackColor = Color.Transparent;
            rgbMenu.Controls.Add(lblTotalValor);
            rgbMenu.Controls.Add(lblGastosValor);
            rgbMenu.Controls.Add(lblIngresosValor);
            rgbMenu.Controls.Add(lblTotal);
            rgbMenu.Controls.Add(lblGastos);
            rgbMenu.Controls.Add(lblIngresos);
            rgbMenu.Controls.Add(cmbCategoria);
            rgbMenu.Controls.Add(cmbDinero);
            rgbMenu.Controls.Add(cmbTipo);
            rgbMenu.Controls.Add(txtNombre);
            rgbMenu.Controls.Add(dgvGastosIngresos);
            rgbMenu.Controls.Add(btnGasto);
            rgbMenu.Controls.Add(btnIngreso);
            rgbMenu.Controls.Add(lblLinea);
            rgbMenu.Controls.Add(lblLinea2);
            rgbMenu.Controls.Add(lblLinea3);
            rgbMenu.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rgbMenu.ForeColor = SystemColors.ControlText;
            rgbMenu.Location = new Point(354, 93);
            rgbMenu.Margin = new Padding(3, 2, 3, 2);
            rgbMenu.Name = "rgbMenu";
            rgbMenu.Padding = new Padding(3, 2, 3, 2);
            rgbMenu.Size = new Size(859, 465);
            rgbMenu.TabIndex = 3;
            rgbMenu.TabStop = false;
            // 
            // lblTotalValor
            // 
            lblTotalValor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalValor.AutoSize = true;
            lblTotalValor.Location = new Point(732, 111);
            lblTotalValor.Name = "lblTotalValor";
            lblTotalValor.Size = new Size(87, 25);
            lblTotalValor.TabIndex = 12;
            lblTotalValor.Text = "Ingresos:";
            // 
            // lblGastosValor
            // 
            lblGastosValor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblGastosValor.AutoSize = true;
            lblGastosValor.Location = new Point(732, 74);
            lblGastosValor.Name = "lblGastosValor";
            lblGastosValor.Size = new Size(87, 25);
            lblGastosValor.TabIndex = 11;
            lblGastosValor.Text = "Ingresos:";
            // 
            // lblIngresosValor
            // 
            lblIngresosValor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblIngresosValor.AutoSize = true;
            lblIngresosValor.Location = new Point(732, 38);
            lblIngresosValor.Name = "lblIngresosValor";
            lblIngresosValor.Size = new Size(87, 25);
            lblIngresosValor.TabIndex = 10;
            lblIngresosValor.Text = "Ingresos:";
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(640, 111);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(56, 25);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "Total:";
            // 
            // lblGastos
            // 
            lblGastos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblGastos.AutoSize = true;
            lblGastos.Location = new Point(640, 74);
            lblGastos.Name = "lblGastos";
            lblGastos.Size = new Size(72, 25);
            lblGastos.TabIndex = 8;
            lblGastos.Text = "Gastos:";
            // 
            // lblIngresos
            // 
            lblIngresos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblIngresos.AutoSize = true;
            lblIngresos.Location = new Point(640, 38);
            lblIngresos.Name = "lblIngresos";
            lblIngresos.Size = new Size(87, 25);
            lblIngresos.TabIndex = 7;
            lblIngresos.Text = "Ingresos:";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(437, 172);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(128, 33);
            cmbCategoria.TabIndex = 6;
            // 
            // cmbDinero
            // 
            cmbDinero.FormattingEnabled = true;
            cmbDinero.Location = new Point(329, 172);
            cmbDinero.Name = "cmbDinero";
            cmbDinero.Size = new Size(92, 33);
            cmbDinero.TabIndex = 5;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(251, 172);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(63, 33);
            cmbTipo.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(41, 172);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(198, 33);
            txtNombre.TabIndex = 3;
            // 
            // dgvGastosIngresos
            // 
            dgvGastosIngresos.BackgroundColor = SystemColors.ControlLightLight;
            dgvGastosIngresos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGastosIngresos.GridColor = SystemColors.Window;
            dgvGastosIngresos.Location = new Point(41, 225);
            dgvGastosIngresos.Name = "dgvGastosIngresos";
            dgvGastosIngresos.RowHeadersWidth = 51;
            dgvGastosIngresos.Size = new Size(524, 209);
            dgvGastosIngresos.TabIndex = 2;
            // 
            // btnGasto
            // 
            btnGasto.BackColor = Color.FromArgb(178, 242, 187);
            btnGasto.Location = new Point(53, 91);
            btnGasto.Name = "btnGasto";
            btnGasto.Size = new Size(160, 45);
            btnGasto.TabIndex = 1;
            btnGasto.Text = "Nuevo Gasto";
            btnGasto.UseVisualStyleBackColor = false;
            btnGasto.Click += btnGasto_Click;
            // 
            // btnIngreso
            // 
            btnIngreso.BackColor = Color.FromArgb(178, 242, 187);
            btnIngreso.Location = new Point(53, 38);
            btnIngreso.Name = "btnIngreso";
            btnIngreso.Size = new Size(160, 45);
            btnIngreso.TabIndex = 0;
            btnIngreso.Text = "Nuevo Ingreso";
            btnIngreso.UseVisualStyleBackColor = false;
            btnIngreso.Click += btnIngreso_Click;
            // 
            // lblLinea
            // 
            lblLinea.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLinea.AutoSize = true;
            lblLinea.Location = new Point(638, 42);
            lblLinea.Name = "lblLinea";
            lblLinea.Size = new Size(172, 25);
            lblLinea.TabIndex = 0;
            lblLinea.Text = "____________________";
            // 
            // lblLinea2
            // 
            lblLinea2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLinea2.AutoSize = true;
            lblLinea2.Location = new Point(640, 78);
            lblLinea2.Name = "lblLinea2";
            lblLinea2.Size = new Size(172, 25);
            lblLinea2.TabIndex = 14;
            lblLinea2.Text = "____________________";
            // 
            // lblLinea3
            // 
            lblLinea3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLinea3.AutoSize = true;
            lblLinea3.Location = new Point(639, 114);
            lblLinea3.Name = "lblLinea3";
            lblLinea3.Size = new Size(172, 25);
            lblLinea3.TabIndex = 13;
            lblLinea3.Text = "____________________";
            // 
            // rgbCalendario
            // 
            rgbCalendario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rgbCalendario.Controls.Add(lblAdelante);
            rgbCalendario.Controls.Add(lblAtras);
            rgbCalendario.Controls.Add(lblMes);
            rgbCalendario.Controls.Add(label3);
            rgbCalendario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rgbCalendario.Location = new Point(1441, 147);
            rgbCalendario.Name = "rgbCalendario";
            rgbCalendario.Size = new Size(199, 103);
            rgbCalendario.TabIndex = 4;
            rgbCalendario.TabStop = false;
            // 
            // lblAdelante
            // 
            lblAdelante.AutoSize = true;
            lblAdelante.BackColor = Color.Transparent;
            lblAdelante.Location = new Point(134, 2);
            lblAdelante.Name = "lblAdelante";
            lblAdelante.Size = new Size(25, 25);
            lblAdelante.TabIndex = 3;
            lblAdelante.Text = ">";
            // 
            // lblAtras
            // 
            lblAtras.AutoSize = true;
            lblAtras.BackColor = Color.Transparent;
            lblAtras.Location = new Point(41, 2);
            lblAtras.Name = "lblAtras";
            lblAtras.Size = new Size(25, 25);
            lblAtras.TabIndex = 2;
            lblAtras.Text = "<";
            // 
            // lblMes
            // 
            lblMes.AutoSize = true;
            lblMes.BackColor = Color.Transparent;
            lblMes.Location = new Point(75, 2);
            lblMes.Name = "lblMes";
            lblMes.Size = new Size(47, 25);
            lblMes.TabIndex = 1;
            lblMes.Text = "Mes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(-4, 6);
            label3.Name = "label3";
            label3.Size = new Size(212, 25);
            label3.TabIndex = 0;
            label3.Text = "_________________________";
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.BackColor = Color.FromArgb(178, 242, 187);
            btnSalir.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(1527, 696);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(152, 45);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // pnlNotas
            // 
            pnlNotas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlNotas.BackColor = Color.FromArgb(205, 213, 221);
            pnlNotas.Controls.Add(lblNotasValor);
            pnlNotas.Controls.Add(lblNotas);
            pnlNotas.Location = new Point(1406, 297);
            pnlNotas.Name = "pnlNotas";
            pnlNotas.Size = new Size(275, 181);
            pnlNotas.TabIndex = 16;
            // 
            // lblNotasValor
            // 
            lblNotasValor.AutoSize = true;
            lblNotasValor.BackColor = Color.Transparent;
            lblNotasValor.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNotasValor.Location = new Point(3, 39);
            lblNotasValor.Name = "lblNotasValor";
            lblNotasValor.Size = new Size(123, 25);
            lblNotasValor.TabIndex = 5;
            lblNotasValor.Text = "Notas del día";
            // 
            // lblNotas
            // 
            lblNotas.AutoSize = true;
            lblNotas.BackColor = Color.Transparent;
            lblNotas.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblNotas.Location = new Point(3, 1);
            lblNotas.Name = "lblNotas";
            lblNotas.Size = new Size(123, 25);
            lblNotas.TabIndex = 4;
            lblNotas.Text = "Notas del día";
            // 
            // flpBarraLateral
            // 
            flpBarraLateral.BackColor = Color.FromArgb(205, 213, 221);
            flpBarraLateral.Controls.Add(btnInicio);
            flpBarraLateral.Controls.Add(btnInversiones);
            flpBarraLateral.Controls.Add(btnMetodoAhorro);
            flpBarraLateral.Controls.Add(btnDeudas);
            flpBarraLateral.Controls.Add(btnPatrimonio);
            flpBarraLateral.Controls.Add(btnNotas);
            flpBarraLateral.Controls.Add(btnTabalClasif);
            flpBarraLateral.Controls.Add(btnHistorial);
            flpBarraLateral.Controls.Add(btnNotificaciones);
            flpBarraLateral.Controls.Add(btnPaginaWeb);
            flpBarraLateral.Controls.Add(btnAyuda);
            flpBarraLateral.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flpBarraLateral.Location = new Point(0, 71);
            flpBarraLateral.Name = "flpBarraLateral";
            flpBarraLateral.Size = new Size(231, 725);
            flpBarraLateral.TabIndex = 18;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(205, 213, 221);
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.Location = new Point(3, 3);
            btnInicio.Name = "btnInicio";
            btnInicio.Padding = new Padding(5, 0, 0, 0);
            btnInicio.Size = new Size(223, 52);
            btnInicio.TabIndex = 20;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = false;
            // 
            // btnInversiones
            // 
            btnInversiones.BackColor = Color.FromArgb(205, 213, 221);
            btnInversiones.FlatStyle = FlatStyle.Flat;
            btnInversiones.ImageAlign = ContentAlignment.MiddleLeft;
            btnInversiones.Location = new Point(3, 61);
            btnInversiones.Name = "btnInversiones";
            btnInversiones.Padding = new Padding(5, 0, 0, 0);
            btnInversiones.Size = new Size(223, 52);
            btnInversiones.TabIndex = 21;
            btnInversiones.Text = "Inversiones";
            btnInversiones.UseVisualStyleBackColor = false;
            // 
            // btnMetodoAhorro
            // 
            btnMetodoAhorro.BackColor = Color.FromArgb(205, 213, 221);
            btnMetodoAhorro.FlatStyle = FlatStyle.Flat;
            btnMetodoAhorro.ImageAlign = ContentAlignment.MiddleLeft;
            btnMetodoAhorro.Location = new Point(3, 119);
            btnMetodoAhorro.Name = "btnMetodoAhorro";
            btnMetodoAhorro.Padding = new Padding(5, 0, 18, 0);
            btnMetodoAhorro.Size = new Size(223, 52);
            btnMetodoAhorro.TabIndex = 22;
            btnMetodoAhorro.Text = "Métodos ahorro";
            btnMetodoAhorro.TextAlign = ContentAlignment.MiddleRight;
            btnMetodoAhorro.UseVisualStyleBackColor = false;
            // 
            // btnDeudas
            // 
            btnDeudas.BackColor = Color.FromArgb(205, 213, 221);
            btnDeudas.FlatStyle = FlatStyle.Flat;
            btnDeudas.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeudas.Location = new Point(3, 177);
            btnDeudas.Name = "btnDeudas";
            btnDeudas.Padding = new Padding(5, 0, 0, 0);
            btnDeudas.Size = new Size(223, 52);
            btnDeudas.TabIndex = 23;
            btnDeudas.Text = "Deudas";
            btnDeudas.UseVisualStyleBackColor = false;
            // 
            // btnPatrimonio
            // 
            btnPatrimonio.BackColor = Color.FromArgb(205, 213, 221);
            btnPatrimonio.FlatStyle = FlatStyle.Flat;
            btnPatrimonio.ImageAlign = ContentAlignment.MiddleLeft;
            btnPatrimonio.Location = new Point(3, 235);
            btnPatrimonio.Name = "btnPatrimonio";
            btnPatrimonio.Padding = new Padding(5, 0, 19, 0);
            btnPatrimonio.Size = new Size(223, 52);
            btnPatrimonio.TabIndex = 24;
            btnPatrimonio.Text = "Patrimonio neto";
            btnPatrimonio.TextAlign = ContentAlignment.MiddleRight;
            btnPatrimonio.UseVisualStyleBackColor = false;
            // 
            // btnNotas
            // 
            btnNotas.BackColor = Color.FromArgb(205, 213, 221);
            btnNotas.FlatStyle = FlatStyle.Flat;
            btnNotas.ImageAlign = ContentAlignment.MiddleLeft;
            btnNotas.Location = new Point(3, 293);
            btnNotas.Name = "btnNotas";
            btnNotas.Padding = new Padding(5, 0, 0, 0);
            btnNotas.Size = new Size(223, 52);
            btnNotas.TabIndex = 25;
            btnNotas.Text = "Notas";
            btnNotas.UseVisualStyleBackColor = false;
            // 
            // btnTabalClasif
            // 
            btnTabalClasif.BackColor = Color.FromArgb(205, 213, 221);
            btnTabalClasif.FlatStyle = FlatStyle.Flat;
            btnTabalClasif.ImageAlign = ContentAlignment.MiddleLeft;
            btnTabalClasif.Location = new Point(3, 351);
            btnTabalClasif.Name = "btnTabalClasif";
            btnTabalClasif.Padding = new Padding(5, 0, 0, 0);
            btnTabalClasif.Size = new Size(223, 52);
            btnTabalClasif.TabIndex = 26;
            btnTabalClasif.Text = "Tabal clasificación";
            btnTabalClasif.TextAlign = ContentAlignment.MiddleRight;
            btnTabalClasif.UseVisualStyleBackColor = false;
            // 
            // btnHistorial
            // 
            btnHistorial.BackColor = Color.FromArgb(205, 213, 221);
            btnHistorial.FlatStyle = FlatStyle.Flat;
            btnHistorial.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistorial.Location = new Point(3, 409);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Padding = new Padding(5, 0, 0, 0);
            btnHistorial.Size = new Size(223, 52);
            btnHistorial.TabIndex = 27;
            btnHistorial.Text = "Historial";
            btnHistorial.UseVisualStyleBackColor = false;
            // 
            // btnNotificaciones
            // 
            btnNotificaciones.BackColor = Color.FromArgb(205, 213, 221);
            btnNotificaciones.FlatStyle = FlatStyle.Flat;
            btnNotificaciones.ImageAlign = ContentAlignment.MiddleLeft;
            btnNotificaciones.Location = new Point(3, 467);
            btnNotificaciones.Name = "btnNotificaciones";
            btnNotificaciones.Padding = new Padding(5, 0, 30, 0);
            btnNotificaciones.Size = new Size(223, 52);
            btnNotificaciones.TabIndex = 28;
            btnNotificaciones.Text = "Notificaciónes";
            btnNotificaciones.TextAlign = ContentAlignment.MiddleRight;
            btnNotificaciones.UseVisualStyleBackColor = false;
            // 
            // btnPaginaWeb
            // 
            btnPaginaWeb.BackColor = Color.FromArgb(205, 213, 221);
            btnPaginaWeb.FlatStyle = FlatStyle.Flat;
            btnPaginaWeb.ImageAlign = ContentAlignment.MiddleLeft;
            btnPaginaWeb.Location = new Point(3, 525);
            btnPaginaWeb.Name = "btnPaginaWeb";
            btnPaginaWeb.Padding = new Padding(5, 0, 0, 0);
            btnPaginaWeb.Size = new Size(223, 52);
            btnPaginaWeb.TabIndex = 29;
            btnPaginaWeb.Text = "Página Web";
            btnPaginaWeb.UseVisualStyleBackColor = false;
            // 
            // btnAyuda
            // 
            btnAyuda.BackColor = Color.FromArgb(205, 213, 221);
            btnAyuda.FlatStyle = FlatStyle.Flat;
            btnAyuda.ImageAlign = ContentAlignment.MiddleLeft;
            btnAyuda.Location = new Point(3, 583);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Padding = new Padding(5, 0, 0, 0);
            btnAyuda.Size = new Size(223, 52);
            btnAyuda.TabIndex = 30;
            btnAyuda.Text = "Ayuda";
            btnAyuda.UseVisualStyleBackColor = false;
            // 
            // transicionBarraLateral
            // 
            transicionBarraLateral.Interval = 10;
            transicionBarraLateral.Tick += transicionBarraLateral_Tick;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 236, 239);
            ClientSize = new Size(1713, 779);
            ControlBox = false;
            Controls.Add(pnlBarra);
            Controls.Add(flpBarraLateral);
            Controls.Add(pnlNotas);
            Controls.Add(btnSalir);
            Controls.Add(rgbCalendario);
            Controls.Add(rgbMenu);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmMenuPrincipal";
            Text = "Gestionis";
            Load += FrmMenuPrincipal_Load;
            pnlBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbSpain).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAyuda).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNotificaciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNoticias).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbTema).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEnglish).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHamburger).EndInit();
            rgbMenu.ResumeLayout(false);
            rgbMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGastosIngresos).EndInit();
            rgbCalendario.ResumeLayout(false);
            rgbCalendario.PerformLayout();
            pnlNotas.ResumeLayout(false);
            pnlNotas.PerformLayout();
            flpBarraLateral.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlBarra;
        private RoundGroupBox rgbMenu;
        private Button btnGasto;
        private Button btnIngreso;
        private DataGridView dgvGastosIngresos;
        private Label lblTotalValor;
        private Label lblGastosValor;
        private Label lblIngresosValor;
        private Label lblTotal;
        private Label lblGastos;
        private Label lblIngresos;
        private ComboBox cmbCategoria;
        private ComboBox cmbDinero;
        private ComboBox cmbTipo;
        private TextBox txtNombre;
        private RoundGroupBox rgbCalendario;
        private Label lblLinea;
        private Label lblLinea2;
        private Label lblLinea3;
        private Label label3;
        private Button btnSalir;
        private Panel pnlNotas;
        private PictureBox pbHamburger;
        private PictureBox pbUsuario;
        private PictureBox pbNotificaciones;
        private PictureBox pbNoticias;
        private PictureBox pbTema;
        private PictureBox pbEnglish;
        private PictureBox pbAyuda;
        private Label lblAdelante;
        private Label lblAtras;
        private Label lblMes;
        private Label lblNotas;
        private Label lblNotasValor;
        private PictureBox pbSpain;
        private FlowLayoutPanel flpBarraLateral;
        private System.Windows.Forms.Timer transicionBarraLateral;
        private Button btnInicio;
        private Button btnInversiones;
        private Button btnMetodoAhorro;
        private Button btnDeudas;
        private Button btnPatrimonio;
        private Button btnNotas;
        private Button btnTabalClasif;
        private Button btnHistorial;
        private Button btnNotificaciones;
        private Button btnPaginaWeb;
        private Button btnAyuda;
    }
}