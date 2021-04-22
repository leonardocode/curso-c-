using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62.excepciones
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 9;
            int numero2 = 0;

            try
            {
                //no se puede dividir entre cero
                int resultado = numero1 / numero2;

            }catch(DivideByZeroException)
            {
                Console.WriteLine("Ocurrio un error, no se puede dividir por cero");
            }








            Console.ReadKey();
        }
    }
}
