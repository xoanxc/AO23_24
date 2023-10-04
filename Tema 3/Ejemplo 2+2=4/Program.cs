using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_2_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numero = 10;
            //calcular a raíz cuadrada
            float raiz = (float)Math.Sqrt(numero);

            //calcular la enesima -- Math.Pow(base,1/n)
            float raizCubica = (float)Math.Pow(numero, 1 / 3);

            //calcular potencia
            int x = 9;
            int y = 4;

            //x elevado a y
            long potencia = (long)Math.Pow(x, y);

            //redondeo de valores
            float valor = 4.52f;

            float valorIntmenor = (float)Math.Floor(valor);

            Console.WriteLine(valor +  " redondeado a " + valorIntmenor);

            float valorIntmayor = (float)Math.Ceiling(valor);

            float valorIntCercano = (float)Math.Round(valor);
            Console.WriteLine(valor + " redondeo cercano " + valorIntCercano);

            Console.ReadLine();


        }
    }
}
