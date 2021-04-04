using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.ejercicio2POO
{
    public class Program
    {
        static void Main(string[] args)
        {
            Ticket oticket = new Ticket();
            oticket.setColor("Azul");
            oticket.setTamanio(2);
            oticket.setTipo(1);
            oticket.setCantidad(2);

            Console.WriteLine("Precio: "+oticket.calcularPrecio());
            Console.WriteLine("Cantidad: "+oticket.getCantidad());
            Console.WriteLine("Total: "+oticket.totalPagar());
            Console.ReadKey();

        }
    }
}
