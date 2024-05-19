using System;
using Gestionis.Clases;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Gestionis
{
    public partial class frmTablaClasificación : FrmBarraPrincipal
    {
        public frmTablaClasificación()
        {
            InitializeComponent();
        }

        private void frmTablaClasificación_Load(object sender, EventArgs e)
        {
            CargarClasificacion();
            barraSecundaria1.BarraSecundaria_Load();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CargarClasificacion()
        {
            string consulta = "SELECT u.apodo, COALESCE(SUM(i.total_ingresos), 0) AS total_ingresos, COALESCE(SUM(d.total_deudas), 0) AS total_deudas, " +
                "COALESCE(SUM(i.total_ingresos), 0) + COALESCE(SUM(d.total_deudas), 0) AS total_puntos FROM usuario u LEFT JOIN (SELECT c.apodoUsuario, " +
                "SUM(i.cantidad) AS total_ingresos FROM cuenta c LEFT JOIN ingreso i ON c.numCuenta = i.numCuenta GROUP BY c.apodoUsuario) i ON u.apodo = i.apodoUsuario " +
                "LEFT JOIN (SELECT c.apodoUsuario, SUM(d.cantidad) AS total_deudas FROM cuenta c LEFT JOIN deuda d ON c.numCuenta = d.numCuenta AND d.debo = FALSE " +
                "GROUP BY  c.apodoUsuario) d ON u.apodo = d.apodoUsuario GROUP BY u.apodo ORDER BY total_puntos DESC LIMIT 10;";
            dgvTabla.DataSource = Utilidades.RellenarDatos(consulta);
        }
    }
}