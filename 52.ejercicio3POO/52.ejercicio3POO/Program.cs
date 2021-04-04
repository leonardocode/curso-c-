using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52.ejercicio3POO
{
    public class Program
    {
        static void Main(string[] args)
        {
            Alumno oalumno = new Alumno();
            oalumno.setNombreAlumno("Coco");
            oalumno.setNota1(35);
            oalumno.setNota2(40);
            oalumno.setNota3(45);
            oalumno.setNota4(50);

            Console.WriteLine("Promedio dos primeras notas: "+oalumno.promedioDosPrimerasNotas());
            Console.WriteLine("Promedio dos ultimas notas: " + oalumno.promedioDosUltimasNotas());
            Console.WriteLine("Promedio cuatro notas: "+ oalumno.promedioCuatroNotas());
            Console.ReadKey();
        }
    }
}
