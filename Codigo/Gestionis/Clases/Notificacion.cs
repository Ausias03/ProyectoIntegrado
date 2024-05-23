using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Gestionis.Clases
{
    public class Notificacion
    {
        private int? id;
        private int numCuenta;
        private string titulo;
        private int categoria;
        private string descripcion;
        private string recomendacion;
        private DateTime fecha;

        public Notificacion(int? id, int numCuenta, string titulo, int categoria, 
            string descripcion, string recomendacion, DateTime fecha)
        {
            this.id = id;
            this.numCuenta = numCuenta;
            this.titulo = titulo;
            this.categoria = categoria;
            this.descripcion = descripcion;
            this.recomendacion = recomendacion;
            this.fecha = fecha;
        }

        public string Titulo { get { return titulo; } }
        public int Categoria { get { return categoria; } }        
        public string Descripcion { get { return descripcion; } }
        public string Recomendacion { get { return recomendacion; } }

        /// <summary>
        /// Devuelve todas las notificaciones de una cuenta
        /// </summary>
        /// <param name="numCuenta">El número de la cuenta</param>
        /// <returns>Una lista con todas las notificaciones encontradas</returns>
        public static List<Notificacion> GetAllNotificaciones(int numCuenta)
        {
            string queryString = "SELECT * FROM notificacion WHERE numCuenta = @numCuenta";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@numCuenta", numCuenta);

            List<Notificacion> notificaciones = new List<Notificacion>();
            ConexionDB.AbrirConexion();

            using (MySqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    notificaciones.Add(new Notificacion(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetString(2),
                        reader.GetInt32(3),
                        reader.GetString(4),
                        reader.GetString(5),
                        reader.GetDateTime(6)
                    ));
                }
            }

            ConexionDB.CerrarConexion();

            return notificaciones;
        }

        /// <summary>
        /// Busca si hay una notificación de una categoría a especificar
        /// </summary>
        /// <param name="categoria">La categoría a buscar</param>
        /// <returns>TRUE si existe una notificación, FALSE si no</returns>
        public static bool ExisteNotif(int categoria)
        {
            string queryString = "SELECT idNotificacion FROM notificacion WHERE idCategoria IN" +
                "(SELECT idCategoria FROM categoriaGasto WHERE idCategoria = @idCategoria);";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@idCategoria", categoria);

            ConexionDB.AbrirConexion();

            bool existe;

            using (MySqlDataReader reader = query.ExecuteReader())
            {
                existe = reader.HasRows;
            }

            ConexionDB.CerrarConexion();

            return existe;
        }

        /// <summary>
        /// Compendio de recomendaciones para las notificaciones de cada categoría
        /// </summary>
        /// <param name="nombreCategoria">El nombre de la categoría</param>
        /// <returns>La recomendación de la notificación de la categoría suministrada por parámetros</returns>
        public static string GetRecomendacion(string nombreCategoria)
        {
            switch (nombreCategoria)
            {
                case "Restaurante":
                    return "Considera cocinar en casa";
                case "Supermercado":
                    return "Considera comprar en supermercados con ofertas";
                case "Gasolina":
                    return "Considera utilizar el transporte público";
                case "Entretenimiento":
                    return "Considera cancelar suscripciones a servicios de series/películas";
                case "Luz":
                    return "Considera reducir el consumo eléctrico con bombillas LED";
                default:
                    return $"Considera gastar menos dinero en {nombreCategoria}";
            }
        }

        /// <summary>
        /// Añade una notificación a la base de datos
        /// </summary>
        public void Add()
        {
            string queryString = "INSERT INTO notificacion (idNotificacion, numCuenta, titulo, idCategoria, descripcion, recomendacion, fecha) " +
                "VALUES (@idNotificacion, @numCuenta, @titulo, @idCategoria, @descripcion, @recomendacion, @fecha);";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@idNotificacion", id);
            query.Parameters.AddWithValue("@numCuenta", numCuenta);
            query.Parameters.AddWithValue("@titulo", titulo);
            query.Parameters.AddWithValue("@idCategoria", categoria);
            query.Parameters.AddWithValue("@descripcion", descripcion);
            query.Parameters.AddWithValue("@recomendacion", recomendacion);
            query.Parameters.AddWithValue("@fecha", fecha);

            ConexionDB.AbrirConexion();

            query.ExecuteNonQuery();

            ConexionDB.CerrarConexion();
        }
    }
}