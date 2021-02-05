using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41.timespan
{
    public class Program
    {
        static void Main(string[] args)
        {
            //TimeSpan - sirve para poner hora, minuto y segundo            
            TimeSpan objeto1 = new TimeSpan(4,10,29);
            TimeSpan objeto2 = new TimeSpan(5,15,10);

            TimeSpan objeto3 = objeto1 + objeto2;
            Console.WriteLine("Suma: "+objeto3);

            TimeSpan objeto4 = objeto1 - objeto2;
            Console.WriteLine("Resta: " + objeto4);

            //obtener la hora
            Console.WriteLine("Hora: "+ objeto1.Hours);
            Console.WriteLine("Dias: "+ objeto1.Days);
            Console.WriteLine("Minutos: "+ objeto1.Minutes);
            Console.WriteLine("Segundos: "+ objeto1.Seconds);
            Console.WriteLine("Milisegundos: "+objeto1.Milliseconds);

            //metodos
            Console.WriteLine("Dias Totales: "+objeto1.TotalDays);
            Console.WriteLine("Horas Totales: " + objeto1.TotalHours);
            Console.WriteLine("Minutos Totales: " + objeto1.TotalMinutes);
            Console.WriteLine("Segundos Totales: "+objeto1.TotalSeconds);

            Console.WriteLine(objeto1.CompareTo(objeto2));
            Console.WriteLine(TimeSpan.FromDays(1));
            Console.WriteLine(TimeSpan.FromHours(1));
            Console.WriteLine(TimeSpan.FromMinutes(1));
            Console.WriteLine(TimeSpan.FromSeconds(1));

            //convertir un string a una fecha
            string fecha = "17:20";
            Console.WriteLine(TimeSpan.ParseExact(fecha,@"h\:mm",null));


            Console.ReadKey();


        }
    }
}
