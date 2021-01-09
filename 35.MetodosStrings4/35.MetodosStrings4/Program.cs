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


            //comienza con determinada letra
            string[] nombres = { "Pepe", "Pedro", "Damian", "Leonardo", "Lorena"};
            int c = 0;
            string cadena = "";
            List<String> nombrePersona = new List<String>();

            foreach (string nom in nombres)
            {
                if(nom.StartsWith("L"))
                {
                    
                    nombrePersona.Add(nom);
                    cadena = nom.Substring(0, 1);
                    c++;
                }
            }
            Console.WriteLine("existen " + c + " nombres que inician con la letra "+ cadena);
            Console.WriteLine("Los nombres son: ");
            foreach(var item in nombrePersona)
            {
                Console.WriteLine("Nombre: "+item);
            }

            Console.ReadKey();

        }
    }
}
