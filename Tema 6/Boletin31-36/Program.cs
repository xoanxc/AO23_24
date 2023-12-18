using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletin31_36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicios 31 - 36 By Xoán Alonso Fernández";
            Console.WriteLine("Boletin31-36 By Xoán Alonso Fernández");
            Console.WriteLine();
            Console.WriteLine("Introduce un ejercicio comprendido entre 31 y 36");
            int ejercicio = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (ejercicio)
            {
                case 31:

                    int[] a31 = new int[25];
                    Random gen31 = new Random();

                    //a.Llenar todas las posiciones con un número negativo.
                    for (int i = 0; i < a31.Length; i++)
                    {
                        a31[i] = gen31.Next(-50, -1);
                    }


                    //b.Guardar en las 5 primeras posiciones del array y las 5 últimas con números aleatorios.
                    //Primeros 5
                    for (int i = 0; i < 5; i++)
                    {
                        a31[i] = gen31.Next(1, 50);
                    }
                    //Últimos 5
                    for (int i = a31.Length - 5; i < a31.Length; i++)
                    {
                        a31[i] = gen31.Next(1, 50);
                    }


                    //c.El resto de posiciones actualizarlas al número que se os ocurra.
                    for (int i = a31.Length - 20; i < a31.Length - 5; i++)
                    {
                        a31[i] = gen31.Next(1, 50);
                    }

                    //d.Mostrar por pantalla el valor de la primera y de la última posición.
                    Console.WriteLine("Número en la primera posición: " + a31[0]);
                    Console.WriteLine("Número en la última posición: " + a31[24]);


                    //e.Crear un array copia del array generado.
                    int[] c31 = new int[25];
                    for (int i = 0; i < c31.Length; i++)
                    {
                        c31[i] = a31[i];
                    }

                    //f.Ordenar el array copia de menor a mayor.
                    for (int i = 0; i < c31.Length; i++)
                    {
                        for (int j = 0; j < c31.Length - 1; j++)
                        {
                            if (c31[j] > c31[j + 1])
                            {
                                int aux = c31[j];
                                c31[j] = c31[j + 1];
                                c31[j + 1] = aux;
                            }
                        }
                    }

                    //g.Calcular la suma de los valores almacenados en las 10 primeras posiciones de ambos arrays. 
                    int suma = 0;
                    for (int i = 0; i < 9; i++)
                    {
                        suma += a31[i] + c31[i];
                    }
                    Console.WriteLine("g.La suma de ambos arrays es: " + suma);

                    //h.Sumarle 10 a todas las posiciones del array copia.
                    Console.Write("h.Suma +10 a todos los valores: ");
                    for (int i = 0; i < c31.Length; i++)
                    {
                        c31[i] += 10;
                        Console.Write(c31[i] + " ");
                    }

                    //i.Poner a cero todas aquellas posiciones que almacenen un número mayor que la media en ambos arrays.


                    break;
                case 32:
                    break;
                case 33:
                    break;
                case 34:
                    break;
                case 35:
                    break;
                case 36:
                    break;


                   
                default: //Default
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error CRITICO, el numero introducido no se encuentra en el intervalo de 31 y 36");
                    break;

            }
            //Cierre de Consola
            Console.ReadLine();
        }
    }
}
