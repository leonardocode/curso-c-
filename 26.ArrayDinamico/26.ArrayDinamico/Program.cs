using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.ArrayDinamico
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad del arreglo");
            int cantArreglo = int.Parse(Console.ReadLine());
            int numero;

            int[] numeros = new int[cantArreglo];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Ingrese numero: ");
                numero = int.Parse(Console.ReadLine());
                numeros[i] = numero;
            }


        }
    }
}
