using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36.MetodosStrings5
{
    public class Program
    {
        static void Main(string[] args)
        {
            string aves = "Pollo";
            if(aves.StartsWith("P"))
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Mal");
            }



            string apellido = "Amaya";
            if(apellido.EndsWith("a"))
            {
                Console.WriteLine("Temrina con a");
                Console.WriteLine("el tamaño de apellido es: "+apellido.Length);
                Console.WriteLine("el ultimo caracter de apellido es: "+(apellido.Length -1));
                string ultimaLetra = apellido.Substring(apellido.Length - 1, 1);
                Console.WriteLine(ultimaLetra);
            }
            else
            {
                Console.WriteLine("No termina con a");

            }



            string nombre = "leonardo";
            if(nombre.Contains("leo"))
            {
                Console.WriteLine("Bienvenido señor: " + nombre.ToUpper().Substring(0,1));
            }
            else
            {
                Console.WriteLine("No eres bienvenido...");
            }



            //split separa las frases cada vez q encuentra una letra o frase q nosotros le pasemos como parametro a buscar
            string palabra = "Cartuchera";
            string[] array = palabra.Split('a');
            foreach(string item in array)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
