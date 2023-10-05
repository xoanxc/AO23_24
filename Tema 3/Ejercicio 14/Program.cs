using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Recogida de Datos 1
            Console.WriteLine("Precio del producto: ");
            float precio = float.Parse(Console.ReadLine());

            //Espacio
            Console.WriteLine();

            //Recogida de Datos 2
            Console.WriteLine("Rebaja del producto: ");
            float descuento = float.Parse(Console.ReadLine());

            float resultado = ((precio/100) * descuento);


        }
    }
}
