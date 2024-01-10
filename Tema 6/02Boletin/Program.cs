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
            Console.WriteLine("02Boletín By Xoán Alonso Fernández");
            Console.WriteLine();
            Console.WriteLine("Introduce un ejercicio entre 1 a 27");
            int ejercicio = int.Parse(Console.ReadLine());
            Console.WriteLine();

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
                    Console.WriteLine("La suma de los no negativos es: " + suma15);

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

                    if(a26.Length  != b26.Length)
                        {
                        Console.WriteLine("No son iguales");
                        }
                    else
                    {

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
                    }
                    break;

                case 27:

                    Funciones.printEnunciado(27);

                    int capacidadArray27 = 50;
                    int[] a27 = new int[capacidadArray27];
                    int[] b27 = new int[capacidadArray27];

                    bool[] result = new bool[capacidadArray27];
                    int contador27 = 0;
                    

                    for (int i = 0; i < a27.Length; i++)
                    {
                        result[i] = Array.Equals(a27[i], b27[i]);
                    }
                    for (int i = 0; i < result.Length; i++)
                    {
                        if (result[i] == true)
                        {
                            contador27++;
                        }

                    }
                    if (contador27 == capacidadArray27)
                    {
                        Console.WriteLine("Son iguales");
                    }
                    else
                    {
                        Console.WriteLine("No son iguales");
                    }
                    break;
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
                    Random generador33 = new Random();
                    double suma33 = 0;

                    //Llenar el array y calcular la suma
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = generador33.Next();
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
                case 37: //Con problemas

                    
                    int[] a37 = new int[50];
                    Random gen37 = new Random();

                    bool encontrado37 = false;

                    //Llenar con nº aleatorios
                    for (int i = 0; i < a37.Length; i++)
                    {
                        a37[i] = gen37.Next(1, 99);
                    }

                    Console.WriteLine("Introduzca un número");
                    int num37 = int.Parse(Console.ReadLine());


                    Console.WriteLine(num37 + " aparece en las posiciones: ");
                    for (int i = 0; i < a37.Length; i++)
                    {
                        if (num37 == a37[i])
                        {
                            encontrado37 = true;
                            Console.WriteLine("Posición: " + i);      
                        }
                    }
                    if (!encontrado37)
                    {
                        Console.WriteLine("Lamentablemente, el numero no se encuentra en el array");
                    }
                    break;
                case 38:

                    String[] series = new String[100];

                    series[0] = "Breaking Bad";
                    series[1] = "True Detective";
                    series[2] = "The Wire";
                    int opcion = 0;

                    do
                    {

                        Console.WriteLine("1.Introducir Serie");
                        Console.WriteLine("2.Mostrar Series");
                        Console.WriteLine("3.Contar Series");
                        Console.WriteLine("4.Contar huecos");
                        Console.WriteLine("5.Buscar Serie");
                        Console.WriteLine("6.Eliminar Serie");
                        opcion = int.Parse(Console.ReadLine());
                        Console.WriteLine();//Espacio

                        switch (opcion)
                        {
                            case 1:
                                Console.WriteLine("Introduzca el título dela serie:");
                                String serie = Console.ReadLine();

                                //Guardar en la primera posición vacía
                                for (int i = 0; i < series.Length; i++)
                                {
                                    if (series[i] == null)
                                    {
                                        series[i] = serie;
                                        break;
                                    }
                                }
                                break;
                            case 2:
                                Console.WriteLine("Series en la BBDD: ");
                                foreach (String s in series)
                                {
                                    if (s != null)
                                    {
                                        Console.WriteLine(s);
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                break;
                            case 3:
                                int contador38 = 0;

                                foreach (String s in series)
                                {
                                    if (s != null)
                                    {
                                        contador38++;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                Console.WriteLine("Hay " + contador38 + " series guardadas.");

                                break;
                            case 4:
                                break;
                            case 5:
                                Console.WriteLine("Que serie desea buscar?");
                                String serieBuscada = Console.ReadLine();
                                bool encontrado38 = false;

                                for (int i = 0; i < series.Length; i++)
                                {
                                    if (series[i] == serieBuscada)
                                    {
                                        Console.WriteLine("La serie está en la posición " + i);
                                        encontrado38 = true;
                                        break;
                                    }
                                }
                                if (!encontrado38)
                                {
                                    Console.WriteLine("La serie está fuera del DBBDD");
                                }
                                break;
                            case 6:
                                break;
                        }
                    }
                    while (opcion < 7);
                        break;


                default: //Default
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error CRITICO");
                    break;

            }
            //Cierre de Consola
            Console.ReadLine();
        }
    }

}