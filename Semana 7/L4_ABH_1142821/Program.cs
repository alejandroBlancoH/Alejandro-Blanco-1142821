using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_ABH_1142821
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables e intro
            Console.WriteLine("Ejercicio 1: operaciones aritméticas");
            Console.WriteLine("Ingrese dos números");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            //Procesos
            double a = x + y;
            Console.WriteLine( x + " + " + y + " = " + a);
            double b = x - y;
            Console.WriteLine(x + " - " + y + " = " + b);
            double c = x / y;
            Console.WriteLine(x + " ÷ " + y + " = " + c);

            Console.ReadKey();
             
        }
    }
}
