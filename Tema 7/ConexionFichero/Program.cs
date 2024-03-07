using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //Nos da los metodos para acceder a los direcctorios

namespace ConexionFichero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String ruta = Directory.GetCurrentDirectory();
            String rutaFichero = ruta + @"\series.txt";
            Console.WriteLine("Ruta actual: " + ruta);

            //Escrubir en un fichero
            StreamWriter escritor = new StreamWriter(rutaFichero, true);

            //escritor.WriteLine("The Wire*HBO");
            //escritor.Close();

            //Leer registros del fichero:

            StreamWriter lector = new StreamWriter(rutaFichero);

            String registro = "";
            Console.WriteLine("Series guardadas en BBDD: ");
            while(registro != null)
            {
                registro = lector.ReadLine();
                if( registro != null )
                {
                    Console.WriteLine(registro);
                }
                
            }





            Console.ReadLine();
        }
    }
}
