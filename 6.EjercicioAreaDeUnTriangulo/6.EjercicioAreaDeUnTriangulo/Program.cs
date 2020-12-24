using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.EjercicioAreaDeUnTriangulo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la base");
            double baseTriangulo = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la altura");
            double alturaTriangulo = double.Parse(Console.ReadLine());

            double area = (baseTriangulo * alturaTriangulo)/2;

            Console.WriteLine("El area del triangulo es: "+area);

            Console.ReadKey();

        }
    }
}
