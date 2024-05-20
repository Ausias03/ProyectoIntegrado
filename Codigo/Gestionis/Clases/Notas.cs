using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestionis.Formularios;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg.OpenPgp;

namespace Gestionis.Clases
{
    class Notas
    {
        private int? idNota;
        private string apodoUsuario;
        private string titulo;
        private string descripcion;
        private DateTime fechaRecordatorio;
        private bool alarma;
        private int color;

        #region Constructores
        public Notas(string tit, string desc, DateTime fRecord, bool alar, int col)
        {
            idNota = null;
            apodoUsuario = Sesion.Instance.ApodoUsuario;
            titulo = tit;
            descripcion = desc;
            fechaRecordatorio = fRecord;
            alarma = alar;
            color = col;
        }
        public Notas() { }
        #endregion

        public void Add()
        {
            string queryString = "INSERT INTO nota (idNota, apodoUsuario, titulo, alarma, color, descripcion, fechaRecordatorio) " +
                "VALUES (@idNota, @apodoUsuario, @titulo, @alarma, @color, @descripcion, @fechaRecordatorio)";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@idNota", idNota);
            query.Parameters.AddWithValue("@apodoUsuario", apodoUsuario);
            query.Parameters.AddWithValue("@titulo", titulo);
            query.Parameters.AddWithValue("@descripcion", descripcion);
            query.Parameters.AddWithValue("@fechaRecordatorio", fechaRecordatorio);
            query.Parameters.AddWithValue("@alarma", alarma);
            query.Parameters.AddWithValue("@color", color);

            ConexionDB.AbrirConexion();
            query.ExecuteNonQuery();
            ConexionDB.CerrarConexion();

            SistemaNiveles.IncrementarExperiencia(apodoUsuario, 20);
        }

        public static void BorrarNota(string tituloNota)
        {
            string queryString = $"DELETE FROM nota WHERE titulo = '{tituloNota}';";

            using (MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion))
            {
                query.Parameters.AddWithValue("@titulo", tituloNota);

                ConexionDB.AbrirConexion();
                query.ExecuteNonQuery();
                ConexionDB.CerrarConexion();
            }
        }
        public static DataTable RecargarTabla()
        {
            return Utilidades.RellenarDatos($"SELECT titulo, alarma, color, descripcion, fechaRecordatorio " +
                $"FROM nota WHERE apodoUsuario = '{Sesion.Instance.ApodoUsuario}';") ;
        }
       
        public static string[] CargaFiltros()
        {
            string[] lista = new string[] { "Fecha", "Titulo", "Alarma", "Descripcion", "Color" };
            return lista;
        }

        public static DataTable BuscarPorFiltro(string filtro, string titulo, string descripcion, bool alarma, int color, string fecha)
        {
            string nombreUsuario = Sesion.Instance.ApodoUsuario;
            int valor = alarma ? 1 : 0;
            string consulta = $"SELECT titulo, alarma, color, descripcion, fechaRecordatorio FROM nota WHERE apodoUsuario = '{nombreUsuario}'";
            switch (filtro)
            {
                case "Titulo":
                    consulta += $" AND titulo = '{titulo}';";
                    break;
                case "Descripcion":
                    consulta += $" AND descripcion LIKE '%{descripcion}%';";
                    break;
                case "Fecha":
                    consulta += $" AND fechaRecordatorio = '{fecha}';";
                    break;
                case "Alarma":
                    consulta += $" AND alarma = '{valor}';";
                    break;
                case "Color":
                    consulta += $" AND color = '{color}';";
                    break;
                default:
                    break;
            }

            return Utilidades.RellenarDatos(consulta);
        }
               
        public static DataTable NotasDia()
        {
            string fechaActual = DateTime.Today.ToString("yyyy-MM-dd");

            return Utilidades.RellenarDatos($"SELECT titulo, descripcion FROM nota WHERE apodoUsuario = " +
                $"'{Sesion.Instance.ApodoUsuario}' AND fechaRecordatorio = '{fechaActual}';");
        }

        #region Calculo Días Totales
        public static int NotasTotales()
        {
            string queryString = $"SELECT COUNT(*) FROM nota WHERE apodoUsuario = '{Sesion.Instance.ApodoUsuario}';";
            int total = 0;

            using (MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion))
            {
                ConexionDB.AbrirConexion();
                total = Convert.ToInt32(query.ExecuteScalar());
                ConexionDB.CerrarConexion();
            }

            return total;
        }
        public static int NotasTotalesDia()
        {
            string fechaActual = DateTime.Today.ToString("yyyy-MM-dd");
            string queryString = $"SELECT COUNT(*) FROM nota WHERE fechaRecordatorio = '{fechaActual}';";
            int total = 0;

            using (MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion))
            {
                ConexionDB.AbrirConexion();
                total = Convert.ToInt32(query.ExecuteScalar());
                ConexionDB.CerrarConexion();
            }

            return total;
        }

        #endregion

    }
}
