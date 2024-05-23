using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Gestionis.Properties;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace Gestionis.Clases
{
    public class Usuario
    {
        #region Datos Contrasenya
        private const int keySize = 64;
        private const int iterations = 350000;
        private static HashAlgorithmName hashAlgorithm = HashAlgorithmName.SHA512;
        #endregion

        private string apodo;
        private string nombre;
        private string? apellidos;
        private string correo;
        private string contrasenya;
        private string salt;
        private string? direccion;
        private string? telefono;
        private byte[] foto;

        #region Constructores
        public Usuario(string apodo, string nombre, string? apellidos, string correo,
            string contrasenya, string? direccion, string? telefono)
        {
            this.apodo = apodo;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.correo = correo;
            byte[] salt;
            this.contrasenya = HashContrasenya(contrasenya, out salt);
            this.salt = Convert.ToHexString(salt);
            this.direccion = direccion;
            this.telefono = telefono;
            Bitmap imagen = Properties.Resources.user;
            using (MemoryStream ms = new MemoryStream())
            {
                imagen.Save(ms, ImageFormat.Jpeg);
                foto = ms.ToArray();
            }
        }

        public Usuario(string apodo, string nombre, string? apellidos, string correo,
            string contrasenya, string salt, string? direccion, string? telefono, byte[] foto)
        {
            this.apodo = apodo;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.correo = correo;
            this.contrasenya = contrasenya;
            this.salt = salt;
            this.direccion = direccion;
            this.telefono = telefono;
            this.foto = foto;
        }
        #endregion

        #region Propiedades
        public string Apodo { get { return apodo; } set { this.apodo = value; } }
        public string Nombre { get { return nombre; } set { this.nombre = value; } }
        public string? Apellidos { get { return apellidos; } set { this.apellidos = value; } }
        public string Correo { get { return correo; } set { this.correo = value; } }
        public string? Direccion { get { return direccion; } set { this.direccion = value; } }
        public string? Telefono { get { return telefono; } set { this.telefono = value; } }
        public byte[] Foto { get { return foto; } set { this.foto = value; } }
        #endregion

        #region Cambiar Atributos
        /// <summary>
        /// Modifica un valor de la BD del campo especificado
        /// </summary>
        /// <param name="campo">Campo especificado que se quiere cambiar</param>
        /// <param name="valor">String del valor a actualizar</param>
        public static void CambiarCampo(string campo, string valor)
        {
            string queryString = $"UPDATE usuario SET {campo} = @valor WHERE apodo = @apodo;";

            MySqlCommand comando = new MySqlCommand(queryString, ConexionDB.Conexion);
            comando.Parameters.AddWithValue("@valor", valor);
            comando.Parameters.AddWithValue("@apodo", Sesion.Instance.ApodoUsuario);

            ConexionDB.AbrirConexion();

            comando.ExecuteNonQuery();

            ConexionDB.CerrarConexion();
        }

        /// <summary>
        /// Modifica un valor de la BD del campo especificado
        /// </summary>
        /// <param name="campo">Campo especificado que se quiere cambiar</param>
        /// <param name="valor">Array de bytes del valor a actualizar</param>
        public static void CambiarCampo(string campo, byte[] valor)
        {
            string queryString = $"UPDATE usuario SET {campo} = @valor WHERE apodo = @apodo;";

            MySqlCommand comando = new MySqlCommand(queryString, ConexionDB.Conexion);
            comando.Parameters.AddWithValue("@valor", valor);
            comando.Parameters.AddWithValue("@apodo", Sesion.Instance.ApodoUsuario);

            ConexionDB.AbrirConexion();

            comando.ExecuteNonQuery();

            ConexionDB.CerrarConexion();
        }
        #endregion
        
        /// <summary>
        /// Comprueba si ya hay dado de alta un usuario en la BD
        /// </summary>
        /// <param name="apodo">El apodo (PK) del usuario</param>
        /// <returns>TRUE si existe, FALSE si no</returns>
        public static bool Existe(string apodo)
        {
            string queryString = "SELECT apodo FROM usuario WHERE apodo = @apodo;";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@apodo", apodo);

            ConexionDB.AbrirConexion();

            bool existe;

            using (MySqlDataReader reader = query.ExecuteReader())
            {
                existe = reader.HasRows;
            }

            ConexionDB.CerrarConexion();

            return existe;
        }

        /// <summary>
        /// Comprueba si ya hay dado de alta un correo en la BD
        /// </summary>
        /// <param name="correo">El correo (Campo Unique) a buscar</param>
        /// <returns>TRUE si existe, FALSE si no</returns>
        public static bool CorreoExiste(string correo)
        {
            string queryString = "SELECT correo FROM usuario WHERE correo = @correo;";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@correo", correo);

            ConexionDB.AbrirConexion();

            bool existe;

            using (MySqlDataReader reader = query.ExecuteReader())
            {
                existe = reader.HasRows;
            }

            ConexionDB.CerrarConexion();

            return existe;
        }

        /// <summary>
        /// Busca y retorna un usuario en la BD
        /// </summary>
        /// <param name="apodo">El apodo del usuario a buscar</param>
        /// <returns>Un objeto usuario con los datos recuperados de la BD</returns>
        public static Usuario BuscaUsuario(string apodo)
        {
            Usuario? usuario = null;

            string queryString = "SELECT * FROM usuario WHERE apodo = @apodo";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@apodo", apodo);

            ConexionDB.AbrirConexion();

            using (MySqlDataReader reader = query.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    reader.Read();

                    byte[] byteImagen = (byte[])reader["foto"];

                    usuario = new Usuario(
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetSafeString(2),
                        reader.GetString(3),
                        reader.GetString(4),
                        reader.GetString(5),
                        reader.GetSafeString(6),
                        reader.GetSafeString(7),
                        byteImagen
                    );
                }
            }

            ConexionDB.CerrarConexion();

            return usuario;
        }

        /// <summary>
        /// Añade un usuario a la base de datos
        /// </summary>
        public void Add()
        {
            string queryString = "INSERT INTO usuario (apodo, correo, nombre, apellidos," +
                "contrasenya, salt, direccion, telefono, foto) " +
                "VALUES (@apodo, @correo, @nombre, @apellidos, @contrasenya, @salt, @direccion," +
                "@telefono, @foto);";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@apodo", apodo);
            query.Parameters.AddWithValue("@correo", correo);
            query.Parameters.AddWithValue("@nombre", nombre);
            query.Parameters.AddWithValue("@apellidos", apellidos);
            query.Parameters.AddWithValue("@contrasenya", contrasenya);
            query.Parameters.AddWithValue("@salt", salt);
            query.Parameters.AddWithValue("@direccion", direccion);
            query.Parameters.AddWithValue("@telefono", telefono);
            query.Parameters.AddWithValue("@foto", foto);

            ConexionDB.AbrirConexion();

            query.ExecuteNonQuery();

            ConexionDB.CerrarConexion();
        }

        /// <summary>
        /// Recupera la cuenta del usuario de la base de datos
        /// </summary>
        /// <returns>Un objeto cuenta con los datos recuperados de la base de datos</returns>
        public Cuenta GetCuenta()
        {
            Cuenta cuenta = null;

            string queryString = "SELECT * FROM cuenta WHERE apodoUsuario = @apodo;";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@apodo", apodo);

            ConexionDB.AbrirConexion();

            using (MySqlDataReader reader = query.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    reader.Read();

                    cuenta = new Cuenta(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetFloat(2)
                    );
                }
            }
            
            ConexionDB.CerrarConexion();

            return cuenta;
        }

        /// <summary>
        /// Comprueba las credenciales introducidas por el usuario con las de la BD
        /// </summary>
        /// <param name="contrasenya">La contraseña a comparar</param>
        /// <returns>TRUE si coinciden, FALSE si no</returns>
        public bool CompruebaCredenciales(string contrasenya)
        {
            var saltBytes = Convert.FromHexString(salt);
            var hashAComparar = Rfc2898DeriveBytes.Pbkdf2(
                Encoding.UTF8.GetBytes(contrasenya),
                saltBytes,
                iterations,
                hashAlgorithm,
                keySize);

            string stringAComparar = Convert.ToHexString(hashAComparar);

            return stringAComparar == this.contrasenya;
        }

        /// <summary>
        /// Crea un hash de la contraseña proporcionada por el usuario
        /// </summary>
        /// <param name="contrasenya">El string de la contraseña sin procesar</param>
        /// <param name="salt">Devuelve el salt gastado para cifrar la pwd para guardarlo en la BD</param>
        /// <returns>La contraseña cifrada en un string hexadecimal</returns>
        private string HashContrasenya(string contrasenya, out byte[] salt)
        {
            salt = RandomNumberGenerator.GetBytes(keySize);

            var hash = Rfc2898DeriveBytes.Pbkdf2(
                Encoding.UTF8.GetBytes(contrasenya),
                salt,
                iterations,
                hashAlgorithm,
                keySize);
            return Convert.ToHexString(hash);
        }        
    }
}
