using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48.POO3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Estatico oestatico = new Estatico();

            Console.WriteLine("Digite su nombre ");
            oestatico.nombre = Console.ReadLine();


            string saludo = Estatico.saludo(oestatico.nombre);
            Console.WriteLine(saludo);

            Console.ReadKey();
                         
        }
    }
}
