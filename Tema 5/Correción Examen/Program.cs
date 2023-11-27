using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correción_Examen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ejercicio;
            do
            {
                //Bucle Do While
                Console.WriteLine("Intro ejercicio 1 - 4");
                ejercicio = int.Parse(Console.ReadLine());

                //Selección ejercicio
                switch (ejercicio)
                {
                    //Ejercicio 1
                    case 1:
                        int i = 500;
                        while (i >= 100)
                        {
                            Console.Write(i + " ");
                            i -= 100;
                        }

                        i = 13;
                        while (i <= 25)
                        {
                            Console.Write(i + " ");
                            i += 2;
                        }
                        break;

                    //Ejercicio 2
                    case 2:
                        int n, m;

                        do
                        {
                            Console.WriteLine("Intro n: ");
                            n = int.Parse(Console.ReadLine());
                            Console.WriteLine("Intro m: ");
                            m = int.Parse(Console.ReadLine());

                            int contador = 0;

                            for (i = n; i <= m; i++)
                            {
                                if (i % 2 == 1 && i % 7 == 0)
                                {
                                    Console.WriteLine(i + " ");
                                    contador++;
                                }
                                if (contador == 10)
                                {
                                    break;
                                }
                            }

                        }
                        while (n >= m);
                        break;

                    //Ejercicio 3
                    case 3:
                        int n3;
                        double suma = 0;
                        Console.WriteLine("Intro valor de n: ");
                        n3 = int.Parse(Console.ReadLine());

                        for (i = 10; i <= n3; i++)
                        {
                            suma = suma + 1 + i / (Math.Pow(i, 3)) + 1;
                        }
                        break;

                    //Ejercicio 4
                    case 4:
                        int n4, m4;
                        Console.WriteLine("Intro n4: ");
                        n4 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Intro m4: ");
                        m4 = int.Parse(Console.ReadLine());

                        bool primos = true;

                        for (i = 2; i < m4; i++)
                        {
                            if (n4 % i == 0 && m4 % i == 0)
                            {
                                Console.WriteLine("No son primos entre sí");
                                break;
                            }
                        }
                        if (primos)
                        {
                            Console.WriteLine("Son primos entre sí");
                        }

                        break;
                }

            }
            while (ejercicio < 1 || ejercicio > 4);

            Console.ReadLine();
        }
    }
}
