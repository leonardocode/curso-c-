using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.EjercicioCategoria
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una nota A, B o C");
            string valor = Console.ReadLine();

            if (valor.Equals("A") || valor.Equals("a"))
            {
                Console.WriteLine("El usuario Aprobo");
            }
            else if (valor.Equals("B") || valor.Equals("b"))
            {
                Console.WriteLine("El usuario necesita reforzamiento");
            }
            else if (valor.Equals("C") || valor.Equals("c"))
            {
                Console.WriteLine("El usuario desaprobo");
            }
            else
            {
                Console.WriteLine("Error esa nota no existe");
            }

            Console.ReadKey();
        }
    }
}
