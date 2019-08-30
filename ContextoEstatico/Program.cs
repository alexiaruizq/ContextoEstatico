using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContextoEstatico
{
    class Program
    {
        static void Main(string[] args)
        {

            Matematicas matematicas = new Matematicas();
            double sumando1 = 10;
            double sumando2 = 43;
            double resultado = matematicas.sumar(sumando1, sumando2);

            Console.WriteLine(sumando1.ToString() + " + " + sumando2.ToString() + " = " + resultado.ToString());

            Console.WriteLine("Pi: " + Matematicas.PI);
            double radio = 3.67;
            Console.WriteLine("Radio: 5, Area = " + Matematicas.areaCirculo(5));

            Console.ReadLine();
         }
    }
}
