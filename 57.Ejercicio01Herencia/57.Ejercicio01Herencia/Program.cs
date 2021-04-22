using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.Ejercicio01Herencia
{
    class Program
    {
        static void Main(string[] args)
        {

            Repartidor orepartidor = new Repartidor();
            orepartidor.Nombre = "Kevin";
            orepartidor.edad = 25;
            orepartidor.salario = 2000;
            orepartidor.zona = "zona 3";
            orepartidor.plus();
            Console.WriteLine("Salario Repartidor: " + orepartidor.salario);

            Comercial ocomercial = new Comercial();
            ocomercial.Nombre = "Leonardo";
            ocomercial.edad = 22;
            ocomercial.salario = 4000;
            ocomercial.comision = 1000;
            ocomercial.plus();

            Console.WriteLine("Salario Comercial: " + ocomercial.salario);
            Console.ReadKey();

        }
    }
}
