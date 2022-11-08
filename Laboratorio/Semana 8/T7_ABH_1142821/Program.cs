using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7_ABH_1142821
{
    class Program
    {
        static void Main(string[] args)
        {
            double suma=0;
            double suma2 = 0;
            double suma3 = 0;
            menu:
            Console.WriteLine("Ingrese un número mayor a 0");
            double n = Convert.ToDouble(Console.ReadLine());

            if (n>0)
            {
                Console.WriteLine("Fórmula 1:");
                for (double i=1; i<=n; i++)
                {
                    suma = suma +(1 / i);
                }
               Console.WriteLine(Math.Round(suma,2));

                Console.WriteLine("Fórmula 2:");
                for (double a=1; a <=n ;a++)
                {
                    suma2 = suma2 + (1 / Math.Pow(2, a));
                }
                Console.WriteLine(Math.Round(suma2, 4));

                for (double a=1; a<=n; a++)
                {
                    porsi:
                    Console.WriteLine("Ingrese dos valores para realizar el tercer proceso");
                    double x= Convert.ToDouble(Console.ReadLine());
                    double b= Convert.ToDouble(Console.ReadLine());
                    if ((x>0) && (b > 0))
                    {
                        double resta1 = n - a;
                        suma3 = suma3 +(Math.Pow(x, a)) *(Math.Pow(b,resta1 )) ; 
                    }

                    else
                    {
                        Console.WriteLine("Error");
                        goto porsi;
                    }

                }
                Console.WriteLine(Math.Round(suma3, 4));

            }
            else
            {
                Console.WriteLine("Error. Vuelva a intentar");
                goto menu;
            }

            Console.ReadKey();
        }
    }
}
