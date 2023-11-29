using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Boletin
{
    internal class Funciones
    {
        public static void printArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] + " ");
            }
            Console.WriteLine();

        }
        public static void printArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                break;
            }
            Console.WriteLine(a[i]);
        }
    }
}
