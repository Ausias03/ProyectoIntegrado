using System;
using Gestionis.Clases;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Gestionis
{
    public partial class frmHistorial : FrmBarraPrincipal
    {
        public frmHistorial()
        {
            InitializeComponent();
        }

        private void frmHistorial_Load(object sender, EventArgs e)
        {
            dtpBuscaFecha.MaxDate = DateTime.Now;
            lblFecha.Show();
            lblFecha.Text = ("Hoy, " + DateTime.Today.ToString("D"));
        }

        private void cmbMetodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMetodo.SelectedIndex == 0)
            {
                txtBuscar.Hide();
                cmbBuscador.Show();
            }
            else
            {
                txtBuscar.Show();
                cmbBuscador.Hide();
                txtBuscar.Text = "";
            }
        }

        private void picBuscar_Click(object sender, EventArgs e)
        {
            lblFecha.Text = dtpBuscaFecha.Value.ToString("D");
            dtpBuscaFecha.Value = DateTime.Today;
            txtBuscar.Text = "";
        }

        private void picBuscaFecha_Click(object sender, EventArgs e)
        {
            lblFecha.Text = dtpBuscaFecha.Value.ToString("D");
            dtpBuscaFecha.Value = DateTime.Today;
            txtBuscar.Text = "";
        }

        /*
        private void CargarBusquedaFecha(DateTime fecha, int numCuenta)
        {
            List<object> listaTotal = new List<object>();
            listaTotal.Add();
            listaTotal.Add();
            listaTotal.Sort((x, y) => ObtenerHora(x).CompareTo(ObtenerHora(y)));
            dgvHistorial.DataSource = listaTotal;
        }

        private void CargarBusquedaMetodica(DateTime fecha, int numCuenta, int filtrar, string param)
        {
            List<object> listaTotal = new List<object>();
            listaTotal.Add();
            listaTotal.Add();
            listaTotal.Sort((x, y) => ObtenerHora(x).CompareTo(ObtenerHora(y)));
            dgvHistorial.DataSource = listaTotal;
        }

        private void CargarBusquedaTipo(DateTime fecha, int numCuenta, int tipo, string param)
        {
            List<object> lista = new List<object>();
            switch (tipo)
            {
                case 0:
                    lista = Gasto.BusquedaTipo();
                    break;
                case 1:
                    lista = Gasto.BusquedaTipo();
                    break;
                case 2:
                    lista = Ingreso.BusquedaTipo();
                    break;
                case 3:
                    lista = Ingreso.BusquedaTipo();
                    break;
            }
            dgvHistorial.DataSource = lista;
        }

        TimeSpan ObtenerHora(object obj)
        {
            if (obj is Gasto)
            {
                return ((Gasto)obj).Hora;
            }
            else if (obj is Ingreso)
            {
                return ((Ingreso)obj).Hora;
            }
            else
            {
                throw new ArgumentException("Objeto no reconocido");
            }
        }
        */
    }
}