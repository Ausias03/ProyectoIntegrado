using MySql.Data.MySqlClient;

namespace Gestionis.Clases
{
    internal class CategoriaGasto
    {
        private int? idCategoria;
        private string nombre;
        private int color;

        public CategoriaGasto(string nombre, int color)
        {
            this.idCategoria = null;
            this.nombre = nombre;
            this.color = color;
        }

        public CategoriaGasto(int idCategoria, string nombre, int color)
        {
            this.idCategoria = idCategoria;
            this.nombre = nombre;
            this.color = color;
        }

        /// <summary>
        /// Comprueba si hay una categoría de gastos con el color suministrado
        /// </summary>
        /// <param name="color">El color en formato ARGB a comprobar</param>
        /// <returns>TRUE si existe, FALSE si no</returns>
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

        /// <summary>
        /// Comprueba si hay una categoría de gastos con el nombre suministrado
        /// </summary>
        /// <param name="nombre">El nombre de la categoria a comprobar</param>
        /// <returns>TRUE si existe, FALSE si no</returns>
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

        /// <summary>
        /// Devuelve los nombres de todas las categorías de gastos dadas de alta en la BD
        /// </summary>
        /// <returns>Una lista de strings con todos los nombres</returns>
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

        /// <summary>
        /// Busca una categoría por su nombre y devuelve su ID
        /// </summary>
        /// <param name="nombre">El nombre de la categoría a buscar</param>
        /// <returns>El ID de la categoría como int</returns>
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

        /// <summary>
        /// Busca una categoría por su ID y devuelve su nombre
        /// </summary>
        /// <param name="idCat">El ID de la categoría a buscar</param>
        /// <returns>El nombre de la categoría como string</returns>
        public static string DevuelveNombreCategoria(int idCat)
        {
            string queryString = "SELECT nombre FROM categoriaGasto WHERE idCategoria = @idCategoria";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@idCategoria", idCat);

            ConexionDB.AbrirConexion();

            string? nombreCategoria = query.ExecuteScalar().ToString();

            ConexionDB.CerrarConexion();

            return nombreCategoria ?? String.Empty;
        }

        /// <summary>
        /// Busca una categoría por su ID y devuelve su color asignado
        /// </summary>
        /// <param name="idCategoria">El ID de la categoría a buscar</param>
        /// <returns>El color de la categoría como int en formato ARGB</returns>
        public static int GetColor(int idCategoria)
        {
            string queryString = "SELECT color FROM categoriaGasto WHERE idCategoria = @idCategoria;";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@idCategoria", idCategoria);

            ConexionDB.AbrirConexion();

            int color = (int)query.ExecuteScalar();

            ConexionDB.CerrarConexion();

            return color;
        }

        /// <summary>
        /// Añade una categoría de gasto a la base de datos
        /// </summary>
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
