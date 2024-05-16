using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Gestionis.Properties;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace Gestionis.Clases
{
    class Usuario
    {
        private string apodo;
        private string nombre;
        private string? apellidos;
        private string correo;
        private string contrasenya;
        private string? direccion;
        private string? telefono;
        private int experiencia;
        private byte[] foto;

        public Usuario(string apodo, string nombre, string? apellidos, string correo,
            string contrasenya, string? direccion, string? telefono)
        {
            this.apodo = apodo;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.correo = correo;
            this.contrasenya = contrasenya;
            this.direccion = direccion;
            this.telefono = telefono;
            experiencia = 0;
            Bitmap imagen = Resources.usuario;
            using (MemoryStream ms = new MemoryStream())
            {
                imagen.Save(ms, ImageFormat.Jpeg);
                foto = ms.ToArray();
            }
        }

        public Usuario(string apodo, string nombre, string? apellidos, string correo,
            string contrasenya, string? direccion, string? telefono, int experiencia,
            byte[] foto)
        {
            this.apodo = apodo;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.correo = correo;
            this.contrasenya = contrasenya;
            this.direccion = direccion;
            this.telefono = telefono;
            this.experiencia = experiencia;
            this.foto = foto;
        }

        public string Apodo { get { return apodo; } set { this.apodo = value; } }
        public string Nombre { get { return nombre; } set { this.nombre = value; } }
        public string? Apellidos { get { return apellidos; } set { this.apellidos = value; } }
        public string Correo { get { return correo; } set { this.correo = value; } }
        public string? Direccion { get { return direccion; } set { this.direccion = value; } }
        public string? Telefono { get { return telefono; } set { this.telefono = value; } }
        public int Experiencia { get { return experiencia; } set { this.experiencia = value; } }
        public byte[] Foto { get { return foto; } set { this.foto = value; } }

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

        public static bool CompruebaCredenciales(string apodo, string contrasenya)
        {
            string queryString = "SELECT contrasenya FROM usuario WHERE apodo = @apodo;";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@apodo", apodo);

            ConexionDB.AbrirConexion();

            bool contrasenyaCorrecta = contrasenya == query.ExecuteScalar().ToString();

            ConexionDB.CerrarConexion();

            return contrasenyaCorrecta;
        }

        public static Usuario? BuscaUsuario(string apodo)
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
                        reader.GetSafeString(5),
                        reader.GetSafeString(6),
                        reader.GetInt32(7),
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
                "contrasenya, direccion, telefono, experiencia, foto) " +
                "VALUES (@apodo, @correo, @nombre, @apellidos, @contrasenya, @direccion," +
                "@telefono, @experiencia, @foto);";

            MySqlCommand query = new MySqlCommand(queryString, ConexionDB.Conexion);
            query.Parameters.AddWithValue("@apodo", apodo);
            query.Parameters.AddWithValue("@correo", correo);
            query.Parameters.AddWithValue("@nombre", nombre);
            query.Parameters.AddWithValue("@apellidos", apellidos);
            query.Parameters.AddWithValue("@contrasenya", contrasenya);
            query.Parameters.AddWithValue("@direccion", direccion);
            query.Parameters.AddWithValue("@telefono", telefono);
            query.Parameters.AddWithValue("@experiencia", experiencia);
            query.Parameters.AddWithValue("@foto", foto);

            ConexionDB.AbrirConexion();

            query.ExecuteNonQuery();

            ConexionDB.CerrarConexion();
        }
    }
}
