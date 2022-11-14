using System;

namespace Proyecto2_Album
{
    class Program
    {
        static Album album;
        static void marcarestampa(string codigo)
        {
            int i = album.buscarEstampa(codigo);
            if (i >= 0)
            {
                album.estampas[i].marcar();
            }else
            {
                Console.WriteLine("Estampa no encontrada");
            }
        }
        static void mrepetirestampa(string codigo)
        {
            int i = album.buscarEstampa(codigo);
            if (i >= 0)
            {
                album.estampas[i].repetir();
            }
            else
            {
                Console.WriteLine("Estampa no encontrada");
            }
        }
        static void Main(string[] args)
        {
            album = new Album();
            int opcion;
            string estampadeseada, estamparepetida;
        menu:
            Console.WriteLine("----------Album del mundial 2022----------");
            Console.WriteLine("ingrese el número de la opción que desee:");
            Console.WriteLine("1.Marcar una estampa");
            Console.WriteLine("2.Marcar una estampa repetida");
            Console.WriteLine("3. Ver estampas marcadas");
            Console.WriteLine("4. Ver estampas faltantes");
            Console.WriteLine("5. Ver estampas repetidas");
            Console.WriteLine("6. Salir");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Ingrese las siglas de la seleccion seguido de su número");
                    estampadeseada = Console.ReadLine();
                    marcarestampa(estampadeseada);
                    Console.WriteLine("Estampa marcada");
                    goto menu;
                case 3:
                    Console.Clear();
                    album.mostrarMarcadas();
                    goto menu;
                    
                case 4:
                    Console.Clear();
                    album.mostrarFaltantes();
                    goto menu;
                    
                case 5:
                    Console.Clear();
                    album.mostrarRepetidas();
                    goto menu;
                case 6:
                    Console.WriteLine("Adios!");
                    break;
                case 2:
                    Console.WriteLine("Ingrese las siglas de la selección seguida de su número");
                    estamparepetida = Console.ReadLine();
                    mrepetirestampa(estamparepetida);
                    goto menu;
                   
                    
                default:
                    Console.WriteLine("Error, vuelva a intentar");
                    goto menu;
                    
            }
            //imprimir todas las estampas
           /* for (int i = 0; i < album.totalEstampas; i++)
                {
                    Console.WriteLine(album.estampas[i].codigo);
                }
                marcarestampa("FWC0");
                marcarestampa("QAT19");
                album.mostrarMarcadas();*/
            
        }
    }
}
