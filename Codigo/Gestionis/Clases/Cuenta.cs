using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Data;
using System.Drawing.Printing;
using System.Reflection.Metadata;
using System.Xml.Linq;

using iTextSharp.text;
using iTextSharp.text.pdf;
using Document = iTextSharp.text.Document;
using Chunk = iTextSharp.text.Chunk;

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
            if (Notificacion.ExisteNotif(categoria, numCuenta.Value))
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
            if (!Notificacion.ExisteNotif(categoria, numCuenta.Value))
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

        #region Generación de un PDF
        public static void GenerarPDF(string usuario, string apellidos, string apodoUsuario, string correo, string tel, string direccion, double? ingresoMensual, double? gastoMensual,
            List<Gasto> listaGastos, List<Ingreso> listaIngresos, double? debo, double? meDeben, double? deudasTotales)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ResumenMensual.pdf");
            FileStream fs = new FileStream(path, FileMode.Create);

            Document doc = new Document(PageSize.LETTER, 60, 60, 45, 45);
            PdfWriter.GetInstance(doc, fs);

            doc.Open();
            doc.AddAuthor("Gestioi$");
            doc.AddTitle("Resumen mensual");

            // Fuente utilizada para el pdf
            iTextSharp.text.Font fuenteTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 22, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            iTextSharp.text.Font fuenteSubtitulo = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            iTextSharp.text.Font fuenteSubtituloSmall = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            iTextSharp.text.Font standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            iTextSharp.text.Font standardFontBold = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

            // Encabezado
            Paragraph titulo = new Paragraph("Resumen Mensual", fuenteTitulo);
            titulo.Alignment = Element.ALIGN_CENTER;
            doc.Add(titulo);
            doc.Add(Chunk.NEWLINE);

            #region Datos Personales

            // Subtitulo 1 (Datos personales del usuario)
            Phrase datosPersonales = new Phrase("Datos Personales ", fuenteSubtitulo);
            doc.Add(datosPersonales);

            PdfPTable table = new PdfPTable(2);
            table.WidthPercentage = 100;

            // Añadir celdas con bordes
            PdfPCell cell;

            cell = new PdfPCell(new Phrase($"Nombre: {usuario}", standardFont));
            cell.BorderWidth = 0;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase($"Correo: {correo}", standardFont));
            cell.BorderWidth = 0;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase($"Apellidos: {apellidos}", standardFont));
            cell.BorderWidth = 0;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase($"Dirección: {direccion}", standardFont));
            cell.BorderWidth = 0;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase($"Apodo: {apodoUsuario}", standardFont));
            cell.BorderWidth = 0;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase($"Teléfono: {tel}", standardFont));
            cell.BorderWidth = 0;
            table.AddCell(cell);



            doc.Add(table);
            doc.Add(Chunk.NEWLINE);

            #endregion

            #region Movimientos

            Phrase movimientos = new Phrase("Movimientos ", fuenteSubtitulo);
            doc.Add(movimientos);
            doc.Add(Chunk.NEWLINE);

            doc.Add(new Phrase($"Ingresos: {ingresoMensual.Value.ToString("0.00") + " €"}", standardFont));
            doc.Add(Chunk.NEWLINE);

            doc.Add(new Phrase($"Gastos: {gastoMensual.Value.ToString("0.00") + " €"}", standardFont));
            doc.Add(Chunk.NEWLINE);
            doc.Add(Chunk.NEWLINE);

            Phrase infoGastos = new Phrase("Gastos: ", fuenteSubtituloSmall);
            doc.Add(infoGastos);

            // Tabla de los gastos totales
            PdfPTable tablaGastos = new PdfPTable(5);
            tablaGastos.WidthPercentage = 100;

            tablaGastos.AddCell(new PdfPCell(new Phrase("Nombre", standardFontBold)));
            tablaGastos.AddCell(new PdfPCell(new Phrase("Cantidad", standardFontBold)));
            tablaGastos.AddCell(new PdfPCell(new Phrase("Categoría", standardFontBold)));
            tablaGastos.AddCell(new PdfPCell(new Phrase("Tipo", standardFontBold)));
            tablaGastos.AddCell(new PdfPCell(new Phrase("Fecha", standardFontBold)));

            foreach (var gasto in listaGastos)
            {
                tablaGastos.AddCell(new PdfPCell(new Phrase(gasto.Nombre, standardFont)));
                tablaGastos.AddCell(new PdfPCell(new Phrase(gasto.Cantidad.ToString("C"), standardFont)));
                tablaGastos.AddCell(new PdfPCell(new Phrase(gasto.Categoria, standardFont)));
                tablaGastos.AddCell(new PdfPCell(new Phrase(gasto.Tipo, standardFont)));
                tablaGastos.AddCell(new PdfPCell(new Phrase(gasto.Fecha.ToShortDateString(), standardFont)));
            }
            doc.Add(tablaGastos);
            doc.Add(Chunk.NEWLINE);

            Phrase infoIngresos = new Phrase("Ingresos: ", fuenteSubtituloSmall);
            doc.Add(infoIngresos);

            // Tabla de los Ingresos totales
            PdfPTable tablaIngresos = new PdfPTable(5);
            tablaIngresos.WidthPercentage = 100;

            tablaIngresos.AddCell(new PdfPCell(new Phrase("Nombre", standardFontBold)));
            tablaIngresos.AddCell(new PdfPCell(new Phrase("Cantidad", standardFontBold)));
            tablaIngresos.AddCell(new PdfPCell(new Phrase("Categoría", standardFontBold)));
            tablaIngresos.AddCell(new PdfPCell(new Phrase("Tipo", standardFontBold)));
            tablaIngresos.AddCell(new PdfPCell(new Phrase("Fecha", standardFontBold)));

            foreach (var ingreso in listaIngresos)
            {
                tablaIngresos.AddCell(new PdfPCell(new Phrase(ingreso.Nombre, standardFont)));
                tablaIngresos.AddCell(new PdfPCell(new Phrase(ingreso.Cantidad.ToString("C"), standardFont)));
                tablaIngresos.AddCell(new PdfPCell(new Phrase(ingreso.Categoria, standardFont)));
                tablaIngresos.AddCell(new PdfPCell(new Phrase(ingreso.Tipo, standardFont)));
                tablaIngresos.AddCell(new PdfPCell(new Phrase(ingreso.Fecha.ToShortDateString(), standardFont)));
            }
            doc.Add(tablaIngresos);

            #endregion

            doc.NewPage();

            #region Deudas

            Paragraph deudas = new Paragraph("Deudas", fuenteSubtitulo);
            doc.Add(deudas);

            doc.Add(new Phrase($"Debo: {debo.Value.ToString("0.00") + " €"}", standardFont));
            doc.Add(Chunk.NEWLINE);

            doc.Add(new Phrase($"Me deben: {meDeben.Value.ToString("0.00") + " €"}", standardFont));
            doc.Add(Chunk.NEWLINE);
            doc.Add(Chunk.NEWLINE);

            doc.Add(new Phrase($"Debo: ", fuenteSubtituloSmall));
            doc.Add(Chunk.NEWLINE);

            DataTable dt = Deuda.RecargarTabla(false);

            PdfPTable tablaDeudas = new PdfPTable(4);
            tablaDeudas.WidthPercentage = 100;

            // Añadir encabezados de columna
            tablaDeudas.AddCell(new PdfPCell(new Phrase("Nombre", standardFontBold)));
            tablaDeudas.AddCell(new PdfPCell(new Phrase("Cantidad", standardFontBold)));
            tablaDeudas.AddCell(new PdfPCell(new Phrase("Fecha creación", standardFontBold)));
            tablaDeudas.AddCell(new PdfPCell(new Phrase("Fecha vencimiento", standardFontBold)));

            foreach (DataRow row in dt.Rows)
            {
                tablaDeudas.AddCell(new PdfPCell(new Phrase(row["titulo"].ToString(), standardFont)));
                tablaDeudas.AddCell(new PdfPCell(new Phrase(Convert.ToDecimal(row["Cantidad"]).ToString("C"), standardFont)));
                tablaDeudas.AddCell(new PdfPCell(new Phrase(Convert.ToDateTime(row["FechaCreacion"]).ToShortDateString(), standardFont)));
                tablaDeudas.AddCell(new PdfPCell(new Phrase(Convert.ToDateTime(row["FechaVencimiento"]).ToShortDateString(), standardFont)));
            }

            doc.Add(tablaDeudas);

            doc.Add(new Phrase($"Deudas totales: {deudasTotales}", standardFont));
            doc.Add(Chunk.NEWLINE);
            doc.Add(Chunk.NEWLINE);

            doc.Add(new Phrase($"Me deben: ", fuenteSubtituloSmall));
            doc.Add(Chunk.NEWLINE);

            DataTable dt1 = Deuda.RecargarTabla(true);

            PdfPTable tablaDeudasDeben = new PdfPTable(4);
            tablaDeudasDeben.WidthPercentage = 100;

            // Añadir encabezados de columna
            tablaDeudasDeben.AddCell(new PdfPCell(new Phrase("Nombre", standardFontBold)));
            tablaDeudasDeben.AddCell(new PdfPCell(new Phrase("Cantidad", standardFontBold)));
            tablaDeudasDeben.AddCell(new PdfPCell(new Phrase("Fecha creación", standardFontBold)));
            tablaDeudasDeben.AddCell(new PdfPCell(new Phrase("Fecha vencimiento", standardFontBold)));

            foreach (DataRow row in dt1.Rows)
            {
                tablaDeudasDeben.AddCell(new PdfPCell(new Phrase(row["titulo"].ToString(), standardFont)));
                tablaDeudasDeben.AddCell(new PdfPCell(new Phrase(Convert.ToDecimal(row["Cantidad"]).ToString("C"), standardFont)));
                tablaDeudasDeben.AddCell(new PdfPCell(new Phrase(Convert.ToDateTime(row["FechaCreacion"]).ToShortDateString(), standardFont)));
                tablaDeudasDeben.AddCell(new PdfPCell(new Phrase(Convert.ToDateTime(row["FechaVencimiento"]).ToShortDateString(), standardFont)));
            }

            doc.Add(tablaDeudasDeben);
            doc.Add(Chunk.NEWLINE);

            #endregion

            #region Notas

            Paragraph notas = new Paragraph("Notas", fuenteSubtitulo);
            doc.Add(notas);
            doc.Add(Chunk.NEWLINE);

            Phrase infoNotas = new Phrase("Notas de este mes: ", fuenteSubtituloSmall);
            doc.Add(infoNotas);
            doc.Add(Chunk.NEWLINE);

            // Tabla de los Ingresos totales
            DataTable dt3 = Notas.notasMesActual();

            PdfPTable tablaNotas = new PdfPTable(4);
            tablaNotas.WidthPercentage = 100;

            // Añadir encabezados de columna
            tablaNotas.AddCell(new PdfPCell(new Phrase("Titulo", standardFontBold)));
            tablaNotas.AddCell(new PdfPCell(new Phrase("Descripcion", standardFontBold)));
            tablaNotas.AddCell(new PdfPCell(new Phrase("Fecha Recordatorio", standardFontBold)));
            tablaNotas.AddCell(new PdfPCell(new Phrase("Alarma", standardFontBold)));

            foreach (DataRow row in dt3.Rows)
            {
                tablaNotas.AddCell(new PdfPCell(new Phrase(row["titulo"].ToString(), standardFont)));
                tablaNotas.AddCell(new PdfPCell(new Phrase((row["descripcion"]).ToString(), standardFont)));
                tablaNotas.AddCell(new PdfPCell(new Phrase(Convert.ToDateTime(row["fechaRecordatorio"]).ToShortDateString(), standardFont)));
                tablaNotas.AddCell(new PdfPCell(new Phrase(Convert.ToString((row["alarma"]).ToString()), standardFont)));

            }

            doc.Add(tablaNotas);

            Phrase infoNotasProxMes = new Phrase("Notas del próximo mes: ", fuenteSubtituloSmall);
            doc.Add(infoNotasProxMes);
            doc.Add(Chunk.NEWLINE);


            DataTable dt4 = Notas.notasMesProx();

            PdfPTable tablaNotasdia = new PdfPTable(4);
            tablaNotasdia.WidthPercentage = 100;

            // Añadir encabezados de columna
            tablaNotasdia.AddCell(new PdfPCell(new Phrase("Titulo", standardFontBold)));
            tablaNotasdia.AddCell(new PdfPCell(new Phrase("Descripcion", standardFontBold)));
            tablaNotasdia.AddCell(new PdfPCell(new Phrase("Fecha Recordatorio", standardFontBold)));
            tablaNotasdia.AddCell(new PdfPCell(new Phrase("Alarma", standardFontBold)));

            foreach (DataRow row in dt4.Rows)
            {
                tablaNotasdia.AddCell(new PdfPCell(new Phrase(row["titulo"].ToString(), standardFont)));
                tablaNotasdia.AddCell(new PdfPCell(new Phrase((row["descripcion"]).ToString(), standardFont)));
                tablaNotasdia.AddCell(new PdfPCell(new Phrase(Convert.ToDateTime(row["fechaRecordatorio"]).ToShortDateString(), standardFont)));
                tablaNotasdia.AddCell(new PdfPCell(new Phrase(Convert.ToString((row["alarma"]).ToString()), standardFont)));

            }

            doc.Add(tablaNotasdia);
            doc.Add(Chunk.NEWLINE);

            #endregion
            doc.Close();
        }
        #endregion
    }
}
