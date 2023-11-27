using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _01ExplicacionArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa que trabaje con 10 valores de tipo int
            int[] notas = new int[10];

            //Modificar posicione 0, 3, 7
            notas[0] = 9;
            notas[3] = 7;
            notas[7] = 5;

            //Visualizar todas las posiciones por pantalla
            //Console.WriteLine(notas[0] + " "  + notas[1] + " " + notas[2]);

            for (int i = 0; i < 10; i++)
            {
                Console.Write(notas[i] + " ");
            }


            //Ej1. Hacer un programa que solicite al usuario 5 notas y las almacene en las primeras posiciones del arra
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Introduce nota " + i);
                notas[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(notas[i] + " ");
            }




            //Ej2. Calcular la media de Ej1
            double media = 0;

            for (int n = 0; n < 5; n++)
            {
                media = media + notas[n];
            }
            media = media / 5;

            Console.WriteLine();

            Console.WriteLine("La media es: " + media);

            //Inicializar un array con valores
            float[] temperaturas = { 1, 6f, 17.5f; 20, 6f, 12.5f };


        Console.ReadLine();

        }
    }
}
