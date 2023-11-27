using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correción_Examen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ejercicio;
            do
            {
                //Bucle Do While
                Console.WriteLine("Intro ejercicio 1 - 4");
                ejercicio = int.Parse(Console.ReadLine());

                //Selección ejercicio
                switch (ejercicio)
                {
                    //Ejercicio 1
                    case 1:
                        int i = 500;
                        while (i >= 100)
                        {
                            Console.Write(i + " ");
                            i -= 100;
                        }

                        i = 13;
                        while (i <= 25)
                        {
                            Console.Write(i + " ");
                            i += 2;
                        }
                        break;

                    //Ejercicio 2
                    case 2:

                        break;
                }

            }
            while (ejercicio < 1 || ejercicio > 4);

            Console.ReadLine();
        }
    }
}
