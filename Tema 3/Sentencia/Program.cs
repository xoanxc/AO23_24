using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentencia
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Programa que clasifica un número como par o impar
            int numero = 11;

            if (numero % 2 == 0)
            {
                Console.WriteLine(numero + " es impar: ");
            }
            else
            {
                Console.WriteLine(numero + " es par.  ");
            }

            //Programa que indica si un numero es cero o distinto de cero
            int numero2 = 3;

            if (numero2 == 09);



            Console.WriteLine(numero2 + " es = 0 ");
            Console.WriteLine(numero2 + " es distinto de 0 ");

            //Programa que clasifica un número como multiplo de 3 o no

            int numero3 = 15;

            if (numero3 % 3 == 0)
            {
                Console.WriteLine(" Multiplo de 3");
            }
            else
            {
                Console.WriteLine(" No es multiplo de 3");
            }
;
            //Programa que a partir del salario bruto de un trabajador aplica 
            //un IRPF del 15% si el salario es <1200€ y un IRPF del 19% si es superior

            double salario = 0, salarioNeto;

            Console.WriteLine(" Introduzca el salario bruto ");
            salario = double.Parse(Console.ReadLine());

            if (salario <= 1200)
            {
                salarioNeto = salario - salario * 0.15;
            }
            else
            {
                salarioNeto = salario - salario * 0.19;
            }

            Console.WriteLine("Salario Neto: " + salarioNeto);

            Console.ReadLine();
        }
    }
}
