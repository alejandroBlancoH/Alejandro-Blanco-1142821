using System;

namespace ProyectoLab
{
    class Program
    {
         static void enfrentamiento8tavos(Equipo equipo1, Equipo equipo8)
        {
            Random eleccion = new Random();
            Random cantidadgoles = new Random();
            int ganador = eleccion.Next(1, 2);
            if (ganador == 1)
            {
                int goles1 = cantidadgoles.Next(2, 4);
                int goles2 = cantidadgoles.Next(0, 1);
                Console.WriteLine(equipo1._nombreEquipo+ " " + goles1 + " - " + equipo8._nombreEquipo + " " + goles2);
                Console.WriteLine("El ganador es " + equipo1._nombreEquipo);
            }
            else if (ganador == 2)
            {
                int goles1= cantidadgoles.Next(2, 4);
                int goles2 = cantidadgoles.Next(0, 1);
                Console.WriteLine(equipo8._nombreEquipo + " " + goles1 + " - " + equipo1._nombreEquipo + " " + goles2);
                Console.WriteLine("El ganador es " + equipo8._nombreEquipo);
            }
        }
        static void enfrentamiento4tos()
        {
            
            Random anotargol = new Random();
            int contador = 0;
            do
            {
                
                int golesanotados1 = 0;
               
                int anotargoles = anotargol.Next(0, 1);
                if (anotargoles < 2)
                {
                    Console.WriteLine("se ha anotado un gol" + "Goles anotados primer equipo" + golesanotados1);
                    contador = contador + 1;
                    golesanotados1 = golesanotados1 + 1;
                }
                else
                {
                   Console.WriteLine  ("no se ha anotado gol, puedes intentar de nuevo");
                }
            }
            while (contador <= 6);

        }
        static void Main(string[] args)
        {

            Equipo equipo1 = new Equipo ("x",0,0,0);
            Equipo equipo2 = new Equipo("x", 0, 0, 0);
            Equipo equipo3 = new Equipo("x", 0, 0, 0);
            Equipo equipo4 = new Equipo("x", 0, 0, 0);
            Equipo equipo5 = new Equipo("x", 0, 0, 0);
            Equipo equipo6 = new Equipo("x", 0, 0, 0);
            Equipo equipo7 = new Equipo("x", 0, 0, 0);
            Equipo equipo8 = new Equipo("x", 0, 0, 0);
            
            
            int eleccion1 = 0;

        menuprincipal:
            Console.WriteLine("Ingrese 1 para:Ingresar datos de los equipos");
            Console.WriteLine("Ingrese 2 para:Mostrar la información de los equipos");
            Console.WriteLine("Ingrese 3 para: Para iniciar simulación");
            Console.WriteLine("Ingrese 4 para:salir");
            int eleccionmenu = int.Parse(Console.ReadLine());

            
                Console.Clear();
            menu1:
                switch (eleccionmenu)
                {

                    case 1:
                    
                        do

                        {
                            Console.WriteLine("Ingrese 1 para ingresar los datos del equipo 1");
                            Console.WriteLine("Ingrese 2 para ingresar los datos del equipo 2");
                            Console.WriteLine("Ingrese 3 para ingresar los datos del equipo 3");
                            Console.WriteLine("Ingrese 4 para ingresar los datos del equipo 4");
                            Console.WriteLine("Ingrese 5 para ingresar los datos del equipo 5");
                            Console.WriteLine("Ingrese 6 para ingresar los datos del equipo 6");
                            Console.WriteLine("Ingrese 7 para ingresar los datos del equipo 7");
                            Console.WriteLine("Ingrese 8 para ingresar los datos del equipo 8");
                            Console.WriteLine("Ingrese 9 para regresar al menú principal");
                            eleccion1 = int.Parse(Console.ReadLine());
                            if ((eleccion1 > 0) && (eleccion1 < 10))
                            {
                                switch (eleccion1)
                                {

                                    case 1:
                                        Console.Clear();
                                    datosequipo1:
                                        Console.WriteLine("Ingrese el nombre del equipo");
                                        equipo1._nombreEquipo = Console.ReadLine();
                                        Console.WriteLine("Ingrese los partidos ganados del equipo");
                                        equipo1._PG = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Ingrese los partidos empatados del equipo");
                                        equipo1._PE = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Ingrese los partidos perdidos del equipo");
                                        equipo1._PP = int.Parse(Console.ReadLine());
                                        if ((equipo1._PG + equipo1._PE + equipo1._PP) <= 4)
                                        {
                                            Console.WriteLine("Datos guardados puede continuar");
                                        }
                                        else if ((equipo1._nombreEquipo == equipo2._nombreEquipo) || (equipo1._nombreEquipo == equipo3._nombreEquipo) || (equipo1._nombreEquipo == equipo4._nombreEquipo) || (equipo1._nombreEquipo == equipo5._nombreEquipo) || (equipo1._nombreEquipo == equipo6._nombreEquipo) || (equipo1._nombreEquipo == equipo7._nombreEquipo) || (equipo1._nombreEquipo == equipo8._nombreEquipo))
                                        {
                                            Console.WriteLine("No se puede ingresar el mismo nombre de otro equipo, vuelva a intentar");
                                            goto datosequipo1;

                                        }
                                        else
                                        {
                                            Console.WriteLine("Los partidos ganados, empatados y perdidos deben de sumar 4, vuelva a intentar");
                                            goto datosequipo1;
                                        }
                                        break;
                                    case 2:
                                        Console.Clear();
                                    datosequipo2:
                                        Console.WriteLine("Ingrese el nombre del equipo");
                                        equipo2._nombreEquipo = Console.ReadLine();
                                        Console.WriteLine("Ingrese los partidos ganados del equipo");
                                        equipo2._PG = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Ingrese los partidos empatados del equipo");
                                        equipo2._PE = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Ingrese los partidos perdidos del equipo");
                                        equipo2._PP = int.Parse(Console.ReadLine());
                                        if ((equipo2._PG + equipo2._PE + equipo2._PP) <= 4)
                                        {
                                            Console.WriteLine("Datos guardados puede continuar");
                                        }
                                        else if ((equipo2._nombreEquipo == equipo1._nombreEquipo) || (equipo2._nombreEquipo == equipo3._nombreEquipo) || (equipo2._nombreEquipo == equipo4._nombreEquipo) || (equipo2._nombreEquipo == equipo5._nombreEquipo) || (equipo2._nombreEquipo == equipo6._nombreEquipo) || (equipo2._nombreEquipo == equipo7._nombreEquipo) || (equipo2._nombreEquipo == equipo8._nombreEquipo))
                                        {
                                            Console.WriteLine("No se puede ingresar el mismo nombre de otro equipo, vuelva a intentar");
                                            goto datosequipo1;

                                        }
                                        else
                                        {
                                            Console.WriteLine("Los partidos ganados, empatados y perdidos deben de sumar 4, vuelva a intentar");
                                            goto datosequipo2;
                                        }
                                        break;
                                    case 3:
                                        Console.Clear();
                                    datosequipo3:
                                        Console.WriteLine("Ingrese el nombre del equipo");
                                        equipo3._nombreEquipo = Console.ReadLine();
                                        Console.WriteLine("Ingrese los partidos ganados del equipo");
                                        equipo3._PG = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Ingrese los partidos empatados del equipo");
                                        equipo3._PE = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Ingrese los partidos perdidos del equipo");
                                        equipo3._PP = int.Parse(Console.ReadLine());
                                        if ((equipo3._PG + equipo3._PE + equipo3._PP) <= 4)
                                        {
                                            Console.WriteLine("Datos guardados puede continuar");
                                        }
                                        else if ((equipo3._nombreEquipo == equipo1._nombreEquipo) || (equipo3._nombreEquipo == equipo2._nombreEquipo) || (equipo3._nombreEquipo == equipo4._nombreEquipo) || (equipo3._nombreEquipo == equipo5._nombreEquipo) || (equipo3._nombreEquipo == equipo6._nombreEquipo) || (equipo3._nombreEquipo == equipo7._nombreEquipo) || (equipo3._nombreEquipo == equipo8._nombreEquipo))
                                        {
                                            Console.WriteLine("No se puede ingresar el mismo nombre de otro equipo, vuelva a intentar");
                                            goto datosequipo3;

                                        }
                                        else
                                        {
                                            Console.WriteLine("Los partidos ganados, empatados y perdidos deben de sumar 4, vuelva a intentar");
                                            goto datosequipo3;
                                        }

                                        break;
                                    case 4:
                                        Console.Clear();
                                    datosequipo4:
                                        Console.WriteLine("Ingrese el nombre del equipo");
                                        equipo4._nombreEquipo = Console.ReadLine();
                                        Console.WriteLine("Ingrese los partidos ganados del equipo");
                                        equipo4._PG = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Ingrese los partidos empatados del equipo");
                                        equipo4._PE = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Ingrese los partidos perdidos del equipo");
                                        equipo4._PP = int.Parse(Console.ReadLine());
                                        if ((equipo4._PG + equipo4._PE + equipo4._PP) <= 4)
                                        {
                                            Console.WriteLine("Datos guardados puede continuar");
                                        }
                                        else if ((equipo4._nombreEquipo == equipo1._nombreEquipo) || (equipo4._nombreEquipo == equipo2._nombreEquipo) || (equipo4._nombreEquipo == equipo5._nombreEquipo) || (equipo4._nombreEquipo == equipo6._nombreEquipo) || (equipo4._nombreEquipo == equipo7._nombreEquipo) || (equipo4._nombreEquipo == equipo8._nombreEquipo) || (equipo1._nombreEquipo == equipo3._nombreEquipo))
                                        {
                                            Console.WriteLine("No se puede ingresar el mismo nombre de otro equipo, vuelva a intentar");
                                            goto datosequipo1;

                                        }
                                        else
                                        {
                                            Console.WriteLine("Los partidos ganados, empatados y perdidos deben de sumar 4, vuelva a intentar");
                                            goto datosequipo4;
                                        }
                                        Console.Clear();
                                        break;
                                    case 5:
                                        Console.Clear();
                                    datosequipo5:
                                        Console.WriteLine("Ingrese el nombre del equipo");
                                        equipo5._nombreEquipo = Console.ReadLine();
                                        Console.WriteLine("Ingrese los partidos ganados del equipo");
                                        equipo5._PG = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Ingrese los partidos empatados del equipo");
                                        equipo5._PE = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Ingrese los partidos perdidos del equipo");
                                        equipo5._PP = int.Parse(Console.ReadLine());
                                        if ((equipo5._PG + equipo5._PE + equipo5._PP) <= 4)
                                        {
                                            Console.WriteLine("Datos guardados puede continuar");
                                        }
                                        else if ((equipo5._nombreEquipo == equipo1._nombreEquipo) || (equipo5._nombreEquipo == equipo2._nombreEquipo) || (equipo5._nombreEquipo == equipo3._nombreEquipo) || (equipo5._nombreEquipo == equipo4._nombreEquipo) || (equipo5._nombreEquipo == equipo6._nombreEquipo) || (equipo5._nombreEquipo == equipo7._nombreEquipo) || (equipo5._nombreEquipo == equipo8._nombreEquipo))
                                        {
                                            Console.WriteLine("No se puede ingresar el mismo nombre de otro equipo, vuelva a intentar");
                                            goto datosequipo5;

                                        }
                                        else
                                        {
                                            Console.WriteLine("Los partidos ganados, empatados y perdidos deben de sumar 4, vuelva a intentar");
                                            goto datosequipo5;
                                        }

                                        break;
                                    case 6:
                                        Console.Clear();
                                    datosequipo6:
                                        Console.WriteLine("Ingrese el nombre del equipo");
                                        equipo6._nombreEquipo = Console.ReadLine();
                                        Console.WriteLine("Ingrese los partidos ganados del equipo");
                                        equipo6._PG = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Ingrese los partidos empatados del equipo");
                                        equipo6._PE = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Ingrese los partidos perdidos del equipo");
                                        equipo6._PP = int.Parse(Console.ReadLine());
                                        if ((equipo6._PG + equipo6._PE + equipo6._PP) <= 4)
                                        {
                                            Console.WriteLine("Datos guardados puede continuar");
                                        }
                                        else if ((equipo6._nombreEquipo == equipo1._nombreEquipo) || (equipo6._nombreEquipo == equipo2._nombreEquipo) || (equipo6._nombreEquipo == equipo3._nombreEquipo) || (equipo6._nombreEquipo == equipo4._nombreEquipo) || (equipo6._nombreEquipo == equipo7._nombreEquipo) || (equipo6._nombreEquipo == equipo8._nombreEquipo) || (equipo6._nombreEquipo == equipo5._nombreEquipo))
                                        {
                                            Console.WriteLine("No se puede ingresar el mismo nombre de otro equipo, vuelva a intentar");
                                            goto datosequipo6;

                                        }
                                        else
                                        {
                                            Console.WriteLine("Los partidos ganados, empatados y perdidos deben de sumar 4, vuelva a intentar");
                                            goto datosequipo6;
                                        }

                                        break;
                                    case 7:
                                        Console.Clear();
                                    datosequipo7:
                                        Console.WriteLine("Ingrese el nombre del equipo");
                                        equipo7._nombreEquipo = Console.ReadLine();
                                        Console.WriteLine("Ingrese los partidos ganados del equipo");
                                        equipo7._PG = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Ingrese los partidos empatados del equipo");
                                        equipo7._PE = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Ingrese los partidos perdidos del equipo");
                                        equipo7._PP = int.Parse(Console.ReadLine());
                                        if ((equipo7._PG + equipo7._PE + equipo7._PP) <= 4)
                                        {
                                            Console.WriteLine("Datos guardados puede continuar");
                                        }
                                        else if ((equipo7._nombreEquipo == equipo1._nombreEquipo) || (equipo7._nombreEquipo == equipo2._nombreEquipo) || (equipo7._nombreEquipo == equipo3._nombreEquipo) || (equipo7._nombreEquipo == equipo4._nombreEquipo) || (equipo7._nombreEquipo == equipo5._nombreEquipo) || (equipo7._nombreEquipo == equipo6._nombreEquipo) || (equipo7._nombreEquipo == equipo8._nombreEquipo))
                                        {
                                            Console.WriteLine("No se puede ingresar el mismo nombre de otro equipo, vuelva a intentar");
                                            goto datosequipo7;

                                        }
                                        else
                                        {
                                            Console.WriteLine("Los partidos ganados, empatados y perdidos deben de sumar 4, vuelva a intentar");
                                            goto datosequipo7;
                                        }

                                        break;
                                    case 8:
                                        Console.Clear();
                                    datosequipo8:
                                        Console.WriteLine("Ingrese el nombre del equipo");
                                        equipo8._nombreEquipo = Console.ReadLine();
                                        Console.WriteLine("Ingrese los partidos ganados del equipo");
                                        equipo8._PG = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Ingrese los partidos empatados del equipo");
                                        equipo8._PE = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Ingrese los partidos perdidos del equipo");
                                        equipo8._PP = int.Parse(Console.ReadLine());
                                        if ((equipo8._PG + equipo8._PE + equipo8._PP) <= 4)
                                        {
                                            Console.WriteLine("Datos guardados puede continuar");
                                        }
                                        else if ((equipo8._nombreEquipo == equipo2._nombreEquipo) || (equipo8._nombreEquipo == equipo3._nombreEquipo) || (equipo8._nombreEquipo == equipo4._nombreEquipo) || (equipo8._nombreEquipo == equipo5._nombreEquipo) || (equipo8._nombreEquipo == equipo6._nombreEquipo) || (equipo8._nombreEquipo == equipo7._nombreEquipo) || (equipo8._nombreEquipo == equipo1._nombreEquipo))
                                        {
                                            Console.WriteLine("No se puede ingresar el mismo nombre de otro equipo, vuelva a intentar");
                                            goto datosequipo8;

                                        }
                                        else
                                        {
                                            Console.WriteLine("Los partidos ganados, empatados y perdidos deben de sumar 4, vuelva a intentar");
                                            goto datosequipo8;
                                        }

                                        break;
                                    case 9:
                                        Console.Clear();
                                        Console.WriteLine("Nombre: " + equipo1._nombreEquipo + ", partidos ganados: " + equipo1._PG + ", partidos empatados: " + equipo1._PE + ", partidos perdidos: " + equipo1._PP );
                                        Console.WriteLine("Nombre: " + equipo2._nombreEquipo + ", partidos ganados: " + equipo2._PG + ", partidos empatados: " + equipo2._PE + ", partidos perdidos: " + equipo2._PP);
                                        Console.WriteLine("Nombre: " + equipo3._nombreEquipo + ", partidos ganados: " + equipo3._PG + ", partidos empatados: " + equipo3._PE + ", partidos perdidos: " + equipo3._PP);
                                        Console.WriteLine("Nombre: " + equipo4._nombreEquipo + ", partidos ganados: " + equipo4._PG + ", partidos empatados: " + equipo4._PE + ", partidos perdidos: " + equipo4._PP);
                                        Console.WriteLine("Nombre: " + equipo5._nombreEquipo + ", partidos ganados: " + equipo5._PG + ", partidos empatados: " + equipo5._PE + ", partidos perdidos: " + equipo5._PP);
                                        Console.WriteLine("Nombre: " + equipo6._nombreEquipo + ", partidos ganados: " + equipo6._PG + ", partidos empatados: " + equipo6._PE + ", partidos perdidos: " + equipo6._PP);
                                        Console.WriteLine("Nombre: " + equipo7._nombreEquipo + ", partidos ganados: " + equipo7._PG + ", partidos empatados: " + equipo7._PE + ", partidos perdidos: " + equipo7._PP);
                                        Console.WriteLine("Nombre: " + equipo8._nombreEquipo + ", partidos ganados: " + equipo8._PG + ", partidos empatados: " + equipo8._PE + ", partidos perdidos: " + equipo8._PP);
                                        goto menuprincipal;

                                }
                            }
                            else
                            {
                                goto menu1;
                            }
                        } while (eleccion1 != 9);
                        break;
                    case 2:
                    Console.Clear();
                    Console.WriteLine("Nombre: " + equipo1._nombreEquipo + ", partidos ganados: " + equipo1._PG + ", partidos empatados: " + equipo1._PE + ", partidos perdidos: " + equipo1._PP);
                    Console.WriteLine("Nombre: " + equipo2._nombreEquipo + ", partidos ganados: " + equipo2._PG + ", partidos empatados: " + equipo2._PE + ", partidos perdidos: " + equipo2._PP);
                    Console.WriteLine("Nombre: " + equipo3._nombreEquipo + ", partidos ganados: " + equipo3._PG + ", partidos empatados: " + equipo3._PE + ", partidos perdidos: " + equipo3._PP);
                    Console.WriteLine("Nombre: " + equipo4._nombreEquipo + ", partidos ganados: " + equipo4._PG + ", partidos empatados: " + equipo4._PE + ", partidos perdidos: " + equipo4._PP);
                    Console.WriteLine("Nombre: " + equipo5._nombreEquipo + ", partidos ganados: " + equipo5._PG + ", partidos empatados: " + equipo5._PE + ", partidos perdidos: " + equipo5._PP);
                    Console.WriteLine("Nombre: " + equipo6._nombreEquipo + ", partidos ganados: " + equipo6._PG + ", partidos empatados: " + equipo6._PE + ", partidos perdidos: " + equipo6._PP);
                    Console.WriteLine("Nombre: " + equipo7._nombreEquipo + ", partidos ganados: " + equipo7._PG + ", partidos empatados: " + equipo7._PE + ", partidos perdidos: " + equipo7._PP);
                    Console.WriteLine("Nombre: " + equipo8._nombreEquipo + ", partidos ganados: " + equipo8._PG + ", partidos empatados: " + equipo8._PE + ", partidos perdidos: " + equipo8._PP);
                    goto menuprincipal;
                    
                    case 3:
                   
                    Console.WriteLine("8tavos de final:");
                    Console.WriteLine("Partido 1: ");
                    enfrentamiento8tavos(equipo1 , equipo8);
                    Console.WriteLine("Partido 2: ");
                    enfrentamiento8tavos (equipo2, equipo7);
                    Console.WriteLine("Partido 3: ");
                    enfrentamiento8tavos(equipo3, equipo6);
                    Console.WriteLine("Partido 4: ");
                    enfrentamiento8tavos(equipo4, equipo5);

                    Console.WriteLine("4tos de final");
                    Console.WriteLine("Partido 1: ");

                    break;

                    default:

                        break;
                }
            
        }
    }
}
