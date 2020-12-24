using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.EjercicioComercial
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese Precio");
            decimal precio = decimal.Parse(Console.ReadLine());

            //como el 20% es 0.20 se coloca la m para q convierta ese 0.20 en decimal y asi multiplicar uno con el otro
            decimal descuento = precio * 0.20m;

            decimal totalAPagar = precio - descuento;

            Console.WriteLine("El total a pagar es: "+totalAPagar);

            Console.ReadKey();

        }
    }
}
