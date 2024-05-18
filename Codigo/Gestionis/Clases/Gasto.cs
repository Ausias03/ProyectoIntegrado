using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Crud.Order.Types;

namespace Gestionis.Clases
{
    public class Gasto
    {
        private static List<String> tiposGasto = new List<String>() { "Fijo", "Variable" };

        private int? idGasto;
        private int numCuenta;
        private string nombre;
        private float cantidad;
        private int categoria;
        private string tipo;
        private string? comentarios;
        private DateTime fecha;
        private TimeSpan hora;

        public Gasto(int numCuenta, string nombre, float cantidad, int categoria,
            string tipo, string? comentarios)
        {
            this.idGasto = null;
            this.numCuenta = numCuenta;
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.categoria = categoria;
            this.tipo = tipo;
            this.comentarios = comentarios;
            this.fecha = DateTime.Today;
            this.hora = DateTime.Now.TimeOfDay;
        }

        public Gasto(int idGasto, int numCuenta, string nombre, float cantidad, int categoria,
            string tipo, string? comentarios, DateTime fecha, TimeSpan hora)
        {
            this.idGasto = idGasto;
            this.numCuenta = numCuenta;
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.categoria = categoria;
            this.tipo = tipo;
            this.comentarios = comentarios;
            this.fecha = fecha;
            this.hora = hora;
        }

        // Necesarias para el dataSource de FrmMenuPrincipal
        #region Propiedades
        public static List<String> TiposGasto { get { return tiposGasto; } }
        public int? IdGasto { get { return idGasto; } }
        public int NumCuenta { get { return numCuenta; } }
        public string Nombre { get { return nombre; } }
        public float Cantidad { get { return cantidad; } }
        public string Categoria { get { return CategoriaGasto.DevuelveNombreCategoria(categoria); } }
        public string Tipo { get { return tipo; } }
        public string? Comentarios { get { return comentarios; } }
        public DateTime Fecha { get { return fecha; } }
        public TimeSpan Hora { get {  return hora; } }
        #endregion        

        public void Add()
        {
            string queryString = "INSERT INTO gasto (idGasto, numCuenta, nombre, cantidad," +
                "categoria, tipo, comentarios, fecha, hora) " +
                "VALUES (@idGasto, @numCuenta, @nombre, @cantidad, @categoria, @tipo, @comentarios," +
                "@fecha, @hora);";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@idGasto", idGasto);
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
        //public static List<Gasto> BusquedaFecha(MySqlConnection conexion, DateTime fecha, int numCuenta)
        //{
        //    List<Gasto> lista = new List<Gasto>();
        //    string consulta = String.Format("SELECT gasto.hora,gasto.tipo,categoriagasto.nombre AS categoria,gasto.nombre," +
        //    "gasto.cantidad,gasto.comentarios FROM gasto INNER JOIN categoriagasto WHERE fecha = '{0}' AND numCuenta = '{1}';",
        //    fecha.ToString("yyyy/MM/dd"), numCuenta);
        //    MySqlCommand comando = new MySqlCommand(consulta, conexion);
        //    MySqlDataReader reader = comando.ExecuteReader();

        //    if (reader.HasRows)
        //    {
        //        while (reader.Read())
        //        {
        //            Gasto nuevo;
        //            nuevo = new Gasto(reader.GetTimeSpan(0), reader.GetString(1), reader.GetString(2),
        //                reader.GetString(3), reader.GetString(4), reader.GetDouble(5));
        //            lista.Add(nuevo);
        //        }
        //    }
        //    reader.Close();
        //    return lista;
        //}‌

        //public static List<Gasto> Historial(MySqlConnection conexion, int numCuenta)
        //{
        //    DateTime fecha = DateTime.Today;
        //    List<Gasto> lista = new List<Gasto>();
        //    string consulta = String.Format("SELECT gasto.hora,gasto.tipo,categoriagasto.nombre AS categoria,gasto.nombre," +
        //    "gasto.cantidad,gasto.comentarios FROM gasto INNER JOIN categoriagasto WHERE fecha = '{0}' AND numCuenta = '{1}';",
        //    fecha.ToString("yyyy/MM/dd"), numCuenta);
        //    MySqlCommand comando = new MySqlCommand(consulta, conexion);
        //    MySqlDataReader reader = comando.ExecuteReader();

        //    if (reader.HasRows)
        //    {
        //        while (reader.Read())
        //        {
        //            Gasto nuevo;
        //            nuevo = new Gasto(reader.GetTimeSpan(0), reader.GetString(1), reader.GetString(2),
        //                reader.GetString(3), reader.GetString(4), reader.GetDouble(5));
        //            lista.Add(nuevo);
        //        }
        //    }
        //    reader.Close();
        //    return lista;

        //}‌

        //public static List<Gasto> BusquedaMetodica(MySqlConnection conexion, int filtrar, string param, DateTime fecha, int numCuenta)
        //{
        //    string filtro = "";
        //    switch (filtrar)
        //    {
        //        case 1:
        //            filtro = "categoriagasto.nombre";
        //            break;
        //        case 2:
        //            filtro = "gasto.nombre";
        //            break;
        //        case 3:
        //            filtro = "gasto.cantidad";
        //            break;
        //    }
        //    List<Gasto> lista = new List<Gasto>();
        //    string consulta = String.Format("SELECT gasto.hora,gasto.tipo,categoriagasto.nombre AS categoria,gasto.nombre," +
        //    "gasto.cantidad,gasto.comentarios FROM gasto INNER JOIN categoriagasto WHERE fecha = '{0}' AND numCuenta = '{1}' AND {2} = '{3}';",
        //    fecha.ToString("yyyy/MM/dd"), numCuenta, filtro, param);
        //    MySqlCommand comando = new MySqlCommand(consulta, conexion);
        //    MySqlDataReader reader = comando.ExecuteReader();

        //    if (reader.HasRows)
        //    {
        //        while (reader.Read())
        //        {
        //            Gasto nuevo;
        //            nuevo = new Gasto(reader.GetTimeSpan(0), reader.GetString(1), reader.GetString(2),
        //                reader.GetString(3), reader.GetString(4), reader.GetDouble(5));
        //            lista.Add(nuevo);
        //        }
        //    }
        //    reader.Close();
        //    return lista;

        //}‌

        //public static List<Gasto> BusquedaTipo(MySqlConnection conexion, string tipo, DateTime fecha, int numCuenta)
        //{
        //    List<Gasto> lista = new List<Gasto>();
        //    string consulta = String.Format("SELECT gasto.hora,gasto.tipo,categoriagasto.nombre AS categoria,gasto.nombre," +
        //    "gasto.cantidad,gasto.comentarios FROM gasto INNER JOIN categoriagasto WHERE fecha = '{0}' AND numCuenta = '{1}' AND tipo = '{2}';",
        //    fecha.ToString("yyyy/MM/dd"), numCuenta, tipo);
        //    MySqlCommand comando = new MySqlCommand(consulta, conexion);
        //    MySqlDataReader reader = comando.ExecuteReader();

        //    if (reader.HasRows)
        //    {
        //        while (reader.Read())
        //        {
        //            Gasto nuevo;
        //            nuevo = new Gasto(reader.GetTimeSpan(0), reader.GetString(1), reader.GetString(2),
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
