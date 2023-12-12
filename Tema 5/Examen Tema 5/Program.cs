using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Examen_Tema_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********Examen Tema 5 By: Xoán Alonso Fernández*********");
            char opción;
            do
            {
                Console.WriteLine("Selecciona un ejercicio del 1 al 4");
                int ejercicio = int.Parse(Console.ReadLine());

                switch (ejercicio)
                {



                    case 1:
                
                    Console.WriteLine("Ejercicio 1: Bucle While");
                    Console.WriteLine();
                    int a = 500;
                    int b = 13;

                    int i = 0;


                    while (a = 100)
                    {
                        a -= 100

                        Console.Write(a);
                        
                    }
                    while (b = 25)
                    {
                        b += 2
                    }

                        break;
                    case 2:
                
                    //Solicitud de valores
                    Console.WriteLine("Dale un valor a n y m");
                    //Para n
                    Console.WriteLine("Valor para n: ");
                    int n = int.Parse(Console.ReadLine());

                    //Espacio
                    Console.WriteLine();

                    //Para m
                    Console.WriteLine("Valor para m: ");
                    int m = int.Parse(Console.ReadLine());

                    if (n < m)
                        {
                            //for (int = n; i < 5; i++)
                            //{

                            //}
                        }
                        break;
                    case 3:
                        n = 20;

                        i = 0;

                        ////Encontrar el par entre 10 y n
                        //for (i = 10; i <= n; i++)
                        //{
                        //    if (i % 2 == 0)
                        //    {
                               
                        //    }
                        //} 

                        int suma = 0;

                        //Hacer el calculo
                        for (i = 10; i <= n; i += 2)
                        {
                            suma += 1 + (i + 1) / 2;
                        }

                        Console.WriteLine("La suma es: " + suma);
                        
                        break;



                    case 4:
                        //Solicitud de valores
                        Console.WriteLine("Introduce dos números");

                        //Para num1
                        Console.WriteLine("Primer Numero: ");
                        int num1 = int.Parse(Console.ReadLine());

                        //Espacio
                        Console.WriteLine();

                        //Para num2
                        Console.WriteLine("Segundo numero: ");
                        int num2 = int.Parse(Console.ReadLine());

                        if (num1 % 2 == 0  && num2 % 2 == 0)
                        {
                            Console.WriteLine("No son primos entre si");      
                        }
                        else
                        {
                            Console.WriteLine("Ambos números son primos entre si");
                        }
                        break;
                    default:
                        Console.WriteLine("Lo siento, ese ejercicio no esta disponible");
                        break;
                }

                Console.WriteLine("Quiere volver al menú: s/n");
                opción = Char.ToLower(char.Parse(Console.ReadLine()));
            } //Fin de la llave do
            while (opción == 's');
        }
    }
}
