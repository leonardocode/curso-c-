using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46.POO1
{
    public class Program
    {
        public static string nom1;
        public static string nom2;
        public static string ape1;
        public static string ape2;
        public static int edad;
        public static decimal sueldo;
        public static int respuesta;




        static void Main(string[] args)
        {
            Persona opersona = new Persona();

            do
            {
                Console.WriteLine("Ingrese Su Primer Nombre: ");
                opersona.primerNombre = Console.ReadLine();

                Console.WriteLine("Ingrese Su Segundo Nombre: ");
                opersona.segundoNombre = Console.ReadLine();

                Console.WriteLine("Ingrese Su Primer Apellido: ");
                opersona.primerApellido = Console.ReadLine();

                Console.WriteLine("Ingrese Su Segundo Apellido: ");
                opersona.segundoApellido = Console.ReadLine();

                Console.WriteLine("Ingrese Su Edad: ");
                opersona.edad = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese Su Sueldo: ");
                opersona.sueldo = Decimal.Parse(Console.ReadLine());


                Console.WriteLine(opersona.imprimenombreCompleto());
                Console.WriteLine(opersona.imprimirEdad());
                Console.WriteLine(opersona.imprimirSueldo());
                Console.WriteLine(opersona.sueldoAnual());

                Console.WriteLine("Desea Ingresar otro registro? " +
                    "Digite 1 para si " +
                    "Digite 2 para no ");
                respuesta = Int32.Parse(Console.ReadLine());



            }
            while (respuesta == 1);       
            
            if(respuesta == 2 )
            {
                Console.WriteLine("Hasta Luego vuelva pronto....");
                Console.WriteLine("Presione ENTER para salir del programa");

            }

           
            Console.ReadKey();
        }


       

        
    }
}
