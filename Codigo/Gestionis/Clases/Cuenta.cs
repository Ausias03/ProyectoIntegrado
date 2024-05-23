using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Crud.Order.Types;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Gestionis.Formularios;

namespace Gestionis.Clases
{
    public class Cuenta
    {
        private int? numCuenta;
        private string apodoUsuario;
        private float pasivos;

        public Cuenta(string apodoUsuario)
        {
            this.numCuenta = null;
            this.apodoUsuario = apodoUsuario;
            this.pasivos = 0;
        }

        public Cuenta(int numCuenta, string apodoUsuario, float pasivos)
        {
            this.numCuenta = numCuenta;
            this.apodoUsuario = apodoUsuario;
            this.pasivos = pasivos;
        }

        public int? NumCuenta { get { return numCuenta; } }

        /// <summary>
        /// Devuelve el número de cuenta de la cuenta asignada a un usuario
        /// </summary>
        /// <param name="apodoUsuario">El apodo del usuario</param>
        /// <returns>Un int con el número de la cuenta</returns>
        public static int IDCuentaUsuario(string apodoUsuario)
        {
            int numCuenta;
            string queryString = "SELECT numCuenta FROM cuenta WHERE apodoUsuario = @apodoUsuario;";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@apodoUsuario", apodoUsuario);

            ConexionDB.AbrirConexion();

            numCuenta = Convert.ToInt32(query.ExecuteScalar());

            ConexionDB.CerrarConexion();

            return numCuenta;
        }

        /// <summary>
        /// Añade una cuenta a la base de datos
        /// </summary>
        public void Add()
        {
            string queryString = "INSERT INTO cuenta (numCuenta, apodoUsuario, pasivos) " +
                "VALUES (@numCuenta, @apodoUsuario, @pasivos);";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@numCuenta", numCuenta);
            query.Parameters.AddWithValue("@apodoUsuario", apodoUsuario);
            query.Parameters.AddWithValue("@pasivos", pasivos);

            ConexionDB.AbrirConexion();

            query.ExecuteNonQuery();

            ConexionDB.CerrarConexion();
        }

        /// <summary>
        /// Serie de comprobaciones para añadir o no una Notificación asignada a la cuenta
        /// </summary>
        /// <param name="categoria">Categoría de la notificación a crear</param>
        public void AddNotificacion(int categoria)
        {
            if (Notificacion.ExisteNotif(categoria))
            {
                return;
            }

            decimal? limite = LimitesNotif.GetLimite(Sesion.Instance.NumCuenta, categoria);
            if (limite == null)
            {
                return;
            }

            if (TotalGastos(categoria) > Convert.ToDouble(limite))
            {
                string nombreCategoria = CategoriaGasto.DevuelveNombreCategoria(categoria);
                Notificacion noti = new Notificacion(
                    null,
                    Sesion.Instance.NumCuenta,
                    $"Gasto elevado en {nombreCategoria}",
                    categoria,
                    $"+ {limite}€ gastados en {nombreCategoria}",
                    Notificacion.GetRecomendacion(nombreCategoria),
                    DateTime.Now
                );

                noti.Add();
            }
        }

        /// <summary>
        /// Serie de comprobaciones para eliminar o no una Notificación asignada a la cuenta
        /// </summary>
        /// <param name="categoria">Categoría de la notificación a eliminar</param>
        public void EliminaNotificacion(int categoria)
        {
            if (!Notificacion.ExisteNotif(categoria))
            {
                return;
            }

            decimal limite = LimitesNotif.GetLimite(Sesion.Instance.NumCuenta, categoria) ?? 0m;

            if (TotalGastos(categoria) < Convert.ToDouble(limite))
            {
                string queryString = "DELETE FROM notificacion WHERE idCategoria = @idCategoria AND numCuenta = @numCuenta;";

                MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
                query.Parameters.AddWithValue("@idCategoria", categoria);
                query.Parameters.AddWithValue("@numCuenta", Sesion.Instance.NumCuenta);

                ConexionDB.AbrirConexion();

                query.ExecuteNonQuery();

                ConexionDB.CerrarConexion();
            }
        }

        #region Métodos para ver / recuperar gastos e ingresos
        /// <summary>
        /// Busca todos los gastos asignados a una cuenta
        /// </summary>
        /// <returns>Una lista de objetos gasto con los datos recuperados de la BD</returns>
        public List<Gasto> DevuelveGastos()
        {
            string queryString = "SELECT * FROM gasto WHERE numCuenta = @numCuenta";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@numCuenta", numCuenta);

            return EjecutarConsultaGastos(query);
        }

        /// <summary>
        /// Busca los gastos asignados a una cuenta que coincidan con una búsqueda
        /// </summary>
        /// <typeparam name="T">Especifica que el tipo del valor puede ser cualquiera</typeparam>
        /// <param name="campo">El campo a buscar en la tabla de la BD</param>
        /// <param name="valor">El valor a comprobar para devolver o no un gasto</param>
        /// <returns></returns>
        public List<Gasto> DevuelveGastos<T>(string campo, T valor)
        {
            string queryString = $"SELECT * FROM gasto WHERE numCuenta = @numCuenta AND {campo} ";

            if (campo == "Cantidad")
            {
                queryString += ">= @valor;";
            }
            else
            {
                queryString += "= @valor;";
            }

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@numCuenta", numCuenta);
            query.Parameters.AddWithValue("@valor", valor);

            return EjecutarConsultaGastos(query);
        }

        /// <summary>
        /// Busca todos los ingresos asignados a una cuenta
        /// </summary>
        /// <returns>Una lista de objetos ingreso con los datos recuperados de la BD</returns>
        public List<Ingreso> DevuelveIngresos()
        {
            string queryString = "SELECT * FROM ingreso WHERE numCuenta = @numCuenta";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@numCuenta", numCuenta);

            return EjecutarConsultaIngresos(query);
        }

        /// <summary>
        /// Busca los ingresos asignados a una cuenta que coincidan con una búsqueda
        /// </summary>
        /// <typeparam name="T">Especifica que el tipo del valor puede ser cualquiera</typeparam>
        /// <param name="campo">El campo a buscar en la tabla de la BD</param>
        /// <param name="valor">El valor a comprobar para devolver o no un ingreso</param>
        /// <returns></returns>
        public List<Ingreso> DevuelveIngresos<T>(string campo, T? valor)
        {
            string queryString = $"SELECT * FROM ingreso WHERE numCuenta = @numCuenta AND {campo} ";

            if (valor == null)
            {
                queryString += "IS NULL;";
            }
            else if (campo == "Cantidad")
            {
                queryString += ">= @valor;";
            }
            else
            {
                queryString += "= @valor;";
            }

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@numCuenta", numCuenta);
            query.Parameters.AddWithValue("@valor", valor);

            return EjecutarConsultaIngresos(query);
        }

        /// <summary>
        /// Devuelve el saldo total de una cuenta
        /// </summary>
        /// <returns>El saldo como double</returns>
        public double DineroTotal()
        {
            return TotalIngresos() - TotalGastos();
        }

        /// <summary>
        /// Devuelve el dinero total de los gastos de una cuenta
        /// </summary>
        /// <returns>El coste de los gastos como double</returns>
        public double TotalGastos()
        {
            List<Gasto> gastos = DevuelveGastos();
            return CalculaTotalGastos(gastos);
        }

        /// <summary>
        /// Devuelve el dinero total de los gastos de una categoría de una cuenta
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns>El coste de los gastos como double</returns>
        public double TotalGastos(int categoria)
        {
            List<Gasto> gastos = DevuelveGastos("idCategoria", categoria);
            return CalculaTotalGastos(gastos);
        }

        /// <summary>
        /// Calcula el coste total de los gastos
        /// </summary>
        /// <param name="gastos">Una lista con todos los gastos de los que se va a calcular su coste</param>
        /// <returns>El total de los gastos como double</returns>
        public double CalculaTotalGastos(List<Gasto> gastos)
        {
            double totalGastos = 0;
            for (int i = 0; i < gastos.Count; i++)
            {
                totalGastos += gastos[i].Cantidad;
            }
            return totalGastos;
        }

        /// <summary>
        /// Devuelve el dinero total de los ingresos de una cuenta
        /// </summary>
        /// <returns>El coste de los ingresos como double</returns>
        public double TotalIngresos()
        {
            List<Ingreso> ingresos = DevuelveIngresos();
            double totalIngresos = 0;
            for (int i = 0; i < ingresos.Count; i++)
            {
                totalIngresos += ingresos[i].Cantidad;
            }
            return totalIngresos;
        }

        /// <summary>
        /// Método gastado para ejecutar una consulta que busque una serie de gastos de la tabla gastos de la BD
        /// </summary>
        /// <param name="query">La consulta a ejecutar</param>
        /// <returns>La lista de gastos cuyos datos coincidan con la consulta suministrada por parámetros</returns>
        private List<Gasto> EjecutarConsultaGastos(MySqlCommand query)
        {
            List<Gasto> gastos = new List<Gasto>();

            ConexionDB.AbrirConexion();

            using (MySqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    gastos.Add(new Gasto(
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

            return gastos;
        }

        /// <summary>
        /// Método gastado para ejecutar una consulta que busque una serie de ingresos de la tabla ingresos de la BD
        /// </summary>
        /// <param name="query">La consulta a ejecutar</param>
        /// <returns>La lista de ingresos cuyos datos coincidan con la consulta suministrada por parámetros</returns>
        private List<Ingreso> EjecutarConsultaIngresos(MySqlCommand query)
        {
            List<Ingreso> ingresos = new List<Ingreso>();

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
                        reader.GetString(4),
                        reader.GetSafeInt32(5),
                        reader.GetSafeString(6),
                        reader.GetDateTime(7),
                        reader.GetTimeSpan(8)
                    ));
                }
            }

            ConexionDB.CerrarConexion();

            return ingresos;
        }
        #endregion

        #region Métodos para eliminar gastos / ingresos

        /// <summary>
        /// Elimina un gasto de la BD
        /// </summary>
        /// <param name="idGasto">El identificador del gasto a eliminar</param>
        public void EliminaGasto(int idGasto)
        {
            string queryString = "DELETE FROM gasto WHERE idGasto = @idGasto;";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@idGasto", idGasto);

            ConexionDB.AbrirConexion();

            query.ExecuteNonQuery();

            ConexionDB.CerrarConexion();
        }

        /// <summary>
        /// Elimina un ingreso de la BD
        /// </summary>
        /// <param name="idIngreso">El identificador del ingreso a eliminar</param>
        public void EliminaIngreso(int idIngreso)
        {
            string queryString = "DELETE FROM ingreso WHERE idIngreso = @idIngreso;";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@idIngreso", idIngreso);

            ConexionDB.AbrirConexion();

            query.ExecuteNonQuery();

            ConexionDB.CerrarConexion();
        }

        #endregion
    }
}
