using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionis
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
        private Image? foto;



        public Usuario(string ap, string nom, string apel, string corr, string contr, string dir, string tel, int exp, Image fot)
        {
            apodo = ap;
            nombre = nom;
            apellidos = apel;
            correo = corr;
            contrasenya = contr;
            direccion = dir;
            telefono = tel;
            experiencia = exp;
            foto = fot;
        }



    }
}
