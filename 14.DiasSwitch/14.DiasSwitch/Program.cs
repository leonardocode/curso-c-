using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.DiasSwitch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero del 1 al 7");
            int dia = int.Parse(Console.ReadLine());

            switch(dia)
            {
                case 1:
                    Console.WriteLine("El dia es Lunes");
                break;
                case 2:
                    Console.WriteLine("El dia es Martes");
                break;
                case 3:
                    Console.WriteLine("El dia es Miercoles");
                break;
                case 4:
                    Console.WriteLine("El dia es Jueves");
                break;
                case 5:
                    Console.WriteLine("El dia es Viernes");
                break;
                case 6:
                    Console.WriteLine("El dia es Sabado");
                break;
                case 7:
                    Console.WriteLine("El dia es Domingo");
                break;
                default:
                    Console.WriteLine("Error: el dia ingresado es incorrecto");
                break;
            }

            Console.ReadKey();
        }
    }
}
