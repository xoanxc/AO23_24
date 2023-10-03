using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float horas, tasa, salarioBruto;
            float irpf, salarioNeto;

            Console.Write("Introduzca horas trabajadas: ");
            horas = float.Parse(Console.ReadLine());

            Console.Write("Introduzca el precio hora: ");
            tasa = float.Parse(Console.ReadLine());
            Console.WriteLine("Que IRPF desea aplicar?");
            irpf = float.Parse(Console.ReadLine());


            salarioBruto = horas * tasa;
            salarioNeto = salarioBruto - (irpf * salarioBruto) / 100;

            Console.WriteLine("Salario Bruto: " + salarioBruto);
            Console.WriteLine("Salario Neto: " + salarioNeto);

            Console.ReadLine();






        }
    }
}
