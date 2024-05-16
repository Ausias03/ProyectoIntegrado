using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionis.Clases
{
    internal class Utilidades
    {
        public static bool TieneEspacios(string apodo)
        {
            const char espacio = ' ';
            return apodo.Contains(espacio);
        }
    }
}
