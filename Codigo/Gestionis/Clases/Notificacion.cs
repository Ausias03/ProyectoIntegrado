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
    internal class Notificacion
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

        public static bool ExisteNotif(string categoria)
        {
            string queryString = "SELECT idNotificacion FROM notificacion WHERE categoria IN" +
                "(SELECT idCategoria FROM categoriaGasto WHERE nombre = @nombreCategoria);";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@nombreCategoria", categoria);

            ConexionDB.AbrirConexion();

            bool existe;

            using (MySqlDataReader reader = query.ExecuteReader())
            {
                existe = reader.HasRows;
            }

            ConexionDB.CerrarConexion();

            return existe;
        }

        public void Add()
        {
            string queryString = "INSERT INTO notificacion (idNotificacion, numCuenta, titulo, categoria, descripcion, recomendacion, fecha) " +
                "VALUES (@idNotificacion, @numCuenta, @titulo, @categoria, @descripcion, @recomendacion, @fecha);";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@idNotificacion", id);
            query.Parameters.AddWithValue("@numCuenta", numCuenta);
            query.Parameters.AddWithValue("@titulo", titulo);
            query.Parameters.AddWithValue("@categoria", categoria);
            query.Parameters.AddWithValue("@descripcion", descripcion);
            query.Parameters.AddWithValue("@recomendacion", recomendacion);
            query.Parameters.AddWithValue("@fecha", fecha);

            ConexionDB.AbrirConexion();

            query.ExecuteNonQuery();

            ConexionDB.CerrarConexion();
        }
    }
}