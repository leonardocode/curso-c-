using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53.ejercicioHerencia
{
    //hereda las propiedades de Persona
    public class Cliente:Persona
    {
        public string Direccion { get; set; }
        public DateTime fechaNacimiento { get; set; }
    }
}
