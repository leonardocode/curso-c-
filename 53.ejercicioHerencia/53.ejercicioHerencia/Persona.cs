using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53.ejercicioHerencia
{
    //superclase de esta clase heredan propiedades y metodos
    public class Persona
    {
        public string nombre { get; set; }
        public string appaterno { get; set; }
        public string apmaterno { get; set; }
        public int edad { get; set; }

        public string nombreCompleto()
        {
            return this.nombre + " "+ this.appaterno + " " + this.apmaterno;
        }
    }
}
