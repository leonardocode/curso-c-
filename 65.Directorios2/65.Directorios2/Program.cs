using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _65.Directorios2
{
   public class Program
    {
        static void Main(string[] args)
        {
            /*string ruta = @"D:\Desarrollo\Directorio\Carpeta1";

            string directorio = Directory.GetCurrentDirectory();

            Console.WriteLine(directorio);

            string unidad = Directory.GetDirectoryRoot(ruta);

            Console.WriteLine("Unidad: "+ unidad);*/



            //se mueve una carpeta a una ruta
            /*string rutaInicio = @"D:\Desarrollo\Directorio\CarpetMover";

            string rutaFinal = @"D:\Desarrollo\Directorio2";

            Directory.Move(rutaInicio,rutaFinal);*/


            //copiar un archivo
            string rutaOrigen = @"D:\Desarrollo\Directorio\Carpeta1\documentoExcel.xlsx";
            string rutaDesino = @"D:\Desarrollo\documentoExcel.xlsx";

            File.Copy(rutaOrigen,rutaDesino);




            /*List<string> lista = Directory.EnumerateFileSystemEntries(ruta).ToList();

            foreach(string item in lista)
            {
                Console.WriteLine(item);
            }*/

            Console.ReadKey();
        }
    }
}
