using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Declaración de Variables
            double espacio, tiempo, velocidad;


            //Recogida de Datos
            Console.WriteLine("Introduzca el Espacio: ");
            espacio = double.Parse(Console.ReadLine());

            //Espacio
            Console.WriteLine();

            //Recogida de Datos 2
            Console.WriteLine("Introduzca el Tiempo: ");
            tiempo = double.Parse(Console.ReadLine());

            //Espacio
            Console.WriteLine();

            //Calculo de la Formula
            velocidad = espacio / tiempo;

            //Muestra del resultado
            Console.WriteLine("La velocidad es de " + velocidad + " metros/segundo");

            //Evitar que se cierre la consola
            Console.ReadLine();

        }
    }
}
