using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49.POO4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Persona opersona = new Persona("fabio leonardo","amaya","chaves",26,4600000);

            Console.WriteLine(opersona.imprimenombreCompleto());
            Console.WriteLine(opersona.imprimeedad());
            Console.WriteLine(opersona.imprimeSueldo());

            Console.ReadKey();
        }
    }
}
