using System;

namespace Semana12Teoria
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector;
            Console.WriteLine("Ingrese el tamaño del vector");
            int contador = int.Parse(Console.ReadLine());
            vector = new int[contador];

            for(int i=0; i < contador; i++)
            {
                Console.WriteLine("Ingrese un valor");
                vector[i] = int.Parse(Console.ReadLine());
                if (vector[i] % 2==0)
                {
                    Console.WriteLine(vector[i] + " es par");
                    
                }
                else
                {
                    Console.WriteLine(vector[i] + " es impar");
                }
            }

        }
    }
}
