using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Descuento
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("El sueldo del empleado es: ");
            double sueldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Categoria");
            string categoria = Console.ReadLine();
            double aumento;

            switch(categoria)
            {
                case "A":
                    aumento = 500;
                break;
                case "B":
                    aumento = 300;
                break;
                case "C":
                    aumento = 100;
                break;
                default:
                    aumento = 10;
                break;

            }

            double total = sueldo + aumento;
            Console.WriteLine("el total a pagar es: "+total);
            Console.ReadKey();

        }
    }
}
