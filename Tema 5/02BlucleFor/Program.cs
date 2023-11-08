using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02BlucleFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bucle For
            //Mostrar números entre 1 y 20 por pantalla
            for (int i = 1; i <= 20; i = i + 1)
            {
                Console.WriteLine(i + " ");
            }


            //Calcular la suma de todos los números entre n y m
            int n = 15;
            int m = 30;
            int suma = 0; //n + n +1 + n+2 + n+3+ n+4 . . . .

            //Espacio
            Console.WriteLine();

            //Intento 1
            for (int i = n; i <= m; i++)
            {
                suma = suma + i;
            }
            Console.WriteLine("La suma es: " + suma);










            //Calcular la suma de los números impares entre n y m
            for (n + 1)
            {

            }

            Console.ReadLine();
        }
    }
}
