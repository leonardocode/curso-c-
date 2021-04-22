using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58.Lista
{
    public class Estudiante
    {
        public string nombre { get; set; }
        public int  nota1 { get; set; }

        public int nota2 { get; set; }

        public int nota3 { get; set; }


        public Estudiante(string nombre, int nota1, int nota2, int nota3)
        {
            this.nombre = nombre;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;

        }
    }
}
