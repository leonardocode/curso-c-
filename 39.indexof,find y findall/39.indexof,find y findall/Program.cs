using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39.indexof_find_y_findall
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = {5,18,21,4,13 };
            string[] nombres = {"Pedro","Luis","Jose","Felipe"};


            int longitudNumeros = numeros.Length;
            Console.WriteLine("el numero de elementos es: "+ longitudNumeros);


            //sacar el primer elemento del array  que sea mayor a 15
            //con p declaramos una variable de rango y lo q va hacer es buscar en todo el array cual cumple con la condicion de ser mayor a 15
            //este arrayfind solo busca una coincidencia con la condicion que uno busca
            int mayora15 = Array.Find(numeros, p => p > 15);
            Console.WriteLine("el primer elemento mayor a 15 es: " + mayora15);

            //con findAll busca todos los numeros q son mayores a 15 y imprime todos a diferencia de solo el find
            int[] numerosFiltrados = Array.FindAll(numeros,e => e > 15);
            foreach(int numero in numerosFiltrados)
            {
                Console.WriteLine("numero: "+numero);
            }

            //devuelve el indice en donde se encuentra el valor buscado en el array
            int indice = Array.IndexOf(numeros,21);
            if(indice > 0)
            {
                Console.WriteLine("Existe el valor");
            }
            else
            {
                Console.WriteLine("No Existe el valor");
            }

            Console.ReadKey();
        }
    }
}
