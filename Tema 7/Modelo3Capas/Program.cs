using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Modelo3Capas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String ruta = Directory.GetCurrentDirectory();
            String rutaFichero = ruta + @"\series.txt";

            String[] registros = new String[100];

            //Resuperar la info del fichero series.txt
            StreamReader lector = new StreamReader(rutaFichero);

            String registro = "";
            int posicion = 0;

            while(registros != null)
            {
                registro = lector.ReadLine();

                //Guardar el registro en la priemra posición vacia de la matriz
                registros[posicion] = registro;
                posicion++;
            }


            lector.Close();

            //Mostrar por pantalla la matriz de string
            foreach(String reg in registros)
            {
                if (reg != null)
                { 
                    Console.WriteLine(reg);
                }
            }

            byte opcion = 1;
            switch(opcion)
            {
                case 1:
                    StreamWriter escritor = new StreamWriter(rutaFichero, true);
                    Console.WriteLine("Introduzca su serie: ");
                    string serie = Console.ReadLine();
                    Console.WriteLine("En que plataforma se emite?");
                    string plataforma = Console.ReadLine();
                    escritor.WriteLine(serie + "*" + plataforma);

                    escritor.Close();
                    break;
                case 2:
                    //Ver serie de una determinada plataforma:
                    String platform;
                    Console.WriteLine("De qué plataforma quieres obtener información: ");
                    plataforma = Console.ReadLine();

                    //Cuantas series hay y listarlas:

                    break;

            }

            

            Console.ReadLine();

        }
    }
}
