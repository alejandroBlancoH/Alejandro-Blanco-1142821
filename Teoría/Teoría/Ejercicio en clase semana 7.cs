using System;

namespace Alejandro_Blanco_1142821
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Asigne el valor de r en números arábicos (2,3,4.5, etc)");
            double pi = 3.1416;
            double r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(r);
            Console.WriteLine(pi);
            double area;
        
                area = pi * Math.Pow(r, 2);
                Console.WriteLine("El valor del area es: " + area.ToString() + " m2");

            Console.WriteLine("Ingrese el valor de la base del rectángulo");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la altura del rectángulo");
            double h= Convert.ToDouble(Console.ReadLine());

            double perimetro = 2*(b + h);
            Console.WriteLine("El valor del perímetro es de " + perimetro.ToString() + " m");

            double arear = b * h;
            Console.WriteLine("El valor del área del rectángulo es de " + arear.ToString() + " m");
            Console.ReadKey();

        }
    }
}
