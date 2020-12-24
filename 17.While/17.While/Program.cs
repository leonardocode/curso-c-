using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.While
{
    public class Program
    {
        static void Main(string[] args)
        {
            //inicializador
            int i = 1;

            while(i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.ReadKey();
        }
    }
}
