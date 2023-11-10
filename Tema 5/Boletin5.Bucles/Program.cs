using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletin5.Bucles
{
    internal class Program
    {
        static void escribirTitular(String titular)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.ForegroundColor = ConsoleColor.White;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("*******Boletín de Bucles*******");
            char opcion;
            do
            {
                escribirTitular("Escoja un ejercicio entre 5 y 25");
                int ejercicio = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (ejercicio)
                {
                    case 5:
                        escribirTitular("ejercicio 5: ");
                        int i = 320;

                        while (i >= 160)
                        {
                            Console.WriteLine(i);
                            i = i - 20;
                        }
                        Console.WriteLine();
                        break;
                    case 6:
                        escribirTitular("ejercicio 6");

                        for (int j = 0; j <= 100; j++)
                        {
                            if (j % 5 == 0 && j % 7 == 0)
                            {
                                Console.WriteLine(j + ' ');
                            }
                        }
                        break;
                    case 7:
                        
                        break;
                    case 8:
                        break;
                    case 9:

                        break;
                    case 10: //Para el Lunes
                        Console.WriteLine("Introduce un numero no negativo: ");

                        break;
                    case 11: //Para el Lunes

                        break;
                    case 12: //Para el Lunes

                        break;
                    default:
                        Console.WriteLine("Error, ejercicio inexistente.");
                        break;

                }

                Console.WriteLine("Desea volver al menú inicial: s/n");
                opcion = char.ToLower(char.Parse(Console.ReadLine()));
            } while (opcion == 's');
        }
    }
}
