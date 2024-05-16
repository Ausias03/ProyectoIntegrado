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
        private float cantidad;
        private DateTime fechaCreacion;
        private DateTime fechaVencimiento;
        private bool anyadirRecordatorio;

        public Deuda()
        {
            
        }
        public Deuda(int cuenta, string tit, string descrip, bool deb, float cant, DateTime fechaCrea, DateTime fechaVenc, bool record)
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

        public void Add()
        {
            int debo = this.debo ? 1 : 0;
            int anyadirRecordatorio = this.anyadirRecordatorio ? 1 : 0;
            string fechaVencimiento = this.fechaVencimiento.ToString("yyyy/MMM/dd");
            string fechaCreacion = this.fechaCreacion.ToString("yyyy/MMM/dd");

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

                    query.ExecuteNonQuery();

                    ConexionDB.CerrarConexion();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public static Deuda GetDeuda(string tit, Deuda deuda)
        {
            string queryString = "SELECT * FROM deuda WHERE tituulo = @titulo;";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@titulo", tit);

            ConexionDB.AbrirConexion();



            ConexionDB.CerrarConexion();

            return deuda;
        }
    }
}
