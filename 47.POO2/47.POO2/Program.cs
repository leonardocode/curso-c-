using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47.POO2
{
    public class Program
    {
        static void Main(string[] args)
        {
            usuario ousuario = new usuario();
            ousuario.nombreUsuario = "lamaya";
            ousuario.contra = "12345678";

            Console.WriteLine("El usuario es: "+ousuario.nombreUsuario);
            Console.WriteLine("Su Contraseña es: "+ousuario.contra);
            Console.ReadKey();
        }
    }
}
