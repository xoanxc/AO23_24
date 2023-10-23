using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentencia_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char opcion;
            char continuar;

            do
            {


                Console.WriteLine("Escoge una opción:");
                Console.WriteLine("a) Saludar");
                Console.WriteLine("b) Animar");
                Console.WriteLine("c) Despedir");
                opcion = Char.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 'a':
                        Console.WriteLine("Hola!!!");
                        break;
                    case 'b':
                        Console.WriteLine("Vamos !!!");
                        break;
                    case 'c':
                        Console.WriteLine("Hasta la próxima !!!");
                        break;

                    default:
                        Console.WriteLine("Te has equivocado");
                        break; //Opcional
                }
                Console.WriteLine("Quiere volver al menú: s/n");
                continuar = Char.Parse(Console.ReadLine());
                //continuar = Console.ReadKey().KeyChar; //Otra forma de hacerlo sin presionar enter

            }

            while (continuar == 's');
            }
    }
}
