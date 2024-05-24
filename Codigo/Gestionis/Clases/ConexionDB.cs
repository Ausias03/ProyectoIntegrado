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
                        conexion.ConnectionString = "server=sql11.freesqldatabase.com;" +
                            "port=3306;" +
                            "database=sql11699221;" +
                            "uid=sql11699221;" +
                            "pwd=2uxGcND89X;";
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
