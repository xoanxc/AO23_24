using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double presion, volumen8, temperatura, nMoles;
            const double R = 0.082;
            Console.WriteLine("Introduzca el volumen de Litros: ");
            volumen8 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca la temperatura en Kelvin: ");
            temperatura = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca el volumen de Litros: ");
            nMoles = double.Parse(Console.ReadLine());

            presion = (nMoles * R * temperatura) / volumen8;

            Console.WriteLine("Con un volumen de " + 8 + "litros, y una temperatura de " + temperatura + "kelvin, n");





        }
    }
}
