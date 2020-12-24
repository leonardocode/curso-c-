using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30.ArraysAcumuladoresContadores
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 4, 5,-4, 7, 8, -2, 12, 176, -6 };
            int sumaNegativos = 0, cantNegativos = 0;
            int sumaPositivos = 0, cantPositivos = 0;
            foreach(int numero in numeros)
            {
                if(numero >= 0)
                {
                    sumaPositivos = sumaPositivos + numero;
                    cantNegativos++;
                }
                else
                {
                    sumaNegativos = sumaNegativos + numero;
                    cantPositivos++;
                }

            }

            Console.WriteLine("la suma de los numeros positivos es: " + sumaPositivos);
            Console.WriteLine("la suma de los numeros negativos es: "+sumaNegativos);
            Console.WriteLine("la cantidad de numeros positivos es: "+cantPositivos);
            Console.WriteLine("la cantidad de numeros negativos es: "+cantNegativos);
            Console.ReadKey();
        }
    }
}
