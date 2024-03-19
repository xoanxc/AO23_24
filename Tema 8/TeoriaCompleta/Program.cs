using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeoriaCompleta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione una opción: ");
            Console.WriteLine("1. Teoría de conjuntos");
            Console.WriteLine("2. Teoría de listas");
            Console.WriteLine("3. Teoría de diccionarios");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Teoría de conjuntos");
                    
                    break;
                case 2:
                    Console.WriteLine("Teoría de listas");
                    break;
                case 3:
                    Console.WriteLine("Teoría de diccionarios");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }
}
