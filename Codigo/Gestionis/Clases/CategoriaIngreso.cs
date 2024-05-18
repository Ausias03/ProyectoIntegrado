using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionis.Clases
{
    internal class CategoriaIngreso
    {
        public static List<String> DevuelveNombresCategorias()
        {
            List<String> nombresCategorias = new List<string>();

            string queryString = "SELECT nombre FROM categoriaIngreso";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);

            ConexionDB.AbrirConexion();

            using (MySqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    nombresCategorias.Add(
                        reader.GetString(0)
                    );
                }
            }

            ConexionDB.CerrarConexion();            

            return nombresCategorias;
        }
        
        public static int DevuelveIDCategoria(string nombre)
        {
            string queryString = "SELECT idCategoria FROM categoriaIngreso WHERE nombre = @nombre";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@nombre", nombre);

            ConexionDB.AbrirConexion();

            int idCategoria = (int)query.ExecuteScalar();

            ConexionDB.CerrarConexion();

            return idCategoria;
        }

        public static string DevuelveNombreCategoria(int? idCat)
        {
            if (idCat == null)
            {
                return string.Empty;
            }

            string queryString = "SELECT nombre FROM categoriaIngreso WHERE idCategoria = @idCategoria";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@idCategoria", idCat);

            ConexionDB.AbrirConexion();

            string nombreCategoria = query.ExecuteScalar().ToString();

            ConexionDB.CerrarConexion();

            return nombreCategoria;
        }
    }
}
