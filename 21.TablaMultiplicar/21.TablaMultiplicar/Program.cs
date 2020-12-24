using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.TablaMultiplicar
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa la tabla de multiplicar que deseas? ");
            int tabla = int.Parse(Console.ReadLine());

            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine(tabla + " X " + i + " = " + tabla * i);               
            }
            Console.ReadKey();
        }
    }
}
