using System;

namespace Actividad2S10_ABH
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una oración: ");
            string texto = Console.ReadLine();
            String[] palabras = texto.Split(' ');
            Console.WriteLine("\npalabras ("+ palabras.Length + ")\n");
            for (int a=0; a< palabras.Length; a++)
            {
                Console.WriteLine(palabras[0]);
                    for (int x=1; x< palabras.Length; x++)
                    {
                        if (palabras[x] != palabras[a])
                        {
                            if (a < palabras.Length)
                        {
                            a++;
                            Console.WriteLine(palabras[a]);
                        }
                        
                        }
                    
                }

                
            }
            Console.ReadKey();

        }
    }
}
