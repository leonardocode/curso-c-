using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58.Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            int respuesta = 1;
            int contador = 0;
            int contadorNumerico = 1;
            List<Estudiante> listaestudiantes = new List<Estudiante>();
            while (respuesta == 1)
            {
                Console.WriteLine("Ingrese Nombre");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese nota 1");
                int nota1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese nota 2");
                int nota2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese nota 3");
                int nota3 = Int32.Parse(Console.ReadLine());                
                Estudiante oestudiante = new Estudiante(nombre,nota1,nota2, nota3);                
                listaestudiantes.Add(oestudiante);
                contador = contador + 1;

                Console.WriteLine("Desea Agregar otro estudiante ?" 
                    + "Digite 1 para Si" 
                    + "Cualquier tecla para No");
                respuesta = Int32.Parse(Console.ReadLine());

                if(respuesta == 1)
                {
                    respuesta = 1;
                }
                else
                {
                    respuesta = 0;
                }

            }

                      

            foreach (var estudiante in listaestudiantes)
            {         
               
                Console.WriteLine("//--------------------------------------//");
                Console.WriteLine("Estudiante #: " + contadorNumerico);            
                Console.WriteLine("Nombre: " + estudiante.nombre);
                Console.WriteLine("Nota 1: " + estudiante.nota1);
                Console.WriteLine("Nota 2: " + estudiante.nota2);
                Console.WriteLine("Nota 3: " + estudiante.nota3);

                int promedio = estudiante.nota1 + estudiante.nota2 + estudiante.nota3 / contador;

                Console.WriteLine("El promedio de sus notas es: " + promedio);
                contadorNumerico = contadorNumerico + 1;
               
               
              
            }
            Console.WriteLine("Hasta Luego Vuelva pronto !!!!");
            Console.ReadKey();
        }
    }
}
