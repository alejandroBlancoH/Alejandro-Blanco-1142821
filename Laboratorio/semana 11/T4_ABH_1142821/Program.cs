using System;

namespace T4_ABH_1142821
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] billetes = new int[6];
            billetes[0] = 100;
            billetes[1] = 50;
            billetes[2] = 20;
            billetes[3] = 10;
            billetes[4] = 5;
            billetes[5] = 1;

            Console.Write("Ingrese una cantidad: Q");
            int cantidad = int.Parse(Console.ReadLine());

            for (int i=0; i<billetes.Length; i++)
            {
                int x = cantidad / billetes[i];
                cantidad = cantidad % billetes[i];
                Console.WriteLine("Q" + billetes[i] + " = " + x);
            }

            Console.ReadKey();
        }
    }
}
