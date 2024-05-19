using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionis.Clases
{
    internal class Utilidades
    {
        public static bool TieneEspacios(string apodo)
        {
            const char espacio = ' ';
            return apodo.Contains(espacio);
        }

        public static DataTable RellenarDatos(string consulta)
        {
            DataTable tablaDatos = new DataTable();
            try
            {
                ConexionDB.AbrirConexion();
                using (MySqlCommand comando = new MySqlCommand(consulta, ConexionDB.Conexion))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(comando))
                    {
                        adapter.Fill(tablaDatos);
                    }
                }
                ConexionDB.CerrarConexion();
            }catch (Exception) { }
            return tablaDatos;
        }
    }
}
