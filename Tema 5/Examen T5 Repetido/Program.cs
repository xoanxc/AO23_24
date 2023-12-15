using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_T5_Repetido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ");
            char opcion;
            do
            {
                Console.WriteLine("Selecciona un ejercicio entre 1-");
                byte ejercicio = byte.Parse(Console.ReadLine());


                Console.WriteLine("¿Desea regresar al menu inicial? s/n");
                opcion = char.ToLower(char.Parse(Console.ReadLine()));
            }

            while (opcion == 's');
        }

    }
}
