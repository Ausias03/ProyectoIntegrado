using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Crud.Order.Types;

namespace Gestionis.Clases
{
    public class Ingreso
    {
        private static List<String> tiposIngreso = new List<String>() { "Salario", "Extra" };

        private int? idIngreso;
        private int numCuenta;
        private string nombre;
        private float cantidad;
        private string tipo;
        private int? categoria;
        private string? comentarios;
        private DateTime fecha;
        private TimeSpan hora;

        #region Constructores
        public Ingreso(int numCuenta, string nombre, float cantidad, string tipo,
             int? categoria, string? comentarios)
        {
            this.idIngreso = null;
            this.numCuenta = numCuenta;
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.tipo = tipo;
            this.categoria = categoria;
            this.comentarios = comentarios;
            this.fecha = DateTime.Today;
            this.hora = DateTime.Now.TimeOfDay;
        }

        public Ingreso(int idIngreso, int numCuenta, string nombre, float cantidad, string tipo,
             int? categoria, string? comentarios, DateTime fecha, TimeSpan hora)
        {
            this.idIngreso = idIngreso;
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

        // Necesarias para el dataSource de FrmMenuPrincipal
        #region Propiedades
        public static List<String> TiposIngreso { get { return tiposIngreso; } }
        public int IdIngreso { get { return idIngreso.Value; } }
        public string Nombre { get { return nombre; } }
        public float Cantidad { get { return cantidad; } }
        public string Tipo { get { return tipo; } }
        public string Categoria { get { return CategoriaIngreso.DevuelveNombreCategoria(categoria); } }
        public string? Comentarios { get { return comentarios; } }
        public DateTime Fecha { get { return fecha; } }
        public TimeSpan Hora { get { return hora; } }
        #endregion

        /// <summary>
        /// Añade un registro ingreso a la base de datos
        /// </summary>
        public void Add()
        {
            string queryString = "INSERT INTO ingreso (idIngreso, numCuenta, nombre, cantidad," +
                "tipo, idCategoria, comentarios, fecha, hora) " +
                "VALUES (@idIngreso, @numCuenta, @nombre, @cantidad, @tipo, @idCategoria, @comentarios," +
                "@fecha, @hora);";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@idIngreso", idIngreso);
            query.Parameters.AddWithValue("@numCuenta", numCuenta);
            query.Parameters.AddWithValue("@nombre", nombre);
            query.Parameters.AddWithValue("@cantidad", cantidad);
            query.Parameters.AddWithValue("@tipo", tipo);
            query.Parameters.AddWithValue("@idCategoria", categoria);
            query.Parameters.AddWithValue("@comentarios", comentarios);
            query.Parameters.AddWithValue("@fecha", fecha);
            query.Parameters.AddWithValue("@hora", hora);

            ConexionDB.AbrirConexion();

            query.ExecuteNonQuery();

            ConexionDB.CerrarConexion();            
        }

        /// <summary>
        /// Campos por los que se puede filtrar un ingreso
        /// </summary>
        /// <returns>Devuelve una lista de campos para poder filtrar los ingresos de la BD</returns>
        public static string[] DevuelveFiltros()
        {
            string[] lista = new string[] { "Nombre", "Cantidad", "Categoria", "Tipo" };
            return lista;
        }
    }
}
