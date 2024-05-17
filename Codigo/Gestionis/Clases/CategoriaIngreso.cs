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
        private int color;

        public CategoriaIngreso(string nombre, int color)
        {
            this.idCategoria = null;
            this.nombre = nombre;
            this.color = color;
        }

        public CategoriaIngreso(int idCategoria, string nombre, int color)
        {
            this.idCategoria = idCategoria;
            this.nombre = nombre;
            this.color = color;
        }

        public static bool ExisteColor(int color)
        {
            string queryString = "SELECT idCategoria FROM categoriaGasto WHERE color = @color;";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@color", color);

            ConexionDB.AbrirConexion();

            bool existe;

            using (MySqlDataReader result = query.ExecuteReader())
            {
                existe = result.HasRows;
            }

            ConexionDB.CerrarConexion();

            return existe;
        }

        public static bool ExisteNombre(string nombre)
        {
            string queryString = "SELECT idCategoria FROM categoriaGasto WHERE nombre = @nombre;";

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

            string queryString = "SELECT nombre FROM categoriaGasto";

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
            string queryString = "SELECT idCategoria FROM categoriaGasto WHERE nombre = @nombre";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@nombre", nombre);

            ConexionDB.AbrirConexion();

            int idCategoria = (int)query.ExecuteScalar();

            ConexionDB.CerrarConexion();

            return idCategoria;
        }

        public void Add()
        {
            string queryString = "INSERT INTO categoriaGasto (idCategoria, nombre, color) " +
                "VALUES (@idCategoria, @nombre, @color);";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@idCategoria", idCategoria);
            query.Parameters.AddWithValue("@nombre", nombre);
            query.Parameters.AddWithValue("@color", color);

            ConexionDB.AbrirConexion();

            query.ExecuteNonQuery();

            ConexionDB.CerrarConexion();
        }
    }
}
