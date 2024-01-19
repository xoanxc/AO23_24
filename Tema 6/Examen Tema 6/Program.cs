using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Tema_6
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
                Console.WriteLine("Selecciona un ejercicio entre 1 y 4");
                byte ejercicio = byte.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (ejercicio)


                {
                    //Ejercicio 1
                    case 1:

                        //Solicito datos por teclado al usuario
                        Console.WriteLine("Introduce el valor de n (maximo 10)");
                        int valorN = int.Parse(Console.ReadLine());

                        //Evitar que el programa tenga un ERROR FATAL a casusa del usuario
                        if (valorN >= 11)
                        {
                            valorN = 10;
                        }

                        //Inicializo las matrices
                        int[] a1 = new int[10];

                        int[] b1 = new int[10];


                        //Doy valores aleatorios a la primera matriz
                        Random Gen1 = new Random();
                        for (int i = 0; i < a1.Length; i++)
                        {
                            a1[i] = Gen1.Next(1, 9);
                        }

                        //Copio a la matriz 2
                        for (int i = 0; i < valorN; i++)
                        {
                            b1[i] = a1[i];
                        }

                        Console.WriteLine();
                        //Muestro la matriz Original
                        Console.WriteLine("Matriz Original");
                        for (int i = 0; i < a1.Length; i++)
                        {
                            Console.WriteLine("Posición " + i + ": " + a1[i]);
                        }

                        Console.WriteLine();
                        //Muestro la matriz copia
                        Console.WriteLine("Matriz copia");
                        for (int i = 0; i < b1.Length; i++)
                        {
                            Console.WriteLine("Posición " + i + ": " + b1[i]);
                        }
                        break;

                    //Ejercicio 2
                    case 2:

                        //Inicializo la matriz
                        int[] a2 = new int[50];

                        //Declaración de variables
                        int comprobación2 = 45; //Buen numero

                        //Doy valores aleatorios a la matriz
                        Random Gen2 = new Random();
                        for (int i = 0; i < a2.Length; i++)
                        {
                            a2[i] = Gen2.Next(1, 100);
                        }

                        //Busqueda del primer multiplo de 7
                        for (int i = 0; i < a2.Length; i++)
                        {
                            if (a2[i] % 7 == 0)
                            {
                                comprobación2++;
                                Console.WriteLine("El primer multiplo de 7 se encuentra en la posición " + i + " es el numero " + a2[i]);
                                break; //Importante para que el bucle termine en la primera conincidencia
                            }
                        }

                        //En caso de no encontrar un multiplo de 7
                        if (comprobación2 == 45)
                        {
                            Console.WriteLine("¡Jopetas! En esta matriz no hay ningun multiplo de 7");
                        }
                        break;

                    //Ejercicio 3
                    case 3:

                        //Inicializo la matriz
                        int[] a3 = new int[50];

                        //Declaración de variables
                        int conteo3 = 0;

                        //Doy valores aleatorios a la matriz
                        Random Gen3 = new Random();
                        for (int i = 0; i < a3.Length; i++)
                        {
                            a3[i] = Gen3.Next(1, 100);
                        }

                        //Solicitud de variables
                        Console.WriteLine("Introduce un valor");
                        int valor3 = int.Parse(Console.ReadLine());

                        //Conteo de cuantos números son superiores al introducido por teclado
                        foreach (int copia in a3)
                        {
                            if (copia > valor3)
                            {
                                conteo3++;
                            }
                        }

                        Console.WriteLine();
                        //En el caso de no haber ninguno
                        if (conteo3 == 0)
                        {
                            Console.WriteLine("Ningun valor del array supera al tuyo, ¡IMPRESIONANTE!");
                        }
                        break;

                    //Ejercicio 4
                    case 4:

                        //Inicializo la matriz
                        int[] a4 = new int[50];

                        //Inicializo las variables
                        double conteo = 0;
                        double suma4 = 0;
                        double media = 0;
                        double desviación = 0;

                        //Doy valores aleatorios a la matriz
                        Random Gen4 = new Random();
                        for (int i = 0; i < a4.Length; i++)
                        {
                            a4[i] = Gen4.Next(1, 100);
                        }

                        //Calcular media de la matriz
                        for (int i = 0; i < a4.Length; i++)
                        {
                            conteo++;
                            suma4 += a4[i];
                        }
                        media = (suma4 / conteo);
                            
                        //Calcular y motrar la desviación
                        for (int i = a4.Length-5; i < a4.Length; i++)
                        {
                            desviación = a4[i] - media;
                            Console.WriteLine("Posición " + i + ": " + desviación);
                        }
                        break;


                        Console.WriteLine("En la matriz hay " + conteo3 + " valores que se encuentran por encima del introducido por teclado");
                        
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
