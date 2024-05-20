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
        private const int limiteRestaurantes = 5;
        private const double limiteEntretenimiento = 50;
        private const double limiteLuz = 0.15;
        private const double limiteSupermercados = 300;

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

        #region Métodos para comprobar si crear notificaciones
        public static bool NotifRestaurante()
        {
            string queryString = "SELECT COUNT(idGasto) FROM gasto " +
                "WHERE categoria IN (SELECT idCategoria FROM categoriagasto WHERE nombre = 'Restaurante');";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);

            ConexionDB.AbrirConexion();

            bool aviso = Convert.ToInt32(query.ExecuteScalar()) >= limiteRestaurantes;

            ConexionDB.CerrarConexion();

            return aviso;
        }

        public static bool NotifEntretenimiento()
        {
            string queryString = "SELECT SUM(cantidad) FROM gasto " +
                "WHERE categoria IN (SELECT idcategoria FROM categoriagasto WHERE nombre = 'Entretenimiento');";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);

            ConexionDB.AbrirConexion();

            bool aviso = Convert.ToDouble(query.ExecuteScalar()) >= limiteEntretenimiento;

            ConexionDB.CerrarConexion();

            return aviso;
        }

        public static bool NotifLuz()
        {
            string queryString = "SELECT SUM(cantidad) FROM gasto " +
                "WHERE categoria IN (SELECT idcategoria FROM categoriagasto WHERE nombre = 'Entretenimiento');";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);

            ConexionDB.AbrirConexion();

            bool aviso = Convert.ToDouble(query.ExecuteScalar()) >= limiteEntretenimiento;

            ConexionDB.CerrarConexion();

            return aviso;
        }
        #endregion

        public void Add()
        {
            string queryString = "INSERT INTO gasto (idGasto, numCuenta, nombre, cantidad," +
                "categoria, tipo, comentarios, fecha, hora) " +
                "VALUES (@idGasto, @numCuenta, @nombre, @cantidad, @categoria, @tipo, @comentarios," +
                "@fecha, @hora);";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@idGasto", idGasto);
            query.Parameters.AddWithValue("@numCuenta", Sesion.Instance.NumCuenta);
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
    }
}
