using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.Ejercicio01Herencia
{
    public class Comercial:Empleado
    {
        public double comision { get; set; }

        public override double plus()
        {
            if(edad > 20 && comision > 300)
            {
                salario = salario + PLUS;
                
            }
            return salario;

        }
    }
}
