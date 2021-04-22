using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55.MetodosClasesAbstractas
{
   public class Program
    {
        static void Main(string[] args)
        {
            //para implementar la abstraccion siempre se debe heredar o debe haber una herencia
            //y nunca se va apoder instanciar de una clase abstracta
            Verano overano = new Verano();
            overano.clima();


            Invierno oinvierno = new Invierno();
            oinvierno.clima();


            Console.ReadKey();


        }
    }
}
