using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40.FindIndex_FindLast
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 5, 18, 21, 4, 13 };
            string[] nombres = { "Pedro", "Luis", "Jose", "Felipe" };

            //va a buscar que numero desde atras para adelante del array es mayor a 20 solo va a traer un solo resultado
            int atrasAelante = Array.FindLast(numeros, p => p > 20);
            Console.WriteLine("El primer numero de atras para adelante es: "+atrasAelante);

            int adelanteAtras = Array.FindIndex(numeros, p => p > 10);
            Console.WriteLine("El indice del  primer numero de adelante para atras es: "+adelanteAtras);
            Console.WriteLine("Su valor es: "+numeros[adelanteAtras]);

            int derechaIzquierda = Array.FindLastIndex(numeros,p => p < 14);
            Console.WriteLine("El indice es: "+ derechaIzquierda);
            Console.WriteLine("El valor es: " + numeros[derechaIzquierda]);

            //buscar nombres en el array
            //p es variable de rango que recorrera cada elemento del array
           bool exito =  Array.Exists(nombres, p => p.StartsWith("P"));
            if(exito)
            {
                Console.WriteLine("Hay elementos que cumplen con la condicion");
            }
            else
            {
                Console.WriteLine("No hay elementos que cumplan la condicion");
            }
                

            Console.ReadKey();
        }
    }
}
