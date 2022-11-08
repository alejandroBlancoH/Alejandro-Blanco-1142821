using System;

namespace Semana12TS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 12 TS: ");
            int[] numeros = new int [5];
            string[] letras = new string[5];
            numeros[0]= 1;
            numeros[1] = 2;
            numeros[2] = 3;
            numeros[3] = 4;
            numeros[4] = 5;

            letras[0] = "a";
            letras[1] = "e";
            letras[2] = "i";
            letras[3] = "o";
            letras[4] = "u";

            for (int i = 0; i < 5; i++)
            {
                for (int y = 0; y < 5; y++)
                {
                    Console.Write(numeros[i] + letras[y] + " ");
                }
            }
        }
    }
}
