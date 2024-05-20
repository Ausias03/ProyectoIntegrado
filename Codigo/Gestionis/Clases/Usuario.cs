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
            Bitmap imagen = Properties.Resources.usuario;
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
        public void CambiarTel(MySqlConnection conexion, string apodo, string tel)
        {
            string consulta = String.Format("UPDATE usuario SET telefono= '{0}' WHERE apodo = '{1}'", tel, apodo);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();

        }

        public void CambiarDir(MySqlConnection conexion, string apodo, string dir)
        {
            string consulta = String.Format("UPDATE usuario SET direccion= '{0}' WHERE apodo = '{1}'", dir, apodo);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();

        }

        public void CambiarCorreo(MySqlConnection conexion, string apodo, string correo)
        {
            string consulta = String.Format("UPDATE usuario SET correo= '{0}' WHERE apodo = '{1}'", correo, apodo);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();

        }

        public void CambiarApodo(MySqlConnection conexion, string apodo, string apodo2)
        {
            string consulta = String.Format("UPDATE usuario SET apodo= '{0}' WHERE apodo = '{1}'", apodo2, apodo);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();

        }

        public void CambiarApellidos(MySqlConnection conexion, string apodo, string apellidos)
        {
            string consulta = String.Format("UPDATE usuario SET apellidos = '{0}' WHERE apodo = '{1}'", apellidos, apodo);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();

        }

        public void CambiarNombre(MySqlConnection conexion, string apodo, string nombre)
        {
            string consulta = String.Format("UPDATE usuario SET nombre = '{0}' WHERE apodo = '{1}'", nombre, apodo);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();

        }
        #endregion
        
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
