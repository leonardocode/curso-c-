using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Rangos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese Rango 1");
            int rango1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Rango 2");
            int rango2 = int.Parse(Console.ReadLine());

            for(int i = rango1; i <= rango2; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine("Los Numeros Pares que hay entre: "+rango1 + " y el numero "+rango2+ " Son: "+i);
                }
            }
            Console.ReadKey();  
        }
    }
}
