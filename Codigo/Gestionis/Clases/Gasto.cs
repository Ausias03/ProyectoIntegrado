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
        private static List<double> limiteNotifs = new List<double> { 150, 50, 80, 300, 200 };

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
        public string Nombre { get { return nombre; } }
        public float Cantidad { get { return cantidad; } }
        public string Categoria { get { return CategoriaGasto.DevuelveNombreCategoria(categoria); } }
        public string Tipo { get { return tipo; } }
        public string? Comentarios { get { return comentarios; } }
        public DateTime Fecha { get { return fecha; } }
        public TimeSpan Hora { get { return hora; } }
        #endregion

        #region Geters
        public int GetNumericCategoria()
        {
            return categoria;
        }
        #endregion

        public void Add()
        {
            string queryString = "INSERT INTO gasto (idGasto, numCuenta, nombre, cantidad," +
                "idCategoria, tipo, comentarios, fecha, hora) " +
                "VALUES (@idGasto, @numCuenta, @nombre, @cantidad, @idCategoria, @tipo, @comentarios," +
                "@fecha, @hora);";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@idGasto", idGasto);
            query.Parameters.AddWithValue("@numCuenta", Sesion.Instance.NumCuenta);
            query.Parameters.AddWithValue("@nombre", nombre);
            query.Parameters.AddWithValue("@cantidad", cantidad);
            query.Parameters.AddWithValue("@idCategoria", categoria);
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
