using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50.ejercicio1POO
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cuenta ocuenta = new Cuenta();
            ocuenta.setTitular("Leonardo Amaya");
            ocuenta.setCantidad(400000);
            ocuenta.Ingresar(100000);
            ocuenta.Retirar(100000);

            Console.WriteLine("El dinero que tiene es: "+ocuenta.getCantidad());
            ocuenta.Retirar(500000);
            Console.WriteLine("El dinero que tiene es: " + ocuenta.getCantidad());
            Console.ReadKey();
        }
    }
}
