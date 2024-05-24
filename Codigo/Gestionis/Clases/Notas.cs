using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mysqlx.Resultset;
using Org.BouncyCastle.Bcpg.OpenPgp;
using Outlook = Microsoft.Office.Interop.Outlook;


namespace Gestionis.Clases
{
    class Notas
    {
        private int? idNota;
        private int? idDeuda;
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
            idDeuda = null;
            apodoUsuario = Sesion.Instance.ApodoUsuario;
            titulo = tit;
            descripcion = desc;
            fechaRecordatorio = fRecord;
            alarma = alar;
            color = col;
        }
        public Notas(int idDeu,  string tit, string desc, DateTime fRecord, bool alar, int col) 
        {
            idNota = null;
            idDeuda = idDeu;
            apodoUsuario = Sesion.Instance.ApodoUsuario;
            titulo = tit;
            descripcion = desc;
            fechaRecordatorio = fRecord;
            alarma = alar;
            color = col;
        }
        #endregion

        /// <summary>
        /// Añade una nota a la BD
        /// </summary>
        public void Add()
        {
            string queryString = "INSERT INTO nota (idNota, apodoUsuario, titulo, alarma, color, descripcion, fechaRecordatorio"
                            + (idDeuda.HasValue ? ", idDeuda" : "") + ") "
                            + "VALUES (@idNota, @apodoUsuario, @titulo, @alarma, @color, @descripcion, @fechaRecordatorio"
                            + (idDeuda.HasValue ? ", @idDeuda" : "") + ")";

            using (MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion))
            {
                query.Parameters.AddWithValue("@idNota", idNota);
                query.Parameters.AddWithValue("@apodoUsuario", apodoUsuario);
                query.Parameters.AddWithValue("@titulo", titulo);
                query.Parameters.AddWithValue("@descripcion", descripcion);
                query.Parameters.AddWithValue("@fechaRecordatorio", fechaRecordatorio);
                query.Parameters.AddWithValue("@alarma", alarma);
                query.Parameters.AddWithValue("@color", color);

                if (idDeuda.HasValue)
                {
                    query.Parameters.AddWithValue("@idDeuda", idDeuda.Value);
                }

                ConexionDB.AbrirConexion();
                query.ExecuteNonQuery();
                ConexionDB.CerrarConexion();
            }
            SistemaNiveles.IncrementarExperiencia(apodoUsuario, 20);

        }

        /// <summary>
        /// Borra una nota de la BD
        /// </summary>
        /// <param name="tituloNota"></param>
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

        /// <summary>
        /// Recarga DGV
        /// </summary>
        /// <returns>Info DGV</returns>
        public static DataTable RecargarTabla()
        {
            return Utilidades.RellenarDatos($"SELECT titulo, alarma, color, descripcion, fechaRecordatorio " +
                $"FROM nota WHERE apodoUsuario = '{Sesion.Instance.ApodoUsuario}';");
        }

        /// <summary>
        /// Carga filtros en CMB
        /// </summary>
        /// <returns>Lista cargada</returns>
        public static string[] CargaFiltros()
        {
            string[] lista;
            if (Sesion.Instance.Espanyol) lista = new string[] { "Fecha", "Titulo", "Alarma", "Descripcion", "Color", "Deuda" };
            else lista = new string[] { "Date", "Title", "Alarm", "Description", "Color", "Debt" };
            return lista;
        }

        /// <summary>
        /// Filtro
        /// </summary>
        /// <param name="filtro"></param>
        /// <param name="titulo"></param>
        /// <param name="descripcion"></param>
        /// <param name="alarma"></param>
        /// <param name="color"></param>
        /// <param name="fecha"></param>
        /// <param name="deuda"></param>
        /// <returns>Devuelve info DGV</returns>
        public static DataTable BuscarPorFiltro(int filtro, string titulo, string descripcion, bool alarma, int color, string fecha, bool? deuda)
        {
            string nombreUsuario = Sesion.Instance.ApodoUsuario;
            int valorAlarma = alarma ? 1 : 0;
            string consulta = $"SELECT titulo, alarma, color, descripcion, fechaRecordatorio FROM nota WHERE apodoUsuario = '{nombreUsuario}'";
            switch (filtro)
            {
                case 1:
                    consulta += $" AND titulo = '{titulo}';";
                    break;
                case 3:
                    consulta += $" AND descripcion LIKE '%{descripcion}%';";
                    break;
                case 0:
                    consulta += $" AND fechaRecordatorio = '{fecha}';";
                    break;
                case 2:
                    consulta += $" AND alarma = '{valorAlarma}';";
                    break;
                case 4:
                    consulta += $" AND color = '{color}';";
                    break;
                case 5:
                    if (deuda == true) { consulta += $" AND idDeuda IS NOT NULL;"; }
                    else { consulta += $" AND idDeuda IS NULL;"; }
                    break;
                default:
                    break;
            }

            return Utilidades.RellenarDatos(consulta);
        }

        /// <summary>
        /// DGV Notas del día
        /// </summary>
        /// <returns>Info DGV</returns>
        public static DataTable NotasDia()
        {
            string fechaActual = DateTime.Today.ToString("yyyy-MM-dd");

            return Utilidades.RellenarDatos($"SELECT titulo, descripcion FROM nota WHERE apodoUsuario = " +
                $"'{Sesion.Instance.ApodoUsuario}' AND fechaRecordatorio = '{fechaActual}';");
        }

        public static DataTable notasMesActual()
        {
            // Obtener la fecha actual
            DateTime fechaActual = DateTime.Today;

            // Calcular el primer y último día del mes actual
            DateTime primerDiaMesActual = new DateTime(fechaActual.Year, fechaActual.Month, 1);
            DateTime ultimoDiaMesActual = primerDiaMesActual.AddMonths(1).AddDays(-1);

            // Convertir fechas a formato de cadena
            string primerDiaMesActualStr = primerDiaMesActual.ToString("yyyy-MM-dd");
            string ultimoDiaMesActualStr = ultimoDiaMesActual.ToString("yyyy-MM-dd");

            // Construir y ejecutar la consulta SQL
            return Utilidades.RellenarDatos($"SELECT titulo, alarma, color, descripcion, fechaRecordatorio FROM nota" +
                $" WHERE apodoUsuario = '{Sesion.Instance.ApodoUsuario}'  AND fechaRecordatorio >= '{primerDiaMesActualStr}' AND fechaRecordatorio <= '{ultimoDiaMesActualStr}';");
        }


        public static DataTable notasMesProx()
        {

            DateTime fechaActual = DateTime.Today;

            // Calcular el primer y último día del próximo mes
            DateTime primerDiaMesProx = new DateTime(fechaActual.Year, fechaActual.Month, 1).AddMonths(1);
            DateTime ultimoDiaMesProx = primerDiaMesProx.AddMonths(1).AddDays(-1);

            // Convertir fechas a formato de cadena
            string primerDiaMesProxStr = primerDiaMesProx.ToString("yyyy-MM-dd");
            string ultimoDiaMesProxStr = ultimoDiaMesProx.ToString("yyyy-MM-dd");

            // Construir y ejecutar la consulta SQL
            return Utilidades.RellenarDatos($"SELECT titulo, alarma, descripcion, fechaRecordatorio FROM nota " +
                $"WHERE apodoUsuario = '{Sesion.Instance.ApodoUsuario}' AND fechaRecordatorio >= '{primerDiaMesProxStr}' AND fechaRecordatorio <= '{ultimoDiaMesProxStr}';");

        }

        #region Calculo Días Totales

        /// <summary>
        /// Cuenta las notas existentes en la BD
        /// </summary>
        /// <returns>Total notas existentes</returns>
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

        /// <summary>
        /// Cuenta las notas existentes en la BD (Diarias)
        /// </summary>
        /// <returns>Total notas existentes diarias</returns>
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

        #region Agregación/Eliminación de nota en calendario

        /// <summary>
        /// Agrega nota al calendario (outlook)
        /// </summary>
        /// <param name="fechaInicio"></param>
        public void AgregarNotaAlCalendario(DateTime fechaInicio)
        {
            try
            {
                Outlook.Application outlookApp = new Outlook.Application();
                Outlook.AppointmentItem newAppointment = (Outlook.AppointmentItem)outlookApp.CreateItem(Outlook.OlItemType.olAppointmentItem);

                newAppointment.Body = descripcion;
                newAppointment.Subject = titulo;
                newAppointment.Start = fechaInicio;
                newAppointment.Duration = 60;

                newAppointment.Save();

                System.Runtime.InteropServices.Marshal.ReleaseComObject(outlookApp);

                MessageBox.Show("Nota guardada y sincronizada con el calendario de Outlook correctamente.", "Sincronización con Calendario", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        /// <summary>
        /// Elimina notas del día
        /// </summary>
        /// <param name="titulo"></param>
        public static void EliminarNotaCalendario(string titulo)
        {
            Outlook.Application outlookApp = null;
            Outlook.Items outlookItems = null;

            try
            {
                outlookApp = new Outlook.Application();
                Outlook.MAPIFolder calendarFolder = outlookApp.Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderCalendar);
                outlookItems = calendarFolder.Items;

                foreach (object item in outlookItems)
                {
                    if (item is Outlook.AppointmentItem appointment)
                    {
                        if (appointment.Subject == titulo)
                        {
                            appointment.Delete();
                            MessageBox.Show("Evento eliminado del calendario de Outlook correctamente.");
                            return;
                        }
                    }
                }

                MessageBox.Show("No se encontró ningún evento con el título especificado en el calendario de Outlook.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el evento del calendario de Outlook: " + ex.Message);
            }
            finally
            {
                if (outlookItems != null)
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(outlookItems);
                }
                if (outlookApp != null)
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(outlookApp);
                }
            }
        }
        #endregion
    }
}
