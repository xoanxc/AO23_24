﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Titulo de la consola
            Console.Title = "Calcular";

            //Recogida de Datos
            Console.WriteLine("Lado del cubo: ");
            float lado = float.Parse(Console.ReadLine());

            //Espacio
            Console.WriteLine();

            //Calculo de datos
            float D = (float)Math.Sqrt(3) * (lado);
            float Al = (float)Math.Pow(lado, 2) * 4;
            float V = (float)Math.Pow(lado, 3);

            //Mostrar resultado por pantalla
            Console.WriteLine("La Diagonal es " + D + " la Al es " + Al + " y el V es " + V);

            //Evitar que se cierre la consola
            Console.ReadLine();
        }
    }
}
