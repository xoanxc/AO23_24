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

                                //Introduzco el dni
                                Console.WriteLine("Introduce el dni:");
                                string dniE = Console.ReadLine(); //Dni Eliminar

                                //Compruebo si el dni ya está almacenado   
                                if (dni.ContainsKey(dniE))
                                {
                                    //Introduzco el nombre
                                    Console.WriteLine("Introduce el nombre:");
                                    string nombreI = Console.ReadLine(); //Nombre Introducido

                                    //Elimino el DNI y el nombre del diccionario
                                    dni.Remove(dniE);          
                                }
                                else
                                {
                                    Console.WriteLine("El DNI no está almacenado");
                                }
                                break;

                            case 3: //Mostrar dnis:

                                //Muestro los dnis almacenados
                                foreach (KeyValuePair<string, string> dniM in dni)
                                {
                                    Console.WriteLine("DNI: " + dniM.Key + " Nombre: " + dniM.Value);
                                }
                                break;
                                
                                

                            case 4: //Buscar dnis:

                                //Introduzco el dni
                                Console.WriteLine("Introduce el dni:");
                                string dniB = Console.ReadLine(); //Dni Buscar

                                //Compruebo si el dni ya está almacenado
                                if (dni.ContainsKey(dniB))
                                {
                                    //Muestro el nombre asociado al dni
                                    Console.WriteLine("El nombre asociado al DNI " + dniB + " es: " + dni[dniB]);
                                }
                                else
                                {
                                    Console.WriteLine("El DNI no está almacenado");
                                }
                                break;

                            case 5: //Contar dnis.

                                //Muestro el número de dnis almacenados
                                Console.WriteLine("El número de DNI's almacenados es: " + dni.Count);

                                break;

                            default:
                                Console.WriteLine("ERROR");
                                break;
                        }
                        break;

                      
                    case 4: //4.Crear un diccionario que permita almacenar los estados de USA junto con su ciudad capital. Inicializarlo con 15 valores. A continuación mostrar un menú que permita al usuario:

                        //Creación del diccionario
                        Dictionary<string, string> estados = new Dictionary<string, string>(15);

                        //Añado los estados y sus capitales al diccionario
                        estados.Add("Alabama", "Montgomery");
                        estados.Add("Alaska", "Juneau");
                        estados.Add("Arizona", "Phoenix");
                        estados.Add("Arkansas", "Little Rock");
                        estados.Add("California", "Sacramento");
                        estados.Add("Colorado", "Denver");
                        estados.Add("Connecticut", "Hartford");
                        estados.Add("Delaware", "Dover");
                        estados.Add("Florida", "Tallahassee");
                        estados.Add("Georgia", "Atlanta");


                        //Menú
                        Console.WriteLine("1.Buscar capital de un estado en concreto");
                        Console.WriteLine("2.Mostrar el estado al que pertenece una determinada capital");
                        Console.WriteLine("3.Introducir un nuevo estado con su capital.");
                        Console.WriteLine("4.Mostrar los estados ordenados alfabéticamente.");
                        Console.WriteLine("5.Eliminar un determinado estado junto con su capital.");
                        byte opcion4 = byte.Parse(Console.ReadLine());

                        switch(opcion4)
                        {
                            case 1: //a)Buscar capital de un estado en concreto

                                //Introduzco el estado
                                Console.WriteLine("Introduce el estado:");
                                string estadoB = Console.ReadLine(); //Estado Buscar

                                //Compruebo si el estado ya está almacenado
                                if (estados.ContainsKey(estadoB))
                                {
                                    //Muestro la capital asociada al estado
                                    Console.WriteLine("La capital de " + estadoB + " es: " + estados[estadoB]);
                                }
                                else
                                {
                                    Console.WriteLine("El estado no está almacenado");
                                }     
                                break;

                            case 2: //b)Mostrar el estado al que pertenece una determinada capital

                                //Introduzco la capital
                                Console.WriteLine("Introduce la capital:");
                                string capitalB = Console.ReadLine(); //Capital Buscar

                                //Compruebo si la capital ya está almacenada
                                if (estados.ContainsValue(capitalB))
                                {
                                    //Muestro el estado asociado a la capital
                                    foreach (KeyValuePair<string, string> estadoM in estados)
                                    {
                                        if (estadoM.Value == capitalB)
                                        {
                                            Console.WriteLine("La capital " + capitalB + " pertenece al estado de " + estadoM.Key);
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("La capital no está almacenada");
                                }
                                break;

                            case 3: //c)Introducir un nuevo estado con su capital.

                                //Introduzco el estado
                                Console.WriteLine("Introduce el estado:");
                                string estadoI = Console.ReadLine(); //Estado Introducir

                                //Compruebo si el estado ya está almacenado
                                if (estados.ContainsKey(estadoI))
                                {
                                    Console.WriteLine("El estado ya está almacenado");
                                }
                                else
                                {
                                    //Introduzco la capital
                                    Console.WriteLine("Introduce la capital:");
                                    string capitalI = Console.ReadLine(); //Capital Introducir

                                    //Añado el estado y la capital al diccionario
                                    estados.Add(estadoI, capitalI);
                                }
                                break;

                            case 4: //d)Mostrar los estados ordenados alfabéticamente.

                                //Muestro los estados ordenados alfabéticamente
                                foreach (KeyValuePair<string, string> estadoM in estados.OrderBy(key => key.Key))
                                {
                                    Console.WriteLine("Estado: " + estadoM.Key + " Capital: " + estadoM.Value);
                                }



                                break;


                            case 5: //e)Eliminar un determinado estado junto con su capital.

                                //Introduzco el estado
                                Console.WriteLine("Introduce el estado:");
                                string estadoE = Console.ReadLine(); //Estado Eliminar

                                //Compruebo si el estado ya está almacenado
                                if (estados.ContainsKey(estadoE))
                                {
                                    //Elimino el estado y la capital del diccionario
                                    estados.Remove(estadoE);
                                }
                                else
                                {
                                    Console.WriteLine("El estado no está almacenado");
                                }
                                break;


                            default:
                                Console.WriteLine("ERROR");
                                break;
                        }


                        break;

                    case 5: //5.Crear un diccionario cuya clave sea un Integer y el valor sea un String. Este diccionario servirá para almacenar los datos de los clientes de una determinada empresa. De cada cliente hay que almacenar: 

                        //Creación del diccionario
                        Dictionary<int, string> clientes = new Dictionary<int, string>();

                        //Almacenar por cada cliente: DNI , Nombre, Edad y correo electrónico.
                        clientes.Add(1, "12345678A, Juan, 25, juanmagan@gmail.com");
                        clientes.Add(2, "87654321B, Maria, 30, marcosamigui@gmail.com");
                        clientes.Add(3, "13579246C, Pepe, 40, alvarokj@gmail.com");

                        //Menú
                        Console.WriteLine("1.Guardar clientes asignándole una clave.");
                        Console.WriteLine("2.Mostrar clientes.");
                        Console.WriteLine("3.Buscar cliente a partir de la clave.");
                        Console.WriteLine("4.Eliminar cliente a partir de la clave.");
                        byte opcion5 = byte.Parse(Console.ReadLine());

                        switch(opcion5)
                        {
                            case 1:
                                //a)Guardar clientes asignándole una clave.
                                Console.WriteLine("Introduce una clave:");
                                int clave = int.Parse(Console.ReadLine());

                                //Solciito el DNI
                                Console.WriteLine("Introduce el DNI:");
                                string dni5 = Console.ReadLine();

                                //Solicito el nombre
                                Console.WriteLine("Introduce el nombre:");
                                string nombre5 = Console.ReadLine();

                                //Solicito la edad
                                Console.WriteLine("Introduce la edad:");
                                int edad5 = int.Parse(Console.ReadLine());

                                //Solicito el correo electrónico
                                Console.WriteLine("Introduce el correo electrónico:");
                                string correo5 = Console.ReadLine();

                                //Construyo el string con los datos del cliente
                                clientes.Add(clave, dni5 + ", " + nombre5 + ", " + edad5 + ", " + correo5);

                                break;
                                
                            case 2:

                                //b)Mostrar clientes.
                                foreach (KeyValuePair<int, string> clienteM in clientes)
                                {
                                    Console.WriteLine("Clave: " + clienteM.Key + " Datos: " + clienteM.Value);
                                }

                                break;

                            case 3:

                                //c)Buscar cliente a partir de la clave.
                                Console.WriteLine("Introduce la clave:");
                                int claveB = int.Parse(Console.ReadLine());

                                //Compruebo si la clave ya está almacenada
                                if (clientes.ContainsKey(claveB))
                                {
                                    //Muestro los datos del cliente asociados a la clave
                                    Console.WriteLine("Datos del cliente: " + clientes[claveB]);
                                }
                                else
                                {
                                    Console.WriteLine("La clave no está almacenada");
                                }

                                break;
                            case 4:

                                //d)Eliminar cliente a partir de la clave.

                                //Introduzco la clave
                                Console.WriteLine("Introduce la clave:");
                                int claveE = int.Parse(Console.ReadLine()); //Clave Eliminar

                                //Compruebo si la clave ya está almacenada
                                if (clientes.ContainsKey(claveE))
                                {
                                    //Elimino el cliente del diccionario
                                    clientes.Remove(claveE);
                                }
                                else
                                {
                                    Console.WriteLine("La clave no está almacenada");
                                }

                                break;
                        }

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
