using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32.MetodosStrings
{
   public class Program
    {
        static void Main(string[] args)
        {
            String nombre = "Leonardo";

            //saber el tramaño de caracteres de la variable
            Console.WriteLine("el tamaño de caracteres es: "+nombre.Length);


            //equals sirven para comparar si dos cadenas son iguales
            String a = "papa";
            String b = "papa";
            if(a.Equals(b))
            {
                Console.WriteLine("Las Cadenas Son Iguales");
            }
            else
            {
                Console.WriteLine("Las Cadenas Son Diferentes");
            }


            //Trim
            //funciona para eliminar los espacios en las cadenas de caracteres de solo el inicio y el final
            string apellido = " amaya ";
            Console.WriteLine("El tamaño del apellido es: "+apellido.Length);
            Console.WriteLine(apellido);
            Console.WriteLine(apellido.Trim());

            //TrimStart elimina los espacios solo al inicio
            string objeto = " Meza ";
            Console.WriteLine(objeto.TrimStart());

            //TrimEnd elimina los espacios solo al final
            string objeto2 = " Meza  ";
            Console.WriteLine(objeto2.TrimEnd());
            
            Console.ReadKey();
        }
    }
}
