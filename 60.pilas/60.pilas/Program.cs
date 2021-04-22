using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60.pilas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack pilas = new Stack();
            pilas.Push("Lunes");
            pilas.Push("Martes");
            pilas.Push("Miercoles");
            pilas.Push("Jueves");
            pilas.Push("Viernes");
            pilas.Push("Sabado");
            pilas.Push("Domingo");

            Console.WriteLine("El numero de elementos es: "+ pilas.Count);
            foreach(var pila in pilas)
            {
                Console.WriteLine(pila);
            }

            Console.ReadKey();
        }
    }
}
