using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.OperacionesStrings
{
    public class Program
    {
        static void Main(string[] args)
        {
            string cad1 = "ABC";
            string cad2 = "DEF";
            int numero = 20;
            string resultado = cad1 + cad2;
            string resultadoDos = cad1 + numero;

            Console.WriteLine(resultado);
            Console.WriteLine(resultadoDos);

            Console.ReadKey();


        }
    }
}
