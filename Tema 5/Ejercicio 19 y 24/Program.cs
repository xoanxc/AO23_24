using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19_y_24
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Nuevo Ejercicio
            Console.WriteLine("Mostrar todos los primos que hay en un intervalo");
            int limiteInferior, limiteSuperior;

            Console.WriteLine("Introduzca limite inferior:");
            limiteInferior = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca limite superior:");
            limiteSuperior = int.Parse(Console.ReadLine());

            bool primo24 = true;
            int j = 1;
            int i = 0;
            for (i = limiteInferior; i <= limiteSuperior; i++)
            {
                for(j = 2; j <= i / 2; j++)
                {
                    
                }
            }
        }
    }
}
