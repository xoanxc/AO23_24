using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Recogida de Datos
            Console.WriteLine("Indroduzca el Lado: ");
            float lado = float.Parse(Console.ReadLine());

            //Calculos necesarios
            float perimetro = (4 * lado);
            float diagonal = (float)(lado * (Math.Sqrt(2)));
            float area = (float)(Math.Pow(lado, 2));


            //Mostrar resultados
            Console.WriteLine("El perimetro es " + perimetro);
            Console.WriteLine("El diagonal es " + diagonal);
            Console.WriteLine("El arena es " + area);

            //Evitar que se cierre la consola
            Console.ReadLine();






        }
    }
}
