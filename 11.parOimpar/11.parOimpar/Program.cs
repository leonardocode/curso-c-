using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.parOimpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese numero");
            int numero = int.Parse(Console.ReadLine());
            
            if(numero % 2 == 0)
            {
                //numero divido entre 2 el modulo o residuo es igual a 0 y eso significa que es par
                Console.WriteLine(numero + " Es Par. ");
            }
            else
            {
                Console.WriteLine(numero + " Es Impar. ");
            }
            Console.ReadKey();
        }
    }
}
