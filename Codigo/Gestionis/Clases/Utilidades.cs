using MySql.Data.MySqlClient;
using System.Data;

namespace Gestionis.Clases
{
    class Utilidades
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ConexionDB.CerrarConexion();
            }

            return tablaDatos;
        }

        public static DataTable RellenarDatosParametrizados(MySqlCommand querry)
        {
            DataTable tablaDatos = new DataTable();
            try
            {
                ConexionDB.AbrirConexion();

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(querry))
                {
                    adapter.Fill(tablaDatos);
                }

                ConexionDB.CerrarConexion();
            }
            catch (Exception) { }
            finally { ConexionDB.CerrarConexion(); }

            return tablaDatos;
        }

        /// <summary>
        /// Calcula el valor máximo para una representación gráfica proporcional de dos tablas,
        /// tomando en cuenta la diferencia entre ellas
        /// </summary>
        /// <param name="debo">Cantidad total que se debe</param>
        /// <param name="meDeben">Cantidad total que se debe recibir</param>
        /// <returns>El valor máximo ajustado para la representación gráfica proporcional de ambas tablas</returns>
        public static int ProgramarGrafico(double valor1, double valor2)
        {
            double diferencia = Math.Abs(valor1 - valor2);

            double valorMax = Math.Max(valor1, valor2) + (diferencia / 2);

            return (int)Math.Ceiling(valorMax);
        }
    }
}
