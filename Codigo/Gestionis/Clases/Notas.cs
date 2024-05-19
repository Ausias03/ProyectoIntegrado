using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


            try
            {
                using (MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion))
                {
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
                }
            } 
            catch (Exception) { }
 
        } 
        public void BorrarNota()
        {
            string querryString;
        }

        public static DataTable RecargarTabla()
        {
            return Utilidades.RellenarDatos($"SELECT titulo, alarma, color, descripcion, fechaRecordatorio FROM nota WHERE apodoUsuario = '{Sesion.Instance.ApodoUsuario}';") ;
        }

        public static DataTable BuscarFiltro(string filtro, string titulo, string descripcion, bool alarma, int color, DateTime fecha)
        {
            string nombreUsuario = Sesion.Instance.ApodoUsuario;
            string consulta = $"SELECT titulo, descripcion, cantidad, alarma, color, fechaRecordatorio FROM nota WHERE apodoUsuario = {nombreUsuario}";
            switch (filtro)
            {
                case "Titulo":
                    consulta += $" AND titulo = '{titulo}'";
                    break;
                case "Descripcion":
                    consulta += $" AND descripcion = '{descripcion}'";
                    break;
                case "Fecha":
                    consulta += $" AND fechaRecordatorio = ' {fecha} '";
                    break;
                case "Alarma":
                    consulta += $" AND alarma = ' {alarma} '";
                    break;
                case "Color":
                    consulta += $" AND color = ' {color} '";
                    break;
                default:
                    break;
            }

            return Utilidades.RellenarDatos(consulta);
        }

        public static string[] CargaFiltros()
        {
            string[] lista = new string[] {"Fecha", "Titulo", "Alarma", "Descripcion", "Color"};
            return lista;
        }
    }
}
