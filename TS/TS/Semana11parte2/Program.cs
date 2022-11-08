using System;

namespace Semana11parte2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese 9 valores numéricos");
            int[,] matriz = new int[3, 3];
            for (int i=0; i < 3; i++)
            {
                for(int y = 0; y < 3; y++)
                {
                    matriz[y,i]= int.Parse(Console.ReadLine());
                    
                   
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int y = 0; y < 3; y++)
                {
                   if (matriz[i,y]== matriz[y, i])
                    {
                        Console.WriteLine("Es simétrica");
                    }


                }
            }

        }
    }
}
