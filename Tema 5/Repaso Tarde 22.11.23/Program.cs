using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_Tarde_22._11._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicios
            //Mostar todos los numeros impares multiplos de 3 en rango
            int n = 199;
            int m = 400;

            int i = n;

            while (i <= m)
            {

                //Ejercicio 1. Comprobar si es impar o múltiplo de 3
                if (i % 2 != 0 && i % 3 == 0)
                {
                    Console.Write(i + "");


                }
                i++;
            }
            Console.WriteLine();

            //Ejercicio 2. Contar todos los números múltiplos de 3 y 4 en el intervalo anterior
            int contador = 0;

            for (i = n; i <= m; i++)
            {
                if (i % 3 == 0 && i % 4 == 0)
                {
                    contador++;
                }
            }
            Console.WriteLine("Hay " + contador + " múltiplos de 3 y de 4");

            //Ejercicio 3. Programa que suma los cuadrados de los números impares que hay entre n y m
            n = 1;
            m = 10;
            int suma = 0;

            for (i = n; i <= m; i++)
            {
                if (i % 2 == 1)
                {
                    suma = suma + i * i;
                }
            }


            //****Ejercicio de Practica****

            //4.    Mostrad por pantalla los 10 primeros números impares entre n y m.

            for (i = n; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            //5.    Calcular la suma de los 10 últimos números del intervalo n y m.
            n = 100;
            m = 400;

            int calculo2 = 0;

            for (i = m -10; i <= m; i++)
            {
                calculo2 = calculo2  + i;
            }
            Console.WriteLine( "Son " + i);

            //6.    Contar cuantos números mayores que el doble de n son múltiplos de 7.

            n = 100;
            m = 400;

            int doble = n * 2;
            int calculo = 0;

            for (i = n; i <= m; i++)
            {
                if (i % 7 == 0)
                {
                    calculo++;

                }


            }
            Console.WriteLine();

            Console.WriteLine("Son " + calculo);





            Console.ReadLine();



        }
    }
}
