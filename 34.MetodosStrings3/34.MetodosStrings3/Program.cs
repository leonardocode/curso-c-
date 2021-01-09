using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34.MetodosStrings3
{
    public class Program
    {
        static void Main(string[] args)
        {
            //TocharArray
            string nombre = "leonardo";
            int c = 0;
            char[] array = nombre.ToCharArray();
            foreach(var arreglo in array)
            {
                if(arreglo.Equals('o'))
                {
                    c++;
                }
            }
            Console.WriteLine("Se repite la letra o: "+c+" veces");
            Console.ReadKey();
        }
    }
}
