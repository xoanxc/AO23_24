using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_EjemploFunciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letra = 's';
            char caracter = ' ';
            char caracter2 = '4';

            int letraInt = Convert.ToInt32(letra);
            int caracterInt = Convert.ToInt32(caracter);
            int caracter2Int = Convert.ToInt32(caracter2);

            Console.WriteLine(letra + " : " + letraInt);
            Console.WriteLine(caracter + " : " + caracterInt);
            Console.WriteLine(caracter2 + " : " + caracterInt);

            //Funciones de clase Char
            bool mayusculas = char.IsUpper('W');
            bool mayucula = char.IsLower('W');
            bool digito = char.IsDigit('4');
            bool letraA = char.IsLetter('4');
            char minuscula2 = char.ToLower(letra); //No modifica la variable letra, genera otro char con el caracter minúscula 





            Console.ReadLine();
        }
    }
}
