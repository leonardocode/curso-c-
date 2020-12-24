using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.EjercicioSuma
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese numero 1");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero 2");
            int numero2 = int.Parse(Console.ReadLine());
            int suma = numero1 + numero2;
            Console.WriteLine("El resultado de la suma es: "+ suma);
            Console.ReadKey();

        }
    }
}
