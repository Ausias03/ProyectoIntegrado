using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionis.Clases
{
    static class ExtensionMethods
    {
        /// <summary>
        /// Método de extensión para añadir la funcionalidad a la clase MySqlDataReader de poder leer
        /// celdas nulas de la BD de manera segura
        /// </summary>
        /// <param name="reader">El objeto reader con los datos recuperados de la BD</param>
        /// <param name="index">El índice de la columna donde puede estar el valor nulo</param>
        /// <returns>.NET null si la celda tiene un valor nulo, el valor original si NO</returns>
        public static string? GetSafeString(this MySqlDataReader reader, int index)
        {
            if (reader.IsDBNull(index))
            {
                return null;
            }
            else
            {
                return reader.GetString(index);
            }
        }

        /// <summary>
        /// Método de extensión para añadir la funcionalidad a la clase MySqlDataReader de poder leer
        /// celdas nulas de la BD de manera segura
        /// </summary>
        /// <param name="reader">El objeto reader con los datos recuperados de la BD</param>
        /// <param name="index">El índice de la columna donde puede estar el valor nulo</param>
        /// <returns>.NET null si la celda tiene un valor nulo, el valor original si NO</returns>
        public static int? GetSafeInt32(this MySqlDataReader reader, int index)
        {
            if (reader.IsDBNull(index))
            {
                return null;
            }
            else
            {
                return reader.GetInt32(index);
            }
        }

        /// <summary>
        /// Método de extensión para añadir la funcionalidad a la clase MySqlDataReader de poder leer
        /// celdas nulas de la BD de manera segura
        /// </summary>
        /// <param name="reader">El objeto reader con los datos recuperados de la BD</param>
        /// <param name="index">El índice de la columna donde puede estar el valor nulo</param>
        /// <returns>.NET null si la celda tiene un valor nulo, el valor original si NO</returns>
        public static decimal? GetSafeDecimal(this MySqlDataReader reader, int index)
        {
            if (reader.IsDBNull(index))
            {
                return null;
            }
            else
            {
                return reader.GetDecimal(index);
            }
        }

        /// <summary>
        /// Método de extensión para añadir la funcionalidad a la clase MySqlDataReader de poder leer
        /// celdas nulas de la BD de manera segura
        /// </summary>
        /// <param name="reader">El objeto reader con los datos recuperados de la BD</param>
        /// <param name="index">El índice de la columna donde puede estar el valor nulo</param>
        /// <returns>.NET null si la celda tiene un valor nulo, el valor original si NO</returns>
        public static float? GetSafeFloat(this MySqlDataReader reader, int index)
        {
            if(reader.IsDBNull(index))
            {
                return null;
            }
            {
                return reader.GetFloat(index);
            }
        }
    }
}
