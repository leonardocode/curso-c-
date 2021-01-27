using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38.PropiedadMath
{
    public class Program
    {
        static void Main(string[] args)
        {
            //floor elimina el decimal del numero
            double precio = 28.9;
            int a = 2;
            int b = 5;
            int c = 36;
            int d = -2;

            Console.WriteLine("Math.floor: "+ Math.Floor(precio));


            //ceiling- toma el numero entero y le suma 1
            Console.WriteLine("Math.Ceiling: "+ Math.Ceiling(precio));


            //round - redondea al que esta mas cerca
            Console.WriteLine("Math.Round: "+ Math.Round(precio));


            //devuelve el resultado de la potencia base - exponente
            Console.WriteLine("Potencia: " + Math.Pow(a,b));


            //raiz cuadrada
            Console.WriteLine("Raiz Cuadrdada: "+Math.Sqrt(c));


            //saber cual es el mayor de dos numeros
            Console.WriteLine("El mayor es: "+Math.Max(a,b));


            //saber cual es el menor
            Console.WriteLine("El menor es: "+Math.Min(a,b));


            //calcula la integral de un numero
            Console.WriteLine("El valor absoluto es: " + Math.Abs(d));




            Console.ReadKey();
        }
    }
}
