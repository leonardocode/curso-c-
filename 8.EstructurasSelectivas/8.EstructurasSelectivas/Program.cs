﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.EstructurasSelectivas
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 30;

            if(a > b)
            {
                Console.WriteLine(a + " es mayor que "+b);
            }
            else
            {
                Console.WriteLine(b + " es mayor que "+a);
            }

            if(a.Equals(b))
            {
                Console.WriteLine(a + " Es Igual "+b);
            }else
            {
                Console.WriteLine(a+ " Es Diferente "+b);
            }
            Console.ReadKey();
        }
    }
}
