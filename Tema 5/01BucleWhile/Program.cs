using System;

namespace _01BucleWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Programa que muestre por pantalla los números entre el 100 y el 150

            int i = 100; //Inicializando la variable de control

            while (i < 150)
            {
                Console.WriteLine(i + "");
                //Sumando 1 a la i
                i += 2; //Lo mismo que escribir => i = i +1;

                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine();



            //Programa que muestre por pantalla los números entre el 101 y el 149

            int e = 101; //Inicializando la variable de control

            while (e < 150)
            {
                Console.WriteLine(e + "");
                e += 2;
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine();


            //Mostrar los valores entre n y m, cambiando de color cada 10 valores






            Console.ReadLine();
        }
    }
}
