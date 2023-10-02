using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Programa que calcula el precio de los productos
            double precio;
            float cantidad;
            string total;


            Console.WriteLine("Introduzca el Precio: ");
            precio = double.Parse(Console.ReadLine());


            Console.WriteLine("Introduzca la Cantidad: ");
            cantidad = float.Parse(Console.ReadLine());

            total = (precio * cantidad).ToString();

            Console.WriteLine(("El precio del producto es" + precio) ("euros y la cantidad que compra es" + cantidad) ("por lo tanto debe pagar" + total) ("euros.Vuelva pronto."));

            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
