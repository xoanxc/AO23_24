using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletinMatrizes2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            char opcion;
            do
            {
                Console.WriteLine("Selecciona un ejercicio");
                Console.WriteLine();
                Console.WriteLine("44.Declarar una matriz 3 X 3 y darle valores en la declaración.");
                Console.WriteLine("46.A partir de una matriz 3x3 obtener otra matriz que...");
                Console.WriteLine("55.El programa debe llenar una matriz 5x5 con números generados aleatoriamente...");
                Console.WriteLine("56.Programar el hundir la flota.");
                byte ejercicio = byte.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (ejercicio)


                {
                    //Ejercicio 44
                    case 44:
                        //Declaración de la matriz
                        int[,] a44 = { { 4, 2, 7 }, { 1, 5, 8 }, { 4, 3, 1 } };

                        //Solicitud de datos
                        Console.WriteLine("Selecciona una fila 0-2");
                        int seleccion = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        if (seleccion >= 3)
                        {
                            seleccion = 2;
                            Console.WriteLine("Fila a mostrar: 2");
                        }

                        //a)Solicitar al usuario que escoja una fila y mostrarle los valores de esa fila.
                        for (int j = 0; j < a44.GetLength(1); j++)
                            {
                                Console.Write(a44[seleccion, j] + " ");
                            }
                        
                        Console.WriteLine();

                        //b)Guardar un cero en las últimas posiciones de cada fila.
                        for (int i = 0; i < a44.GetLength(0); i++)
                        {
                            a44[i, a44.GetLength(1) - 1] = 0;
                        }

                        int suma = 0;
                        //c) Sumar todos los valores de la primera fila.
                        for (int i = 0; i < a44.GetLength(0); i++)
                        {
                            suma += a44[0, i];
                        }

                        //d)Contar cuántos ceros hay en la segunda columna.

                        //e)Calcular la media de una matriz 3x3
                        break;

                    //Ejercicio 46
                    case 46:

                        break;

                    //Ejercicio 55
                    case 55:

                        break;






                }
                Console.WriteLine();
                Console.WriteLine("¿Desea volver al menú inicial? s/n");
                opcion = char.ToLower(char.Parse(Console.ReadLine()));

            }
            while (opcion == 's');
        }
    }
}
