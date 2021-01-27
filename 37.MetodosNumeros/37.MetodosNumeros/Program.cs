using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37.MetodosNumeros
{
    public class Program
    {
        static void Main(string[] args)
        {
            string numero = "15";
            int resultado;
            //convertir u string  a un numero
            //Int16 short
            //Int64 long
            bool exito = Int32.TryParse(numero,out resultado);
            if(exito == true)
            {
                Console.WriteLine("se pudo convertir el numero de manera correcta. Numero: "+resultado);
            }
            else
            {
                Console.WriteLine("Fue imposible convertir el numero señor");
            }


            int a = 20;
            int b = 20;
            if(a.Equals(b))
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("Son Diferentes");
            }

           
            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());


            Console.ReadKey();
        }
    }
}
