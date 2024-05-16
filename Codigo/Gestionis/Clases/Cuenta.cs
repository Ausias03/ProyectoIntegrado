using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Crud.Order.Types;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Gestionis.Clases
{
    internal class Cuenta
    {
        private int? numCuenta;
        private string apodoUsuario;
        private float totalDinero;
        private float pasivos;

        public Cuenta(string apodoUsuario)
        {
            this.numCuenta = null;
            this.apodoUsuario = apodoUsuario;
            this.totalDinero = 0;
            this.pasivos = 0;
        }

        public void Add()
        {
            string queryString = "INSERT INTO cuenta (numCuenta, apodoUsuario, totalDinero, pasivos) " +
                "VALUES (@numCuenta, @apodoUsuario, @totalDinero, @pasivos);";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@numCuenta", numCuenta);
            query.Parameters.AddWithValue("@apodoUsuario", apodoUsuario);
            query.Parameters.AddWithValue("@totalDinero", totalDinero);
            query.Parameters.AddWithValue("@pasivos", pasivos);

            ConexionDB.AbrirConexion();

            query.ExecuteNonQuery();

            ConexionDB.CerrarConexion();
        }
    }
}
