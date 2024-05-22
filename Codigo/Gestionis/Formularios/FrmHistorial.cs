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
            string consulta;
            string consulta2;
            if (Sesion.Instance.Espanyol)
            {
                consulta = $"SELECT g.hora AS Hora,g.tipo AS Tipo,c.nombre AS Categoria,g.nombre AS Nombre,g.cantidad AS Cantidad," +
                    $"g.comentarios AS Comentarios FROM gasto AS g LEFT JOIN categoriagasto AS c ON g.idCategoria = c.idCategoria " +
                    $"WHERE fecha = '{fecha.ToString("yyyy/MM/dd")}' AND numCuenta = {numCuenta};";
                consulta2 = $"SELECT i.hora AS Hora,i.tipo AS Tipo,c.nombre AS Categoria,i.nombre AS Nombre,i.cantidad AS Cantidad" +
                    $",i.comentarios AS Comentarios FROM ingreso AS i LEFT JOIN categoriaingreso AS c ON i.idCategoria = c.idCategoria " +
                    $"WHERE fecha = '{fecha.ToString("yyyy/MM/dd")}' AND numCuenta = {numCuenta};";
            }
            else
            {
                consulta = $"SELECT g.hora AS Date,g.tipo AS Type,c.nombre AS Category,g.nombre AS Name,g.cantidad AS Amount," +
                    $"g.comentarios AS Commentaries FROM gasto AS g LEFT JOIN categoriagasto AS c ON g.categoria = c.idCategoria " +
                    $"WHERE fecha = '{fecha.ToString("yyyy/MM/dd")}' AND numCuenta = {numCuenta};";
                consulta2 = $"SELECT i.hora AS Date,i.tipo AS Type,c.nombre AS Category,i.nombre AS Name,i.cantidad AS Amount" +
                    $",i.comentarios AS Commentaries FROM ingreso AS i LEFT JOIN categoriaingreso AS c ON i.categoria = c.idCategoria " +
                    $"WHERE fecha = '{fecha.ToString("yyyy/MM/dd")}' AND numCuenta = {numCuenta};";
            }
            dgvGastos.DataSource = Utilidades.RellenarDatos(consulta);
            dgvIngresos.DataSource = Utilidades.RellenarDatos(consulta2);
        }

        private void CargarFiltro(DateTime fecha, int numCuenta, int filtro, string param)
        {
            string consulta;
            string consulta2;
            if (Sesion.Instance.Espanyol)
            {
                consulta = $"SELECT g.hora AS Hora,g.tipo AS Tipo,c.nombre AS Categoria,g.nombre AS Nombre,g.cantidad AS Cantidad," +
                    $"g.comentarios AS Comentarios FROM gasto AS g LEFT JOIN categoriagasto AS c ON g.categoria = c.idCategoria " +
                    $"WHERE fecha = '{fecha.ToString("yyyy/MM/dd")}' AND numCuenta = {numCuenta}";
                consulta2 = $"SELECT i.hora AS Hora,i.tipo AS Tipo,c.nombre AS Categoria,i.nombre AS Nombre,i.cantidad AS Cantidad" +
                    $",i.comentarios AS Comentarios FROM ingreso AS i LEFT JOIN categoriaingreso AS c ON i.categoria = c.idCategoria " +
                    $"WHERE fecha = '{fecha.ToString("yyyy/MM/dd")}' AND numCuenta = {numCuenta}";
            }
            else
            {
                consulta = $"SELECT g.hora AS Date,g.tipo AS Type,c.nombre AS Category,g.nombre AS Name,g.cantidad AS Amount," +
                    $"g.comentarios AS Commentaries FROM gasto AS g LEFT JOIN categoriagasto AS c ON g.categoria = c.idCategoria " +
                    $"WHERE fecha = '{fecha.ToString("yyyy/MM/dd")}' AND numCuenta = {numCuenta}";
                consulta2 = $"SELECT i.hora AS Date,i.tipo AS Type,c.nombre AS Category,i.nombre AS Name,i.cantidad AS Amount" +
                    $",i.comentarios AS Commentaries FROM ingreso AS i LEFT JOIN categoriaingreso AS c ON i.categoria = c.idCategoria " +
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
    }
}