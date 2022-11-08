using System;

namespace Actividad_3
{
    class Program
    {
        static void Main(string[] args)
        {
            inicio:
            Console.WriteLine("Ingrese dos números");

            Double a = Convert.ToDouble(Console.ReadLine());
            Double b = Convert.ToDouble(Console.ReadLine());

            if (b < a)
            {
                Console.WriteLine("b es mayor que a");
            }
            else if (a < b)
            {
                Console.WriteLine("a es mayor que b");
            }
            else
            {
                goto inicio; 
            }

            Console.ReadKey();
        }
    }
}
