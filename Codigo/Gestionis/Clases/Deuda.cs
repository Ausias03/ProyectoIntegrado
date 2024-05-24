using MySql.Data.MySqlClient;
using System.Data;

namespace Gestionis.Clases
{
    class Deuda
    {
        private int? idDeuda;
        private int numCuenta;
        private string titulo;
        private string descripcion;
        private bool debo;
        private decimal cantidad;
        private DateTime fechaCreacion;
        private DateTime fechaVencimiento;
        private bool anyadirRecordatorio;

        #region Propiedades
        public string Titulo { get { return titulo; } }
        public string Descripcion { get { return descripcion; } }
        public bool Debo { get { return debo; } }
        public decimal Cantidad { get { return cantidad; } }
        public DateTime FechaCreacion { get { return fechaCreacion; } }
        public DateTime FechaVencimiento { get { return fechaVencimiento; } }
        #endregion

        #region Constructores
        public Deuda() { }

        public Deuda(string tit, string descrip, bool deb, decimal cant, DateTime fechaCrea, DateTime fechaVenc, bool record)
        {
            idDeuda = null;
            numCuenta = Sesion.Instance.NumCuenta;
            titulo = tit;
            descripcion = descrip;
            debo = deb;
            cantidad = cant;
            fechaCreacion = fechaCrea;
            fechaVencimiento = fechaVenc;
            anyadirRecordatorio = record;
        }
        #endregion

        /// <summary>
        /// Agrega una nueva deuda a la base de datos.
        /// </summary>
        public int Add()
        {
            int resultado = 0;
            string fechaVencimiento = this.fechaVencimiento.ToString("yyyy/MM/dd");
            string fechaCreacion = this.fechaCreacion.ToString("yyyy/MM/dd");

            string queryString = "INSERT INTO deuda (idDeuda, numCuenta, titulo, descripcion," +
                "debo, cantidad, fechaCreacion, fechaVencimiento, anyadirRecordatorio) " +
                "VALUES (@idDeuda, @numCuenta, @titulo, @descripcion, @debo, @cantidad," +
                "@fechaCreacion, @fechaVencimiento, @anyadirRecordatorio);";

            using (MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion))
            {
                query.Parameters.AddWithValue("@idDeuda", idDeuda);
                query.Parameters.AddWithValue("@numCuenta", numCuenta);
                query.Parameters.AddWithValue("@titulo", titulo);
                query.Parameters.AddWithValue("@descripcion", descripcion);
                query.Parameters.AddWithValue("@debo", debo);
                query.Parameters.AddWithValue("@cantidad", cantidad);
                query.Parameters.AddWithValue("@fechaCreacion", fechaCreacion);
                query.Parameters.AddWithValue("@fechaVencimiento", fechaVencimiento);
                query.Parameters.AddWithValue("@anyadirRecordatorio", anyadirRecordatorio);

                ConexionDB.AbrirConexion();

                resultado = query.ExecuteNonQuery();

                ConexionDB.CerrarConexion();
            }

            return resultado;
        }

        /// <summary>
        /// Obtiene el ID de la deuda basado en su título.
        /// </summary>
        /// <param name="deuda">Instancia de la deuda.</param>
        /// <returns>El ID de la deuda.</returns>
        public int GetIdDeuda(Deuda deuda)
        {
            int resultado = 0;
            string queryString = $"SELECT idDeuda FROM deuda WHERE titulo = @titulo;";

            using (MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion))
            {
                query.Parameters.AddWithValue("@titulo", deuda.titulo);

                ConexionDB.AbrirConexion();
                using (MySqlDataReader reader = query.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        resultado = reader.GetInt32(0);
                    }
                }
                ConexionDB.CerrarConexion();
            }
            return resultado;
        }

        /// <summary>
        /// Verifica si una deuda existe en la base de datos.
        /// </summary>
        /// <param name="tit">Título de la deuda.</param>
        /// <returns>Verdadero si la deuda existe; de lo contrario, falso.</returns>
        public static bool ExisteDeuda(string tit)
        {
            string queryString = $"SELECT titulo FROM deuda WHERE titulo = @titulo AND numCuenta = {Sesion.Instance.NumCuenta};";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@titulo", tit);

            ConexionDB.AbrirConexion();

            bool existe;

            using (MySqlDataReader reader = query.ExecuteReader())
            {
                existe = reader.HasRows;
            }

            ConexionDB.CerrarConexion();

            return existe;
        }

        /// <summary>
        /// Obtiene información detallada de una deuda.
        /// </summary>
        /// <param name="tit">Título de la deuda.</param>
        /// <param name="deuda">Instancia de la deuda.</param>
        /// <returns>Instancia de la deuda con información actualizada.</returns>
        public static Deuda GetDeuda(string tit, Deuda deuda)
        {
            string queryString = $"SELECT descripcion, debo, cantidad, fechaCreacion, fechaVencimiento FROM deuda WHERE titulo = @titulo AND numCuenta = {Sesion.Instance.NumCuenta};";

            using (MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion))
            {
                query.Parameters.AddWithValue("@titulo", tit);

                ConexionDB.AbrirConexion();
                using (MySqlDataReader reader = query.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        deuda.descripcion = reader.GetSafeString(0);
                        deuda.debo = reader.GetBoolean(1);
                        deuda.cantidad = reader.GetDecimal(2);
                        deuda.fechaCreacion = Convert.ToDateTime(reader.GetDateTime(3).ToString("dd/MM/yyyy"));
                        deuda.fechaVencimiento = Convert.ToDateTime(reader.GetDateTime(4).ToString("dd/MM/yyyy"));
                    }
                }
                ConexionDB.CerrarConexion();
            }
            return deuda;
        }

        /// <summary>
        /// Elimina una deuda de la base de datos.
        /// </summary>
        /// <param name="tit">Título de la deuda a eliminar.</param>
        /// <returns>El número de filas afectadas.</returns>
        public static int EliminarDeuda(string tit)
        {
            int resultado = 0;

            string consulta = $"DELETE FROM deuda WHERE titulo = '{tit}' AND numCuenta = {Sesion.Instance.NumCuenta};";

            ConexionDB.AbrirConexion();
            using (MySqlCommand comando = new MySqlCommand(consulta, ConexionDB.Conexion))
            {
                resultado = comando.ExecuteNonQuery();
            }
            ConexionDB.CerrarConexion();

            return resultado;
        }

        /// <summary>
        /// Obtiene la cantidad total de deudas.
        /// </summary>
        /// <returns>El número total de deudas.</returns>
        public static int DeudasTotales()
        {
            int resultado = 0;

            string queryString = "SELECT COUNT(idDeuda) FROM deuda WHERE numCuenta = @numCuenta AND debo = TRUE;";

            using (MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion))
            {
                query.Parameters.AddWithValue("@numCuenta", Sesion.Instance.NumCuenta);
                ConexionDB.AbrirConexion();
                using (MySqlDataReader reader = query.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        resultado = reader.GetInt32(0);
                    }
                    else
                    {
                        resultado = 0;
                    }
                }
                ConexionDB.CerrarConexion();
            }

            return resultado;
        }

        /// <summary>
        /// Obtiene información sobre la próxima deuda basada en la fecha de vencimiento más próxima.
        /// </summary>
        /// <param name="deuda">Instancia de la deuda.</param>
        public void GetProximaDeuda(Deuda deuda)
        {
            string queryString = "SELECT titulo, debo, MIN(fechaVencimiento) FROM deuda WHERE numCuenta = @numCuenta;";

            using (MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion))
            {
                query.Parameters.AddWithValue("@numCuenta", Sesion.Instance.NumCuenta);

                ConexionDB.AbrirConexion();
                using (MySqlDataReader reader = query.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        deuda.titulo = reader.GetSafeString(0);
                        deuda.debo = !reader.IsDBNull(1) && reader.GetBoolean(1);
                        deuda.fechaVencimiento = reader.IsDBNull(2) ? DateTime.MinValue : Convert.ToDateTime(reader.GetDateTime(2).ToString("dd/MM/yyyy"));
                    }
                }
                ConexionDB.CerrarConexion();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Filtros para el combobox</returns>
        public static string[] Filtros()
        {
            string[] filtro;
            if (Sesion.Instance.Espanyol) filtro = new string[] { "Título", "Precio max.", "Precio min.", "Fecha deuda", "Fecha vencim" };
            else filtro = new string[] { "Title", "Max price", "Min price", "Debt date", "Due date" };
            return filtro;
        }

        /// <summary>
        /// Recarga la tabla de deudas.
        /// </summary>
        /// <returns>Un DataTable con los datos de las deudas.</returns>
        public static DataTable RecargarTabla()
        {
            return Utilidades.RellenarDatos($"SELECT titulo, descripcion, cantidad, fechaCreacion, fechaVencimiento FROM deuda WHERE numCuenta = {Sesion.Instance.NumCuenta}");
        }

        /// <summary>
        /// Recarga la tabla de deudas con filtro de si debes o te deben.
        /// </summary>
        /// <param name="debo">true si debes, fales si te deben</param>
        /// <returns>Un DataTable con los datos de las deudas, que debes o te deben</returns>
        public static DataTable RecargarTabla(bool debo)
        {
            return Utilidades.RellenarDatos($"SELECT titulo, descripcion, cantidad, fechaCreacion, fechaVencimiento FROM deuda WHERE numCuenta = {Sesion.Instance.NumCuenta} AND debo = {debo}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filtro"></param>
        /// <param name="debo"></param>
        /// <param name="titulo"></param>
        /// <returns></returns>
        public static DataTable CargarFiltro(string filtro, bool debo, string titulo)
        {
            int numCuenta = Sesion.Instance.NumCuenta;
            string consulta = $"SELECT titulo, descripcion, cantidad, fechaCreacion, fechaVencimiento FROM deuda WHERE numCuenta = {numCuenta} AND debo = {debo}";
            switch (filtro)
            {
                case "Título":
                    consulta += $" AND titulo = '{titulo}'";
                    break;
                case "Precio max.":
                    consulta += $" AND cantidad = (SELECT MAX(cantidad) FROM deuda WHERE numCuenta = {numCuenta} AND debo = {debo})";
                    break;
                case "Precio min.":
                    consulta += $" AND cantidad = (SELECT MIN(cantidad) FROM deuda WHERE numCuenta = {numCuenta} AND debo = {debo})";
                    break;
                case "Fecha deuda":
                    consulta += $" AND fechaCreacion = (SELECT MIN(fechaCreacion) FROM deuda WHERE numCuenta = {numCuenta} AND debo = {debo})";
                    break;
                case "Fecha vencim":
                    consulta += $" AND fechaVencimiento = (SELECT MIN(fechaVencimiento) FROM deuda WHERE numCuenta = {numCuenta} AND debo = {debo})";
                    break;

                default:
                    break;
            }

            return Utilidades.RellenarDatos(consulta);
        }

        /// <summary>
        /// Calcula el total de las deudas.
        /// </summary>
        /// <param name="debo">True: deudas que tebes, false: deudas que te deben</param>
        /// <returns>Retorna el total de las deudas</returns>
        public static double CalcularTotalDeuda(bool debo)
        {
            float? resultado = null;
            string consulta = $"SELECT SUM(cantidad) FROM deuda WHERE numCuenta = {Sesion.Instance.NumCuenta} AND debo = {debo}";

            using (MySqlCommand query = new MySqlCommand(consulta, ConexionDB.Conexion))
            {
                ConexionDB.AbrirConexion();
                using (MySqlDataReader reader = query.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        resultado = reader.GetSafeFloat(0);
                    }
                }
                ConexionDB.CerrarConexion();
            }

            return resultado == null ? 0 : Convert.ToDouble(resultado);
        }
    }
}
