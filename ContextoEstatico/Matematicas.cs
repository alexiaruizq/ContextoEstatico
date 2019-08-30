using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContextoEstatico
{
    class Matematicas
    {
        public const double PI = 3.1416; 
        public double sumar(double sumando1, double sumando2)
        {
            return sumando1 + sumando2;
        }

        public static double areaCirculo(double radio)
        {
            return (radio * radio) * PI;
        }
            
    }
}
