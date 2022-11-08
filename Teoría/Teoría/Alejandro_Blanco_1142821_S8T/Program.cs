using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alejandro_Blanco_1142821_S8T
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int edad = 0;
            int precio = 0;
            string clasificación = "";

            //lectura de datos
            Console.WriteLine("¿Cuál es su edad? (responder en números arábicos)");
            edad = Convert.ToInt32(Console.ReadLine());

            //determinar precio de entrada 
            if (edad<=10)
            {
                precio = 0;
                clasificación = " pg13";
                Console.WriteLine("Precio a pagar es de Q" + precio + clasificación  );

            }
            else if ((10<edad) && (edad<15))
            {
                precio = 15;
                clasificación = " pg13 y pg15 con un adulto";
                Console.WriteLine("Precio a pagar es de Q" + precio + clasificación );
            }

            else if ((15<edad)&&(edad<21))
            {
                precio = 25;
                clasificación = " pg15";
                Console.WriteLine("Precio a pagar es de Q" + precio + clasificación );
            }
            else if ((21 < edad) && (edad < 60))
            {
                precio = 35;
                clasificación = " puede ver todas";
                Console.WriteLine("Precio a pagar es de Q" + precio + clasificación );
            }
            else if (60<=edad )
            {
                precio = 0;
                clasificación = " puede ver todas";
                Console.WriteLine("Precio a pagar es de Q" + precio + clasificación );
            }

            
            Console.ReadKey();

        }
    }
}
