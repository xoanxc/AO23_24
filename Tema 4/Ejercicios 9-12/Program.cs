using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_9_12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Ejercicios 9-12 by Xoán Alonso";

            int ejercicio = 0;

            Console.WriteLine("Introducir ejercicios 9-12: ");
            ejercicio = int.Parse(Console.ReadLine());


            if (ejercicio == 9)
            {

                Console.WriteLine("Introduce un Numero: "); //Recogida de datos
                double numero = double.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    Console.WriteLine("Es múltiplo de 2");
                }

                if (numero % 3 == 0)
                {
                    Console.WriteLine("Es múltiplo de 3");
                }
            }

            else if (ejercicio == 10)
            {
                Console.WriteLine("Introduce una cantidad de Dinero: "); //Recogida de datos
                double numero2 = double.Parse(Console.ReadLine());

                if (numero2 <= 100)
                {
                    double calculo1 = (numero2 * 0.90); //Calculo del 10%
                    Console.WriteLine("El descuento es del 10% y el precio queda en " + calculo1);
                }

                if (numero2 >= 100)
                {
                    double calculo2 = (numero2 * 0.85); //Calculo del 15&%
                    Console.WriteLine("El descuento es del 15% y el precio queda en " + calculo2);
                }
            }
            else if (ejercicio == 11)
            {
                Console.WriteLine("Introduce un numero de 0 a 10: "); //Recogida de Datos
                double numero3 = double.Parse(Console.ReadLine());

                if (numero3 <= 0.0 || numero3 >= 10.0)
                {
                    Console.WriteLine("Error en nota (tan difícil es poner un numero?)");
                }

            }

            else if (ejercicio < 9 || ejercicio > 12)

            {
                Console.WriteLine("Te equivocaste, esperemos que no se repita");
            }



            Console.ReadLine();
        }
    }
}



