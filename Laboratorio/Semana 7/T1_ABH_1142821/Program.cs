using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_ABH_1142821
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mi segundo programa");
            string SNombre, SEdad, SCarrera, Scarne = "";
            Console.WriteLine("Nombre:");
            SNombre = Console.ReadLine();
            Console.WriteLine("Edad:");
            SEdad = Console.ReadLine();
            Console.WriteLine("Carrera:");
            SCarrera = Console.ReadLine();
            Console.WriteLine("Carné:");
            Scarne = Console.ReadLine();

            Console.WriteLine("Soy "+ SNombre + " ,tengo " + SEdad + " años y estudio la carrera de " + SCarrera + " . Mi número de carné es; "+ Scarne );
            Console.ReadKey();
        }
    }
}
