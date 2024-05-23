using Gestionis.Clases;
using Gestionis.Formularios;
using System.Globalization;

namespace Gestionis
{
    public partial class FrmGestorDeudas : FrmBarraPrincipal
    {
        private ToolTip toolTip;
        private System.Windows.Forms.Timer tooltipTimer;
        private Queue<KeyValuePair<Control, string>> tooltipQueue;
        private int tooltipDuration = 2000;
        private readonly Usuario usuario;
        private readonly Cuenta cuentaUsuario;

        public FrmGestorDeudas()
        {
            InitializeComponent();
            ModificarBotones();
            toolTip = new ToolTip();
            tooltipQueue = new Queue<KeyValuePair<Control, string>>();
            tooltipTimer = new System.Windows.Forms.Timer();
            tooltipTimer.Interval = tooltipDuration;
            tooltipTimer.Tick += TooltipTimer_Tick;
            usuario = Usuario.BuscaUsuario(Sesion.Instance.ApodoUsuario);
            cuentaUsuario = usuario.GetCuenta();
        }

        private void FrmGestorDeudas_Load(object sender, EventArgs e)
        {
            #region Botones
            btnAnyadirDeuda.FlatStyle = FlatStyle.Flat;
            btnAnyadirDeuda.FlatAppearance.BorderColor = Color.Black;
            btnAnyadirDeuda.FlatAppearance.BorderSize = 2;

            btnEliminarDeuda.FlatStyle = FlatStyle.Flat;
            btnEliminarDeuda.FlatAppearance.BorderColor = Color.Black;
            btnEliminarDeuda.FlatAppearance.BorderSize = 2;

            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.FlatAppearance.BorderColor = Color.Black;
            btnBuscar.FlatAppearance.BorderSize = 2;

            btnRestaurar.FlatStyle = FlatStyle.Flat;
            btnRestaurar.FlatAppearance.BorderColor = Color.Black;
            btnRestaurar.FlatAppearance.BorderSize = 2;
            #endregion

            if (Sesion.Instance.Espanyol) Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
            else Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            AplicarIdioma();

            try
            {
                lblSaldoValor.Text = cuentaUsuario.DineroTotal().ToString("0.00") + " €";

                cmbCategoria.DataSource = Deuda.Filtros();
                cmbCategoria.SelectedIndex = 0;

                SetGrafico();
                vpbDebo.ForeColor = Color.IndianRed;
                Titulo();

                lblDeudasTotalesValor.Text = Deuda.DeudasTotales().ToString();
                ProximaDeuda();

                dgvGastosIngresos.DataSource = Deuda.RecargarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            barraSecundaria.Load();
            barraLateral2.Load();
        }

        private void ModificarBotones()
        {
            barraSecundaria.BtnAyuda.Click += BtnAyuda_Click;
            barraSecundaria.BtnLanguage.Click += BtnLanguage_Click;
        }
        private void BtnLanguage_Click(object sender, EventArgs e)
        {
            try
            {
                AplicarIdioma();
                barraLateral1.AplicarIdiomas();
                cmbCategoria.DataSource = Deuda.Filtros();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region ToolTips
        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            tooltipQueue.Enqueue(new KeyValuePair<Control, string>(btnAnyadirDeuda, "Añadir una nueva deuda."));
            tooltipQueue.Enqueue(new KeyValuePair<Control, string>(btnEliminarDeuda, "Eliminar una deuda existente."));
            tooltipQueue.Enqueue(new KeyValuePair<Control, string>(btnBuscar, "Buscar deudas según los filtros seleccionados."));
            tooltipQueue.Enqueue(new KeyValuePair<Control, string>(btnRestaurar, "Restaurar la tabla de deudas."));
            tooltipQueue.Enqueue(new KeyValuePair<Control, string>(cmbCategoria, "Seleccionar una categoría de deuda."));
            tooltipQueue.Enqueue(new KeyValuePair<Control, string>(txtTitulo, "Escribir el título de la deuda a buscar."));
            tooltipQueue.Enqueue(new KeyValuePair<Control, string>(chkDebo, "Marcar si se deben mostrar solo las deudas que debes."));
            tooltipQueue.Enqueue(new KeyValuePair<Control, string>(lblDeudasTotalesValor, "Muestra el total de deudas."));
            tooltipQueue.Enqueue(new KeyValuePair<Control, string>(lblProximaDeudaValor, "Muestra la próxima deuda."));
            tooltipQueue.Enqueue(new KeyValuePair<Control, string>(lblFechaLimiteValor, "Muestra la fecha límite de la próxima deuda."));
            tooltipQueue.Enqueue(new KeyValuePair<Control, string>(lblTipoValor, "Indica si debes o te deben."));
            tooltipQueue.Enqueue(new KeyValuePair<Control, string>(vpbDebo, "Progreso de las deudas que debes."));
            tooltipQueue.Enqueue(new KeyValuePair<Control, string>(vpbMeDeben, "Progreso de las deudas que te deben."));

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

        private void Titulo()
        {
            if (cmbCategoria.SelectedIndex == 0)
            {
                lblTitulo.Visible = true;
                txtTitulo.Visible = true;
            }
            else
            {
                txtTitulo.Clear();
                lblTitulo.Visible = false;
                txtTitulo.Visible = false;
            }
        }
        private void ProximaDeuda()
        {
            try
            {
                Deuda deuda = new Deuda();
                deuda.GetProximaDeuda(deuda);

                if (deuda.Titulo != null)
                {
                    lblProximaDeudaValor.Text = deuda.Titulo.ToString();
                    lblFechaLimiteValor.Text = deuda.FechaVencimiento.ToShortDateString();
                    if (deuda.Debo) lblTipoValor.Text = "Debo"; else lblTipoValor.Text = "Me deben";
                }
                else
                {
                    lblProximaDeudaValor.Text = string.Empty;
                    lblFechaLimiteValor.Text = string.Empty;
                    lblTipoValor.Text = string.Empty;
                }
                SetGrafico();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAnyadirDeuda_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAnyadirDeuda frmAnyadirDeuda = new FrmAnyadirDeuda();
                frmAnyadirDeuda.ShowDialog();
                lblDeudasTotalesValor.Text = Deuda.DeudasTotales().ToString();
                ProximaDeuda();
                dgvGastosIngresos.DataSource = Deuda.RecargarTabla(chkDebo.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarDeuda_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEliminarDeuda frmEliminarDeuda = new FrmEliminarDeuda();
                frmEliminarDeuda.ShowDialog();
                lblDeudasTotalesValor.Text = Deuda.DeudasTotales().ToString();
                ProximaDeuda();
                dgvGastosIngresos.DataSource = Deuda.RecargarTabla(chkDebo.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategoria.SelectedIndex == 0 && txtTitulo.Text == "")
                {
                    MessageBox.Show("Introduce el título de la deuda!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dgvGastosIngresos.DataSource = Deuda.CargarFiltro(cmbCategoria.Text, chkDebo.Checked, txtTitulo.Text);
                    Titulo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            Titulo();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvGastosIngresos.DataSource = Deuda.RecargarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chkDebo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dgvGastosIngresos.DataSource = Deuda.RecargarTabla(chkDebo.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetGrafico()
        {
            try
            {
                double debo = Deuda.CalcularTotalDeuda(true), meDeben = Deuda.CalcularTotalDeuda(false);

                int valorMax = Utilidades.ProgramarGrafico(debo, meDeben);
                vpbDebo.Maximum = valorMax;
                vpbMeDeben.Maximum = valorMax;

                vpbDebo.Value = (int)debo;
                vpbMeDeben.Value = (int)meDeben;

                lblDeboTotal.Text = debo.ToString("0.00") + " €";
                lblMeDebenTotal.Text = meDeben.ToString("0.00") + " €";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AplicarIdioma()
        {
            lblDeboBarra.Text = Resources.Idiomas.StringRecursosGestor.lblDeboBarra;
            lblDeudasTotales.Text = Resources.Idiomas.StringRecursosGestor.lblDeudasTotales;
            lblFechaLimite.Text = Resources.Idiomas.StringRecursosGestor.lblFechaLimite;
            lblMeDeben.Text = Resources.Idiomas.StringRecursosGestor.lblMeDeben;
            lblProximaDeuda.Text = Resources.Idiomas.StringRecursosGestor.lblProximaDeuda;
            lblResumen.Text = Resources.Idiomas.StringRecursosGestor.lblResumen;
            lblSaldo.Text = Resources.Idiomas.StringRecursosGestor.lblSaldo;
            lblTipo.Text = Resources.Idiomas.StringRecursosGestor.lblTipo;
            lblTitulo.Text = Resources.Idiomas.StringRecursosGestor.lblTitulo;
            btnAnyadirDeuda.Text = Resources.Idiomas.StringRecursosGestor.btnAnyadirDeuda;
            btnBuscar.Text = Resources.Idiomas.StringRecursosGestor.btnBuscar;
            btnEliminarDeuda.Text = Resources.Idiomas.StringRecursosGestor.btnEliminarDeuda;
            btnRestaurar.Text = Resources.Idiomas.StringRecursosGestor.btnRestaurar;
            chkDebo.Text = Resources.Idiomas.StringRecursosGestor.chkDebo;
        }
    }
}
