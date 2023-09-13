using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Mandar por consola un mensaje:
            Console.WriteLine("Me lo paso genial en clase de programación");

            /* Vamos a ver otros metodos 
             * y propiedades de la clase console
             */
            //Cambiar el color del texto
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Alucinante");
            //Cambiar el titulo de la ventana
            Console.Title = "Mi primer programa";

            Console.Beep(22000, 2000);

            //Evitar que se cierre la consola hasta que el usuario pulse enter
            Console.ReadLine();
        }//Cierra el método Main
    }//Cierra la clase
}//Cierra el Namespace
