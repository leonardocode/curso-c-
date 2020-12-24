using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.ejercicioEdad
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la edad de la persona");
            int edad = int.Parse(Console.ReadLine());

            if(edad >= 18)
            {
                Console.WriteLine("la persona es mayor de edad");
            }else
            {
                Console.WriteLine("La persona es menor de edad");
            }
            Console.ReadKey();
        }
    }
}
