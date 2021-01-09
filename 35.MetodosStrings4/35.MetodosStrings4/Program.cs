using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35.MetodosStrings4
{
    public class Program
    {
        static void Main(string[] args)
        {
            string pasaporte = "12345678";
            string nombre = "Pato Lucas";

            //substring
            string codigo = nombre.Substring(5,5) + pasaporte.Substring(0, 3);
            Console.WriteLine("El codigo suyo es: "+codigo);


            //remove
            Console.WriteLine("Se eliminan caracteres y queda: "+codigo.Remove(5, 3));


            Console.ReadKey();

        }
    }
}
