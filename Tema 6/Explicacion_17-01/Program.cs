using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicacion_17_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear un array con capacidad para 10 elementos de tipo float
            float[] a1 = new float[10];

            Console.WriteLine(a1[7]);

            Console.WriteLine(a1.Length);

            Console.WriteLine(a1[a1.Length - 1]);

            int n = 0;
            Console.WriteLine("intro valor de n");
            n = int.Parse(Console.ReadLine());

            int[] m = new int[n];

            //Inicializar las posiciones de indice par a -1
            for (int i = 0; i < m.Length; i += 2)
            {
                m[i] = -1;
            }

            //Ininializar las posiciones impares a 1, 2, 3, 4, 5...
            int contador = 1;
            for (int i = 1; i < m.Length; i += 2)
            {
                m[i] = contador;
                contador++;
            }

            //Mostrar el array m por consola utilizando un foreach
            foreach (int valor in m)
            {
                Console.WriteLine(valor + " ");
            }

            //Espacio
            Console.WriteLine();

            //Calcular la media
            int suma = 0;
            double media = 0;

            foreach (int valor in m)
            {
                suma = suma + valor;
            }

            media = suma / m.Length;

            //Buscar un valor y mostrar por pantalla todas las posiciones en las que se encuentra
            int valorBuscado = 3;
            bool encontrado = false;

            for (int i = 0; i < m.Length; i++)
            {
                if (m[i] == valorBuscado)
                {
                    Console.WriteLine("Posición " + i);
                    encontrado = true;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("No se encontro el " + valorBuscado);
            }

            //Encontrar el primer cero
            int cero = -1;

            for (int i = 0; i < m.Length; i++)
            {
                if (m[i] == 0)
                {
                    Console.WriteLine("El primer cero está en la posición" + i);
                    break;
                }
            }
            if (cero == -1)
            {
                Console.WriteLine("No hay ceros :(");
            }








            Console.ReadLine();

        }
    }
}
