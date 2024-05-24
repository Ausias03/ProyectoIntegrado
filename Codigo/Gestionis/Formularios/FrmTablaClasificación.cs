using Gestionis.Clases;
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
            barraSecundaria1.Load();
            barraLateral1.Load();
            if (Sesion.Instance.Espanyol) Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
            else Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            AplicarIdioma();
            CargarClasificacion();
        }

        private void ModificarBotones()
        {
            barraSecundaria1.BtnLanguage.Click += BtnLanguage_Click;
            barraSecundaria1.BtnAyuda.Click += BtnAyuda_Click;
        }

        private void BtnLanguage_Click(object sender, EventArgs e)
        {
            AplicarIdioma();
            CargarClasificacion();
            barraLateral1.AplicarIdiomas();
        }

        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            if (Sesion.Instance.Espanyol)
            {
                MessageBox.Show("Aqui se muestran los 10 usuarios que más puntos han conseguido este mes.", "Ayuda",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Here are the top 10 users who have earned the most points this month.", "Help",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CargarClasificacion()
        {
            try
            {
                string consulta = "";
                if (Sesion.Instance.Espanyol)
                {
                    consulta = "SELECT u.apodo AS Apodo, ROUND(COALESCE(SUM(i.total_ingresos), 0), 2) AS Total_Ingresos, " +
                        "ROUND(COALESCE(SUM(d.total_deudas), 0), 2) AS Total_Deudas, ROUND(COALESCE(SUM(i.total_ingresos), 0) + " +
                        "COALESCE(SUM(d.total_deudas), 0), 2) AS Total_Puntos FROM usuario u LEFT JOIN (SELECT c.apodoUsuario, " +
                        "SUM(i.cantidad) AS Total_Ingresos FROM cuenta c LEFT JOIN ingreso i ON c.numCuenta = i.numCuenta " +
                        "GROUP BY c.apodoUsuario) i ON u.apodo = i.apodoUsuario LEFT JOIN (SELECT c.apodoUsuario, SUM(d.cantidad) " +
                        "AS Total_Deudas FROM cuenta c LEFT JOIN deuda d ON c.numCuenta = d.numCuenta AND d.debo = FALSE GROUP " +
                        "BY c.apodoUsuario) d ON u.apodo = d.apodoUsuario GROUP BY u.apodo ORDER BY Total_Puntos DESC LIMIT 10;";
                }
                else
                {
                    consulta = "SELECT u.apodo AS Username, ROUND(COALESCE(SUM(i.total_ingresos), 0), 2) AS Total_Income, " +
                        "ROUND(COALESCE(SUM(d.total_deudas), 0), 2) AS Total_Debt, ROUND(COALESCE(SUM(i.total_ingresos), 0) + " +
                        "COALESCE(SUM(d.total_deudas), 0), 2) AS Total_Points FROM usuario u LEFT JOIN (SELECT c.apodoUsuario, " +
                        "SUM(i.cantidad) AS Total_Ingresos FROM cuenta c LEFT JOIN ingreso i ON c.numCuenta = i.numCuenta " +
                        "GROUP BY c.apodoUsuario) i ON u.apodo = i.apodoUsuario LEFT JOIN (SELECT c.apodoUsuario, SUM(d.cantidad) " +
                        "AS Total_Deudas FROM cuenta c LEFT JOIN deuda d ON c.numCuenta = d.numCuenta AND d.debo = FALSE GROUP " +
                        "BY c.apodoUsuario) d ON u.apodo = d.apodoUsuario GROUP BY u.apodo ORDER BY Total_Points DESC LIMIT 10;";
                }
                dgvTabla.DataSource = Utilidades.RellenarDatos(consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConexionDB.CerrarConexion();
            }
        }

        private void AplicarIdioma()
        {
            lblTabla.Text = Resources.Idiomas.StringRecursosTabla.lblTabla;
            btnSalir.Text = Resources.Idiomas.StringRecursosTabla.btnSalir;
        }
    }
}