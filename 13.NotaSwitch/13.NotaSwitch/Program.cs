using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.NotaSwitch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una nota A,B o C");
            string nota = Console.ReadLine();

            switch(nota)
            {
                case "A":
                    Console.WriteLine("Aprobo");
                break;

                case "B":
                    Console.WriteLine("Necesita Reforzamiento");
                break;

                case "C":
                    Console.WriteLine("Desaprobo");
                break;

                default:
                    Console.WriteLine("Error");
                break;
            }
            Console.ReadKey();
        }
    }
}
