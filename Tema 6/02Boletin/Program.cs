using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
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
            Console.WriteLine("Introduce un ejercicio entre 1 a 12");
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
                    int a7 = int.Parse(Console.ReadLine());
                    int[] n = new int[a7];

                    n[n.Length - 1] = 20;

                    n[0] = 10;

                    Funciones.printArray(n);
                    break;
                case 8:
                    //Ejercicio 8:
                    Funciones.printEnunciado(8);

                    int[] a8 = new int[100];

                    //Asignar variable Random
                    Random generador = new Random();

                    //Dar valores al Array y mostrarlo
                    for (int i = 0; i < a8.Length; i++)
                    {
                        a8[i] = generador.Next(0, 10);
                        Console.Write(a8[i] + " ");
                    }
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

                    //Asignar variable Random
                    Random generador10 = new Random();

                    //Dar valores al Array y mostrarlos
                    for (int i = 1; i < 100; i += 2)
                    {
                        a10[i] = generador10.Next(10, 35);
                        Console.Write(a10[i] + " ");
                    }
                    break;

                case 11: //Ejercicio 11
                    Funciones.printEnunciado(11);

                    //Crear array con 50 valores
                    int[] a11 = new int[50];

                    //Asignar variable Random
                    Random generador11 = new Random();

                    //Dar valores al Array y mostrarlos
                    for (int i = 0; i < a11.Length; i++)
                    {
                        a11[i] = generador11.Next(-10, 50);

                        //Mostrar los numeros
                        if (a11[i] < 0)
                        {
                            //Mostrar de distintas formas el array
                            //Console.WriteLine(a11[i] + " y la posición es " + i);
                            Console.WriteLine("En la posición " + i + " el numero es " + a11[i]);
                        }
                    }
                    break;

                case 12: //Ejercicio 12

                    Funciones.printEnunciado(12);

                    int[] a12 = new int[50];

                    Random generador12 = new Random();

                    for (int i = 0; i < a12.Length; i++)
                    {
                        a12[i] = generador12.Next(1, 99);
                    }
                    for (int i = 0; i < a12.Length; i++)
                    {
                        a12[0] = a12[0] + a12[i];
                    }
                    Console.WriteLine("La suma es: " + a12[0]);
                    break;

                case 14: //Ejercicio 14

                    Funciones.printEnunciado(14);

                    int[] a14 = new int[50];

                    //double cuadrado14 = 0;

                    double suma14 = 0;

                    Random generador14 = new Random();

                    for (int i = 0; i < a14.Length; i++)
                    {
                        a14[i] = generador14.Next(1, 99);

                        //cuadrado14 = Math.Sqrt(a14[i]);

                        suma14 += Math.Pow(a14[i], 2);
                    }
                    Console.WriteLine("La suma es: " + suma14);


                    break;

                case 15://Ejercicio 15

                    Funciones.printEnunciado(15);

                    int[] a15 = new int[50];

                    int suma15 = 0;

                    Random generador15 = new Random();

                    for (int i = 0; i < a15.Length; i++)
                    {
                        a15[i] = generador15.Next(-50, 50);

                        if (a15[i] >= 0)
                        {
                            suma15 += a15[i];
                        }
                    }
                    Console.WriteLine("La sumade los no negativos es: " + suma15);

                    break;

                case 16: //Ejercicio 16
                    Funciones.printEnunciado(16);

                    int contador = 0;
                    int[] a16 = new int[50];

                    Random generador16 = new Random();

                    for (int i = 0; i < a16.Length; i++)
                    {
                        //Generar los negativos
                        a16[i] = generador16.Next(-25, 25);

                        //Contar los negativos
                        if (a16[i] < 0)
                        {
                            contador++;
                        }
                    }
                    Console.WriteLine("Son " + contador + " números negativos");
                    break;

                case 17: //Ejercicio 17

                    Funciones.printEnunciado(17);

                    int[] a17 = new int[50];

                    double impares17 = 0;

                    double porcentaje17 = 0;

                    Random generador17 = new Random();

                    for (int i = 0; i < a17.Length; i++)
                    {
                        a17[i] = generador17.Next(0, 100);

                        if (a17[i] % 2 != 0)
                        {
                            impares17++;
                        }
                    }
                    porcentaje17 = (impares17 / 50) * 100;
                    Console.WriteLine("El porcentaje de numeros impares es " + porcentaje17 + "%");
                    break;

                case 18: //Ejercicio 18
                    Funciones.printEnunciado(18);

                    string[] a18 = new string[10];
                    a18[0] = "RC Celta de Vigo";

                    int contador18 = 0;

                    for (int i = 0; i < a18.Length; i++)
                    {
                        if (a18[i] == null) //null es 0 en String
                        {
                            contador18++;
                        }
                    }
                    Console.WriteLine("Posiciones vacías: " + contador18);
                    break;

                case 26: //Ejercicio 26

                    Funciones.printEnunciado(26);

                    int capacidadArray = 50;

                    int[] a26 = new int[capacidadArray];
                    int[] b26 = new int[capacidadArray];

                    a26[1] = 1;
                    b26[1] = 0;

                    bool[] Estado = new bool[50];

                    int contador26 = 0;


                    for (int i = 0; i < a26.Length; i++)
                    {
                        if (a26[i] == b26[i])
                        {
                            Estado[i] = true;
                        }
                        else
                        {
                            Estado[i] = false;
                        }
                    }
                    for (int i = 0; i < Estado.Length; i++)
                    {
                        if (Estado[i] == true)
                        {
                            contador26++;
                        }
                        
                    }
                    if (contador26 == capacidadArray)
                    {
                        Console.WriteLine("Son iguales");
                    }
                    else
                    {
                        Console.WriteLine("No son iguales");
                    }
                    break;


                //Default
                default:
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error CRITICO, vuelva a intentarlo");
                    break;

            }
            //Cierre de Consola
            Console.ReadLine();
        }
    }

}