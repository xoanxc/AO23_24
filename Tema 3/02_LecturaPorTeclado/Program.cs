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
            float salario;



            Console.WriteLine("Introduce el DNI: ");
            dni = Console.ReadLine();

            Console.WriteLine("Introduce su edad: ");
            edad = byte.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca su salario ");
            salario = float.Parse(Console.ReadLine());

            //Espacio entre datos y respuesta
            Console.WriteLine();

            Console.WriteLine("DNI: " + dni);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Salario: " + salario);
            

            Console.ReadLine();
        }
    }
}
