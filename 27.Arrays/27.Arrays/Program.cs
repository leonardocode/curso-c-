using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27.Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = {31,34,37,46,20,42};

            foreach(int numero in numeros)
            {
                if(numero > 18 && numero < 35)
                {
                    Console.WriteLine(numero);
                }
            }
            Console.ReadKey();
        }
    }
}
