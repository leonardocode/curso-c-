using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Arrays
{
   public class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = { "leonardo", "pepe", "jose", "gerardo"};

            Console.WriteLine("La posicion 0 del arreglo es: "+nombres[0]);
            Console.WriteLine("La cantidad de elementos que tiene el arreglo es: "+nombres.Length);
            //como inicia en 0 se le resta 1 para traer el ultimo elemento
            Console.WriteLine("el ultimo nombre es: "+nombres[nombres.Length -1]);

            //forma 1 de imprimir
            Console.WriteLine("************ Impresion FOREACH *************");
            foreach(string nombre in nombres)
            {
                Console.WriteLine(nombre);
            }

            Console.WriteLine("************ Impresion FOR *************");
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine(nombres[i]);
            }

            Console.ReadKey();
        }
    }
}
