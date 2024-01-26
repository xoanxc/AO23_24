using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String frase = "El Celta cae derrotado nuevamente";


            //Un String es en realidad un array de caracteres
            //Cada caracter tiene asignado un indice
            //Pero los String no se pueden modificar
            char primerCaracter = frase[0];
            char ultimoCaracter = frase[frase.Length - 1];

            //Como recorro un string
            int contadorAes;
            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == 'a')
                {
                    
                }
;
            }
            //indexOf --> Que posición ocupa un determinado caracter
            int posPrimerEspacio = frase.IndexOf(' ');
            //Buscar la posicion de la primera a despues de un espacio
            int posicion = frase.IndexOf('a', posPrimerEspacio);

            char[] vocales = { 'a', 'e', 'i' };
            int posPrimeraVocal = frase.IndexOfAny(vocales);

            //Substring --> Obtiene una subcadena del string principal
            String subCadena = frase.Substring(posPrimerEspacio + 1);
            Console.WriteLine("SubCadena: " + subCadena);
            Console.ReadLine();
        }
    }
}
