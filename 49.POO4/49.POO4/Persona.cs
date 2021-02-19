using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49.POO4
{
    public class Persona
    {
        //atributos
        public  string nombre { get; set; }

        public  string apPaterno { get; set; }

        public  string apMaterno { get; set; }

        public  int edad { get; set; }

        public  double sueldo { get; set; }


        //constructor
        public Persona(string nombre, string apPaterno, string apMaterno, int edad, double sueldo)
        {
            this.nombre = nombre;
            this.apPaterno = apPaterno;
            this.apMaterno = apMaterno;
            this.edad = edad;
            this.sueldo = sueldo;
        }

        //metodos
        public string imprimenombreCompleto()
        {
            return "Bienvenido Sr(a). " + nombre + " " + apPaterno + " " + apMaterno;
        }

        public string imprimeedad()
        {
            return "Tu edad es: " + edad;
        }

        public string imprimeSueldo()
        {
            return "Tu sueldo es: " + sueldo;
        }




    }
}
