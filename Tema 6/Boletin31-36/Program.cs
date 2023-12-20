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

                    // f. Ordenar el array copia de menor a mayor.
                    for (int i = 0; i < c31.Length; i++)
                    {
                        for (int j = 0; j < c31.Length - 1; j++)
                        {
                            if (c31[j] > c31[j + 1])
                            {
                                int aux = c31[j];
                                c31[j] = c31[j + 1]; //No consigo que funcione a pesar de usar el mismo codigo del GitHub de Ramon
                                c31[j + 1] = aux;
                            }
                        }
                        for (i = 0; i < c31.Length; i++)
                        {
                            Console.Write(c31[i] + " "); 
                        }
                        Console.WriteLine();
                    }

                    //g.Calcular la suma de los valores almacenados en las 10 primeras posiciones de ambos arrays. 
                    double suma = 0;
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

                    //Reinicio la variable suma
                    suma = 0;

                    for (int i = 0; i < a31.Length; i++)
                    {
                        suma += a31[i] + c31[i];
                    }
                    suma /= 50;

                    for (int i = 0; i < a31.Length; i++)
                    {
                        if (a31[i] > suma)
                        {
                            a31[i] = 0;
                        }
                    }
                    Console.WriteLine();
                    for (int i = 0; i < c31.Length; i++)
                    {
                        if (c31[i] > suma)
                        {
                            c31[i] = 0;
                        }
                    }

                    //j.Solicitar al usuario un valor y buscarlo en ambos arrays mostrar por pantalla la posición que ocupa. En caso de no encontrarlo avisa de que no 'está en la matriz'
                    Console.WriteLine();
                    Console.WriteLine("Introduce un valor: ");
                    int valorj = int.Parse(Console.ReadLine());
                    bool encontrado1 = false;
                    bool encontrado2 = false;

                    for (int i = 0; i < a31.Length; i++)
                    {
                        if (a31[i] == valorj)
                        {
                            Console.WriteLine("He encontrado este valor " + a31[i] + " en la posición " + i + " del array a31");
                            encontrado1 = true;
                        }

                    }
                    for (int i = 0; i < c31.Length; i++)
                    {
                        if (c31[i] == valorj)
                        {
                            Console.WriteLine("He encontrado este valor " + c31[i] + " en la posición " + i + " del array c31");
                            encontrado2 = true;
                        }
                    }
                    if (!encontrado1 && !encontrado2)
                    {
                        Console.WriteLine("El valor introducido no se encuentra en ninguno de los dos arrays");
                    }
                    break;

                case 32:
                    Console.WriteLine("Introduce el valor de n ");
                    int valorN = int.Parse(Console.ReadLine());

                    double suma32 = 0;
                    int[] a32 = new int[valorN];
                    Random gen32 = new Random();
                    for (int i = 0; i < a32.Length; i++)
                    {
                        a32[i] = gen32.Next(0, 11);
                    }

                    //a.Calcular la media de los elementos del Array.
                    for (int i = 0; i < a32.Length; i++)
                    {
                        suma32 += a32[i];
                    }
                    suma32 /= valorN;
                    Console.WriteLine("La media es " + suma32);

                    //b.Calcular el porcentaje de valores que están por encima de la media:
                    double porcentaje32 = 0;

                    for (int i = 0; i < a32.Length; i++)
                    {
                        if (suma32 < a32[i])
                        {
                            porcentaje32++;
                        }
                    }
                    porcentaje32 = Math.Round(((porcentaje32 / valorN) * 100), 2); //Un parentesis sobra, pero me quedo mas tranquilo :(


                    //Comprobación de quien aprueba y quien NO (no lo decido yo, lo decide el if)

                    if (porcentaje32 < 5)
                    {
                        Console.WriteLine("Lamentablemente debo informarte de tu suspenso, con una media de " + porcentaje32 + ", esfuerzate mas en las recuperaciones");
                    }
                    else if (porcentaje32 >= 5 || porcentaje32 < 7)
                    {
                        Console.WriteLine("Felicidades, has aprobado, aunque tienes margen para mejorar");
                    }
                    else if (porcentaje32 > 7 || porcentaje32 < 9)
                    {
                        Console.WriteLine("Notable, a las puertas de la perfección");
                    }
                    else if (porcentaje32 > 9 || porcentaje32 <= 10)
                    {
                        Console.WriteLine("Sobresaliente, felicidades");
                    }
                    else
                    {
                        Console.WriteLine("Error fatal");
                    }
                    break;

                case 33:
                    Console.WriteLine("Introduce n");
                    int n33 = int.Parse(Console.ReadLine());

                    int[] array = new int[n33];
                    double[] desviaciones = new double[n33];
                    Random generador = new Random();
                    double suma33 = 0;

                    //Llenar el array y calcular la suma
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = generador.Next();
                        suma33 += array[i];
                    }

                    //Calcular la media
                    double media = suma33 / n33;

                    //Calcular la desviación con respecto a la media y acumular en un array
                    for (int i = 0; i < array.Length; i++)
                    {
                        desviaciones[i] = Math.Abs(array[i] - media);
                    }

                    //Calcular la desviación media
                    double desviacionMedia = 0;
                    for (int i = 0; i < desviaciones.Length; i++)
                    {
                        desviacionMedia += desviaciones[i];
                    }
                    desviacionMedia /= n33;

                    Console.WriteLine("Desviación Media: " + desviacionMedia); //Has hecho que me duela la cabeza
                    break;

                case 34:

                    int[] a34 = new int[5];
                    int[] b34 = new int[5];

                    Console.WriteLine("Introduce los valores del array");
                    Console.WriteLine("Primer valor");
                    a34[0] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Segundo valor");
                    a34[1] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Tercer valor");
                    a34[2] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Cuarto valor");
                    a34[3] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Quinto valor");
                    a34[4] = int.Parse(Console.ReadLine());
                    //*Se podia haber hecho con un for :(

                    for (int i = 0; i < b34.Length; i++)
                    {
                        b34[i] = a34[i] + 10;
                    }
                    for (int i = 0; i < a34.Length; i++)
                    {
                        Console.Write(a34[i] + " ");
                    }
                    Console.WriteLine();
                    for (int i = 0; i < b34.Length; i++)
                    {
                        Console.Write(b34[i] + " ");
                    }

                    break;

                case 35:

                    double suma35 = 0;
                    double modulo = 0;
                    double[] a35 = new double[5];
                    double[] potencias = new double[5];

                    Random gen35 = new Random();

                    for (int i = 0; i < a35.Length; i++)
                    {
                        a35[i] = gen35.Next();
                    }
                    for (int i = 0; i < potencias.Length; i++)
                    {
                        potencias[i] = Math.Pow(a35[i], 2);
                        suma35 += potencias[i]; //Innecesario
                    }
                    suma35 = Math.Round(Math.Sqrt(suma35), 2);
                    Console.WriteLine("El modulo es: " + suma35);




                    break;

                case 36:

                    int[] a36 = new int[25];
                    Random gen36 = new Random();
                    for (int i = 0; i < a36.Length; i++)
                    {
                        a36[i] = gen36.Next(-25, 25);
                    }
                    for (int i = 0; i < a36.Length; i++)
                    {
                        if (a36[i] < 0)
                        {
                            Console.WriteLine("El primer número negativo en la posición " + i + " es " + a36[i]);
                            break;
                        }
                    }
                    break;


                //Ojala haber utilizado funciones :(

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
