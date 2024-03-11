using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Boletin_Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" ");
            char opcion;
            do
            {
                Console.WriteLine("Selecciona un ejercicio entre 1 y 6");
                byte ejercicio = byte.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (ejercicio)


                {
                    case 1: //1.Crea una lista y llénala con valores aleatorios entre 1 y 25. Muestra por pantalla la siguiente información: 

                        //Inicializo la lista y le doy capacidad de 15
                        List<int> list = new List<int>(15); //Puedo no poner el 15 y la capacidad se adaptara

                        Random gen1 = new Random();

                        for (int i = 0; i < 15; i++)
                        {
                            //Añado números aleatorios a la lista
                            list.Add(gen1.Next(1, 26));
                        }

                        //Muestro la lista
                        Console.WriteLine("Lista de números generados aleatoriamente: ");
                        foreach (int num in list)
                        {
                            Console.Write(num + " ");
                        }
                        Console.WriteLine();
                        Console.WriteLine();

                        //a) Posición en la que se encuentra el valor 2.
                        Console.WriteLine("a.Posición en la que se encuentra el valor 2.");



                        //Si la lista contiene un 2, muestro la posición
                        if (list.Contains(2))
                        {
                            //Almaceno la posicion de la primera aparicion del número 2
                            int posicion = list.IndexOf(2);

                            //Musestro la posición del 2
                            Console.WriteLine("El número 2 se encuentra en la posición " + posicion);
                        }
                        else
                        {
                            Console.WriteLine("El número 2 no se encuentra en la lista");
                        }
                        Console.WriteLine();


                        //b) Calcular la suma de los valores generados.
                        Console.WriteLine("b) Calcular la suma de los valores generados.");

                        //Sumo los valores de la lista
                        int suma = 0;
                        foreach (int num in list)
                        {
                            suma += num;
                        }
                        Console.WriteLine("La suma de los valores generados es: " + suma);
                        Console.WriteLine();

                        //c) Calcular la media de valores generados.
                        Console.WriteLine("c) Calcular la media de valores generados.");

                        //Calculo la media
                        double media = (double)suma / list.Count; //Es lo mismo dividirlo entre 15, pero mas PRO
                        Console.WriteLine("La media de los valores generados es: " + media);
                        Console.WriteLine();

                        //d) Calcular el porcentaje de números superiores a 20 almacenados en la lista.
                        Console.WriteLine("d) Calcular el porcentaje de números superiores a 20 almacenados en la lista.");

                        //Contar los números superiores a 20
                        int contador = 0;
                        foreach (int num in list)
                        {
                            if (num > 20)
                            {
                                contador++;
                            }
                        }

                        //Calculo el porcentaje
                        double porcentaje = (double)contador / list.Count * 100;

                        //Muestro y redondeo el porcentaje a dos decimales
                        Console.WriteLine("El porcentaje de números superiores a 20 es: " + Math.Round(porcentaje, 2) + "%");
                        Console.WriteLine();

                        //e) Mostrar los valores que están almacenados, sin mostrar las repeticiones.
                        Console.WriteLine("e) Mostrar los valores que están almacenados, sin mostrar las repeticiones.");

                        //Creo un HashSet para almacenar los valores sin repeticiones
                        HashSet<int> set = new HashSet<int>(list);

                        //Muestro los valores sin repeticiones
                        foreach (int num in set)
                        {
                            Console.Write(num + " ");
                        }
                        Console.WriteLine();

                        break;

                    case 2: //2.Crear una aplicación que permita realizar las siguientes operaciones al usuario:


                        //Creación de las listas 
                        List<string> tareasP = new List<string>(); //Tareas Pendientes
                        List<string> tareasC = new List<string>(); //Tareas Completadas

                        //Menú
                        Console.WriteLine("1.Introducir tarea");
                        Console.WriteLine("2.Eliminar tarea");
                        Console.WriteLine("3.Contar tareas pendientes");
                        Console.WriteLine("4.Mostrar tareas pendientes");
                        Console.WriteLine("5.Monstrar tareas completadas");
                        byte opcion2 = byte.Parse(Console.ReadLine());

                        switch (opcion2)
                        {
                            case 1:

                                //a) Introducir tarea
                                Console.WriteLine("Introduce la tarea:");
                                tareasP.Add(Console.ReadLine());

                                break;

                            case 2:

                                //b) Completar tarea: Elimina esa tarea y la pasa a una lista donde se almacenan las tareas completadas
                                Console.WriteLine("Introduce la tarea que deseas completar:");
                                string tareaS = Console.ReadLine(); //Tarea Seleccionada

                                if (tareasP.Contains(tareaS))
                                {
                                    tareasP.Remove(tareaS);
                                    tareasC.Add(tareaS);
                                }
                                else
                                {
                                    Console.WriteLine("La tarea no se encuentra en la lista de tareas pendientes");
                                }
                                break;

                            case 3:

                                //c) Contar tareas pendientes
                                Console.WriteLine("El número de tareas pendientes es: " + tareasP.Count);

                                break;
                            case 4:

                                //d) Mostrar tareas pendientes
                                Console.WriteLine("Tareas pendientes:");

                                //Muestro las tareas pendientes
                                foreach (string tareaM in tareasP) //Tarea Mostrada
                                {
                                    Console.WriteLine(tareaM);
                                }
                                break;

                            case 5:
                                //e) Mostrar tareas completadas
                                Console.WriteLine("Tareas completadas:");

                                //Muestro las tareas completadas
                                foreach (string tareaM in tareasC) //Tarea Mostrada
                                {
                                    Console.WriteLine(tareaM);
                                }
                                break;

                            default: //ERROR
                                Console.WriteLine("ERROR");
                                break;
                        }
                        break;

                    case 3: //3.Crear una aplicación que permita realizar las siguientes operaciones:

                        //Creación del diccionario
                        Dictionary<string, string> dni = new Dictionary<string, string>();
                        

                        //Menú
                        Console.WriteLine("1.Guardar DNI:"); //En caso de que ya esté almacenado, no se guarda.
                        Console.WriteLine("2.Eliminar DNI:");
                        Console.WriteLine("3.Mostrar DNI's:");
                        Console.WriteLine("4.Buscar DNI's:");
                        Console.WriteLine("5.Constar DNI's");
                        byte opcion3 = byte.Parse(Console.ReadLine());

                        switch(opcion3)
                        {
                            case 1: //Guardar dni: En caso de que el dni ya esté almacenado no se guarda.
                                
                                //Introduzco el dni
                                Console.WriteLine("Introduce el dni:");
                                string dniI = Console.ReadLine(); //Dni Introducido

                                //Compruebo si el dni ya está almacenado   
                                if (dni.ContainsKey(dniI))
                                {
                                    Console.WriteLine("El DNI ya está almacenado");
                                }
                                else
                                {
                                    //Introduzco el nombre
                                    Console.WriteLine("Introduce el nombre:");
                                    string nombreI = Console.ReadLine(); //Nombre Introducido

                                    //Añado el DNI y el nombre al diccionario
                                    dni.Add(dniI, nombreI);
                                }


                                break;

                            case 2: //Eliminar dni:

                                


                                break;

                            case 3: //Mostrar dnis:

                                break;

                            case 4: //Buscar dnis:

                                break;

                            case 5: //Contar dnis.

                                break;

                            default:
                                Console.WriteLine("ERROR");
                                break;
                        }
                        break;

                      
                    case 4: //4.Crear un diccionario que permita almacenar los estados de USA junto con su ciudad capital. Inicializarlo con 15 valores. A continuación mostrar un menú que permita al usuario:

                        break;

                    case 5: //5.Crear un diccionario cuya clave sea un Integer y el valor sea un String. Este diccionario servirá para almacenar los datos de los clientes de una determinada empresa. De cada cliente hay que almacenar: 
                        break;

                    case 6: //6.Crear una aplicación que permita asociar a un dni una lista de productos. Los Productos son Strings que almacenan la siguiente información:

                        //Menú
                        Console.WriteLine("1.Mostrar por pantalla la compra de un determinado cliente.");
                        Console.WriteLine("2.Eliminar un producto de la compra de un cliente.");
                        Console.WriteLine("3.Añadir un producto a la compra de un cliente.");
                        byte opcion6 = byte.Parse(Console.ReadLine());

                        switch(opcion6)
                        {
                            case 1: //a)Mostrar por pantalla la compra de un determinado cliente.

                                break;

                            case 2: //b)Eliminar un producto de la compra de un cliente.
                                break;

                            case 3: //c)Añadir un producto a la compra de un cliente.
                                break;

                            default:
                                Console.WriteLine("ERROR");
                                break;
                        }
                        break;

                    default: //ERROR
                        Console.WriteLine("ERROR");
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
