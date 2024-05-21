using MySql.Data.MySqlClient;
using Mysqlx.Cursor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionis.Clases
{
    internal class LimitesNotif
    {
        private int numCuenta;
        private int idCategoria;
        private decimal limite;

        #region Constructores
        public LimitesNotif(int numCuenta, int idCategoria, decimal limite)
        {
            this.numCuenta = numCuenta;
            this.idCategoria = idCategoria;
            this.limite = limite;
        }
        #endregion

        public static decimal? GetLimite(int numCuenta, int idCategoria)
        {
            string queryString = "SELECT limite FROM limite WHERE numCuenta = @numCuenta AND idCategoria = @idCategoria;";
            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@numCuenta", numCuenta);
            query.Parameters.AddWithValue("@idCategoria", idCategoria);

            ConexionDB.AbrirConexion();

            decimal? limite = null;

            using (MySqlDataReader reader = query.ExecuteReader())
            {
                while (reader.Read())
                {
                    limite = reader.GetSafeDecimal(0);
                }
            }

            ConexionDB.CerrarConexion();

            return limite;
        }

        public static void EditarLimite(int numCuenta, int idCategoria, decimal? limite)
        {
            string queryString = "UPDATE limite SET limite = @limite WHERE numCuenta = @numCuenta AND idCategoria = @idCategoria;";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@limite", limite);
            query.Parameters.AddWithValue("@numCuenta", numCuenta);
            query.Parameters.AddWithValue("@idCategoria", idCategoria);

            ConexionDB.AbrirConexion();

            query.ExecuteNonQuery();

            ConexionDB.CerrarConexion();
        }

        public void Add()
        {
            string queryString = "INSERT INTO limite (numCuenta, idCategoria, limite) " +
                "VALUES (@numCuenta, @idCategoria, @limite);";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@numCuenta", numCuenta);
            query.Parameters.AddWithValue("@idCategoria", idCategoria);
            query.Parameters.AddWithValue("@limite", limite);

            ConexionDB.AbrirConexion();

            query.ExecuteNonQuery();

            ConexionDB.CerrarConexion();
        }
    }
}
