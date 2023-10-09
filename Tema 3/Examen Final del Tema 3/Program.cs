using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alonsofernandez_xoan
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Titulo de la consola Examen Xoán Alonso Fernández
            Console.Title = "Examen Xoán Alonso Fernández";


            //(***Ejercicio 2***) - Xoán Alonso Fernández

            //Mostrar ejercicio
            Console.WriteLine("(***Ejercicio 2***)");
            Console.WriteLine();

            //Recogida de Datos 1
            Console.WriteLine("Precio al que se paga la hora: ");
            float salario = float.Parse(Console.ReadLine());

            //Espacio
            Console.WriteLine();

            //Recogida de Datos 2
            Console.WriteLine("Horas Trabajadas semanales: ");
            float horas = float.Parse(Console.ReadLine());

            //Espacio
            Console.WriteLine();

            //Recogida de Datos 3
            Console.WriteLine("Porcentaje de IRPF: ");
            float irpf = float.Parse(Console.ReadLine());

            //Espacio
            Console.WriteLine();

            //Calculos
            float horasTotales = (horas * 4);
            float salarioBruto = (horasTotales * salario);
            float salarioNeto = ((salarioBruto / 100) * (100 - irpf));

            //Mostrar resultado
            Console.WriteLine("En un mes has trabajado " + horasTotales + " horas, tu salario bruto a sido de " + salarioBruto + " euros y el neto de " + salarioNeto + " euros");

            //Espacio
            Console.WriteLine();


            //(***Ejercicio 3***) - Xoán Alonso Fernández

            //Mostrar ejercicio
            Console.WriteLine("(***Ejercicio 3***)");
            Console.WriteLine();

            //Solicitud del valor 1
            Console.WriteLine("Introduzca un valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            //Raíz del Numero
            double raiz = Math.Sqrt(valor1);

            //Numero elevado de la sexta
            double potencia = Math.Pow(valor1, 6);

            //Almacenar el valor en una variable short
            short variableShort = (short)valor1;

            //Calculo del 20% del numero guardado en float
            float valornum20 = ((valor1/100) * 20);

            //Aumentar su valor en un 35%
            float valornum35 = ((valor1/100) * 135);

            //Mostrar por pantalla el resultado
            Console.WriteLine("La raíz del numero es " + raiz + " el valor almacenado en short es " + variableShort + ", el 20% del numero es " + valornum20 + " y su valor aumentado en un 35% es " + valornum35);

            //Esoacio
            Console.WriteLine();

            //Agradecimiento al Grandisimo Ramon
            Console.WriteLine("Gracias por su corrección :)");

            //Evitar que se cierre la consola
            Console.ReadLine();
        }
    }
}
