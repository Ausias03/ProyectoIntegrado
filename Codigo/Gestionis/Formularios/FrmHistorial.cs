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
namespace Gestionis
{
    public partial class frmHistorial : FrmBarraPrincipal
    {
        private readonly Usuario usuario;
        private int cuenta;

        public frmHistorial()
        {
            InitializeComponent();
            usuario = Usuario.BuscaUsuario(Sesion.Instance.ApodoUsuario);
            cuenta = Cuenta.IDCuentaUsuario(usuario.Apodo);
        }

        private void frmHistorial_Load(object sender, EventArgs e)
        {
            dtpBuscaFecha.MaxDate = DateTime.Now;
            lblFecha.Show();
            lblFecha.Text = DateTime.Today.ToString("D");
            CargarFecha(DateTime.Today, cuenta);
            barraSecundaria1.BarraSecundaria_Load();
        }

        private void picBuscar_Click(object sender, EventArgs e)
        {
            CargarFiltro(dtpBuscaFecha.Value, cuenta, cmbMetodo.Text, txtBuscar.Text);
            lblFecha.Text = dtpBuscaFecha.Value.ToString("D");
            dtpBuscaFecha.Value = DateTime.Today;
            txtBuscar.Text = "";
        }

        private void picBuscaFecha_Click(object sender, EventArgs e)
        {
            CargarFecha(dtpBuscaFecha.Value, cuenta);
            lblFecha.Text = dtpBuscaFecha.Value.ToString("D");
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
    }
}