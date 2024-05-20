using Gestionis.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionis.Clases
{
    static class SistemaNiveles
    {

        public static int GetExperiencia(string apodo)
        {
            int experiencia = 0;

            string consulta = "SELECT experiencia FROM usuario WHERE apodo = @apodo;";
            MySqlCommand comando = new MySqlCommand(consulta, ConexionDB.Conexion);
            comando.Parameters.AddWithValue("@apodo", apodo);

            ConexionDB.AbrirConexion();
            experiencia = Convert.ToInt32(comando.ExecuteScalar());
            ConexionDB.CerrarConexion();

            return experiencia;
        }

        public static int GetNivel(string apodo)
        {
            int nivel = 0;

            string consulta = "SELECT nivel FROM usuario WHERE apodo = @apodo;";
            MySqlCommand comando = new MySqlCommand(consulta, ConexionDB.Conexion);
            comando.Parameters.AddWithValue("@apodo", apodo);

            ConexionDB.AbrirConexion();
            nivel = Convert.ToInt32(comando.ExecuteScalar());
            ConexionDB.CerrarConexion();

            return nivel;
        }

        public static void IncrementarExperiencia(string apodo, int puntos)
        {
            int experienciaActual = GetExperiencia(apodo);

            experienciaActual += puntos;

            string consulta = "UPDATE usuario SET experiencia = @experiencia WHERE apodo = @apodo;";
            MySqlCommand comando = new MySqlCommand(consulta, ConexionDB.Conexion);
            comando.Parameters.AddWithValue("@experiencia", experienciaActual);
            comando.Parameters.AddWithValue("@apodo", apodo);

            ConexionDB.AbrirConexion();
            comando.ExecuteNonQuery();
            ConexionDB.CerrarConexion();

            ActualizarNivel(apodo, experienciaActual);
        }

        private static void ActualizarNivel(string apodo, int experiencia)
        {
            int nuevoNivel;

            string consultaNivel = "SELECT idNivel FROM nivel WHERE @experiencia >= xpRequerido ORDER BY xpRequerido DESC LIMIT 1;";
            MySqlCommand comandoNivel = new MySqlCommand(consultaNivel, ConexionDB.Conexion);
            comandoNivel.Parameters.AddWithValue("@experiencia", experiencia);

            ConexionDB.AbrirConexion();
            nuevoNivel = Convert.ToInt32(comandoNivel.ExecuteScalar());
            ConexionDB.CerrarConexion();

            string consultaUpdate = "UPDATE usuario SET nivel = @nivel WHERE apodo = @apodo;";
            MySqlCommand comandoUpdate = new MySqlCommand(consultaUpdate, ConexionDB.Conexion);
            comandoUpdate.Parameters.AddWithValue("@nivel", nuevoNivel);
            comandoUpdate.Parameters.AddWithValue("@apodo", apodo);

            ConexionDB.AbrirConexion();
            comandoUpdate.ExecuteNonQuery();
            ConexionDB.CerrarConexion();
        }

        public static int GetXpRequeridoParaNivel(int nivel)
        {
            int xpRequerido = 0;

            string consulta = "SELECT xpRequerido FROM nivel WHERE idNivel = @nivel;";
            MySqlCommand comando = new MySqlCommand(consulta, ConexionDB.Conexion);
            comando.Parameters.AddWithValue("@nivel", nivel);

            ConexionDB.AbrirConexion();
            xpRequerido = Convert.ToInt32(comando.ExecuteScalar());
            ConexionDB.CerrarConexion();

            return xpRequerido;
        }

        public static (int experienciaActual, int nivelActual, int xpParaSiguienteNivel, int xpParaNivelActual) GetNivelInfo(string apodo)
        {
            int experienciaActual = GetExperiencia(apodo);
            int nivelActual = GetNivel(apodo);
            int xpParaSiguienteNivel = GetXpRequeridoParaNivel(nivelActual + 1);
            int xpParaNivelActual = GetXpRequeridoParaNivel(nivelActual);

            return (experienciaActual, nivelActual, xpParaSiguienteNivel, xpParaNivelActual);
        }

        public static int GetExpProgress(string apodo)
        {
            var (experienciaActual, nivelActual, xpParaSiguienteNivel, xpParaNivelActual) = GetNivelInfo(apodo);

            int progress = experienciaActual - xpParaNivelActual;

            if (progress < 0)
            {
                progress = 0;
            }
            else if (progress > xpParaSiguienteNivel - xpParaNivelActual)
            {
                progress = xpParaSiguienteNivel - xpParaNivelActual;
            }

            return progress;
        }
    }
}
