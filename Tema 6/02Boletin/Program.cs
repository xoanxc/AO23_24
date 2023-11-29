using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Boletin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1:
            int[] a1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, };

            int[] a2 = new int[100]; //1, 2, 3, 4, 5, 6, 7, 8, 9... 100

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(a1[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("a2.");

            Funciones.printArray(a2);

            //Ejercicio 2:
            Console.WriteLine("******Ejercicio 2******");
            Console.WriteLine();

            float[] a3 = new float[20];

            for (int i = 0; i < a3.Length; i++)
            {
                Console.WriteLine(a3[i] + " ");
            }
            

            //Ejercicio 3:
            Console.WriteLine("**********Ejercicio 3**********");
            Console.WriteLine();

            int[] a4 = new int[10];

            a4[0] = -1;
            a4[2] = -1;
            a4[5] = -1;
            a4[9] = -1;

            Console.WriteLine(a4);

            //Ejercicio 4

            double[] a6 = new double[5];

            a6[a6.Length - 1] = -1;

            for (int i = 0; i < a6.Length; i++)
            {
                Console.WriteLine(a6[i] + " ");
            }

            //Evitar que se cierre la consola
            Console.ReadLine();
        }
    }
}
