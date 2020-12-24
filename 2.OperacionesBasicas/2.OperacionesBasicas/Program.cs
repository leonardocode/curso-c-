using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.OperacionesBasicas
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 50;
            int b = 40;
            double c = 20.5;

            int suma = a + b;
            int resta = a - b;
            int multiplicacion = a * b;
            double division = Convert.ToDouble(a) / Convert.ToDouble(b);
            int residuo = a % b;
            double e = b + c;


            Console.WriteLine("Suma: "+suma);
            Console.WriteLine("Resta: "+resta);
            Console.WriteLine("Multiplicacion: "+multiplicacion);
            Console.WriteLine("Division: "+division);
            Console.WriteLine("Suma Double: "+e);
            Console.WriteLine("Residuo: "+residuo);
            Console.ReadKey();
        }
    }
}
