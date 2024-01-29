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

                        //a) Solicitar al usuario que escoja una fila y mostrarle los valores de esa fila.
                        Console.WriteLine("a)Solicitar al usuario que escoja una fila y mostrarle los valores de esa fila.");

                        //Solicitud de datos
                        Console.WriteLine("Selecciona una fila 0-2");
                        int seleccion = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        if (seleccion >= 3)
                        {
                            seleccion = 2;
                            Console.WriteLine("Fila a mostrar: 2");
                        }

                        //Mostrar la fila seleccionada
                        for (int j = 0; j < a44.GetLength(1); j++)
                        {
                            Console.Write(a44[seleccion, j] + " ");
                        }
                        Console.WriteLine();

                        //b) Guardar un cero en las últimas posiciones de cada fila.
                        Console.WriteLine();
                        Console.WriteLine("b)Guardar un cero en las últimas posiciones de cada fila.");

                        //Colocar cero
                        for (int i = 0; i < a44.GetLength(0); i++)
                        {
                            a44[i, a44.GetLength(1) - 1] = 0;
                        }

                        //Mostrar resultado
                        for (int i = 0; i < a44.GetLength(0); i++)
                        {
                            for (int j = 0; j < a44.GetLength(1); j++)
                            {
                                Console.Write(a44[i, j] + " ");
                            }
                            Console.WriteLine();
                        }

                        //c) Sumar todos los valores de la primera fila.
                        Console.WriteLine();
                        Console.WriteLine("c) Sumar todos los valores de la primera fila.");

                        //Sumar valores
                        int suma44 = 0;
                        for (int i = 0; i < a44.GetLength(1); i++)
                        {
                            suma44 += a44[0, i];
                        }

                        Console.WriteLine("El resultado es: " + suma44);

                        //d) Contar cuántos ceros hay en la segunda columna.
                        Console.WriteLine();
                        Console.WriteLine("d)Contar cuántos ceros hay en la segunda columna.");
                        int contador0 = 0; //Menuda ironia

                        //i es la fila
                        for (int i = 0; i < 3; i++)
                        {
                            if (a44[i, 1] == 0)
                            {
                                contador0++;
                            }
                        }
                        Console.WriteLine("Hay " + contador0 + " ceros");

                        //e)Calcular la media de una matriz 3x3
                        Console.WriteLine();
                        Console.WriteLine("e)Calcular la media de una matriz 3x3");
                        suma44 = 0;
                        int media44 = 0;

                        //Recorrer y sumar el array
                        for (int i = 0; i < a44.GetLength(0); i++)
                        {
                            for (int j = 0; j < a44.GetLength(1); j++)
                            {
                                suma44 += a44[i, j];
                            }
                        }

                        //Calcular la media
                        media44 = suma44 / a44.Length;

                        //Mostrar resultado
                        Console.WriteLine("La media del array2D es " + media44);
                        break;

                    //Ejercicio 46
                    case 46:

                        //Declaración de Matriz
                        Console.WriteLine("Matriz Original");
                        int[,] a46 = { { 6, 0, 7 }, { 3, 1, 9 }, { 0, 4, 6 } };

                        //Mostrar array2D
                        for (int i = 0; i < a46.GetLength(0); i++)
                        {
                            for (int j = 0; j < a46.GetLength(1); j++)
                            {
                                Console.Write(a46[i, j] + " ");        
                            }
                            Console.WriteLine();
                        }

                        //Matriz Traspuesta:
                        Console.WriteLine();
                        Console.WriteLine("Matriz Traspuesta");
                        int[,] traspuesta = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };

                        //Trasponer el array
                        for (int i = 0; i < a46.GetLength(0); i++)
                        {
                            for (int j = 0; j < a46.GetLength(1); j++)
                            {
                                traspuesta[j, i] = a46[i, j];
                            }
                        }

                        //Mostrar array2D traspuesto                     
                        for (int i = 0; i < traspuesta.GetLength(0); i++)
                        {
                            for (int j = 0; j < traspuesta.GetLength(1); j++)
                            {
                                Console.Write(traspuesta[i, j] + " ");
                            }
                            Console.WriteLine();
                        }







                        //a)Calcular el porcentaje de ceros
                        Console.WriteLine();
                        Console.WriteLine("a)Calcular el porcentaje de ceros");
                        double contador46 = 0;

                        for (int i = 0; i < a46.GetLength(0); i++)
                        {
                            for (int j = 0; j < a46.GetLength(1); j++)
                            {
                                if (a46[i, j] == 0)
                                {
                                    contador46++;
                                }
                            }
                        }
                        if (contador46 != 0)
                        {
                            double porcentaje0 = (contador46 / (a46.GetLength(0) * a46.GetLength(1))) * 100;
                            Console.WriteLine("El porcentaje de ceros es: " + porcentaje0 + "%");
                        }
                        if (contador46 == 0)
                        {
                            Console.WriteLine("Ningun 0 encontrado para el calculo");
                        }

                        //b)Comprobar que es simétrica. 
                        Console.WriteLine();
                        Console.WriteLine("b)Comprobar que es simétrica");

                        //Comprobación
                        bool simetrica = false;
                        for (int i = 0; i < a46.GetLength(0); i++)
                        {
                            for (int j = 0; j < a46.GetLength(1); j++)
                            {
                                if ((a46[i, j]) == (a46[j, i]))
                                {
                                    simetrica = true;
                                }
                            }
                        }

                        //Respuesta
                        if (!simetrica)
                        {
                            Console.WriteLine("El array NO es simetrico");
                        }
                        else
                        {
                            Console.WriteLine("El array SI es simetrico");
                        }       

                        //c)Calcular la suma de la primera fila. 
                        Console.WriteLine();
                        Console.WriteLine("c)Calcular la suma de la primera fila");

                        //Calcular la suma
                        int suma46 = 0;
                        for (int i = 0; i < a46.GetLength(1); i++)
                        {
                            suma46 += a46[0, i];
                        }
                        Console.WriteLine("La suma de la primera fila es: " + suma46);

                        //d)Calcular la suma de la última columna.
                        Console.WriteLine();
                        Console.WriteLine("d)Calcular la suma de la última columna");

                        //Calcular la suma
                        suma46 = 0;
                        for (int i = 0; i < a46.GetLength(0); i++)
                        {
                            suma46 += a46[i, a46.GetLength(1) -1];
                        }
                        Console.WriteLine("La suma de la ultima columna es: " + suma46);

                        break;

                    //Ejercicio 55
                    case 55:

                        //Declaracion de variables y matrices
                        int[,] a55 = new int[5, 5];
                        Random gen55 = new Random();
                        int vidas = 6;

                        Console.WriteLine("¡Bienvenido al juego!");
                        Console.WriteLine("Encuentra las posiciones de los ceros en la matriz 5x5.");


                        //Inicializar matriz 5x5 con números aleatorios
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                a55[i, j] = gen55.Next(1, 9);
                            }
                        }

                        //Colocar los 3 ceros
                        for (int i = 0; i < 3; i++)
                        {
                            int fila = gen55.Next(0, 5);
                            int columna = gen55.Next(0, 5);
                            a55[fila, columna] = 0;
                        }

                        //Bucle While
                        while (vidas > 0)
                        {
                            // Mostrar la matriz actual
                            Console.WriteLine("Matriz actual:");
                            for (int i = 0; i < 5; i++)
                            {
                                for (int j = 0; j < 5; j++)
                                {
                                    Console.Write(a55[i, j]);
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine();

                            //Solicitar al usuario las coordenadas
                            Console.Write("Introduce la fila (1-5): ");
                            int fila = int.Parse(Console.ReadLine()) - 1; // Restar 1 para convertir de 1-5 a 0-4

                            Console.Write("Introduce la columna (1-5): ");
                            int columna = int.Parse(Console.ReadLine()) - 1; // Restar 1 para convertir de 1-5 a 0-4

                            //Verificar si la coordenada introducida es un cero
                            if (a55[fila, columna] == 0)
                            {
                                Console.WriteLine("¡Correcto! Has encontrado un cero.");

                                //Reiniciar la matriz
                                for (int i = 0; i < 5; i++)
                                {
                                    for (int j = 0; j < 5; j++)
                                    {
                                        a55[i, j] = gen55.Next(1, 10);
                                    }
                                }

                                for (int i = 0; i < 3; i++)
                                {
                                    int newFila = gen55.Next(0, 5);
                                    int newColumna = gen55.Next(0, 5);
                                    a55[newFila, newColumna] = 0;
                                }
                            }
                            else
                            {
                                Console.WriteLine("¡Incorrecto! Pierdes una vida.");
                                vidas--;
                            }

                            Console.WriteLine("Vidas restantes: " + vidas);
                        }

                        // Fin del juego
                        Console.WriteLine("¡Game over! Te quedaste sin vidas.");

                        break;

                    //Ejercicio 56
                    case 56:

                        //Logotipo bien chulo
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("     **");
                        Console.WriteLine("     ****");
                        Console.WriteLine("     ******              **>            *>");
                        Console.WriteLine("     *******    **       ****           ***");
                        Console.WriteLine("***********************************************");
                        Console.WriteLine("********[Hundir la Flota: By xoan.xc]********");
                        Console.WriteLine("  *****************************************");
                        Console.WriteLine("   **************************************");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();

                        //No me va a dar tiempo :(

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
