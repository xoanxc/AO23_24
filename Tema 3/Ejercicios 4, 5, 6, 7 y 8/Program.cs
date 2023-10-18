using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_4__5__6__7_y_8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int ejercicio = 0;

            Console.WriteLine("Introducir ejercicios 4-8: ");
            ejercicio = int.Parse(Console.ReadLine());

            if (ejercicio == 4)
            { //Ejercicio 4

                Console.WriteLine("Introduce el primer Numero: ");
                double numero1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Introduce el segundo Numero: ");
                double numero2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Introduce el tercer Numero: ");
                double numero3 = double.Parse(Console.ReadLine());

                double resultado = (numero1 + numero2 + numero3) / 3;

                if (resultado >= 5)
                {
                    Console.WriteLine("Enhorabuena, has aprobado (que no se te suba a la cabeza)");
                }
                else if (resultado <= 6) 
                {
                    Console.WriteLine("Suspendiste y eso que regale puntos (patético)");
                }


            }
            else if (ejercicio == 5)
            { //Ejercicio 5

            }
            else if (ejercicio == 6)
            { //Ejercicio 6

            }
            else if (ejercicio == 7)
            { //Ejercicio 7

            }
            else if (ejercicio == 8)
            { //Ejercicio 8

            }

            Console.ReadLine();

        }
    }
}
