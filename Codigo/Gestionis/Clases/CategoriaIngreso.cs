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
        /// <summary>
        /// Devuelve los nombres de todas las categorías de ingresos dadas de alta en la BD
        /// </summary>
        /// <returns>Una lista de strings con todos los nombres</returns>
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

        /// <summary>
        /// Busca una categoría por su nombre y devuelve su ID
        /// </summary>
        /// <param name="nombre">El nombre de la categoría a buscar</param>
        /// <returns>El ID de la categoría como int</returns>
        public static int? DevuelveIDCategoria(string nombre)
        {
            string queryString = "SELECT idCategoria FROM categoriaIngreso WHERE nombre = @nombre";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@nombre", nombre);

            ConexionDB.AbrirConexion();

            int? limite = null;

            using (MySqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    limite = reader.GetSafeInt32(0);
                }
            }

            ConexionDB.CerrarConexion();

            return limite;
        }

        /// <summary>
        /// Busca una categoría por su ID y devuelve su nombre
        /// </summary>
        /// <param name="idCat">El ID de la categoría a buscar</param>
        /// <returns>El nombre de la categoría como string</returns>
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
