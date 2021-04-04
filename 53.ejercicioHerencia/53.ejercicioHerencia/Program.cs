using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53.ejercicioHerencia
{
    public class Program
    {
        static void Main(string[] args)
        {
            Empleado emp = new Empleado();
            emp.nombre = "Leonardo";
            emp.appaterno = "Amaya";
            emp.apmaterno = "Chaves";
            emp.sueldo = 4600000;
            emp.fechaContrato = DateTime.Now;
            string nombreCompleto = emp.nombreCompleto();
            Console.WriteLine("Nombre: "+nombreCompleto);
            Console.WriteLine("Fecha Contrato: "+emp.fechaContrato);
            Console.WriteLine("Sueldo: " + emp.sueldo);


            Cliente ocliente = new Cliente();
            ocliente.nombre = "Joseph";
            ocliente.appaterno = "De la Cruz";
            ocliente.apmaterno = "Aurelio";
            ocliente.edad = 29;
            ocliente.Direccion = "cll falsa con carrera falsa";
            ocliente.fechaNacimiento = DateTime.Now;
            string nombrecomp = ocliente.nombreCompleto();
            Console.WriteLine("Nombre: " + nombrecomp);
            Console.WriteLine("Direccion: " + ocliente.Direccion);
            Console.WriteLine("Fecha Nacimiento: " + ocliente.fechaNacimiento);
            Console.ReadKey();
        }
    }
}
