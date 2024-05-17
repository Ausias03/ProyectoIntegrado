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
        private int? idCategoria;
        private string nombre;

        public CategoriaIngreso(string nombre)
        {
            this.idCategoria = null;
            this.nombre = nombre;
        }

        public CategoriaIngreso(int idCategoria, string nombre)
        {
            this.idCategoria = idCategoria;
            this.nombre = nombre;
        }

        public static bool ExisteNombre(string nombre)
        {
            string queryString = "SELECT idCategoria FROM categoriaIngreso WHERE nombre = @nombre;";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@nombre", nombre);

            ConexionDB.AbrirConexion();

            bool existe;

            using (MySqlDataReader result = query.ExecuteReader())
            {
                existe = result.HasRows;
            }

            ConexionDB.CerrarConexion();

            return existe;
        }

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

        public void Add()
        {
            string queryString = "INSERT INTO categoriaIngreso (idCategoria, nombre) " +
                "VALUES (@idCategoria, @nombre);";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@idCategoria", idCategoria);
            query.Parameters.AddWithValue("@nombre", nombre);

            ConexionDB.AbrirConexion();

            query.ExecuteNonQuery();

            ConexionDB.CerrarConexion();
        }
    }
}
