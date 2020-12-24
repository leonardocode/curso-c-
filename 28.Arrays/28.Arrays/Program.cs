using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { -100, 56, -20, 15, -12, -20 };
            int c = 0;

            foreach(int numero in numeros)
            {
                if(numero >= 0)
                {
                    c++;
                }
            }
            Console.WriteLine("el numero de positivos: "+c);
            Console.ReadKey();

        }
    }
}
