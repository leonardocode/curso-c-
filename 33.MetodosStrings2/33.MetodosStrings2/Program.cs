using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33.MetodosStrings2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string utiles = "cartuchera";
            Console.WriteLine(utiles.ToUpper());

            Console.WriteLine(utiles.ToLower());

            string nombre1 = "fabio";
            string nombre2 = "leonardo";
            if(nombre1.ToUpper().Equals(nombre2.ToUpper()))
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("No son iguales");
            }
            Console.ReadKey();

        }
    }
}
