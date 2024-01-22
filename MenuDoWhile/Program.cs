using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" ");
                char opcion;
                do
                {
                    Console.WriteLine("Selecciona un ejercicio entre");
                    byte ejercicio = byte.Parse(Console.ReadLine());
                    Console.WriteLine();
                    switch (ejercicio)


                {
                }



                Console.WriteLine();
                    Console.WriteLine("¿Desea volver al menú inicial? s/n");
                    opcion = char.ToLower(char.Parse(Console.ReadLine()));

                }
                while (opcion == 's');
            }
        }
    }
