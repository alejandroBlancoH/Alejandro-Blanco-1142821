using System;

namespace Corto3TS
{
    class Program
    {
        public static void mostrarmenu()
        {
            Console.WriteLine("Combo 1");
            Console.WriteLine("Hamburguesas, papas fritas y coca Cola");
            Console.WriteLine("Combo 2");
            Console.WriteLine("Pizza de 8 pedazos y Coca cola");
            Console.WriteLine("Combo 3:");
            Console.WriteLine("Tacos y Coca cola");
            Console.WriteLine("Combo 4:");
            Console.WriteLine("Ensalada y agua pura");
        }
        public static int calcularprecio(string eleccioncombo)
        {
            int precioCombo = 0;
            switch (eleccioncombo)
            {
                case "Combo 1":
                    precioCombo = 50;
                    return precioCombo;
                case "Combo 2":
                    precioCombo = 40;
                    return precioCombo;
                case "Combo 3":
                    precioCombo = 30;
                    return precioCombo;
                case "Combo 4":
                    precioCombo = 20;
                    return precioCombo;
            }
            return precioCombo;
        }
        public static void seleccionarmenu(string eleccioncombo)
        {
            
            inicio:
            Console.WriteLine("Ingrese el número de la opción que desea");
            Console.WriteLine("1.Combo 1");
            Console.WriteLine("2.Combo 2");
            Console.WriteLine("3.Combo 3");
            Console.WriteLine("4. Combo 4");
            

            int eleccion1 = int.Parse(Console.ReadLine());
            switch (eleccion1)
            {
                case 1:
                    eleccioncombo = "Combo 1";
                    Console.WriteLine("Elección guardada");
                    break;
                case 2:
                    eleccioncombo = "Combo 2";
                    Console.WriteLine("Elección guardada");
                    break;
                case 3:
                    eleccioncombo = "Combo 3";
                    Console.WriteLine("Elección guardada");
                    break;
                case 4:
                    eleccioncombo = "Combo 4";
                    Console.WriteLine("Elección guardada");
                    break;
               
                default:
                    Console.WriteLine("Elección no es válida, vuelva a intentar");
                    goto inicio;

            }
            
        }
        static void Main(string[] args)
        {
        inicio:
            string eleccioncombo = "Combo 1";
            Console.WriteLine("Ingrese el número de la opción que desea");
            Console.WriteLine("1. Ver menú");
            Console.WriteLine("2.Seleccionar menú deseado");
            Console.WriteLine("3. Mostrar total a pagar por el menú");
            Console.WriteLine("4. Si desea finalizar");
            int menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    Console.Clear();
                    mostrarmenu();
                    goto inicio;
                    
                case 2:
                    Console.Clear();
                    Console.WriteLine("Ingrese el número de la opción que desea");
                    Console.WriteLine("1.Combo 1");
                    Console.WriteLine("2.Combo 2");
                    Console.WriteLine("3.Combo 3");
                    Console.WriteLine("4. Combo 4");


                    int eleccion1 = int.Parse(Console.ReadLine());
                    switch (eleccion1)
                    {
                        case 1:
                            eleccioncombo = "Combo 1";
                            Console.WriteLine("Elección guardada");
                            break;
                        case 2:
                            eleccioncombo = "Combo 2";
                            Console.WriteLine("Elección guardada");
                            break;
                        case 3:
                            eleccioncombo = "Combo 3";
                            Console.WriteLine("Elección guardada");
                            break;
                        case 4:
                            eleccioncombo = "Combo 4";
                            Console.WriteLine("Elección guardada");
                            break;

                        default:
                            Console.WriteLine("Elección no es válida, vuelva a intentar");
                            goto inicio;

                    }

                    goto inicio;
                case 3:
                    Console.Clear();
                    calcularprecio(eleccioncombo);
                    Console.WriteLine(calcularprecio(eleccioncombo));
                    goto inicio;
                case 4:
                    Console.WriteLine("Gracias por su compra!");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opción no es válida, vuelva a intentar");
                    goto inicio;
            }
                
        }
    }
}
