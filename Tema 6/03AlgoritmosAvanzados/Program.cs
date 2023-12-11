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

                    int[] ints = new int[5];

                    break;
                case 3:
                    //3º Algoritmo que obtiene el número mas pequeño de un array.
                    Random generador = new Random();

                    int[] c3 = new int[10];

                    for (int i = 0; i < c3.Length; i++)
                    {
                        
                    }
                    break;
                case 4:
                    //4º Algoritmo que ordena los números de un array de menor a mayor

                    int[] c4 = new int[3];

                    Random gen4 = new Random();

                    for (int i = 0; i < c4.Length; i++)
                    {
                        c4[i] = gen4.Next(1, 20);
                    }
                    for (int i = 0; i < c4.Length; i++)
                    {
                        if (c4[0] > c4[1])
                        {
                            c4[0] = c4[1];

                            if (c4[0] < c4[2])
                            {
                                c4[0] = c4[2];
                            }
                        }
                        else if (c4[0] > c4[1])
                        {
                            c4[1] = c4[0];

                            if (c4[0] < c4[2])
                            {
                                c4[0] = c4[2];
                            }
                        }


                    }
                    for (int i = 0; i < c4.Length; i++)
                    {
                        Console.WriteLine("Ordenados de menor a mayor: " + c4[i]);
                    }

                    break;
                    

            }

            Console.ReadLine();






        }
    }
}
