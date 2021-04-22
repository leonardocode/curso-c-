using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56.Polimorfismo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //una clase padre tambien puede instanciar de sus clases hijas o subclases ese es el polimorfismo
            Persona per = new Persona();
            per.nombre = "leonardo";
            per.appaterno = "amaya";
            per.apmaterno = "chaves";

            
            Persona oPersona1 = new Empleado();

            Persona oPersona2 = new Cliente();
        }
    }
}
