using System;
using System.Collections.Generic;
using System.Text;

namespace Semana10_ABH
{
    class Circulo
    {
        public double radio;

        public double ObtenerPerimetro()
        {
            return 2 * Math.PI * radio;
        }
        public double ObtenerArea()
        {
            return Math.PI * (radio * radio);
        }
        public double ObtenerVolumen()
        {
            return 4 * Math.PI * radio * radio * radio / 3;
        }

    }
}
