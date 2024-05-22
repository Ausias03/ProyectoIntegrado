using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Gestionis.Clases;
using Gestionis.Herramientas;

namespace Gestionis
{
    public partial class FrmMenuPrincipal : FrmBarraPrincipal
    {
        private readonly Usuario usuario;
        private readonly Cuenta cuentaUsuario;
        private ToolTip toolTip;
        private System.Windows.Forms.Timer tooltipTimer;
        private Queue<KeyValuePair<Control, string>> tooltipQueue;
        private int tooltipDuration = 2000;

        public FrmMenuPrincipal()
        {
            InitializeComponent();
            usuario = Usuario.BuscaUsuario(Sesion.Instance.ApodoUsuario);
            cuentaUsuario = usuario.GetCuenta();
            toolTip = new ToolTip(); 
            tooltipQueue = new Queue<KeyValuePair<Control, string>>();
            tooltipTimer = new System.Windows.Forms.Timer();
            tooltipTimer.Interval = tooltipDuration;
            tooltipTimer.Tick += TooltipTimer_Tick;
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

            barraSecundaria1.Load();
            barraLateral1.Load();

            #region Labels
            RecargaLabelTotales();
            lblMes.Text = DateTime.Now.ToString("MMMM");
            lblNotasValor.Text = "";
            #endregion
        }

        private void FrmMenuPrincipal_Activated(object sender, EventArgs e)
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

        private void btnFiltrarGastos_Click(object sender, EventArgs e)
        {
            RecargaDGVGastos(cuentaUsuario.DevuelveGastos(txtNombreGasto.Text, cmbTipoGasto.Text, nudDineroGasto.Value, cmbCategoriaGasto.Text));
        }

        private void btnRestablecerGastos_Click(object sender, EventArgs e)
        {
            RecargaDGVGastos(cuentaUsuario.DevuelveGastos());
            RestableceControlesGasto();
        }

        private void btnFiltrarIngresos_Click(object sender, EventArgs e)
        {
            RecargaDGVIngresos(cuentaUsuario.DevuelveIngresos(txtNombreIngreso.Text, cmbTipoIngreso.Text, nudDineroIngreso.Value, cmbCategoriaIngreso.Text));
        }

        private void btnRestablecerIngresos_Click(object sender, EventArgs e)
        {
            RecargaDGVIngresos(cuentaUsuario.DevuelveIngresos());
            RestableceControlesIngreso();
        }

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
            lblIngresosValor.Text = cuentaUsuario.TotalIngresos().ToString() + " €";
            lblGastosValor.Text = cuentaUsuario.TotalGastos().ToString() + " €";
            lblTotalValor.Text = cuentaUsuario.DineroTotal().ToString() + " €";
        }

        private void ModificarBotones()
        {
            barraSecundaria1.BtnAyuda.Click += btnAyuda_Click;
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            tooltipQueue.Enqueue(new KeyValuePair<Control, string>(btnGasto, "Añadir un nuevo gasto."));
            tooltipQueue.Enqueue(new KeyValuePair<Control, string>(btnIngreso, "Añadir un nuevo ingreso."));
            tooltipQueue.Enqueue(new KeyValuePair<Control, string>(txtNombreGasto, "Escribir el nombre del gasto."));
            tooltipQueue.Enqueue(new KeyValuePair<Control, string>(cmbTipoGasto, "Seleccionar el tipo de gasto."));
            tooltipQueue.Enqueue(new KeyValuePair<Control, string>(nudDineroGasto, "Indicar el monto del gasto."));
            tooltipQueue.Enqueue(new KeyValuePair<Control, string>(cmbCategoriaGasto, "Seleccionar la categoría del gasto."));
            
            tooltipQueue.Enqueue(new KeyValuePair<Control, string>(txtNombreIngreso, "Escribir el nombre del ingreso."));
            tooltipQueue.Enqueue(new KeyValuePair<Control, string>(cmbTipoIngreso, "Seleccionar el tipo de ingreso."));
            tooltipQueue.Enqueue(new KeyValuePair<Control, string>(nudDineroIngreso, "Indicar el monto del ingreso."));
            tooltipQueue.Enqueue(new KeyValuePair<Control, string>(cmbCategoriaIngreso, "Seleccionar la categoría del ingreso."));            
            tooltipQueue.Enqueue(new KeyValuePair<Control, string>(btnFiltrarGastos, "Filtrar los gastos según los criterios seleccionados."));
            
            tooltipQueue.Enqueue(new KeyValuePair<Control, string>(btnRestablecerGastos, "Restablecer la lista de gastos."));
            tooltipQueue.Enqueue(new KeyValuePair<Control, string>(btnFiltrarIngresos, "Filtrar los ingresos según los criterios seleccionados."));
            tooltipQueue.Enqueue(new KeyValuePair<Control, string>(btnRestablecerIngresos, "Restablecer la lista de ingresos."));
            
            tooltipQueue.Enqueue(new KeyValuePair<Control, string>(lblIngresosValor, "Muestra el total de ingresos."));
            tooltipQueue.Enqueue(new KeyValuePair<Control, string>(lblGastosValor, "Muestra el total de gastos."));
            tooltipQueue.Enqueue(new KeyValuePair<Control, string>(lblTotalValor, "Muestra el total de dinero disponible."));
            tooltipQueue.Enqueue(new KeyValuePair<Control, string>(btnSalir, "Salir de la aplicación."));

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
    }
}
