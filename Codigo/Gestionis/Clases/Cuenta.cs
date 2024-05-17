using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
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
        private float pasivos;

        public Cuenta(string apodoUsuario)
        {
            this.numCuenta = null;
            this.apodoUsuario = apodoUsuario;
            this.pasivos = 0;
        }

        public static int IDCuentaUsuario(string apodoUsuario)
        {
            string queryString = "SELECT numCuenta FROM cuenta WHERE apodoUsuario = @apodoUsuario;";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@apodoUsuario", apodoUsuario);

            ConexionDB.AbrirConexion();

            int numCuenta = (int)query.ExecuteScalar();

            ConexionDB.CerrarConexion();

            return numCuenta;
        }

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

        public double DineroTotal()
        {
            List<Gasto> gastos = Gasto.DevuelveGastos(numCuenta ?? default(int));
            List<Ingreso> ingresos = Ingreso.DevuelveIngresos(numCuenta ?? default(int));
            return TotalIngresos(ingresos) - TotalGastos(gastos);
        }

        private double TotalGastos(List<Gasto> gastos)
        {
            double totalGastos = 0;
            for (int i = 0; i < gastos.Count; i++)
            {
                totalGastos += gastos[i].Cantidad;
            }
            return totalGastos;
        }

        private double TotalIngresos(List<Ingreso> ingresos)
        {
            double totalIngresos = 0;
            for (int i = 0; i < ingresos.Count; i++)
            {
                totalIngresos += ingresos[i].Cantidad;
            }
            return totalIngresos;
        }
    }
}
