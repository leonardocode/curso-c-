using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66.MetodosDirectorios
{
   public class Program
    {
        static void Main(string[] args)
        {
            /*string rutaOrigen = @"D:\Desarrollo\examen.txt";

            string rutaMover = @"D:\Desarrollo\Mover\examen.txt";

            File.Copy(rutaOrigen,rutaMover);*/


            /*
            string ruta = @"D:\Desarrollo\prueba.txt";

            //crear, abre el archivo y lo cierra
            using (StreamWriter sw = File.CreateText(ruta))
            {
                sw.Write("Hola");
            }*/

            /*string ruta = @"D:\Desarrollo\prueba.txt";

            File.Delete(ruta);*/


            //escribir contenido a un archivo
            string ruta = @"D:\Desarrollo\examen.txt";

            string contenido = "C# Y SQLSERVER";

            File.WriteAllText(ruta,contenido);


            string contenidoArchivo = File.ReadAllText(ruta);

            Console.WriteLine(contenidoArchivo);

            Console.ReadKey();
        }
    }
}
