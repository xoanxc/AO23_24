using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03AlgoritmosAvanzados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Retos de programación");
            int ejercicios = int.Parse(Console.ReadLine());

            switch (ejercicios)
            {
                case 1:
                    //1º Algoritmo que indica si dos arrays son iguales: es decir, tienen el mismo tamaño y los mismos valores.
                    bool iguales = false;

                    int[] Valor1 = new int[5];
                    Valor1[2] = 5;

                    int[] Valor2 = new int[5];
                    Valor2[3] = 5;

                    for (int i = 0; i < Valor1.Length; i++)
                    {

                    }



                    break;
                case 2:
                    //2º Algoritmo que obtiene la posición del primer número superior a la media del array.

                    int[] a2 = new int[20];

                    break;
                case 3:
                    //3º Algoritmo que obtiene el número mas pequeño de un array.
                    Random generador = new Random();

                    int[] c3 = new int[10];

                    Random gen3 = new Random();

                    for (int i = 0; i < c3.Length; i++)
                    {
                        c3[i] = gen3.Next();
                    }
                    break;

                    int minimo = c3[0];

                    for (int i = 0; i < c3.Length; i++)
                    {
                        if (minimo > c3[i])
                        {
                            minimo = c3[i];
                        }
                    }
                    Console.WriteLine("El minimo es " + minimo);

                case 4:
                    //4º Algoritmo que ordena los números de un array de menor a mayor

                    int[] c4 = new int[5];

                    Random gen4 = new Random();

                    for (int u = 0; u < c4.Length; u++)
                    {
                        c4[u] = gen4.Next(1, 20);
                    }

                    for (int i = 0; i < c4.Length; i++)
                    {
                        for (int j = 0; j < c4.Length - 1; j++)
                        {
                            if (c4[j] > c4[j + 1])
                            {
                                int aux = c4[j];
                                c4[j] = c4[j + 1];
                                c4[j + 1] = aux;
                            }
                        }
                        for (int o = 0; o < c4.Length; o++)
                        {
                            Console.Write(c4[o] + " ");
                        }
                    }

                    break;
                    

            }

            Console.ReadLine();






        }
    }
}
