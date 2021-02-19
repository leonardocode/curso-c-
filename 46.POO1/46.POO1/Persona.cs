using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46.POO1
{
    public class Persona
    {
        //atributos - caracteristicas de nuestra clase

        public string primerNombre { get; set; }

        public string segundoNombre { get; set; }

        public string primerApellido { get; set; }

        public string segundoApellido { get; set; }

        public int edad { get; set; }

        public decimal sueldo { get; set; }


        //Metodos

        public string imprimenombreCompleto()
        {
            string mensaje = "Bienvenido Sr.(a) " + primerNombre + " " + segundoNombre + " " + primerApellido + " " + segundoApellido;
            return mensaje;
        }

        public string imprimirEdad()
        {
            string mensaje = "Su edad es: " + edad;
            return mensaje;
        }

        public string imprimirSueldo()
        {
            string mensaje = "Su sueldo es: " + sueldo;
            return mensaje;
        }

        public string sueldoAnual()
        {
            string sueldoA = "Su sueldo anual es de: "+sueldo*12;
            return sueldoA;
        }
    }
}
