using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_String
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //indexOff, subString, indexOfAny, split, lenght,
            //starsWith, endsWith, contains, replace

            //Algoritmo que valida si un String está compuesto por dos caaracteres
            //Con el formato A9

            string entrada;
            Console.WriteLine("Introduzca un codigo con formato A9");
            entrada = Console.ReadLine();

            bool correcto = true;


            //Primero validamos que esté formado por 2 o mas caracteres
            if (entrada.Length != 2)
            {
                correcto = false;
                Console.WriteLine("El codigo no tiene 2 caracteres");
            }
            else
            {
                if (char.IsLetter(entrada[0]) && char.IsDigit(entrada[1]))
                {
                    correcto = true;
                    Console.WriteLine();
                    Console.WriteLine("Formato correcto");
                }
                else
                {
                    correcto = false;
                    Console.WriteLine();
                    Console.WriteLine("El codigo debe tener formato A9");
                }

            } while (!correcto) ;
            Console.ReadLine();

            Console.WriteLine("********Segundo Ejercicio********");
            //Algoritmo que indica cuantas palabras empieza por A

            string entrada2 = "A lo loco se vive mejor. Algunas veces";

            string[] palabras = entrada2.Split(' ', '.');
            int contador = 0;

            foreach (string palabra in palabras)
            {
                if (palabra.StartsWith("A") || palabra.StartsWith("a"))
                { 
                    contador++;
                }

            }
            if (contador == 0)
            {
                Console.WriteLine("No hay palabras que empiecen por a|A");
            }
            else
            {
                Console.WriteLine("Hay " + contador + " palabras que empiezan por A|a");
            }

            //Programa que cambia los espacios de un String por asteriscos
            //Problema: Los String son inmutables, no se pueden modificar
            string entrada3 = "The Wire es la mejor serie de todos los tiempos";
            entrada3 += "Teneis que verla";

            entrada3.Replace(' ', ',');

            Console.WriteLine(entrada3);

            Console.ReadLine();
        }
    
    }
}