using System;
using Gestionis.Clases;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Gestionis.Herramientas;
using System.Globalization;
namespace Gestionis
{
    public partial class frmHistorial : FrmBarraPrincipal
    {
        private readonly Usuario usuario;
        private int cuenta;

        public frmHistorial()
        {
            InitializeComponent();
            ModificarBotones();
            usuario = Usuario.BuscaUsuario(Sesion.Instance.ApodoUsuario);
            cuenta = Cuenta.IDCuentaUsuario(usuario.Apodo);
        }

        private void frmHistorial_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            AplicarIdioma();
            dtpBuscaFecha.MaxDate = DateTime.Now;
            lblFecha.Show();
            lblFecha.Text = DateTime.Today.ToString("d");
            CargarFecha(DateTime.Today, cuenta);
            barraSecundaria1.Load();
        }
        private void ModificarBotones()
        {
            barraSecundaria1.BtnLanguage.Click += BtnLanguage_Click;
        }

        private void BtnLanguage_Click(object sender, EventArgs e)
        {
            AplicarIdioma();
        }

        private void picBuscar_Click(object sender, EventArgs e)
        {
            CargarFiltro(dtpBuscaFecha.Value, cuenta, cmbMetodo.Text, txtBuscar.Text);
            lblFecha.Text = dtpBuscaFecha.Value.ToString("d");
            dtpBuscaFecha.Value = DateTime.Today;
            txtBuscar.Text = "";
        }

        private void picBuscaFecha_Click(object sender, EventArgs e)
        {
            CargarFecha(dtpBuscaFecha.Value, cuenta);
            lblFecha.Text = dtpBuscaFecha.Value.ToString("d");
            dtpBuscaFecha.Value = DateTime.Today;
            txtBuscar.Text = "";
        }


        private void CargarFecha(DateTime fecha, int numCuenta)
        {
            string consulta = $"SELECT g.hora,g.tipo,c.nombre AS categoria,g.nombre,g.cantidad,g.comentarios FROM gasto AS g INNER JOIN " +
                $"categoriagasto AS c ON g.categoria = c.idCategoria WHERE fecha = '{fecha.ToString("yyyy/MM/dd")}' AND numCuenta = {numCuenta};";
            dgvGastos.DataSource = Utilidades.RellenarDatos(consulta);
            string consulta2 = $"SELECT i.hora,i.tipo,c.nombre AS categoria,i.nombre,i.cantidad,i.comentarios FROM ingreso AS i INNER JOIN " +
                $"categoriaingreso AS c ON i.categoria = c.idCategoria WHERE fecha = '{fecha.ToString("yyyy/MM/dd")}' AND numCuenta = {numCuenta};";
            dgvIngresos.DataSource = Utilidades.RellenarDatos(consulta2);
        }

        private void CargarFiltro(DateTime fecha, int numCuenta, string filtro, string param)
        {
            string consulta = $"SELECT g.hora,g.tipo,c.nombre AS categoria,g.nombre,g.cantidad,g.comentarios FROM gasto AS g INNER JOIN " +
                $"categoriagasto AS c ON g.categoria = c.idCategoria WHERE fecha = '{fecha.ToString("yyyy/MM/dd")}' AND numCuenta = {numCuenta}";
            string consulta2 = $"SELECT i.hora,i.tipo,c.nombre AS categoria,i.nombre,i.cantidad,i.comentarios FROM ingreso AS i INNER JOIN " +
                $"categoriaingreso AS c ON i.categoria = c.idCategoria WHERE fecha = '{fecha.ToString("yyyy/MM/dd")}' AND numCuenta = {numCuenta}";
            switch (filtro)
            {
                case "Tipo":
                    consulta += $" AND tipo = '{param}';";
                    consulta2 += $" AND tipo = '{param}';";
                    break;
                case "Categoria":
                    consulta += $" AND c.nombre = '{param}';";
                    consulta2 += $" AND c.nombre = '{param}';";
                    break;
                case "Nombre":
                    consulta += $" AND g.nombre = '{param}';";
                    consulta2 += $" AND i.nombre = '{param}';";
                    break;
                case "Cantidad":
                    consulta += $" AND cantidad = {param};";
                    consulta2 += $" AND cantidad = {param};";
                    break;
                default:
                    break;
            }
            dgvGastos.DataSource = Utilidades.RellenarDatos(consulta);
            dgvIngresos.DataSource = Utilidades.RellenarDatos(consulta2);
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
    }
}