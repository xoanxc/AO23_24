using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ConexionFicheros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String ruta = Directory.GetCurrentDirectory();
            String rutaFichero = ruta + "\\series.txt";

            //Recuperar datos del fichero
            String[] series = new String[100];

            StreamReader lector;

            try
            { 
                lector = new StreamReader(rutaFichero);

                int posicion = 0;
                String registro = "";

                while(registro != null)
                {
                    registro = lector.ReadLine();
                    series[posicion] = registro;
                    posicion++;
                }
                lector.Close();

            }
            catch (IOException e)
            { 
                //Console.WriteLine("El fichero no existe"); 
                if(!File.Exists(rutaFichero))
                {
                    File.Create(rutaFichero);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            byte opcion = 0;

            do
            { 
            Console.WriteLine("Escoja una opción");
            Console.WriteLine("1.Introdudir una nueva serie");
            Console.WriteLine("2.Consultar catálogo");
            Console.WriteLine("3.Buscar serie");
            Console.WriteLine("4.Ver series por platarforma");
            Console.WriteLine("5.Salir del programa");
            opcion = byte.Parse(Console.ReadLine());

                switch(opcion)
                {
                    case 1:
                        Console.WriteLine("Introduzca título");
                        String titulo = Console.ReadLine();
                        Console.WriteLine("Intro plataforma");
                        String plataforma = Console.ReadLine();

                        //Escribimos registro
                        StreamWriter escritor = new StreamWriter(rutaFichero, true);
                        escritor.WriteLine(titulo + "*" + plataforma);
                    
                        escritor.Close();


                        //Actualizar el array de series local
                        for(int i = 0; i < series.Length; i++)
                            if(series[i] == null)
                            {
                                series[i] = titulo + "*" + plataforma;
                                break;
                            }

                        break;
                    case 2:
                        //Consulatr el registro -- Consultamos el array local de series
                        foreach(String s in series)
                        {
                            if(s != null)
                            {
                                Console.WriteLine(s);
                            }
                            else
                            {
                                break;
                            }
                        }

                        break;
                    case 3:
   
                        break;
                    case 4:
                        break;
                    default:
                        break;
                }

            } while (opcion <= 5) ;




            Console.WriteLine("El programa se sigue ejecutando");
            Console.ReadLine();


        }
    }
}
