using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42.funciones
{
    public class Program
    {
        static void Main(string[] args)
        {
            int resultado = suma(6,7);
            Console.WriteLine("la suma es: "+ resultado);

            int resultado2 = suma(2, 3);
            Console.WriteLine("la suma es: " + resultado2);

            Console.ReadKey();
        }

        static int suma(int a, int b)
        {
            return a + b;
        }
    }
}
