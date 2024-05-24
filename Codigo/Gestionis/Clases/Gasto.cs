using MySql.Data.MySqlClient;
using System.Data;

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

        /// <summary>
        /// Añade un registro gasto a la base de datos
        /// </summary>
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

        /// <summary>
        /// Campos por los que se puede filtrar un gasto
        /// </summary>
        /// <returns>Devuelve una lista de campos para poder filtrar los gastos de la BD</returns>
        public static string[] DevuelveFiltros()
        {
            string[] lista = new string[] { "Nombre", "Cantidad", "Categoria", "Tipo" };
            return lista;
        }

        #region Métodos de Ahorro Totales

        #region Métodos Ahorro dgv Datos

        public static DataTable VisualizarDatosVariable()
        {

            return Utilidades.RellenarDatos("SELECT c.nombre AS categoria, ROUND(SUM(g.cantidad), 2) AS total_gasto, " +
                "ROUND((SUM(g.cantidad) * 100 / (SELECT SUM(cantidad) FROM ingreso))) AS porcentaje FROM gasto g JOIN categoriaGasto " +
                "c ON g.idCategoria = c.idCategoria WHERE g.tipo = 'Variable' GROUP BY c.nombre; ");
        }
        public static DataTable VisualizarDatosFijo()
        {
            return Utilidades.RellenarDatos("SELECT c.nombre AS categoria, ROUND(SUM(g.cantidad), 2) AS total_gasto, ROUND((SUM(g.cantidad) * 100 / (SELECT SUM(cantidad) FROM ingreso))) AS porcentaje " +
                "FROM gasto g JOIN categoriaGasto c ON g.idCategoria = c.idCategoria WHERE g.tipo = 'Fijo' GROUP BY c.nombre;");
        }

        #endregion

        #region Calculo Totales valores (gastos)
        public static double? TotalFijos()
        {
            string queryString = "SELECT SUM(cantidad) FROM gasto WHERE tipo = @tipo";
            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);

            query.Parameters.AddWithValue("@tipo", "fijo");
            ConexionDB.AbrirConexion();
            double? sumaTotal = null;
            using (MySqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    sumaTotal = reader.GetSafeInt32(0);
                }
            }

            ConexionDB.CerrarConexion();
            if (sumaTotal == null || sumaTotal == 0)
            {
                return 0;
            }
            return sumaTotal;
        }
        public static double? TotalVariable()
        {
            string queryString = "SELECT SUM(cantidad) FROM gasto WHERE tipo = @tipo";
            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);

            query.Parameters.AddWithValue("@tipo", "Variable");
            ConexionDB.AbrirConexion();
            double? sumaTotal = null;
            using (MySqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    sumaTotal = reader.GetSafeInt32(0);
                }
            }

            ConexionDB.CerrarConexion();
            if (sumaTotal == null || sumaTotal == 0)
            {
                return 0;
            }

            return sumaTotal;
        }
        public static double? DineroRestante(double? ingresosMensuales)
        {

            if (ingresosMensuales.HasValue == null || ingresosMensuales.Value == 0)
            {
                return 0;
            }

            double? total = Gasto.TotalFijos() + Gasto.TotalVariable();

            if (total.HasValue == null || total.Value == 0)
            {
                return 0;
            }

            return ingresosMensuales - total;
        }


        #endregion

        #region Calculo de los porcentajes totales
        public static double PorcentajeTotalVariable()
        {
            double porcentajeTotal = 0;
            var datosVariable = Gasto.VisualizarDatosVariable();

            for (int i = 0; i < datosVariable.Rows.Count; i++)
            {
                porcentajeTotal += Convert.ToDouble(datosVariable.Rows[i][2]);
            }

            if (porcentajeTotal == 0)
            {
                return 0;
            }
            return porcentajeTotal;
        }
        public static double PorcentajeTotalFijo()
        {
            double porcentajeTotal = 0;
            var datosFijo = Gasto.VisualizarDatosFijo();

            for (int i = 0; i < datosFijo.Rows.Count; i++)
            {
                porcentajeTotal += Convert.ToDouble(datosFijo.Rows[i][2]);
            }
            if (porcentajeTotal == 0) { return 0; }
            return porcentajeTotal;
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
            if (!ingresosMensuales.HasValue)
            {
                return null;
            }
            return ingresosMensuales * 0.50;
        }
        public static double? M503020Presindibles(double? ingresosMensuales)
        {
            if (!ingresosMensuales.HasValue)
            {
                return null;
            }
            return ingresosMensuales * 0.30;
        }
        public static double? M503020Ahorro(double? ingresosMensuales)
        {
            if (!ingresosMensuales.HasValue)
            {
                return null;
            }
            return ingresosMensuales * 0.20;
        }
        #endregion

        #region Calculo de dinero por mes
        public static double? TotalNecesidades()
        {
            string queryString = "SELECT SUM(g.cantidad) FROM gasto g JOIN categoriaGasto c ON g.idCategoria = c.idCategoria WHERE (c.nombre = 'luz' OR c.nombre = 'supermercado');";
            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);

            ConexionDB.AbrirConexion();
            double? sumaTotal = null;
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
        public static double? TotalPrescindibles()
        {
            string queryString = "SELECT SUM(g.cantidad) FROM gasto g JOIN categoriaGasto c ON g.idCategoria = c.idCategoria " +
                         "WHERE (c.nombre = 'restaurante' OR c.nombre = 'gasolina' OR c.nombre = 'entretenimiento');";
            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);

            ConexionDB.AbrirConexion();
            double? sumaTotal = null;
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

        #region Calculo de porcentajes en referencia al dinero gastado
        public static double? PorcentajeNec(double? gastosMensuales)
        {
            if (!gastosMensuales.HasValue || gastosMensuales.Value == 0)
            {
                return null;
            }

            double? totalNecesidades = Gasto.TotalNecesidades();
            if (!totalNecesidades.HasValue || totalNecesidades.Value == 0)
            {
                return null;
            }

            double porcentajeTotal = (totalNecesidades.Value / gastosMensuales.Value) * 100;
            return porcentajeTotal;
        }
        public static double? PorcentajePrescin(double? gastosMensuales)
        {
            if (!gastosMensuales.HasValue || gastosMensuales.Value == 0)
            {
                return null;
            }

            double? totalPrescindibles = Gasto.TotalPrescindibles();
            if (!totalPrescindibles.HasValue || totalPrescindibles.Value == 0)
            {
                return null;
            }

            double porcentajeTotal = (totalPrescindibles.Value / gastosMensuales.Value) * 100;
            return porcentajeTotal;
        }
        #endregion

        #endregion

        #endregion
    }
}
