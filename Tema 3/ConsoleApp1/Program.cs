using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Dos tipos de conevrsiones: implícitas y explícitas:
            Implícitas: Pasamos un valor de una variable de menor capacidad a otra
            de mayor capacidad*/

            byte n1 = 9;
            short n1copia = n1;
            int n1copia2 = n1copia;

            float n2 = 4.5f;
            double n2copia = n2;

            /*Explícitas: Pasamos un valor de una variable de mayor capaidad
            a otra de menor capacidad*/
            int numero1 = 2400;
            short numero1Copia = (short)numero1;
            short numero1Copia2 = Convert.ToInt16(numero1);

            double numero2 = 5.678;
            float numero2Copia = (float)numero2;
            float numero2Copia2 = Convert.ToSingle(numero2);



            /*Son Inseguras
            Overflow y perdida de precisión*/


           /*short n3 = 300;
           byte n3Copia = (byte)n3;*/


        }
    }
}
