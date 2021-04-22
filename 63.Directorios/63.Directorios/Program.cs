using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _63.Directorios
{
    public class Program
    {
        static void Main(string[] args)
        {
            string ruta = @"D:\Desarrollo\Directorio";

            //crea una carpeta llamada directorio en la ruta que se le pasa como parametro
            //Directory.CreateDirectory(ruta);

            //elimina la ruta de la carpeta creada, se pasa como parametro el true para que tenga o no tenga archivos la carpeta la elimine
            //Directory.Delete(ruta, true);

            //para saber los subdirectorios dentro de esa carpeta o directorio
            List<string> lista = Directory.EnumerateDirectories(ruta).ToList();

            //filtrar solo las carpetas que inician con C
            List<string> listaDos = Directory.EnumerateDirectories(ruta,"C*").ToList();

            //filtrar solo las carpetas que terminan con C
            List<string> listaTres = Directory.EnumerateDirectories(ruta, "*C").ToList();           


            /*foreach (string elemento in lista)
            {
                Console.WriteLine(elemento);
            }*/


            string ruta2 = @"D:\Desarrollo\Directorio\Carpeta1";

            //enumera los archivos que hay dentro de la carpeta
            List<string> listaArchivos = Directory.EnumerateFiles(ruta2).ToList();

            foreach(string item in listaArchivos)
            {
                Console.WriteLine(item);
            }



            //clase info
            DirectoryInfo informacionDirectorio = new DirectoryInfo(ruta);
            if(informacionDirectorio.Exists)
            {
                Console.WriteLine("Si existe el directorio");
            }
            else
            {
                Console.WriteLine("No existe el directorio");
            }

            //devuelve el nombre del directorio padre
            Console.WriteLine(informacionDirectorio.Parent);

            //obtiene la unidad del disco en donde se encuentra el directorio
            Console.WriteLine(informacionDirectorio.Root);

            Console.ReadKey();
        }
    }
}
