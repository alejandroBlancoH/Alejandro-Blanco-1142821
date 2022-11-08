using System;

namespace Semana11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] array = new int[10,3];
           
            for (int i=0;i<10 ; i++ )
            {
                array[i, 0] = rnd.Next(1, 10);
                array[i, 1] = array[i, 0] * 2;
                array[i, 2] = (array[i, 1] + array[i, 0])/2;

            }
            for (int i=0; i<10; i++)
            {
                Console.WriteLine(array[i,0]+" "+array[i,1]+ " "+array[i,2]);
            }
            Console.ReadKey();

        }
    }
}
