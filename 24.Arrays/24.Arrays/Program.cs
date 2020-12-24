using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] notas = new int[5];
            notas[0] = 10;
            notas[1] = 20;
            notas[2] = 15;
            notas[3] = 12;
            notas[4] = 18;

            foreach(int nota in notas)
            {
                Console.WriteLine("Nota: "+nota);
            }

            Console.ReadKey();


        }
    }
}
