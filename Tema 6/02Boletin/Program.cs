using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Boletin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("02Boletin By Xoán Alonso Fernández");
            Console.WriteLine();
            Console.WriteLine("Introduce un ejercicio entre 1 a 10");
            int ejercicio = int.Parse(Console.ReadLine());

            switch (ejercicio)
            {
                case 1:
                    //Ejercicio 1:
                    Console.WriteLine("********* EJERCICIO 1 *********");
                    int[] a1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                    int[] a2 = new int[100]; // 1,2,3,4,5,6,7,8,9,10,... 100

                    for (int i = 0; i < 100; i++)
                    {
                        a2[i] = i + 1;
                    }
                    //Visualizar los dos arrays
                    for (int i = 0; i < a1.Length; i++)
                    {
                        Console.Write(a1[i] + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("a2: ");
                    Console.WriteLine();
                    Funciones.printArray(a2);
                    Console.WriteLine();
                    break;
                case 2:
                    //Ejercicio 2: 
                    Funciones.printEnunciado(2);
                    float[] a3 = new float[20];

                    Funciones.printArray(a3);

                    break;
                case 3:
                    //Ejercicio 3: 
                    Funciones.printEnunciado(3);
                    int[] a4 = new int[10];

                    a4[0] = -1;
                    a4[2] = -1;
                    a4[5] = -1;
                    a4[9] = -1;

                    Funciones.printArray(a4);
                    break;
                case 4:
                    //Ejercicio 4:
                    Funciones.printEnunciado(4);

                    String[] libros = new string[50];

                    libros[0] = "Los Pilares de la Tierra";
                    libros[1] = "El archivo de las tormentas";
                    libros[2] = "Los bolechas";
                    libros[3] = "Los secretos de Youtube";
                    libros[4] = "El clan del oso cavernario";

                    /* for(int i = 0; i < libros.Length; i++)
                     {
                         Console.WriteLine(libros[i] + " ");
                     }
                     Console.WriteLine();*/

                    Funciones.printArray(libros);

                    Funciones.printEnunciado(5);

                    short[] a5 = new short[4];

                    for (int i = 0; i < a5.Length; i++)
                    {
                        Console.WriteLine("Intro valor posicion. " + i);
                        a5[i] = short.Parse(Console.ReadLine());
                    }

                    Funciones.printArray(a5);

                    Funciones.printEnunciado(6);

                    double[] a6 = new double[8];

                    //Actualizar la última posición a -1
                    a6[a6.Length - 1] = -1;

                    for (int i = 0; i < a6.Length; i++)
                    {
                        Console.Write(a6[i] + " ");
                    }
                    Console.WriteLine();
                    break;
                case 7:
                    //Ejercicio 7:
                    Funciones.printEnunciado(7);

                    Console.WriteLine("Introduce un valor: ");
                    int i1 = int.Parse(Console.ReadLine());
                    int[] n = new int[i1];

                    n[n.Length -1] = 20;

                    n[0] = 10;

                    Funciones.printArray(n);
                    break;
                case 8:
                    //Ejercicio 8:
                    Funciones.printEnunciado(8);

                    int[] a8 = new int[100];

                    Random generador = new Random();
                    int num = generador.Next(0, 999);

                    //Dar valores al Array
                    for (int i = 0; i < a8.Length; i++)
                    {
                        a8[i] = generador.Next(1, 11);
                        Console.Write(a8[i] + " ");
                    }


                    //Mostrar el Array
                    for (int i = 0; i < a8.Length; i++)
                    {
                        Console.Write(a8[i] + " ");
                    }
                    Console.WriteLine();
                    break;

                case 9: //Ejercicio 9:

                    Funciones.printEnunciado(9);

                    int[] a9 = new int[100];

                    for (int i = 0; i < 100; i += 2)
                    {
                        a9[i] = i / 2 + 1;
                        Console.Write(a9[i] + " ");
                    }


                    break;
                case 10: //Ejercicio 10:

                    Funciones.printEnunciado(10);

                    int[] a10 = new int[100];


                    //Dar valores al Array

                    Random generador10 = new Random();
                    int num10 = generador10.Next(10, 35);

                    for (int i = a10[99]; i < 99; i++)
                    {



                        a10[i] = num10;
                    }
                    //Mostrar el Array
                    for (int i = 0; i < a10.Length; i++)
                    {
                        Console.Write(a10 + " ");
                    }
                    Console.WriteLine();

                    break;
                default:
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error CRITICO, vuelva a intentarlo");
                    break;

                    //Dudas
                    //Mostrar el array




            }
            //Cierre de Consola
            Console.ReadLine();
        }
    }

}