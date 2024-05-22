using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Crud.Order.Types;

namespace Gestionis.Clases
{
    public class Gasto
    {
        private static List<String> tiposGasto = new List<String>() { "Fijo", "Variable" };

        private int? idGasto;
        private int numCuenta;
        private string nombre;
        private float cantidad;
        private int categoria;
        private string tipo;
        private string? comentarios;
        private DateTime fecha;
        private TimeSpan hora;

        public Gasto(int numCuenta, string nombre, float cantidad, int categoria,
            string tipo, string? comentarios)
        {
            this.idGasto = null;
            this.numCuenta = numCuenta;
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.categoria = categoria;
            this.tipo = tipo;
            this.comentarios = comentarios;
            this.fecha = DateTime.Today;
            this.hora = DateTime.Now.TimeOfDay;
        }

        public Gasto(int idGasto, int numCuenta, string nombre, float cantidad, int categoria,
            string tipo, string? comentarios, DateTime fecha, TimeSpan hora)
        {
            this.idGasto = idGasto;
            this.numCuenta = numCuenta;
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.categoria = categoria;
            this.tipo = tipo;
            this.comentarios = comentarios;
            this.fecha = fecha;
            this.hora = hora;
        }

        // Necesarias para el dataSource de FrmMenuPrincipal
        #region Propiedades
        public static List<String> TiposGasto { get { return tiposGasto; } }
        public int IdGasto { get { return idGasto.Value; } }
        public string Nombre { get { return nombre; } }
        public float Cantidad { get { return cantidad; } }
        public string Categoria { get { return CategoriaGasto.DevuelveNombreCategoria(categoria); } }
        public string Tipo { get { return tipo; } }
        public string? Comentarios { get { return comentarios; } }
        public DateTime Fecha { get { return fecha; } }
        public TimeSpan Hora { get { return hora; } }
        #endregion

        #region Geters
        public int GetNumericCategoria()
        {
            return categoria;
        }
        #endregion

        public void Add()
        {
            string queryString = "INSERT INTO gasto (idGasto, numCuenta, nombre, cantidad," +
                "idCategoria, tipo, comentarios, fecha, hora) " +
                "VALUES (@idGasto, @numCuenta, @nombre, @cantidad, @idCategoria, @tipo, @comentarios," +
                "@fecha, @hora);";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@idGasto", idGasto);
            query.Parameters.AddWithValue("@numCuenta", Sesion.Instance.NumCuenta);
            query.Parameters.AddWithValue("@nombre", nombre);
            query.Parameters.AddWithValue("@cantidad", cantidad);
            query.Parameters.AddWithValue("@idCategoria", categoria);
            query.Parameters.AddWithValue("@tipo", tipo);
            query.Parameters.AddWithValue("@comentarios", comentarios);
            query.Parameters.AddWithValue("@fecha", fecha);
            query.Parameters.AddWithValue("@hora", hora);

            ConexionDB.AbrirConexion();

            query.ExecuteNonQuery();

            ConexionDB.CerrarConexion();
        }

        public static string[] DevuelveFiltros()
        {
            string[] lista = new string[] { "Nombre", "Cantidad", "Categoria", "Tipo"};
            return lista;
        }

        #region Métodos de Ahorro Totales

        #region Métodos Ahorro dgv Datos

        public static DataTable VisualizarDatosVariable()
        {

            return Utilidades.RellenarDatos("SELECT c.nombre AS categoria, SUM(g.cantidad) AS total_gasto,(SUM(g.cantidad) * 100 / (SELECT cantidad FROM ingreso)) AS porcentaje " +
                "FROM gasto g JOIN categoriagasto c ON g.idCategoria = c.idCategoria WHERE g.tipo = 'Variable' GROUP BY c.nombre;");
        }
        public static DataTable VisualizarDatosFijo()
        {
            return Utilidades.RellenarDatos("SELECT c.nombre AS categoria, SUM(g.cantidad) AS total_gasto,(SUM(g.cantidad) * 100 / (SELECT cantidad FROM ingreso)) AS porcentaje " +
                "FROM gasto g JOIN categoriagasto c ON g.idCategoria = c.idCategoria WHERE g.tipo = 'Fijo' GROUP BY c.nombre;");
        }

        #endregion

        #region Calculo Totales valores (gastos)
        public static int? TotalFijos()
        {
            string queryString = "SELECT SUM(cantidad) FROM gasto WHERE tipo = @tipo";
            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);

            query.Parameters.AddWithValue("@tipo", "fijo");
            ConexionDB.AbrirConexion();
            int? sumaTotal = null;
            using (MySqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    sumaTotal = reader.GetSafeInt32(0);
                }
            }

            ConexionDB.CerrarConexion();
            return sumaTotal;
        }
        public static int? TotalVariable()
        {
            string queryString = "SELECT SUM(cantidad) FROM gasto WHERE tipo = @tipo";
            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);

            query.Parameters.AddWithValue("@tipo", "Variable");
            ConexionDB.AbrirConexion();
            int? sumaTotal = null;
            using (MySqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    sumaTotal = reader.GetSafeInt32(0);
                }
            }

            ConexionDB.CerrarConexion();
            return sumaTotal;
        }
        #endregion

        #region Calculo de los porcentajes totales
        public static int PorcentajeTotalVariable()
        {
            double porcentajeTotal = 0;
            var datosVariable = Gasto.VisualizarDatosVariable();

            for (int i = 0; i < datosVariable.Rows.Count; i++)
            {
                porcentajeTotal += Convert.ToDouble(datosVariable.Rows[i][2]);
            }
            return (int)porcentajeTotal;
        }
        public static int PorcentajeTotalFijo()
        {
            double porcentajeTotal = 0;
            var datosVariable = Gasto.VisualizarDatosFijo();

            for (int i = 0; i < datosVariable.Rows.Count; i++)
            {
                porcentajeTotal += Convert.ToDouble(datosVariable.Rows[i][2]);
            }
            return (int)porcentajeTotal;
        }

        #endregion

        public static double? DineroRestante(double? ingresosMensuales)
        {
            if (!ingresosMensuales.HasValue)
            {
                return null;
            }

            double? total = Gasto.TotalFijos() + Gasto.TotalVariable();
            return ingresosMensuales - total;
        }

        public static double? PorcentajeRestante(double? ingresosMensuales)
        {
            double? dineroRestante = DineroRestante(ingresosMensuales);

            if (!ingresosMensuales.HasValue || ingresosMensuales.Value == 0 || !dineroRestante.HasValue)
            {
                return 0;
            }

            double? porcentaje = (dineroRestante.Value / ingresosMensuales.Value) * 100;
            return porcentaje;
        }

        #endregion

        #region método 50/30/20

        #region Cálculo de dinero

        public static double? M503020Necesidades(double? ingresosMensuales)
        {
            return ingresosMensuales * 0.50;
        }
        public static double? M503020Presindibles(double? ingresosMensuales)
        {
            return ingresosMensuales * 0.30;
        }
        public static double? M503020Ahorro(double? ingresosMensuales)
        {
            return ingresosMensuales * 0.20;
        }
        #endregion

        #endregion
    }
}
