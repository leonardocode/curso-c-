using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43.funciones2
{
    public class Program
    {
        static void Main(string[] args)
        {
            decimal r = calculadora(5,7,'-');
            Console.WriteLine("El resultado es: "+ r);
            Console.ReadKey();      
        }

        static decimal calculadora(decimal a, decimal b, char operacion)
        {
            decimal resultado = 0;
            switch (operacion)
            {
                case '+': resultado = a + b;
                break;

                case '-': resultado = a - b;
                break;

                case '*': resultado = a * b;
                break;

                case '/': resultado = a / b;
                break;

                default: resultado = 0;
                break;


            }

            return resultado;

        }

       
    }
}
