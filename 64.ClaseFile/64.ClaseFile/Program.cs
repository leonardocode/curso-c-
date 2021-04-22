using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _64.ClaseFile
{
   public class Program
    {
        static void Main(string[] args)
        {
            string ruta = @"D:\Desarrollo\CSharp.txt";

            /*try
            {
                //creamos un archivo txt
                File.Create(ruta);
            } catch (Exception ex)
            {
                Console.WriteLine("Error creando el archivo txt en la ruta");
            }*/

            /*List<String> nombres = new List<string>();
            nombres.Add("Leonardo");
            nombres.Add("Consuelo");
            nombres.Add("Fabio");

            //como primer parametro se le pasa la ruta y despues el contenido que queremos colocar en el archivo
            File.AppendAllLines(ruta,nombres);*/

            string nombres = " Pedro Luis Jose Leonardo Fabio Consuelo";
            File.AppendAllText(ruta,nombres);


            Console.ReadKey();
        }
    }
}
