using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45.funciones4
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = { "Pepe", "Lucho", "Felipe" };
            string[] apellidos = { "Gomez", "Perez", "Mejia" };

            imprimirArray(nombres);
            imprimirArray(apellidos);

            Console.ReadKey();
        }

        static void imprimirArray(string[] array)
        {
            foreach(string item in array)
            {
                Mensaje(item);
            }
        }

        static void Mensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}
