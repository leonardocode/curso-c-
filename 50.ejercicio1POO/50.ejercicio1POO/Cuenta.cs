using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50.ejercicio1POO
{
    public class Cuenta
    {
        private string titular { get; set; }
        private double cantidad { get; set; }


        //metodos get y set

        public string getTitular()
        {
            return titular;
        }

        public void setTitular(string titular)
        {
            this.titular = titular;
        }

        public double getCantidad()
        {
            return cantidad;
        }

        public void setCantidad(double cantidad)
        {
            if (cantidad > 0)
            {
                this.cantidad = cantidad;
            } else
            {
                this.cantidad = 0;
            }

        }


        //metodos ingresar y retirar
        public void Ingresar(double cantidad)
        {
            this.cantidad = this.cantidad + cantidad;
        }

        public void Retirar(double cantidad)
        {
            if(this.cantidad > cantidad)
            {
                this.cantidad = this.cantidad - cantidad;
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente");
            }
        }
    }
}
