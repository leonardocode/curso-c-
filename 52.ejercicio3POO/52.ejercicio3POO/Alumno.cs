using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52.ejercicio3POO
{
   public class Alumno
    {
        private string nombreAlumno;
        private double nota1;
        private double nota2;
        private double nota3;
        private double nota4;

        //metodos get y set
        public string getNombreAlumno()
        {
            return nombreAlumno;
        }

        public void setNombreAlumno(string nombre)
        {
            this.nombreAlumno = nombre;
        }

        public double getNota1()
        {
            return nota1;
        }

        public void setNota1(double nota1)
        {
            if(nota1>=0&& nota1<=50)
            {
                this.nota1 = nota1;
            }
            else
            {
                this.nota1 = 0;
            }
            
        }

        public double getNota2()
        {
            return nota2;
        }

        public void setNota2(double nota2)
        {
            if (nota2 >= 0 && nota2 <= 50)
            {
                this.nota2 = nota2;
            }
            else
            {
                this.nota2 = 0;
            }
        }

        public double getNota3()
        {
            return nota3;
        }

        public void setNota3(double nota3)
        {
            if (nota3 >= 0 && nota3 <= 50)
            {
                this.nota3 = nota3;
            }
            else
            {
                this.nota3 = 0;
            }
        }

        public double getNota4()
        {
            return nota4;
        }

        public void setNota4(double nota4)
        {
            if (nota4 >= 0 && nota4 <= 50)
            {
                this.nota4 = nota4;
            }
            else
            {
                this.nota4 = 0;
            }
        }

        //metodos que calcula el promedio
        public double promedioDosPrimerasNotas()
        {
            return (this.nota1 + this.nota2) / 2.0;
        }

        public double promedioDosUltimasNotas()
        {
            return (this.nota3 + this.nota4) / 2.0;
        }

        public double promedioCuatroNotas()
        {
            return (this.nota1 + this.nota2 + this.nota3 + this.nota4) / 4.0;
        }
    }
}
