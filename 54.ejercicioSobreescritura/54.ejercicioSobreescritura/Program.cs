using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54.ejercicioSobreescritura
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pera oPera = new Pera();
            oPera.Color();

            Fresa oFresa = new Fresa();
            oFresa.Color();

            Console.ReadKey();
        }
    }
}
