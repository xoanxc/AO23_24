using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletin_Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" ");
            char opcion;
            do
            {
                Console.WriteLine("Selecciona un ejercicio entre");
                byte ejercicio = byte.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (ejercicio)


                {
                    case 1:

                        List<int> list = new List<int>(50);

                        Random gen1 = new Random();

                        for(int i = 0; i < 50; i++)
                        {
                            list.Add(gen1.Next(1, 26));
                        }

                        Console.WriteLine("a.Posición en la que se encuentra el valor 2.");
                        Console.WriteLine("Calcular la suma de los valores generados.");
                        Console.WriteLine("Calcular la media de valores generados.");
                        Console.WriteLine("Calcular el porcentaje de números superiores a 20 almacenados en la lista.");
                        Console.WriteLine("Mostrar los valores que están almacenados, sin mostrar las repeticiones.");

                        break;
                        case 2:
                        break;
                        case 3:
                        break;
                }



                Console.WriteLine();
                Console.WriteLine("¿Desea volver al menú inicial? s/n");
                opcion = char.ToLower(char.Parse(Console.ReadLine()));

            }
            while (opcion == 's');
            
        }
    }
}
