using System;

namespace Semana10_ABH
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo circulo = new Circulo();
            Console.WriteLine("Ingrese un radio");
            circulo.radio = double.Parse(Console.ReadLine());

            Console.WriteLine("Perimetro: " + circulo.ObtenerPerimetro ());
            Console.WriteLine("Área: " + circulo.ObtenerArea ());
            Console.WriteLine("Volumen: " + circulo.ObtenerVolumen ());
        }
    }
}
