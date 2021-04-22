using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61.Diccionario
{
   public class Program
    {
        static void Main(string[] args)
        {
            //un diccionario es como llave valor
            Dictionary<int, string> diccionario = new Dictionary<int, string>();
            diccionario.Add(1, "Domingo");
            diccionario.Add(2, "Lunes");
            diccionario.Add(3, "Martes");
            diccionario.Add(4, "Miercoles");
            diccionario.Add(5, "Jueves");
            diccionario.Add(6, "Viernes");
            diccionario.Add(7, "Sabado");

            Console.WriteLine("El numero de elementos es: "+diccionario.Count());

            foreach(string val in diccionario.Values)
            {
                Console.WriteLine(val);
            }
            //metodo clear borra todos los elementos

            if(diccionario.ContainsKey(2))
            {
                Console.WriteLine("Existe");
            }
            else
            {
                Console.WriteLine("No Existe");
            }

            if(diccionario.ContainsValue("Lunes"))
            {
                Console.WriteLine("Existe");
            }

            Console.ReadKey();
        }
    }
}
