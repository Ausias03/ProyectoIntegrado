using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionis.Clases
{
    internal class Notificacion
    {
        private int id;
        private int numCuenta;
        private string titulo;
        private string categoria;
        private string? descripcion;
        private DateTime fecha;

        public Notificacion(int id, int numCuenta, string titulo, string categoria, string? descripcion, DateTime fecha)
        {
            this.id = id;
            this.numCuenta = numCuenta;
            this.titulo = titulo;
            this.categoria = categoria;
            this.descripcion = descripcion;
            this.fecha = fecha;
        }

        public string Titulo { get { return titulo; } }
        public string Categoria { get { return categoria; } }
        public string? Descripcion { get { return descripcion; } }

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
                        reader.GetString(3),
                        reader.GetSafeString(4),
                        reader.GetDateTime(5)
                    ));
                }
            }

            ConexionDB.CerrarConexion();

            return notificaciones;
        }
    }
}
