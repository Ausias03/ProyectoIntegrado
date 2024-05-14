namespace ProyectoIntegrado
{
    partial class frmGestionDeudas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grbContenedor = new System.Windows.Forms.GroupBox();
            this.lblDeudasTotalesCont = new System.Windows.Forms.Label();
            this.grbVisualDeudas = new System.Windows.Forms.GroupBox();
            this.lblTipoCont = new System.Windows.Forms.Label();
            this.lblFechaLimiteCont = new System.Windows.Forms.Label();
            this.lblProximaDeudaCont = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLinea1 = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblFechaLimite = new System.Windows.Forms.Label();
            this.lblProximaDeuda = new System.Windows.Forms.Label();
            this.lblDeudasLinea = new System.Windows.Forms.Label();
            this.lblDeudasTotales = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbFiltrar = new System.Windows.Forms.ComboBox();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminarDeuda = new System.Windows.Forms.Button();
            this.btnNuevaDeuda = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnActualizarDato = new System.Windows.Forms.Button();
            this.grbContenedor.SuspendLayout();
            this.grbVisualDeudas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbContenedor
            // 
            this.grbContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(213)))), ((int)(((byte)(221)))));
            this.grbContenedor.Controls.Add(this.lblDeudasTotalesCont);
            this.grbContenedor.Controls.Add(this.grbVisualDeudas);
            this.grbContenedor.Controls.Add(this.lblDeudasLinea);
            this.grbContenedor.Controls.Add(this.lblDeudasTotales);
            this.grbContenedor.Controls.Add(this.dataGridView1);
            this.grbContenedor.Controls.Add(this.cmbFiltrar);
            this.grbContenedor.Controls.Add(this.btnRestaurar);
            this.grbContenedor.Controls.Add(this.btnBuscar);
            this.grbContenedor.Controls.Add(this.btnEliminarDeuda);
            this.grbContenedor.Controls.Add(this.btnNuevaDeuda);
            this.grbContenedor.Location = new System.Drawing.Point(102, 41);
            this.grbContenedor.Name = "grbContenedor";
            this.grbContenedor.Size = new System.Drawing.Size(687, 537);
            this.grbContenedor.TabIndex = 0;
            this.grbContenedor.TabStop = false;
            // 
            // lblDeudasTotalesCont
            // 
            this.lblDeudasTotalesCont.AutoSize = true;
            this.lblDeudasTotalesCont.BackColor = System.Drawing.Color.Transparent;
            this.lblDeudasTotalesCont.Location = new System.Drawing.Point(154, 503);
            this.lblDeudasTotalesCont.Name = "lblDeudasTotalesCont";
            this.lblDeudasTotalesCont.Size = new System.Drawing.Size(32, 16);
            this.lblDeudasTotalesCont.TabIndex = 9;
            this.lblDeudasTotalesCont.Text = "cont";
            // 
            // grbVisualDeudas
            // 
            this.grbVisualDeudas.Controls.Add(this.lblTipoCont);
            this.grbVisualDeudas.Controls.Add(this.lblFechaLimiteCont);
            this.grbVisualDeudas.Controls.Add(this.lblProximaDeudaCont);
            this.grbVisualDeudas.Controls.Add(this.label2);
            this.grbVisualDeudas.Controls.Add(this.label1);
            this.grbVisualDeudas.Controls.Add(this.lblLinea1);
            this.grbVisualDeudas.Controls.Add(this.lblTipo);
            this.grbVisualDeudas.Controls.Add(this.lblFechaLimite);
            this.grbVisualDeudas.Controls.Add(this.lblProximaDeuda);
            this.grbVisualDeudas.Location = new System.Drawing.Point(305, 74);
            this.grbVisualDeudas.Name = "grbVisualDeudas";
            this.grbVisualDeudas.Size = new System.Drawing.Size(273, 107);
            this.grbVisualDeudas.TabIndex = 8;
            this.grbVisualDeudas.TabStop = false;
            // 
            // lblTipoCont
            // 
            this.lblTipoCont.AutoSize = true;
            this.lblTipoCont.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoCont.Location = new System.Drawing.Point(167, 65);
            this.lblTipoCont.Name = "lblTipoCont";
            this.lblTipoCont.Size = new System.Drawing.Size(32, 16);
            this.lblTipoCont.TabIndex = 8;
            this.lblTipoCont.Text = "cont";
            // 
            // lblFechaLimiteCont
            // 
            this.lblFechaLimiteCont.AutoSize = true;
            this.lblFechaLimiteCont.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaLimiteCont.Location = new System.Drawing.Point(167, 42);
            this.lblFechaLimiteCont.Name = "lblFechaLimiteCont";
            this.lblFechaLimiteCont.Size = new System.Drawing.Size(32, 16);
            this.lblFechaLimiteCont.TabIndex = 7;
            this.lblFechaLimiteCont.Text = "cont";
            // 
            // lblProximaDeudaCont
            // 
            this.lblProximaDeudaCont.AutoSize = true;
            this.lblProximaDeudaCont.BackColor = System.Drawing.Color.Transparent;
            this.lblProximaDeudaCont.Location = new System.Drawing.Point(167, 16);
            this.lblProximaDeudaCont.Name = "lblProximaDeudaCont";
            this.lblProximaDeudaCont.Size = new System.Drawing.Size(32, 16);
            this.lblProximaDeudaCont.TabIndex = 6;
            this.lblProximaDeudaCont.Text = "cont";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "____________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "________________";
            // 
            // lblLinea1
            // 
            this.lblLinea1.AutoSize = true;
            this.lblLinea1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinea1.Location = new System.Drawing.Point(135, 18);
            this.lblLinea1.Name = "lblLinea1";
            this.lblLinea1.Size = new System.Drawing.Size(105, 16);
            this.lblLinea1.TabIndex = 3;
            this.lblLinea1.Text = "______________";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(23, 67);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(52, 16);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "lblTipo:";
            // 
            // lblFechaLimite
            // 
            this.lblFechaLimite.AutoSize = true;
            this.lblFechaLimite.Location = new System.Drawing.Point(23, 44);
            this.lblFechaLimite.Name = "lblFechaLimite";
            this.lblFechaLimite.Size = new System.Drawing.Size(89, 16);
            this.lblFechaLimite.TabIndex = 1;
            this.lblFechaLimite.Text = "Fecha Límite: ";
            // 
            // lblProximaDeuda
            // 
            this.lblProximaDeuda.AutoSize = true;
            this.lblProximaDeuda.Location = new System.Drawing.Point(23, 18);
            this.lblProximaDeuda.Name = "lblProximaDeuda";
            this.lblProximaDeuda.Size = new System.Drawing.Size(106, 16);
            this.lblProximaDeuda.TabIndex = 0;
            this.lblProximaDeuda.Text = "Próxima Deuda: ";
            // 
            // lblDeudasLinea
            // 
            this.lblDeudasLinea.AutoSize = true;
            this.lblDeudasLinea.Location = new System.Drawing.Point(151, 505);
            this.lblDeudasLinea.Name = "lblDeudasLinea";
            this.lblDeudasLinea.Size = new System.Drawing.Size(35, 16);
            this.lblDeudasLinea.TabIndex = 7;
            this.lblDeudasLinea.Text = "____";
            // 
            // lblDeudasTotales
            // 
            this.lblDeudasTotales.AutoSize = true;
            this.lblDeudasTotales.Location = new System.Drawing.Point(44, 505);
            this.lblDeudasTotales.Name = "lblDeudasTotales";
            this.lblDeudasTotales.Size = new System.Drawing.Size(101, 16);
            this.lblDeudasTotales.TabIndex = 6;
            this.lblDeudasTotales.Text = "Deudas totales:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 315);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(531, 174);
            this.dataGridView1.TabIndex = 5;
            // 
            // cmbFiltrar
            // 
            this.cmbFiltrar.FormattingEnabled = true;
            this.cmbFiltrar.Location = new System.Drawing.Point(217, 265);
            this.cmbFiltrar.Name = "cmbFiltrar";
            this.cmbFiltrar.Size = new System.Drawing.Size(161, 24);
            this.cmbFiltrar.TabIndex = 4;
            this.cmbFiltrar.Text = "Filtrar Por";
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(242)))), ((int)(((byte)(187)))));
            this.btnRestaurar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Location = new System.Drawing.Point(399, 263);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(136, 27);
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.Text = "Restaurar";
            this.btnRestaurar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(242)))), ((int)(((byte)(187)))));
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(60, 263);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(136, 27);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnEliminarDeuda
            // 
            this.btnEliminarDeuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(242)))), ((int)(((byte)(187)))));
            this.btnEliminarDeuda.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarDeuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarDeuda.Location = new System.Drawing.Point(60, 141);
            this.btnEliminarDeuda.Name = "btnEliminarDeuda";
            this.btnEliminarDeuda.Size = new System.Drawing.Size(136, 40);
            this.btnEliminarDeuda.TabIndex = 1;
            this.btnEliminarDeuda.Text = "Eliminar deuda";
            this.btnEliminarDeuda.UseVisualStyleBackColor = false;
            // 
            // btnNuevaDeuda
            // 
            this.btnNuevaDeuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(242)))), ((int)(((byte)(187)))));
            this.btnNuevaDeuda.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNuevaDeuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaDeuda.Location = new System.Drawing.Point(60, 74);
            this.btnNuevaDeuda.Name = "btnNuevaDeuda";
            this.btnNuevaDeuda.Size = new System.Drawing.Size(136, 40);
            this.btnNuevaDeuda.TabIndex = 0;
            this.btnNuevaDeuda.Text = "Añadir deuda";
            this.btnNuevaDeuda.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(242)))), ((int)(((byte)(187)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1024, 551);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(817, 131);
            this.chart1.Name = "chart1";
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series3.BorderColor = System.Drawing.Color.Transparent;
            series3.ChartArea = "ChartArea1";
            series3.EmptyPointStyle.LabelForeColor = System.Drawing.Color.BlanchedAlmond;
            series3.Legend = "Legend1";
            series3.LegendText = "Me deben";
            series3.MarkerSize = 0;
            series3.Name = "Medeben";
            series3.XValueMember = "0";
            series3.YValueMembers = "0";
            series4.BorderColor = System.Drawing.Color.Transparent;
            series4.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.LegendText = "Debo";
            series4.MarkerSize = 3;
            series4.Name = "Debo";
            series4.XValueMember = "2";
            series4.YValueMembers = "2";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // btnActualizarDato
            // 
            this.btnActualizarDato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(242)))), ((int)(((byte)(187)))));
            this.btnActualizarDato.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnActualizarDato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarDato.Location = new System.Drawing.Point(981, 98);
            this.btnActualizarDato.Name = "btnActualizarDato";
            this.btnActualizarDato.Size = new System.Drawing.Size(136, 27);
            this.btnActualizarDato.TabIndex = 6;
            this.btnActualizarDato.Text = "Actualizar Datos";
            this.btnActualizarDato.UseVisualStyleBackColor = false;
            this.btnActualizarDato.Click += new System.EventHandler(this.btnActualizarDato_Click);
            // 
            // frmGestionDeudas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1145, 590);
            this.Controls.Add(this.btnActualizarDato);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grbContenedor);
            this.Name = "frmGestionDeudas";
            this.Text = "Gestion de Deudas";
            this.grbContenedor.ResumeLayout(false);
            this.grbContenedor.PerformLayout();
            this.grbVisualDeudas.ResumeLayout(false);
            this.grbVisualDeudas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbContenedor;
        private System.Windows.Forms.Button btnNuevaDeuda;
        private System.Windows.Forms.Button btnEliminarDeuda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.ComboBox cmbFiltrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblDeudasTotales;
        private System.Windows.Forms.Label lblDeudasLinea;
        private System.Windows.Forms.GroupBox grbVisualDeudas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblLinea1;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblFechaLimite;
        private System.Windows.Forms.Label lblProximaDeuda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProximaDeudaCont;
        private System.Windows.Forms.Label lblTipoCont;
        private System.Windows.Forms.Label lblFechaLimiteCont;
        private System.Windows.Forms.Label lblDeudasTotalesCont;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnActualizarDato;
    }
}

