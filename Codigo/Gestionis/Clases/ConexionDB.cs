using MySql.Data.MySqlClient;

namespace Gestionis.Clases
{
    internal static class ConexionDB
    {
        private static MySqlConnection? conexion = null;

        private static readonly object padlock = new object();

        public static MySqlConnection Conexion
        {
            get
            {
                lock (padlock)
                {
                    if (conexion == null)
                    {
                        conexion = new MySqlConnection();
                        conexion.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=gestionis";
                    }

                    return conexion;
                }
            }
        }

        public static void AbrirConexion()
        {
            if (conexion != null)
            {
                conexion.Open();
            }
        }

        public static void CerrarConexion()
        {
            if (conexion != null)
            {
                conexion.Close();
            }
        }
    }
}
