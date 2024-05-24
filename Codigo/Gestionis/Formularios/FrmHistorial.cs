using Gestionis.Clases;
using System.Globalization;
namespace Gestionis
{
    public partial class frmHistorial : FrmBarraPrincipal
    {
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Timer tooltipTimer;
        private Queue<KeyValuePair<Control, string>> tooltipQueue;
        private int tooltipDuration = 2000;
        private readonly Usuario usuario;
        private int cuenta;

        public frmHistorial()
        {
            try
            {
                InitializeComponent();
                ModificarBotones();
                usuario = Usuario.BuscaUsuario(Sesion.Instance.ApodoUsuario);
                cuenta = Cuenta.IDCuentaUsuario(usuario.Apodo);
                toolTip = new System.Windows.Forms.ToolTip();
                tooltipQueue = new Queue<KeyValuePair<Control, string>>();
                tooltipTimer = new System.Windows.Forms.Timer();
                tooltipTimer.Interval = tooltipDuration;
                tooltipTimer.Tick += TooltipTimer_Tick;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmHistorial_Load(object sender, EventArgs e)
        {
            if (Sesion.Instance.Espanyol) Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
            else Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            AplicarIdioma();
            dtpBuscaFecha.MaxDate = DateTime.Now;
            lblFecha.Show();
            lblFecha.Text = DateTime.Today.ToString("d");
            CargarFecha(DateTime.Today, cuenta);
            barraSecundaria1.Load();
            cmbMetodo.DataSource = ListaMetodo();
        }
        private void ModificarBotones()
        {
            barraSecundaria1.BtnAyuda.Click += BtnAyuda_Click;
            barraSecundaria1.BtnLanguage.Click += BtnLanguage_Click;
        }

        private void BtnLanguage_Click(object sender, EventArgs e)
        {
            AplicarIdioma();
            if (txtBuscar.Text != "") CargarFiltro(dtpBuscaFecha.Value, cuenta, cmbMetodo.SelectedIndex, txtBuscar.Text);
            else CargarFecha(dtpBuscaFecha.Value, cuenta);
            cmbMetodo.DataSource = ListaMetodo();
            barraLateral1.AplicarIdiomas();
        }

        #region ToolTips
        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            if (Sesion.Instance.Espanyol)
            {
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(picBuscaFecha, "Selecciona una fecha y haz clic aqui para mostrar los gastos e ingresos de ese día."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(picBuscar, "Selecciona una fecha, introduce un parámetro adecuado y haz clic aqui para mostrar \n los gastos e ingresos de ese día siguiendo el criterio introducido."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(cmbMetodo, "Selecciona el metodo de búsqueda deseado."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(btnSalir, "Haz clic aqui para salir de la aplicación."));
            }
            else
            {
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(picBuscaFecha, "Select a date and click here to display the expenses and income for that day."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(picBuscar, "Select a date, enter an appropriate parameter, and click here to display \n the expenses and income for that day based on the entered criteria."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(cmbMetodo, "Select the desired search method."));
                tooltipQueue.Enqueue(new KeyValuePair<Control, string>(btnSalir, "Click here to exit the application."));

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

        private void picBuscar_Click(object sender, EventArgs e)
        {
            CargarFiltro(dtpBuscaFecha.Value, cuenta, cmbMetodo.SelectedIndex, txtBuscar.Text);
            lblFecha.Text = dtpBuscaFecha.Value.ToString("d");
        }

        private void picBuscaFecha_Click(object sender, EventArgs e)
        {
            CargarFecha(dtpBuscaFecha.Value, cuenta);
            lblFecha.Text = dtpBuscaFecha.Value.ToString("d");
        }


        private void CargarFecha(DateTime fecha, int numCuenta)
        {
            try
            {
                string consulta;
                string consulta2;
                if (Sesion.Instance.Espanyol)
                {
                    consulta = $"SELECT g.hora AS Hora,g.tipo AS Tipo,c.nombre AS Categoria,g.nombre AS Nombre,g.cantidad AS Cantidad," +
                        $"g.comentarios AS Comentarios FROM gasto AS g LEFT JOIN categoriaGasto AS c ON g.idCategoria = c.idCategoria " +
                        $"WHERE fecha = '{fecha.ToString("yyyy/MM/dd")}' AND numCuenta = {numCuenta};";
                    consulta2 = $"SELECT i.hora AS Hora,i.tipo AS Tipo,c.nombre AS Categoria,i.nombre AS Nombre,i.cantidad AS Cantidad" +
                        $",i.comentarios AS Comentarios FROM ingreso AS i LEFT JOIN categoriaIngreso AS c ON i.idCategoria = c.idCategoria " +
                        $"WHERE fecha = '{fecha.ToString("yyyy/MM/dd")}' AND numCuenta = {numCuenta};";
                }
                else
                {
                    consulta = $"SELECT g.hora AS Date,g.tipo AS Type,c.nombre AS Category,g.nombre AS Name,g.cantidad AS Amount," +
                        $"g.comentarios AS Comments FROM gasto AS g LEFT JOIN categoriaGasto AS c ON g.idCategoria = c.idCategoria " +
                        $"WHERE fecha = '{fecha.ToString("yyyy/MM/dd")}' AND numCuenta = {numCuenta};";
                    consulta2 = $"SELECT i.hora AS Date,i.tipo AS Type,c.nombre AS Category,i.nombre AS Name,i.cantidad AS Amount" +
                        $",i.comentarios AS Comments FROM ingreso AS i LEFT JOIN categoriaIngreso AS c ON i.idCategoria = c.idCategoria " +
                        $"WHERE fecha = '{fecha.ToString("yyyy/MM/dd")}' AND numCuenta = {numCuenta};";
                }
                dgvGastos.DataSource = Utilidades.RellenarDatos(consulta);
                dgvIngresos.DataSource = Utilidades.RellenarDatos(consulta2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarFiltro(DateTime fecha, int numCuenta, int filtro, string param)
        {
            if (ValidarParametro(param))
            {
                try
                {
                    string consulta;
                    string consulta2;
                    if (Sesion.Instance.Espanyol)
                    {
                        consulta = $"SELECT g.hora AS Hora,g.tipo AS Tipo,c.nombre AS Categoria,g.nombre AS Nombre,g.cantidad AS Cantidad," +
                            $"g.comentarios AS Comentarios FROM gasto AS g LEFT JOIN categoriaGasto AS c ON g.idCategoria = c.idCategoria " +
                            $"WHERE fecha = '{fecha.ToString("yyyy/MM/dd")}' AND numCuenta = {numCuenta}";
                        consulta2 = $"SELECT i.hora AS Hora,i.tipo AS Tipo,c.nombre AS Categoria,i.nombre AS Nombre,i.cantidad AS Cantidad" +
                            $",i.comentarios AS Comentarios FROM ingreso AS i LEFT JOIN categoriaIngreso AS c ON i.idCategoria = c.idCategoria " +
                            $"WHERE fecha = '{fecha.ToString("yyyy/MM/dd")}' AND numCuenta = {numCuenta}";
                    }
                    else
                    {
                        consulta = $"SELECT g.hora AS Date,g.tipo AS Type,c.nombre AS Category,g.nombre AS Name,g.cantidad AS Amount," +
                            $"g.comentarios AS Comments FROM gasto AS g LEFT JOIN categoriaGasto AS c ON g.idCategoria = c.idCategoria " +
                            $"WHERE fecha = '{fecha.ToString("yyyy/MM/dd")}' AND numCuenta = {numCuenta}";
                        consulta2 = $"SELECT i.hora AS Date,i.tipo AS Type,c.nombre AS Category,i.nombre AS Name,i.cantidad AS Amount" +
                            $",i.comentarios AS Comments FROM ingreso AS i LEFT JOIN categoriaIngreso AS c ON i.idCategoria = c.idCategoria " +
                            $"WHERE fecha = '{fecha.ToString("yyyy/MM/dd")}' AND numCuenta = {numCuenta}";
                    }
                    switch (filtro)
                    {
                        case 0:
                            consulta += $" AND tipo = '{param}';";
                            consulta2 += $" AND tipo = '{param}';";
                            break;
                        case 1:
                            consulta += $" AND c.nombre = '{param}';";
                            consulta2 += $" AND c.nombre = '{param}';";
                            break;
                        case 2:
                            consulta += $" AND g.nombre = '{param}';";
                            consulta2 += $" AND i.nombre = '{param}';";
                            break;
                        case 3:
                            consulta += $" AND cantidad = '{param}';";
                            consulta2 += $" AND cantidad = '{param}';";
                            break;
                        default:
                            break;
                    }
                    dgvGastos.DataSource = Utilidades.RellenarDatos(consulta);
                    dgvIngresos.DataSource = Utilidades.RellenarDatos(consulta2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AplicarIdioma()
        {
            lblHistorial.Text = Resources.Idiomas.StringRecursosHistorial.lblHistorial;
            lblBuscar.Text = Resources.Idiomas.StringRecursosHistorial.lblBuscar;
            lblMetodo.Text = Resources.Idiomas.StringRecursosHistorial.lblMetodo;
            lblBuscaFecha.Text = Resources.Idiomas.StringRecursosHistorial.lblBuscaFecha;
            lblIngresos.Text = Resources.Idiomas.StringRecursosHistorial.lblIngresos;
            lblGastos.Text = Resources.Idiomas.StringRecursosHistorial.lblGastos;
            btnSalir.Text = Resources.Idiomas.StringRecursosHistorial.btnSalir;
        }

        private string[] ListaMetodo()
        {
            string[] lista = new string[4];
            if (Sesion.Instance.Espanyol)
            {
                lista[0] = "Tipo";
                lista[1] = "Categoria";
                lista[2] = "Nombre";
                lista[3] = "Cantidad";
            }
            else
            {
                lista[0] = "Type";
                lista[1] = "Category";
                lista[2] = "Name";
                lista[3] = "Amount";
            }
            return lista;
        }

        private bool ValidarParametro(string param)
        {
            bool valido = true;
            foreach (char c in param)
            {
                if (c.ToString() == "'")
                {
                    valido = false;
                    if (Sesion.Instance.Espanyol) errorProvider1.SetError(picBuscar, "No se pueden introducir comillas simples.");
                    else errorProvider1.SetError(picBuscar, "Simple quotes are not allowed");
                    break;
                }
                else errorProvider1.Clear();
            }
            return valido;
        }
    }
}