using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31.ArraysDigitos
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 10,4,6,11,145,3453,22,44,1,-6,-8};
            int cantUnaCifra = 0;
            int cantDosCifras = 0;
            int cantTresCifras = 0;
            int cantCuatroCifras = 0;
            foreach(int numero in numeros)
            {
               if(numero >= 0 && numero <= 9)
                {
                    cantUnaCifra++;
                }
               else if(numero >= 10 && numero <= 99)
                {
                    cantDosCifras++;
                }
               else if(numero >= 100 && numero <= 999)
                {
                    cantTresCifras++;
                }
               else
                {
                    cantCuatroCifras++;
                }
            }

            Console.WriteLine("la cantidad de numeros de una cifra es: "+cantUnaCifra);
            Console.WriteLine("la cantidad de numeros de dos cifras es: " + cantDosCifras);
            Console.WriteLine("la cantidad de numeros de tres cifras es: " + cantTresCifras);
            Console.WriteLine("la cantidad de numeros de cuatro cifras es: " + cantCuatroCifras);
            Console.ReadKey();


        }
    }
}
