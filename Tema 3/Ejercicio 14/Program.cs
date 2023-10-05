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

            //Nombre de la consola
            Console.Title = "Calcular Media";

            //Recogida de Datos 1
            Console.WriteLine("Precio del producto: ");
            float precio = float.Parse(Console.ReadLine());

            //Espacio
            Console.WriteLine();

            //Recogida de Datos 2
            Console.WriteLine("Rebaja del producto: ");
            float descuento = float.Parse(Console.ReadLine());

            //Calcular el descuento
            float resultado = ((precio / 100) * descuento);
            float resultado2 = (precio - resultado);

            //Mostrar resultado
            Console.WriteLine("Al aplicar un " + descuento + " por ciento de descuento el precio final del producto es de " + resultado2 + " euros y por lo tanto se ahorra " + resultado + " euros.");

            //Evitar que se cierre la consola
            Console.ReadLine();
;

        }
    }
}
