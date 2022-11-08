using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TsS8_ABH
{
    class Program
    {
        static void Main(string[] args)
        {
        menu:
            Console.WriteLine("Ingrese una cantidad en Fahrenheit ");
            Double F = Convert.ToDouble(Console.ReadLine());

            //conversión
            double C = (F -32) * 5/9;
            Console.WriteLine(F + " en celsius es igual a " + C);

            Console.WriteLine("Si desea repetir ingrese 1, sino ingrese 2");
            int a = Convert.ToInt32(Console.ReadLine());
            menu2:
            switch (a)
            {
                case 1:
                    goto menu;
                    
                case 2:
                    Console.WriteLine("Feliz día");
                    break;
                default:
                    Console.WriteLine("Error. Intente otra vez");
                    goto menu2;
            }
            Console.ReadKey();

        }
    }
}
