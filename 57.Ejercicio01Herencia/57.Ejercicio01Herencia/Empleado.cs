using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.Ejercicio01Herencia
{
    public abstract class Empleado
    {

        public string Nombre { get; set; }
        public int edad {get; set;}
        public double salario {get; set;}

        //indica que es una constante
        public readonly int PLUS = 400;

        //metodo abstracto- aquel que no se puede definir y que la implementacion varia segun su tipo, si el metodo es abstracto la clase tambien debe ser abstracta
        public abstract double plus();
    }
}
