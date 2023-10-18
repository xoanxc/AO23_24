using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_multiplo_3_y_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Programa que clasifica un número como múltiplo de 3 o de 5

            int numeroX = 9;

            if (numeroX % 3 == 0 && numeroX % 5 == 0)
            {
                Console.WriteLine("Múltiplo de 3 y de 5");
            }
            else if (numeroX % 3 == 0)
            {
                Console.WriteLine("Múltiplo de 3");

            }
            else if (numeroX % 5 == 0)
            {
                Console.WriteLine("Múltiplo de 5 ");
            }
            else
            {
                Console.WriteLine("No es Múltiplo de 3 ni de 5");
            }

            Console.ReadLine();
        }
    }
}

