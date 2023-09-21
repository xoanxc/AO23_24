using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _01_TiposVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nombre de la consola
            Console.Title = "_01_TiposVariables";

            //Declaración de variables
            byte n1;
            //Inicializando una variable
            n1 = 10;
            byte n2 = n1;


            //Declarar varias variables en la misma linea
            short num1, num2, num3;
            num1 = 9;
            num2 = 10;
            num3 = 5;

            //Modificar el valor que hay en una variable
            int x1 = 10;
            //Incrementar en 1 el valor de x1
            x1 = x1 + 1;

            //Escribir en terminal el valor de x1
            Console.WriteLine("x1 = " + x1);


            Console.WriteLine(); //Espacio

            //Por ejemplo: Sumar 1 a la variable num1
            num1 = (short) (num1 + 1); //Conversión de int a short



            //Escribir en consola el resultado de num1
            Console.WriteLine("num1 = " + num1);

            Console.WriteLine(); //Espacio

            //Variables con números decimales (ejemplo 2)
            double temperatura = 25.6;
            //Aumentar la temperatura en +10 grados
            temperatura = temperatura + 10;

            //Escribir resultado de la suma de Temperatura +10 (25,6 + 10) en consola
            Console.WriteLine("Temperatura total = " + temperatura);


            Console.WriteLine(); //Espacio


            //Programa que a partir de la base y la altura, calcula el area de un triangulo
            int Base, Altura, Area;
            Base = 10;
            Altura = 15;
            //Area = (a la espera de un valor)

            //Calculamos el Area que es Base x Altura dividido entre 2 y lo guardamos en la variable Area
            Area = Base * Altura / 2;

            //Escribimos el resultado en consola
            Console.WriteLine("El area del Triangulo es: " + Area);

            //Evitar que se cierre la consola
            Console.ReadLine();
        }
    }
}
