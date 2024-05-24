using Gestionis.Clases;
using System.Globalization;

namespace Gestionis
{
    public partial class frmMetodosAhorro : FrmBarraPrincipal
    {
        private readonly Usuario usuario;
        private readonly Cuenta cuentaUsuario;
        #region Ayuda
        private ToolTip toolTip;
        private System.Windows.Forms.Timer tooltipTimer;
        private Queue<KeyValuePair<Control, string>> tooltipQueue;
        private int tooltipDuration = 2000;
        #endregion
        const double porcentajeNece = 50;
        const double porcentajePrescin = 30;
        const double porcentajeAhorro = 20;

        public frmMetodosAhorro()
        {
            InitializeComponent();
            ModificarBotones();
            usuario = Usuario.BuscaUsuario(Sesion.Instance.ApodoUsuario);
            cuentaUsuario = usuario.GetCuenta();
            #region Ayuda
            toolTip = new ToolTip();
            tooltipQueue = new Queue<KeyValuePair<Control, string>>();
            tooltipTimer = new System.Windows.Forms.Timer();
            tooltipTimer.Interval = tooltipDuration;
            tooltipTimer.Tick += TooltipTimer_Tick;
            #endregion
        }

        private void MetodosAhorro_Load(object sender, EventArgs e)
        {
            #region Iconos flechas / puntos

            pbDot.Image = Properties.Resources.check.ToBitmap();
            pbDot.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow2.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow2.SizeMode = PictureBoxSizeMode.StretchImage;

            pbDot2.Image = Properties.Resources.check.ToBitmap();
            pbDot2.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow4.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow4.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow5.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow5.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow6.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow6.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow7.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow7.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow8.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow8.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow9.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow9.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow10.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow10.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow11.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow11.SizeMode = PictureBoxSizeMode.StretchImage;

            #endregion

            if (Sesion.Instance.Espanyol) Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
            else Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            AplicarIdioma();

            barraSecundaria1.Load();
            barraLateral4.Load();

            try
            {
                lblIngresoMesCont.Text = cuentaUsuario.TotalIngresos().ToString("0.00") + " €";

                // Carga de info en dgv
                dgvGastosFijos.DataSource = Gasto.VisualizarDatosFijo();
                dgvGastosVariables.DataSource = Gasto.VisualizarDatosVariable();

                // Cálculo gastos totales
                double? gastoFij = Gasto.TotalFijos();
                lblTotalValorFijo.Text = gastoFij.HasValue ? gastoFij.Value.ToString("0.00") + " €" : "0" + " €";

                double? gastoVari = Gasto.TotalVariable();
                lblTotalValorVariables.Text = gastoVari.HasValue ? gastoVari.Value.ToString("0.00") + " €" : "0" + " €";
                lblDineroRest.Text = Gasto.DineroRestante(cuentaUsuario.TotalIngresos()).Value.ToString("0.00") + " €";

                // Cálculos porcentajes
                lblPorcentajeVariable.Text = Gasto.PorcentajeTotalVariable().ToString("0") + " %";
                lblPorcentajeFijo.Text = Gasto.PorcentajeTotalFijo().ToString("0") + " %";

                double? porcenRest = Gasto.PorcentajeRestante(cuentaUsuario.TotalIngresos());
                lblPorcentajeRest.Text = porcenRest.HasValue ? porcenRest.Value.ToString("0") + " %" : "0" + " %";

                // Carga de info del método ahorrativo 50/20/30
                M503020Porcentajes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConexionDB.CerrarConexion();
            }
        }

        private void ModificarBotones()
        {
            barraSecundaria1.BtnLanguage.Click += BtnLanguage_Click;
            barraSecundaria1.BtnAyuda.Click += BtnAyuda_Click;
        }

        private void BtnLanguage_Click(object sender, EventArgs e)
        {
            AplicarIdioma();
            barraLateral4.AplicarIdiomas();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Métodos de implementación
        private void M503020Porcentajes()
        {
            double? ingresoMensual = cuentaUsuario.TotalIngresos();

            // Dinero a gastar según el % del metodo 50/30/20
            double? basicaValor = Gasto.M503020Necesidades(ingresoMensual);
            lblNecBasicasValor.Text = basicaValor.HasValue ? basicaValor.Value.ToString("0.00") + " €" : "0" + " %";

            lblNecPresValor.Text = Gasto.M503020Presindibles(ingresoMensual).Value.ToString("0.00") + " €";
            lblAhoValor.Text = Gasto.M503020Ahorro(ingresoMensual).Value.ToString("0.00") + " €";

            // Totales
            lblGMNecValor.Text = Gasto.TotalNecesidades() + " €";
            lblGPresValor.Text = Gasto.TotalPrescindibles() + " €";
            lblAhorroDinValor.Text = Gasto.DineroRestante(ingresoMensual).Value.ToString("0.00") + " €";

            // Colores
            lblGMNecPorDin.ForeColor = Gasto.PorcentajeNec(ingresoMensual) > porcentajeNece ? Color.Red : Color.Green;
            lblGPPorDin.ForeColor = Gasto.PorcentajePrescin(ingresoMensual) > porcentajePrescin ? Color.Red : Color.Green;
            lblAhorroPorDin.ForeColor = Gasto.PorcentajeRestante(ingresoMensual) > porcentajeAhorro ? Color.Green : Color.Red;

            // Porcentajes
            double? porcentajeNec = Gasto.PorcentajeNec(ingresoMensual);
            lblGMNecPorDin.Text = porcentajeNec.HasValue ? porcentajeNec.Value.ToString("0") + " %" : "0" + " %";

            double? porcentajePres = Gasto.PorcentajePrescin(ingresoMensual);
            lblGPPorDin.Text = porcentajePres.HasValue ? porcentajePres.Value.ToString("0") + " %" : "0" + " %";
            lblAhorroPorDin.Text = (Gasto.PorcentajeRestante(ingresoMensual) ?? 0).ToString("0") + " %";
        }
        #endregion

        #region ToolTips
        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            if (Sesion.Instance.Espanyol)
            {
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(lblIngresoMesCont, "Ingresos mensuales."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(lblGastosFijos, "Muestra los gastos fijos totales."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(lblPorcentajeFijo, "Muestra el porcentaje total de los gastos fijos sobre el sueldo mensual."));

                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(lblGastosVariables, "Muestra los gastos variables totales."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(lblPorcentajeVariable, "Muestra el porcentaje total de los gastos variables sobre el sueldo mensual."));

                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(btn503020, "Método de ahorro 50/30/20."));

                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(lblNecBasicasValor, "En base a los ingresos mensuales, se saca el 50% dedicado a gastos necesarios"));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(lblGMNecPorDin, "Porcentaje en base al dinero dedicado a gastos necesarios y los gastos ya realizados."));

                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(lblNecPresValor, "En base a los ingresos mensuales, se saca el 30% dedicado a gastos prescindibles."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(lblGPPorDin, "Porcentaje en base al dinero dedicado a gastos prescindibles y los gastos ya realizados."));

                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(lblAhoValor, "En base a los ingresos mensuales, se dedica el 20% a ahorros."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(lblAhorroPorDin, "Porcentaje en base al dinero dedicado a ahorros y los ahorros ya realizados."));
            }
            else
            {
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(lblIngresoMesCont, "Monthly Income."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(lblGastosFijos, "Show total of fixed expenses"));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(lblPorcentajeFijo, "Show total percentage of fixed expenses over monthly salary."));

                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(lblGastosVariables, "Shows total variable expenses."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(lblPorcentajeVariable, "Shows the total percentage of variable expenses over monthly salary."));

                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(btn503020, "Saving method 50/30/20."));

                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(lblNecBasicasValor, "Based off monthly incomes, calculate 50% dedicated to necessary expenses"));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(lblGMNecPorDin, "Percentage based on money spent on expendable expenses and expenditures already made."));

                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(lblNecPresValor, "Based on monthly income, the 30% dedicated to expendable expenses is taken out.."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(lblGPPorDin, "Percentage based on money spent on expendable expenses and expenditures already made."));

                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(lblAhoValor, "Based on monthly income, 20% is dedicated to savings.."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(lblAhorroPorDin, "Percentage based on money spent on savings and savings already realized."));
            }

            SiguienteTooltip();
        }

        private void SiguienteTooltip()
        {
            if (tooltipQueue.Count > 0)
            {
                var tooltipItem = tooltipQueue.Dequeue();
                ShowTooltip(tooltipItem.Key, tooltipItem.Value);
                tooltipTimer.Start();
            }
            else
            {
                tooltipTimer.Stop();
            }
        }

        private void TooltipTimer_Tick(object sender, EventArgs e)
        {
            toolTip.Hide(this);
            SiguienteTooltip();
        }

        private void ShowTooltip(Control control, string message)
        {
            toolTip.SetToolTip(control, message);
            toolTip.Show(message, control, control.Width / 2, control.Height / 2);
        }
        #endregion

        private void AplicarIdioma()
        {
            lblIngresosMes.Text = Resources.Idiomas.StringRecursosAhorros.lblIngresosMes;
            lblGastosFijos.Text = Resources.Idiomas.StringRecursosAhorros.lblGastosFijos;
            lblGastosVariables.Text = Resources.Idiomas.StringRecursosAhorros.lblGastosVariables;
            lblDineroRestante.Text = Resources.Idiomas.StringRecursosAhorros.lblDineroRestante;
            btnPersonalizado.Text = Resources.Idiomas.StringRecursosAhorros.btnPersonalizado;
            btnSalir.Text = Resources.Idiomas.StringRecursosAhorros.btnSalir;
            lblPorcentajes.Text = Resources.Idiomas.StringRecursosAhorros.lblPorcentajes;
            lbl20PorCiento.Text = Resources.Idiomas.StringRecursosAhorros.lbl20PorCiento;
            lbl50PorCiento.Text = Resources.Idiomas.StringRecursosAhorros.lbl50PorCiento;
            lbl30PorCiento.Text = Resources.Idiomas.StringRecursosAhorros.lbl30PorCiento;
            lblGastadoMes.Text = Resources.Idiomas.StringRecursosAhorros.lblGastadoMes;
            lblGastadoMes2.Text = Resources.Idiomas.StringRecursosAhorros.lblGastadoMes2;
            lblDineroAhorrar.Text = Resources.Idiomas.StringRecursosAhorros.lblDineroAhorrar;
            lblInfo.Text = Resources.Idiomas.StringRecursosAhorros.lblInfo;
            lblInfo2.Text = Resources.Idiomas.StringRecursosAhorros.lblInfo2;
        }
    }
}
