using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_13._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bucles While
            int numero = 0;

            do
            {
                Console.WriteLine("Intro NUM entre 1 y 5");
                numero = int.Parse(Console.ReadLine());
            }
            while (numero < 1 || numero > 5);

            //Generar con un while
            //50, 60 ,70

            int i = 50;

            while (i <= 75)
            {
                Console.Write(i + " ");
                i += 5;
            }
            Console.WriteLine();
            //Mostrar el primero numero múltiplo de 2 y 5 en un intervalo

            int n = 15;
            int m = 25;

            bool encontrado = false;

            for (int j = n; j <= m; j++)
            {
                if (j % 2 == 0 && j % 7 == 0)
                {
                    encontrado = true;

                    Console.WriteLine("El primero numero múltiplo de n y m es " + j);
                    break;
                }

            }
            if (!encontrado)
            {
                Console.WriteLine("No hay múltiplos de 2 y 7");
            }
            Console.ReadLine();

            switch (numero)
            {
                case 1:
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine();
                    break;
                case 3:

                    break;
                default:

                    break;
            }
        }
    }
}
