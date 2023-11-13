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
                        int m;

                        do
                        {
                            Console.Write("Introduce un número no negativo: ");
                            string input = Console.ReadLine();

                            if (!int.TryParse(input, out m))
                            {
                                Console.WriteLine("Error, introduce un número válido.");
                                continue;
                            }

                            if (m < 0)
                            {
                                Console.WriteLine("Error, el número debe ser no negativo. Inténtalo de nuevo.");
                            }
                            else
                            {
                                int suma = CalcularSuma(m);
                                Console.WriteLine("La suma de los primeros" + m + "números es: " + suma);
                            }

                        } while (m < 0);
                }

                int CalcularSuma(int m)
                {
                    int suma = 0;
                    for (int i = 1; i <= m; i++)
                    {
                        suma += i;
                    }
                    return suma;
                    break; //Fin

                    case 11: //Para el Lunes
                        Console.Write("Introduce un número positivo (n): ");
                        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
                        {
                            double suma = CalcularSuma(n);
                            Console.WriteLine($"La suma de la serie es: {suma:F4}");
                        }
                        else
                        {
                            Console.WriteLine("Por favor, introduce un número positivo válido.");
                        }
                    }

                    static double CalcularSuma(int n)
                    {
                        double suma = 0.0;

                        for (int i = 1; i <= n; i++)
                        {
                            suma += 1.0 / Math.Pow(i * 10 + 3, 3);
                        }
                        return suma;
                        break;
                    case 12: //Para el Lunes

                            Console.Write("Introduce un número no negativo: ");
                            if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
                            {
                                int sumaDivisores = CalcularSumaDivisores(n);
                                Console.WriteLine("La suma de los divisores de" + n + "es:" + sumaDivisores);
                            }
                            else
                            {
                                Console.WriteLine("Error, Introduce un número no negativo válido.");
                            }
                        }

                        int CalcularSumaDivisores(int n)
                        {
                            int suma = 0;

                            for (int i = 1; i <= n; i++)
                            {
                                if (n % i == 0)
                                {
                                    suma += i;
                                }
                            }

                            return suma;
                        }

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
