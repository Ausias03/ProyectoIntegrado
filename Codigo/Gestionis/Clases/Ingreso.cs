using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Crud.Order.Types;

namespace Gestionis.Clases
{
    internal class Ingreso
    {
        private int? idIngreso;
        private int numCuenta;
        private string nombre;
        private float cantidad;
        private string tipo;
        private int categoria;        
        private string? comentarios;
        private DateTime fecha;
        private TimeSpan hora;

        #region Constructores
        public Ingreso(int numCuenta, string nombre, float cantidad, int categoria,
            string tipo, string? comentarios)
        {
            this.idIngreso = null;
            this.numCuenta = numCuenta;
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.categoria = categoria;
            this.tipo = tipo;
            this.comentarios = comentarios;
            this.fecha = DateTime.Today;
            this.hora = DateTime.Now.TimeOfDay;
        }

        public Ingreso(int idGasto, int numCuenta, string nombre, float cantidad, int categoria,
            string tipo, string? comentarios, DateTime fecha, TimeSpan hora)
        {
            this.idIngreso = idGasto;
            this.numCuenta = numCuenta;
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.categoria = categoria;
            this.tipo = tipo;
            this.comentarios = comentarios;
            this.fecha = fecha;
            this.hora = hora;
        }
        #endregion

        public float Cantidad { get { return cantidad; } }

        public static List<Ingreso> DevuelveIngresos(int numCuenta)
        {
            List<Ingreso> ingresos = new List<Ingreso>();

            string queryString = "SELECT * FROM gasto";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);

            ConexionDB.AbrirConexion();

            using (MySqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    ingresos.Add(new Ingreso(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetString(2),
                        reader.GetFloat(3),
                        reader.GetInt32(4),
                        reader.GetString(5),
                        reader.GetSafeString(6),
                        reader.GetDateTime(7),
                        reader.GetTimeSpan(8)
                    ));
                }
            }

            ConexionDB.CerrarConexion();

            return ingresos;
        }

        public void Add()
        {
            string queryString = "INSERT INTO gasto (idGasto, numCuenta, nombre, cantidad," +
                "categoria, tipo, comentarios, fecha, hora) " +
                "VALUES (@idGasto, @numCuenta, @nombre, @cantidad, @categoria, @tipo, @comentarios," +
                "@fecha, @hora);";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@idGasto", idIngreso);
            query.Parameters.AddWithValue("@numCuenta", numCuenta);
            query.Parameters.AddWithValue("@nombre", nombre);
            query.Parameters.AddWithValue("@cantidad", cantidad);
            query.Parameters.AddWithValue("@categoria", categoria);
            query.Parameters.AddWithValue("@tipo", tipo);
            query.Parameters.AddWithValue("@comentarios", comentarios);
            query.Parameters.AddWithValue("@fecha", fecha);
            query.Parameters.AddWithValue("@hora", hora);

            ConexionDB.AbrirConexion();

            query.ExecuteNonQuery();

            ConexionDB.CerrarConexion();
        }

        //#region Arreglar
        //public static List<Ingreso> BusquedaFecha(MySqlConnection conexion, DateTime fecha, int numCuenta)
        //{
        //    List<Ingreso> lista = new List<Ingreso>();
        //    string consulta = String.Format("SELECT ingreso.hora,ingreso.tipo,categoriaingreso.nombre AS categoria,ingreso.nombre," +
        //    "ingreso.cantidad,ingreso.comentarios FROM ingreso INNER JOIN categoriaingreso WHERE fecha = '{0}' " +
        //    "AND numCuenta = '{1}';", fecha.ToString("yyyy/MM/dd"), numCuenta);
        //    MySqlCommand comando = new MySqlCommand(consulta, conexion);
        //    MySqlDataReader reader = comando.ExecuteReader();

        //    if (reader.HasRows)
        //    {
        //        while (reader.Read())
        //        {
        //            Ingreso nuevo;
        //            nuevo = new Ingreso(reader.GetTimeSpan(0), reader.GetString(1), reader.GetString(2),
        //                reader.GetString(3), reader.GetString(4), reader.GetDouble(5));
        //            lista.Add(nuevo);
        //        }
        //    }
        //    reader.Close();
        //    return lista;

        //}‌

        //public static List<Ingreso> Historial(MySqlConnection conexion, int numCuenta)
        //{
        //    DateTime fecha = DateTime.Today;
        //    List<Ingreso> lista = new List<Ingreso>();
        //    string consulta = String.Format("SELECT ingreso.hora,ingreso.tipo,categoriaingreso.nombre AS categoria,ingreso.nombre," +
        //    "ingreso.cantidad,ingreso.comentarios FROM ingreso INNER JOIN categoriaingreso WHERE fecha = '{0}' " +
        //    "AND numCuenta = '{1}';", fecha.ToString("yyyy/MM/dd"), numCuenta);
        //    MySqlCommand comando = new MySqlCommand(consulta, conexion);
        //    MySqlDataReader reader = comando.ExecuteReader();

        //    if (reader.HasRows)
        //    {
        //        while (reader.Read())
        //        {
        //            Ingreso nuevo;
        //            nuevo = new Ingreso(reader.GetTimeSpan(0), reader.GetString(1), reader.GetString(2),
        //                reader.GetString(3), reader.GetString(4), reader.GetDouble(5));
        //            lista.Add(nuevo);
        //        }
        //    }
        //    reader.Close();
        //    return lista;

        //}‌

        //public static List<Ingreso> BusquedaMetodica(MySqlConnection conexion, int filtrar, string param, DateTime fecha, int numCuenta)
        //{
        //    string filtro = "";
        //    switch (filtrar)
        //    {
        //        case 1:
        //            filtro = "categoriaingreso.nombre";
        //            break;
        //        case 2:
        //            filtro = "ingreso.nombre";
        //            break;
        //        case 3:
        //            filtro = "ingreso.cantidad";
        //            break;
        //    }
        //    List<Ingreso> lista = new List<Ingreso>();
        //    string consulta = String.Format("SELECT ingreso.hora,ingreso.tipo,categoriaingreso.nombre AS categoria,ingreso.nombre," +
        //    "ingreso.cantidad,ingreso.comentarios FROM ingreso INNER JOIN categoriaingreso WHERE fecha = '{0}' AND numCuenta = '{1}' AND {2} = '{3}';",
        //    fecha.ToString("yyyy/MM/dd"), numCuenta, filtro, param);
        //    MySqlCommand comando = new MySqlCommand(consulta, conexion);
        //    MySqlDataReader reader = comando.ExecuteReader();

        //    if (reader.HasRows)
        //    {
        //        while (reader.Read())
        //        {
        //            Ingreso nuevo;
        //            nuevo = new Ingreso(reader.GetTimeSpan(0), reader.GetString(1), reader.GetString(2),
        //                reader.GetString(3), reader.GetString(4), reader.GetDouble(5));
        //            lista.Add(nuevo);
        //        }
        //    }
        //    reader.Close();
        //    return lista;

        //}‌

        //public static List<Ingreso> BusquedaTipo(MySqlConnection conexion, string tipo, DateTime fecha, int numCuenta)
        //{
        //    List<Ingreso> lista = new List<Ingreso>();
        //    string consulta = String.Format("SELECT ingreso.hora,ingreso.tipo,categoriaingreso.nombre AS categoria,ingreso.nombre," +
        //    "ingreso.cantidad,ingreso.comentarios FROM ingreso INNER JOIN categoriaingreso WHERE fecha = '{0}' AND numCuenta = '{1}' AND tipo = '{2}';",
        //    fecha.ToString("yyyy/MM/dd"), numCuenta, tipo);
        //    MySqlCommand comando = new MySqlCommand(consulta, conexion);
        //    MySqlDataReader reader = comando.ExecuteReader();

        //    if (reader.HasRows)
        //    {
        //        while (reader.Read())
        //        {
        //            Ingreso nuevo;
        //            nuevo = new Ingreso(reader.GetTimeSpan(0), reader.GetString(1), reader.GetString(2),
        //                reader.GetString(3), reader.GetString(4), reader.GetDouble(5));
        //            lista.Add(nuevo);
        //        }
        //    }
        //    reader.Close();
        //    return lista;

        //}
        //#endregion
    }
}
