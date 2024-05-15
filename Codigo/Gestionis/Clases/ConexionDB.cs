using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                        conexion.ConnectionString = "server=localhost;" +
                            "port=3306;" +
                            "database=gestionis;" +
                            "uid=root;" +
                            "pwd=;";
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
