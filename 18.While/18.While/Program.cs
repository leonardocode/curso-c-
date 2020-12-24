using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.While
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*int i = 120;
            while(i >= 1)
            {
                Console.WriteLine(i);
                //i--;
                //i -= 2;
                i = i - 2;
            }
            Console.ReadKey();*/


            //permitir ingresar 10 numeros y hallar su suma
            int i = 1;
            int numero;
            int sumaTotal = 0;
            while(i <= 5)
            {
                Console.WriteLine("Ingresa numero: ");
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine("El numero ingresado es: "+numero);
                sumaTotal = sumaTotal + numero;
                i++;

            }
            Console.WriteLine("La suma total es: "+ sumaTotal);
            Console.ReadKey();

        }
    }
}
