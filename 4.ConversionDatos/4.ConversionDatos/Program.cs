
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.ConversionDatos
{
   public class Program
    {
        static void Main(string[] args)
        {
            //sumamos una cadena mas un numero con esto lo que obtenemos es una concatenacion
            string numero = "20";
            string resultado = numero + 10;
            Console.WriteLine(resultado);
           


            //otro ejemplo
            string numero2 = "30";
            int numeroConvertido = int.Parse(numero2);
            //double.Parse
            //decimal.Parse
            //float.Parse
            Console.WriteLine(numeroConvertido + 10);



            //conversion al reves
            //si es float, long y demas siempre va a funcionar el toString
            int a = 30;
            string cadena = a.ToString();
            Console.WriteLine(cadena);


            Console.ReadKey();
        }
    }
}
