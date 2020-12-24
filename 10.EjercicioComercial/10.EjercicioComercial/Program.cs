using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.EjercicioComercial
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese precio total");
            double precio = double.Parse(Console.ReadLine());
            double descuento;

            if(precio > 500)
            {
                descuento = precio * 0.20;
            }
            else
            {
                descuento = precio * 0.10;
            }
            double total = precio - descuento;
            Console.WriteLine("El total a pagar es: "+total);

            Console.ReadKey();
        }
    }
}
