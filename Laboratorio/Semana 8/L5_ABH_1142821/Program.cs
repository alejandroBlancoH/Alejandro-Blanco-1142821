using System;

namespace L5_ABH_1142821
{
    class Program
    {
        static void ejercicio1()
        {
            Console.WriteLine("Ejercicio 1");
            Console.Write(" Numero entero: ");
            try
            {
                int x = Convert.ToInt32(Console.ReadLine());

                if (x > 0)
                {
                    Console.WriteLine("Es positivo");
                }
                else if (x == 0)
                {
                    Console.WriteLine("Es cero");
                }
                else
                {
                    Console.WriteLine("Es negativo");
                }
                Console.ReadKey();
            }

            catch (FormatException exception)
            {
                Console.WriteLine("No es un número");
                Console.WriteLine(exception.Message);

            }

            Console.ReadKey();
        }
        static void ejercicio2()
        {
            Console.WriteLine("Ingrese un número");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Serie de Fibonacci: ");
            int a = 0, b = 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write(a + ",");
                int aux = a;
                a = b;
                b = aux + b;
            }
        }
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("Ingrese un número de ejercicio: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                ejercicio1();
                break;
                    case 2:
                        ejercicio2();
                        break;
                    case 0:
                        Console.WriteLine("Adiós!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            } while (opcion != 0);
        }
    }
}
