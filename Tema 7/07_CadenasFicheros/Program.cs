using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_CadenasFicheros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ");
            char opcion;
            do
            {
                Console.WriteLine("Selecciona un ejercicio entre 1 y 26");
                byte ejercicio = byte.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (ejercicio)


                {
                    //Ejercicio 1
                    case 1:

                        break;

                    //Ejercicio 2
                    case 2:
                        break;

                    //Ejercicio 3
                    case 3:
                        break;

                    //Ejercicio 4
                    case 4:
                        break;

                    //Ejercicio 5
                    case 5:
                        break;

                    //Ejercicio 6
                    case 6:
                        break;

                    //Ejercicio 7
                    case 7:
                        break;

                    //Ejercicio 8
                    case 8:
                        break;


                    //Ejercicio 9
                    case 9:
                        break;

                    //Ejercicio 10
                    case 10:
                        break;

                    //Ejercicio 11
                    case 11:
                        break;

                    //Ejercicio 12
                    case 12:
                        break;

                    //Ejercicio 13
                    case 13:
                        break;

                    //Ejercicio 14
                    case 14:
                        break;

                    //Ejercicio 15
                    case 15:
                        break;

                    //Ejercicio 16
                    case 16:
                        break;

                    //Ejercicio 17
                    case 17:
                        break;

                    //Ejercicio 18
                    case 18:
                        break;

                    //Ejercicio 19
                    case 19:
                        break;

                    //Ejercicio 20
                    case 20:
                        break;

                    //Ejercicio 21
                    case 21:
                        break;

                    //Ejercicio 22
                    case 22:
                        break;

                    //Ejercicio 23
                    case 23:
                        break;

                    //Ejercicio 24
                    case 24:
                        break;

                    //Ejercicio 25
                    case 25:
                        break;

                    //Ejercicio 26
                    case 26:

                        //Menu de toda la vida
                        Console.WriteLine("Menu:");
                        Console.WriteLine("1. Mostrar registros");
                        Console.WriteLine("2. Insertar nuevo registro");
                        Console.WriteLine("3. Consultar por DNI");
                        Console.WriteLine("4. Mostrar registros cuyo salario sea superior a 2500€");
                        Console.WriteLine("5. Modificar registro");
                        Console.WriteLine("6. Eliminar registro");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("7. Mostrar registros ordenados por salario (de menor a mayor)");
                        Console.WriteLine("8. Salir");
                        byte menu26 = byte.Parse(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.White;

                        switch (menu26)
                        {
                            //1.Mostrar registros
                            case 1:

                                break;

                            //2.Insertar nuevo registro
                            case 2:

                                break;

                            //3.Consultar por DNI
                            case 3:
                                break;

                            //4.Mostrar registros cuyo salario sea superior a 2500€
                            case 4:

                                break;

                            //5.Modificar registro
                            case 5:

                                break;

                            //6. Eliminar registro
                            case 6:

                                break;

                            //7.Mostrar registros ordenados por salario (de menor a mayor)
                            case 7:

                                break;

                            //8.Salir
                            case 8:
                                //Aquí no hay que poner nada
                                break;
                        }
                        break;

                }



                Console.WriteLine();
                Console.WriteLine("¿Desea volver al menú inicial? s/n");
                opcion = char.ToLower(char.Parse(Console.ReadLine()));

            }
            while (opcion == 's');
        }
    }
}
