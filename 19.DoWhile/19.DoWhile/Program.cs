using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.DoWhile
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ingresar numeros hasta que el numero sea negativo
            int numero, i = 1;

            do {
                Console.WriteLine("Ingrese Numero: "+i);
                numero = int.Parse(Console.ReadLine());
                i++;
               


            } while (numero >= 0);
           
            Console.WriteLine("Finalizo...."); 
            Console.ReadKey();
        }
    }
}
