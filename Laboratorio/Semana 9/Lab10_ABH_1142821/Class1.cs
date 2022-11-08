using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10_ABH_1142821
{
    class Circulo
    {
        private double radio;

        public Circulo(double radio)
        {
            
        }
        
        private double ObtenerPerimetro()
        {
            double p = (2 * radio) * (3.1416);
            return p;
        }

        private double ObtenerArea()
        {
            double area = (3.1416)* radio;
            return area;
        }
        private double ObtenerVolumen()
        {
            double volumen = (1.33)*(3.1416)*(radio)*(radio)*(radio);
            return volumen;
        }
        public void calcular
        {

        }
    }
}
