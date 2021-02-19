using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44.funciones3
{
    public class Program
    {
        static void Main(string[] args)
        {
            decimal CalculoQuincenal = sueldoQuincenal(151.726m);
            Console.WriteLine("Vas a ganar quincenalmente un total de: "+ CalculoQuincenal);

            decimal CalculoMensual = sueldoMensual(151.726m);
            Console.WriteLine("Vas a ganar mensualmente un total de: " + CalculoMensual);

            decimal CalculoAnual = sueldoAnual(151.726m);
            Console.WriteLine("Vas a ganar anualmente un total de: " + CalculoAnual);


            Console.ReadKey();
            
        }

        //quincenal (15 dias)
        static decimal sueldoQuincenal(decimal sueldoDiario)
        {
            return sueldoDiario * 15;
        }

        //mensual (30 dias)
        static decimal sueldoMensual(decimal sueldoDiario)
        {
            return sueldoDiario * 30;
        }

        //anual (365 dias)
        static decimal sueldoAnual(decimal sueldoDiario)
        {
            return sueldoDiario * 365;
        }
    }
}
