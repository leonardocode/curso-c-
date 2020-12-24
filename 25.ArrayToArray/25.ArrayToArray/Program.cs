using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.ArrayToArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[,] nombresCompletos =
            {
                {"Fabio","Leonardo","Amaya","Chaves"},
                {"Ricardo","De la Cruz", "Sandoval","Murayari"},
                {"Rolando","Garcia","Peceros","Sandoval"}
            };

            Console.WriteLine(nombresCompletos[0,0]);
            Console.ReadKey();

        }
    }
}
