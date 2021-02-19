using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48.POO3
{
    public class Estatico
    {
        public string nombre { get; set; }

        public static string saludo(string nombre)
        {
            return "Bienvenido Sr.(a) " + nombre;
        }

    }
}
