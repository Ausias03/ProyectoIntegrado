using MySql.Data.MySqlClient;

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

        public string Titulo { get { return titulo; } }
        public string Descripcion { get { return descripcion; } }
        public bool Debo { get { return debo; } }
        public decimal Cantidad { get { return cantidad; } }
        public DateTime FechaCreacion { get { return fechaCreacion; } }
        public DateTime FechaVencimiento { get { return fechaVencimiento; } }

        public Deuda() { }

        public Deuda(int cuenta, string tit, string descrip, bool deb, decimal cant, DateTime fechaCrea, DateTime fechaVenc, bool record)
        {
            idDeuda = null;
            numCuenta = cuenta;
            titulo = tit;
            descripcion = descrip;
            debo = deb;
            cantidad = cant;
            fechaCreacion = fechaCrea;
            fechaVencimiento = fechaVenc;
            anyadirRecordatorio = record;
        }

        public int Add()
        {
            int resultado = 0;
            string fechaVencimiento = this.fechaVencimiento.ToString("yyyy/MM/dd");
            string fechaCreacion = this.fechaCreacion.ToString("yyyy/MM/dd");

            string queryString = "INSERT INTO deuda (idDeuda, numCuenta, titulo, descripcion," +
                "debo, cantidad, fechaCreacion, fechaVencimiento, anyadirRecordatorio) " +
                "VALUES (@idDeuda, @numCuenta, @titulo, @descripcion, @debo, @cantidad," +
                "@fechaCreacion, @fechaVencimiento, @anyadirRecordatorio);";

            try
            {
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
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return resultado;
        }

        public static bool ExisteDeuda(string tit)
        {
            string queryString = "SELECT titulo FROM deuda WHERE titulo = @titulo;";

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

        public static Deuda GetDeuda(string tit, Deuda deuda)
        {
            string queryString = "SELECT descripcion, debo, cantidad, fechaCreacion, fechaVencimiento FROM deuda WHERE titulo = @titulo;";

            using (MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion))
            {
                query.Parameters.AddWithValue("@titulo", tit);

                ConexionDB.AbrirConexion();
                using (MySqlDataReader reader = query.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        deuda.descripcion = reader.GetString(0);
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

        public static int EliminarDeuda(string tit)
        {
            int resultado = 0;

            string consulta = String.Format("DELETE FROM deuda WHERE titulo LIKE ('{0}');", tit);

            ConexionDB.AbrirConexion();
            using (MySqlCommand comando = new MySqlCommand(consulta, ConexionDB.Conexion))
            {
                resultado = comando.ExecuteNonQuery();
            }
            ConexionDB.CerrarConexion();

            return resultado;
        }

        public static int DeudasTotales(int numCuenta)
        {
            int resultado = 0;

            string queryString = "SELECT COUNT(idDeuda) FROM deuda WHERE numCuenta = @numCuenta AND debo = TRUE;";

            try
            {
                using (MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion))
                {
                    query.Parameters.AddWithValue("@numCuenta", numCuenta);

                    ConexionDB.AbrirConexion();
                    resultado = Convert.ToInt32(query.ExecuteScalar());
                    ConexionDB.CerrarConexion();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return resultado;
        }

        public void GetProximaDeuda(int numCuenta, Deuda deuda)
        {
            string queryString = "SELECT titulo, debo, MIN(fechaVencimiento) FROM deuda WHERE numCuenta = @numCuenta;";

            using (MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion))
            {
                query.Parameters.AddWithValue("@numCuenta", numCuenta);

                ConexionDB.AbrirConexion();
                using (MySqlDataReader reader = query.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        deuda.titulo = reader.GetString(0);
                        deuda.debo = reader.GetBoolean(1);
                        deuda.fechaVencimiento = Convert.ToDateTime(reader.GetDateTime(2).ToString("dd/MM/yyyy"));
                    }
                }
                ConexionDB.CerrarConexion();
            }            
        }

        public static string[] Filtros()
        {
            string[] filtro = { "Título", "Precio max.", "Precio min.", "Fecha deuda", "Fecha vencim" };
            return filtro;
        }
    }
}
