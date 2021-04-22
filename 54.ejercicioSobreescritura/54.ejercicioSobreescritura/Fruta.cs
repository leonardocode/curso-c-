using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54.ejercicioSobreescritura
{
    public class Fruta
    {
        //se coloca la clausula virtual para sobreescribir el metodo en las demas clases
        public virtual void Color()
        {
            Console.WriteLine("Tiene Varios colores");
        }
    }
}
