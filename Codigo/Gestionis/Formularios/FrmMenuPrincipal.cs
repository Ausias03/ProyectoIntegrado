using Gestionis.Clases;
using Gestionis.Herramientas;
using System.Globalization;

namespace Gestionis
{
    public partial class FrmMenuPrincipal : FrmBarraPrincipal
    {
        private readonly Usuario usuario;
        private readonly Cuenta cuentaUsuario;

        #region Ayuda
        private ToolTip toolTip;
        private System.Windows.Forms.Timer tooltipTimer;
        private Queue<KeyValuePair<Control, string>> tooltipQueue;
        private int tooltipDuration = 2000;
        #endregion

        public FrmMenuPrincipal()
        {
            InitializeComponent();
            try
            {
                usuario = Usuario.BuscaUsuario(Sesion.Instance.ApodoUsuario);
                cuentaUsuario = usuario.GetCuenta();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                ConexionDB.CerrarConexion();
            }

            #region Ayuda
            toolTip = new ToolTip();
            tooltipQueue = new Queue<KeyValuePair<Control, string>>();
            tooltipTimer = new System.Windows.Forms.Timer();
            tooltipTimer.Interval = tooltipDuration;
            tooltipTimer.Tick += TooltipTimer_Tick;
            #endregion

            ModificarBotones();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            #region Botones
            btnIngreso.FlatStyle = FlatStyle.Flat;
            btnIngreso.FlatAppearance.BorderColor = Color.Black;
            btnIngreso.FlatAppearance.BorderSize = 2;

            btnGasto.FlatStyle = FlatStyle.Flat;
            btnGasto.FlatAppearance.BorderColor = Color.Black;
            btnGasto.FlatAppearance.BorderSize = 2;

            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.FlatAppearance.BorderColor = Color.Black;
            btnSalir.FlatAppearance.BorderSize = 2;

            #endregion

            try
            {
                barraSecundaria1.Load();
                barraLateral1.Load();
                if (Sesion.Instance.Espanyol) Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
                else Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                AplicarIdioma();
                cmbFiltroGastos.Items.AddRange(Gasto.DevuelveFiltros());
                cmbFiltroIngresos.Items.AddRange(Ingreso.DevuelveFiltros());
                EscondeFiltrosGasto();
                EscondeFiltrosIngreso();

                #region Labels
                RecargaLabelTotales();
                lblMes.Text = DateTime.Now.ToString("MMMM");
                lblNotasValor.Text = "";
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ConexionDB.CerrarConexion();
            }
        }

        private void ModificarBotones()
        {
            barraSecundaria1.BtnAyuda.Click += btnAyuda_Click;
            barraSecundaria1.BtnLanguage.Click += BtnLanguage_Click;
        }

        private void BtnLanguage_Click(object sender, EventArgs e)
        {
            AplicarIdioma();
            barraLateral1.AplicarIdiomas();
        }

        private void FrmMenuPrincipal_Activated(object sender, EventArgs e)
        {
            try
            {
                RecargaDGVGastos(cuentaUsuario.DevuelveGastos());
                RecargaDGVIngresos(cuentaUsuario.DevuelveIngresos());
                RecargaLabelTotales();

                #region Configurar ComboBoxes
                ConfigurarComboBox(cmbTipoGasto, Gasto.TiposGasto);
                ConfigurarComboBox(cmbCategoriaGasto, CategoriaGasto.DevuelveNombresCategorias());
                ConfigurarComboBox(cmbTipoIngreso, Ingreso.TiposIngreso);

                List<String> nombresCategorias = CategoriaIngreso.DevuelveNombresCategorias();
                // Añado un elemento a la lista, ya que puede haber gastos sin categoría asignada
                nombresCategorias.Add(String.Empty);
                ConfigurarComboBox(cmbCategoriaIngreso, nombresCategorias);
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ConexionDB.CerrarConexion();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGasto_Click(object sender, EventArgs e)
        {
            frmAnyadirGasto fAG = new frmAnyadirGasto();
            fAG.ShowDialog();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            frmAnyadirIngreso fAI = new frmAnyadirIngreso();
            fAI.ShowDialog();
        }

        private void pbHamburger_Click(object sender, EventArgs e)
        {
            BarraLateral.ColapsarExpandir();
        }

        private void btnFiltrarGastos_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cmbFiltroGastos.Text)
                {
                    case "Nombre":
                        RecargaDGVGastos(cuentaUsuario.DevuelveGastos(cmbFiltroGastos.Text, txtNombreGasto.Text));
                        break;
                    case "Cantidad":
                        RecargaDGVGastos(cuentaUsuario.DevuelveGastos(cmbFiltroGastos.Text, nudDineroGasto.Value));
                        break;
                    case "Categoria":
                        RecargaDGVGastos(cuentaUsuario.DevuelveGastos($"id{cmbFiltroGastos.Text}", CategoriaGasto.DevuelveIDCategoria(cmbCategoriaGasto.Text)));
                        break;
                    case "Tipo":
                        RecargaDGVGastos(cuentaUsuario.DevuelveGastos(cmbFiltroGastos.Text, cmbTipoGasto.Text));
                        break;
                    default:
                        RecargaDGVGastos(cuentaUsuario.DevuelveGastos());
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ConexionDB.CerrarConexion();
            }
        }

        private void btnRestablecerGastos_Click(object sender, EventArgs e)
        {
            try
            {
                RecargaDGVGastos(cuentaUsuario.DevuelveGastos());
                RestableceControlesGasto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ConexionDB.CerrarConexion();
            }
        }

        private void btnFiltrarIngresos_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cmbFiltroIngresos.Text)
                {
                    case "Nombre":
                        RecargaDGVIngresos(cuentaUsuario.DevuelveIngresos(cmbFiltroIngresos.Text, txtNombreIngreso.Text));
                        break;
                    case "Cantidad":
                        RecargaDGVIngresos(cuentaUsuario.DevuelveIngresos(cmbFiltroIngresos.Text, nudDineroIngreso.Value));
                        break;
                    case "Categoria":
                        RecargaDGVIngresos(cuentaUsuario.DevuelveIngresos($"id{cmbFiltroIngresos.Text}", CategoriaIngreso.DevuelveIDCategoria(cmbCategoriaIngreso.Text)));
                        break;
                    case "Tipo":
                        RecargaDGVIngresos(cuentaUsuario.DevuelveIngresos(cmbFiltroIngresos.Text, cmbTipoIngreso.Text));
                        break;
                    default:
                        RecargaDGVIngresos(cuentaUsuario.DevuelveIngresos());
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ConexionDB.CerrarConexion();
            }
        }

        private void btnRestablecerIngresos_Click(object sender, EventArgs e)
        {
            try
            {
                RecargaDGVIngresos(cuentaUsuario.DevuelveIngresos());
                RestableceControlesIngreso();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ConexionDB.CerrarConexion();
            }
        }

        private void dgvGastos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex == -1))
            {
                DialogResult eliminar = MessageBox.Show("Quieres eliminar el gasto seleccionado?", "Eliminar Gasto"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (eliminar == DialogResult.Yes)
                {
                    try
                    {
                        int idGasto = (int)dgvGastos.Rows[e.RowIndex].Cells[0].Value;
                        int idCategoria = CategoriaGasto.DevuelveIDCategoria(dgvGastos.Rows[e.RowIndex].Cells[3].Value?.ToString());
                        cuentaUsuario.EliminaGasto(idGasto);
                        cuentaUsuario.EliminaNotificacion(idCategoria);
                        RecargaDGVGastos(cuentaUsuario.DevuelveGastos());
                        RecargaLabelTotales();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        ConexionDB.CerrarConexion();
                    }
                }
            }
        }

        private void dgvIngresos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex == -1))
            {
                DialogResult eliminar = MessageBox.Show("Quieres eliminar el Ingreso seleccionado?", "Eliminar Ingreso"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (eliminar == DialogResult.Yes)
                {
                    try
                    {
                        int idIngreso = (int)dgvIngresos.Rows[e.RowIndex].Cells[0].Value;
                        cuentaUsuario.EliminaIngreso(idIngreso);
                        RecargaDGVIngresos(cuentaUsuario.DevuelveIngresos());
                        RecargaLabelTotales();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        ConexionDB.CerrarConexion();
                    }
                }
            }
        }

        #region Métodos de Implementación
        private void ConfigurarComboBox(ComboBox comboBox, List<String> dataSource)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataSource;
            comboBox.DataSource = bs;
        }

        private void RecargaDGVGastos(List<Gasto> gastos)
        {
            dgvGastos.DataSource = gastos;
        }

        private void RecargaDGVIngresos(List<Ingreso> ingresos)
        {
            dgvIngresos.DataSource = ingresos;
        }

        private void RestableceControlesGasto()
        {
            txtNombreGasto.Text = String.Empty;
            cmbTipoGasto.SelectedIndex = 0;
            nudDineroGasto.Value = 0;
            cmbCategoriaGasto.SelectedIndex = 0;
        }

        private void RestableceControlesIngreso()
        {
            txtNombreIngreso.Text = String.Empty;
            cmbTipoIngreso.SelectedIndex = 0;
            nudDineroIngreso.Value = 0;
            cmbCategoriaIngreso.SelectedIndex = 0;
        }

        private void RecargaLabelTotales()
        {
            lblIngresosValor.Text = cuentaUsuario.TotalIngresos().ToString("0.00") + " €";
            lblGastosValor.Text = cuentaUsuario.TotalGastos().ToString("0.00") + " €";
            lblTotalValor.Text = cuentaUsuario.DineroTotal().ToString("0.00") + " €";
        }
        #endregion

        #region Idiomas
        private void AplicarIdioma()
        {
            lblFiltrarPorIng.Text = Resources.Idiomas.StringRecursosMenu.lblFiltrarPor;
            lblFiltrarPorGas.Text = Resources.Idiomas.StringRecursosMenu.lblFiltrarPor;
            lblDCIng.Text = Resources.Idiomas.StringRecursosMenu.lblDCIngreso;
            lblDCGas.Text = Resources.Idiomas.StringRecursosMenu.lblDCGasto;
            btnRestablecerIngresos.Text = Resources.Idiomas.StringRecursosMenu.btnRestablecer;
            btnRestablecerGastos.Text = Resources.Idiomas.StringRecursosMenu.btnRestablecer;
            btnFiltrarIngresos.Text = Resources.Idiomas.StringRecursosMenu.btnFiltrar;
            btnFiltrarGastos.Text = Resources.Idiomas.StringRecursosMenu.btnFiltrar;
            lblTotal.Text = Resources.Idiomas.StringRecursosMenu.lblTotal;
            lblGastos.Text = Resources.Idiomas.StringRecursosMenu.lblGastos;
            lblIngresos.Text = Resources.Idiomas.StringRecursosMenu.lblIngresos;
            btnGasto.Text = Resources.Idiomas.StringRecursosMenu.btnGasto;
            btnIngreso.Text = Resources.Idiomas.StringRecursosMenu.btnIngreso;
            lblNotas.Text = Resources.Idiomas.StringRecursosMenu.lblNotas;
            btnSalir.Text = Resources.Idiomas.StringRecursosMenu.btnSalir;
            lblMes.Text = Resources.Idiomas.StringRecursosMenu.lblMes;
        }
        #endregion

        #region CMBs y controles Filtros
        private void cmbFiltroGastos_SelectedIndexChanged(object sender, EventArgs e)
        {
            EscondeFiltrosGasto();
            switch (cmbFiltroGastos.Text)
            {
                case "Nombre":
                    txtNombreGasto.Visible = true;
                    break;
                case "Cantidad":
                    nudDineroGasto.Visible = true;
                    break;
                case "Categoria":
                    cmbCategoriaGasto.Visible = true;
                    break;
                case "Tipo":
                    cmbTipoGasto.Visible = true;
                    break;
            }
        }

        private void cmbFiltroIngresos_SelectedIndexChanged(object sender, EventArgs e)
        {
            EscondeFiltrosIngreso();
            switch (cmbFiltroIngresos.Text)
            {
                case "Nombre":
                    txtNombreIngreso.Visible = true;
                    break;
                case "Cantidad":
                    nudDineroIngreso.Visible = true;
                    break;
                case "Categoria":
                    cmbCategoriaIngreso.Visible = true;
                    break;
                case "Tipo":
                    cmbTipoIngreso.Visible = true;
                    break;
            }
        }

        private void EscondeFiltrosGasto()
        {
            txtNombreGasto.Visible = false;
            nudDineroGasto.Visible = false;
            cmbCategoriaGasto.Visible = false;
            cmbTipoGasto.Visible = false;
        }

        private void EscondeFiltrosIngreso()
        {
            txtNombreIngreso.Visible = false;
            nudDineroIngreso.Visible = false;
            cmbCategoriaIngreso.Visible = false;
            cmbTipoIngreso.Visible = false;
        }
        #endregion

        #region ToolTips
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            if (Sesion.Instance.Espanyol)
            {
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(btnGasto, "Añadir un nuevo gasto."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(btnIngreso, "Añadir un nuevo ingreso."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(cmbFiltroGastos, "Filtra gastos por nombre, tipo, monto o categoría."));

                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(cmbFiltroIngresos, "Filtra ingresos por nombre, tipo, monto o categoría."));

                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(btnRestablecerGastos, "Restablecer la lista de gastos."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(btnFiltrarIngresos, "Filtrar los ingresos según los criterios seleccionados."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(btnRestablecerIngresos, "Restablecer la lista de ingresos."));

                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(lblIngresosValor, "Muestra el total de ingresos."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(lblGastosValor, "Muestra el total de gastos."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(lblTotalValor, "Muestra el total de dinero disponible."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(btnSalir, "Salir de la aplicación."));
            }
            else
            {
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(btnGasto, "Add new expense."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(btnIngreso, "Add new income."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(cmbFiltroGastos, "Filter expenses by name, type, amount or category."));

                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(cmbFiltroIngresos, "Filter incomes by name, type, amount or category."));

                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(btnRestablecerGastos, "Restablish expenses' list."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(btnFiltrarIngresos, "Filter incomes by the chosen criteria."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(btnRestablecerIngresos, "Restablish incomes' list."));

                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(lblIngresosValor, "Show total income."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(lblGastosValor, "Show total expenses."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(lblTotalValor, "Show avaliable money."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(btnSalir, "Exit the app."));
            }

            ShowNextTooltip();
        }

        private void ShowNextTooltip()
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
            ShowNextTooltip();
        }

        private void ShowTooltip(Control control, string message)
        {
            toolTip.SetToolTip(control, message);
            toolTip.Show(message, control, control.Width / 2, control.Height / 2);
        }
        #endregion
    }
}
