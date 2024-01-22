using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletinMatrizes2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de la matriz
            int[,] a = { { 4, 2, 7 }, { 1, 5, 8 } };

            //Solicitud de datos
            Console.WriteLine("Selecciona una fila");
            int seleccion = int.Parse(Console.ReadLine());

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[seleccion, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();


        }
    }
}
