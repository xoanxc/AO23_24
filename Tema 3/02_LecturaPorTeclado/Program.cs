using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_LecturaPorTeclado
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Programa que solicita al usuario DNI y Edad
            string dni;
            byte edad;



            Console.WriteLine("Introduce el DNI: ");
            dni = Console.ReadLine();

            Console.WriteLine("Introduce su edad: ");
            edad = byte.Parse (Console.ReadLine());

            //Espacio entre datos y respuesta
            Console.WriteLine();

            Console.WriteLine("DNI: " + dni);
            Console.WriteLine("Edad: " + edad);
            

            Console.ReadLine();
        }
    }
}
