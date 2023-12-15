using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperacion_Tema_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" ");
            char opcion;
            do //Ejercicio 0: Menu Do While
            {
                Console.WriteLine("Selecciona un ejercicio entre 1-");
                byte ejercicio = byte.Parse(Console.ReadLine());

                switch(ejercicio)

                {
                    case 1: //Ejercicio 1: Generación de salidas con Bucles While 

                        Console.WriteLine();
                        Console.WriteLine("Ejercicio 1: Generación de salidas a y b");
                        Console.WriteLine();

                        int a = 150;
                        int b = 20;
                        int i = 0;

                        Console.Write("a. ");
                        while (a <= 350) //Bucle de a
                        {
                            Console.Write(a + " ");
                            a += 50;
                        }

                        Console.WriteLine() ;

                        Console.Write("b. ");
                        while (b >= 15) //Bucle de b
                        {
                            Console.Write(b + " ");
                            b -= 1;
                        }

                        break;
                    case 2:

                        Console.WriteLine();
                        Console.WriteLine("Ejercicio 4: Divisores de n");
                        Console.WriteLine();

                        Console.WriteLine("Introduce n: ");
                        int n = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce m: ");
                        int m = int.Parse(Console.ReadLine());

                        bool negativo= false;
                        i = 0;

                        if (n < m)
                        {

                            for (i = n; i <= m; i++)
                            {
                                //No dio tiempo :(
                                if (n % 11 == 0 && m % 11 == 0)
                                {
                                    negativo = true;
                                    Console.WriteLine("");
                                    break;
                                }


                            }
                            if (!negativo)
                            {
                                Console.WriteLine("Vaya faena, no hay ningún número par o múltiplo de 11 a la vez entre n y m");
                            }

                        }
                        else
                        {
                            Console.WriteLine("n debe ser menor que m");
                        }

                        break;
                    case 3: //Ejercicio 3: Suma de los valores entre 10 y n

                        Console.WriteLine();
                        Console.WriteLine("Ejercicio 3: Suma de los valores entre 10 y n");
                        Console.WriteLine();

                        n = 45;
                        
                        double suma = 0;
                        i = 0;

                        for (int j = 10; j < n; j++)
                        {

                            i += j;
                        }

                        suma = 1 + i / 2;

                        Console.WriteLine("La suma es: " + suma );
                        break;
                    case 4: //Divisores de n y verificación de si n es primo

                        Console.WriteLine();
                        Console.WriteLine("Ejercicio 4: Divisores de n y verificación de si n es primo");
                        Console.WriteLine();

                        n = 50;
                        int divisores = 0;

                        for (i = 1; i <= n; i++)
                        {
                            if (n % i == 0)
                            {
                                divisores++;
                                Console.WriteLine("Puede ser dividido entre: " + i);

                                ;
                            }

                        }
                        if (divisores == 2) //En caso de tener 2 divisores pasa al if, es primo
                        {
                            Console.WriteLine();
                            Console.WriteLine("Es primo ya que es divisible entre " + divisores + " números");
                        }
                        else //Si if no se cumple pasa al else, no es primo
                        {
                            Console.WriteLine();
                            Console.WriteLine("No es primo, lamentablemente, ya que es divisible entre " + divisores + " números");
                        }

                        //Mejor colocar la cantidad de divisores junto a si es primo o no
                        //Console.WriteLine();
                        //Console.WriteLine("Puede ser dividido por un total de " + divisores + " números");

                        break;
                }



                Console.WriteLine();
                Console.WriteLine("¿Desea regresar al menú inicial? s/n");
                opcion = char.ToLower(char.Parse(Console.ReadLine()));

            } //LLave Do while
            while (opcion == 's');
        }
    }
}
