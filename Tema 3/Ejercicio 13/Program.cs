using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Calculo de la Hipotenusa";

            //Toma de variable a
            Console.WriteLine("Valor del lado a: ");
            float a = float.Parse(Console.ReadLine());

            //Espacio
            Console.WriteLine();

            //Toma de variable b
            Console.WriteLine("Valor del lado b: ");
            float b = float.Parse(Console.ReadLine());

            //Calculo
            float h = (float)Math.Pow((a + b), 2);

            //Espacio
            Console.WriteLine();

            //Escribir el resultado
            Console.WriteLine("La hipotenusa es: " + h);

            //Evitar que se cierre
            Console.ReadLine();

        }
    }
}
