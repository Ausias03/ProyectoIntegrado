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
        private int? id;
        private int numCuenta;
        private int idCategoria;
        private decimal limite;

        #region Constructores
        public LimitesNotif(int numCuenta, int idCategoria, decimal limite)
        {
            this.id = null;
            this.numCuenta = numCuenta;
            this.idCategoria = idCategoria;
            this.limite = limite;
        }

        public LimitesNotif(int id, int numCuenta, int idCategoria, decimal limite)
        {
            this.id = id;
            this.numCuenta = numCuenta;
            this.idCategoria = idCategoria;
            this.limite = limite;
        }
        #endregion

        public static decimal? GetLimite(int numCuenta, int idCategoria)
        {
            string queryString = "SELECT limite FROM limitesNotificaciones WHERE numCuenta = @numCuenta AND idCategoria = @idCategoria;";
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

        public void Add()
        {
            string queryString = "INSERT INTO limitesNotificaciones (idLimite, numCuenta, idCategoria, limite) " +
                "VALUES (@idLimite, @numCuenta, @idCategoria, @limite);";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@idLimite", id);
            query.Parameters.AddWithValue("@numCuenta", numCuenta);
            query.Parameters.AddWithValue("@idCategoria", idCategoria);
            query.Parameters.AddWithValue("@limite", limite);

            ConexionDB.AbrirConexion();

            query.ExecuteNonQuery();

            ConexionDB.CerrarConexion();
        }
    }
}
