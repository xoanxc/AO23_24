using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Crear un programa que lea 3 valores y calcule la media
            //Calcule el modulo: Raíz (a2 + b2 + c2) --> Con dos decimales
            //Utilizando la librería Math obtener el más pequeño

            //Recogida datos 1
            Console.WriteLine("Introduzca el valor 1: ");
            float valor1 = float.Parse(Console.ReadLine());

            //Espacio
            Console.WriteLine();

            //Recogida datos 2
            Console.WriteLine("Introduzca el valor 2: ");
            float valor2 = float.Parse(Console.ReadLine());

            //Espacio
            Console.WriteLine();

            //Recogida datos 3
            Console.WriteLine("Introduzca el valor 3: ");
            float valor3 = float.Parse(Console.ReadLine());

            //Espacio
            Console.WriteLine();

            //Calculo
            float media = (valor1 + valor2 + valor3) / 3;

            //Mostrar Resultado
            Console.Write(media);

            //EvitarCierre
            Console.ReadLine();
        }
    }
}
