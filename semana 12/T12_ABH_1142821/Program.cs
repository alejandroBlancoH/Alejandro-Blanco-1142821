using System;

namespace T12_ABH_1142821
{
    class Program
    {
        static int cantidadDeEquipos = 8;
        static Equipo[] equipos = new Equipo[cantidadDeEquipos];
        static Random random = new Random();
        static void mostrarEquipos()
        {
            int i = 0;
            int j = cantidadDeEquipos - 1;

            while (i < cantidadDeEquipos / 2)
            {
                Console.WriteLine(equipos[i].nombre + " vs " + equipos[j].nombre);
                i++;
                j--;
            }
        }
        static void sortearEquipos()
          
        {
            for (int i=0; i<cantidadDeEquipos; i++)
            {
                int x = random.Next(0, cantidadDeEquipos);
                Equipo aux = equipos[i];
                equipos[i] = equipos[x];
                equipos[x] = aux;
            }
        }
        static int selecciónganador(int i, int j)
        {
            int x = random.Next(0, 100);
            if (x > 50)
            {
                return j;
            }
            return i;
        }
        static void simulación()
        {
            while (cantidadDeEquipos > 1)
            {
                int i = 0;
                int j = cantidadDeEquipos - 1;
                mostrarEquipos();
                Console.WriteLine("------------------------------------");
                while (i < cantidadDeEquipos / 2)
                {
                    Console.WriteLine(equipos[i].nombre + " vs " + equipos[j].nombre);
                    int x = selecciónganador(i, j);

                    Equipo aux = equipos[i];
                    equipos[i] = equipos[x];
                    equipos[x] = aux;
                    Console.WriteLine("Ganó: " + equipos[i].nombre);
                    i++;
                    j--;
                    Console.WriteLine("------------------------------------");
                }
                cantidadDeEquipos = cantidadDeEquipos / 2;
            }
            Console.WriteLine("El ganador del torneo es: " + equipos[0].nombre);
        }
        static void Main(string[] args)
        {
           for (int i=0; i<equipos.Length; i++)
            {
                equipos[i] = new Equipo();
                equipos[i].nombre = "Equipo" + i;
            }
            sortearEquipos();
            simulación();

        }
    }
}
