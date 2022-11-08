using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alejandro_Blanco_1142821_TAREAS8
{
    class Program
    {
        static void Main(string[] args)
        {
            //definir variables
            string palabra = "";
            int i1 = 0;
            int i = 0;

            /*
            //repetir proceso 10 veces
                for (i = 1; i <= 10; i++)
                {
                    Console.WriteLine("Escriba una palabra");
                //usuario ingresa palabra
                    if (i !=0)
                    {
                        palabra = Console.ReadLine();
                        Console.WriteLine(palabra + " ESTOY PROBANDO" );
                    }
                }*/
            //definir variables
            string palabra1, palabra2, palabra3, palabra4, palabra5, palabra6, palabra7, palabra8, palabra9, palabra10 = "";
            Console.WriteLine("Escriba 10 palabras");
            //pedir las 10 variables
            /*
            for (i = 0; i <=9; i++)
            {
                switch (i)
                {
                    case 0:
                        palabra1 = Console.ReadLine();
                        break;
                    case 1:
                        palabra2 = Console.ReadLine();
                        break;
                    case 2:
                        palabra3 = Console.ReadLine();
                        break;
                    case 3:
                        palabra4= Console.ReadLine();
                        break;
                    case 4:
                        palabra5 = Console.ReadLine();
                        break;
                    case 5:
                        palabra6 = Console.ReadLine();
                        break;
                    case 6:
                        palabra7 = Console.ReadLine();
                        break;
                    case 7:
                        palabra8 = Console.ReadLine();
                        break;
                    case 8:
                        palabra9 = Console.ReadLine();
                        break;
                    case 9:
                        palabra10= Console.ReadLine();
                        break;

                }
                */
            string[] apalabras = { "HOLA", "casa", "carro", "LAPIZ", "uno", "dos", "siete", "ocho", "nueve", "diez" };
            for (int inc = 0; inc <= 0; inc++)
            {
                Console.WriteLine("Validando mayusculas " + apalabras[inc] + "es ");
                if (apalabras[inc].ToUpper() == apalabras[inc])
                {
                    Console.WriteLine("la palabra " + apalabras[inc] + " es mayuscula");
                }
            }



        }
        static bool esmayuscula(string input)
        {
            for (int i=0; i < input.Length; i++)
            {
                if (!Char.IsUpper(input[i]))
                    return false;
            }
            return true;
        }

    }
}
        
