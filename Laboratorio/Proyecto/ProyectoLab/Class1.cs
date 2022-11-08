using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoLab
{
    class Equipo
    {
        public string _nombreEquipo, _fase;
        public double _PG, _PE, _PP, _poderEquipo;
        
        public Equipo (string nombreEquipo, double PG, double PE, double PP )
        {
            this._nombreEquipo = nombreEquipo;
            this._PG= PG;
            this._PE = PE;
            this._PP = PP;
           

        }


        public double CalcularPoderEquipo() {

            switch (_fase)
            {
                case "Cuartos de Final":
                    _poderEquipo = ((_PG * 0.7) - (_PP * 0.2) + (_PE * 0.1)) / 4;
                    return _poderEquipo;
                   
                case "Semis":
                    _poderEquipo = ((_PG * 0.7) - (_PP * 0.2) + (_PE * 0.1)) / 5;
                    return _poderEquipo;
                    
                case "Final":
                    _poderEquipo = ((_PG * 0.7) - (_PP * 0.2) + (_PE * 0.1)) / 6;
                    return _poderEquipo;
                default:
                    Console.WriteLine("Error");
                    return 0;
                    
                    
            }





        }

    }

}
