using System;
using Gestionis.Clases;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Gestionis
{
    public partial class frmTablaClasificación : FrmBarraPrincipal
    {
        public frmTablaClasificación()
        {
            InitializeComponent();
            ModificarBotones();
        }

        private void frmTablaClasificación_Load(object sender, EventArgs e)
        {
            CargarClasificacion();
            barraSecundaria1.Load();
            barraLateral1.Load();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            AplicarIdioma();
        }

        private void ModificarBotones()
        {
            barraSecundaria1.BtnLanguage.Click += BtnLanguage_Click;
        }

        private void BtnLanguage_Click(object sender, EventArgs e)
        {
            AplicarIdioma();
            CargarClasificacion();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CargarClasificacion()
        {
            string consulta = "";
            if (!true)
            {
                consulta = "SELECT u.apodo AS Apodo, COALESCE(SUM(i.total_ingresos), 0) AS Total_Ingresos, COALESCE(SUM(d.total_deudas), 0) AS Total_Deudas, " +
                "COALESCE(SUM(i.total_ingresos), 0) + COALESCE(SUM(d.total_deudas), 0) AS Total_Puntos FROM usuario u LEFT JOIN (SELECT c.apodoUsuario, " +
                "SUM(i.cantidad) AS Total_Ingresos FROM cuenta c LEFT JOIN ingreso i ON c.numCuenta = i.numCuenta GROUP BY c.apodoUsuario) i ON u.apodo = i.apodoUsuario " +
                "LEFT JOIN (SELECT c.apodoUsuario, SUM(d.cantidad) AS Total_Deudas FROM cuenta c LEFT JOIN deuda d ON c.numCuenta = d.numCuenta AND d.debo = FALSE " +
                "GROUP BY  c.apodoUsuario) d ON u.apodo = d.apodoUsuario GROUP BY u.apodo ORDER BY Total_Puntos DESC LIMIT 10;";
            }
            else
            {
                consulta = "SELECT u.apodo AS Username, COALESCE(SUM(i.total_ingresos), 0) AS Total_Income, COALESCE(SUM(d.total_deudas), 0) AS Total_Debt, " +
                "COALESCE(SUM(i.total_ingresos), 0) + COALESCE(SUM(d.total_deudas), 0) AS Total_Points FROM usuario u LEFT JOIN (SELECT c.apodoUsuario, " +
                "SUM(i.cantidad) AS total_ingresos FROM cuenta c LEFT JOIN ingreso i ON c.numCuenta = i.numCuenta GROUP BY c.apodoUsuario) i ON u.apodo = i.apodoUsuario " +
                "LEFT JOIN (SELECT c.apodoUsuario, SUM(d.cantidad) AS total_deudas FROM cuenta c LEFT JOIN deuda d ON c.numCuenta = d.numCuenta AND d.debo = FALSE " +
                "GROUP BY  c.apodoUsuario) d ON u.apodo = d.apodoUsuario GROUP BY u.apodo ORDER BY Total_Points DESC LIMIT 10;";
            }
            dgvTabla.DataSource = Utilidades.RellenarDatos(consulta);
        }

        private void AplicarIdioma()
        {
            lblTabla.Text = Resources.Idiomas.StringRecursosTabla.lblTabla;
            btnSalir.Text = Resources.Idiomas.StringRecursosTabla.btnSalir;
        }
    }
}