using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
                Console.Title = " Ejercicios 1 al 26 - By Xoán Alonso";
                Console.WriteLine("Selecciona un ejercicio entre 1 y 26");
                byte ejercicio = byte.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (ejercicio)


                {
                    //Ejercicio 1
                    case 1:

                        string[] matricula = new string[10];

                        matricula[0] = "1518-GHC";
                        matricula[1] = "7349-JKN";
                        matricula[2] = "5318-LHT";
                        matricula[3] = "7143-DFG";
                        matricula[4] = "1500-DFL";
                        matricula[5] = "4178-HNZ";
                        matricula[6] = "9123-PLD";
                        matricula[7] = "3481-THZ";
                        matricula[8] = "6891-TCG";
                        matricula[9] = "3419-SSR";

                        //Apartado a)
                        Console.WriteLine();
                        Console.WriteLine("a)Mostrar las matrículas que acaban por Z");

                        for (int i = 0; i < matricula.Length; i++)
                        {
                            if (matricula[i].EndsWith("Z"))
                            {
                                Console.WriteLine(matricula[i]);
                            }
                        }

                        //Apartado b)
                        Console.WriteLine();
                        Console.WriteLine("b)Mostrar las matrículas que contienen el número 34");

                        for (int i = 0; i < matricula.Length; i++)
                        {
                            if (matricula[i].Contains("34"))
                            {
                                Console.WriteLine(matricula[i]);
                            }
                        }

                        //Apartado c)
                        Console.WriteLine();
                        Console.WriteLine("Mostrar sólo la parte numérica de las matrículas");

                        //Mostrar los numeros
                        for (int i = 0; i < matricula.Length; i++)
                        {
                            Console.Write("Matricula " + i + ": ");
                            for(int j = 0; j < matricula[i].Length; j++)
                            {
                                if (char.IsDigit(matricula[i][j]))
                                {
                                    Console.Write(matricula[i][j]);
                                }
                            }
                            Console.WriteLine();
                        }

                        //Apartado d)
                        Console.WriteLine();
                        Console.WriteLine("Mostrar sólo la parte de las letras de las matrículas");

                        //Mostrar las letras
                        for (int i = 0; i < matricula.Length; i++)
                        {
                            Console.Write("Matricula " + i + ": ");
                            for (int j = 0; j < matricula[i].Length; j++)
                            {
                                if (char.IsLetter(matricula[i][j]))
                                {
                                    Console.Write(matricula[i][j]);
                                }
                            }
                            Console.WriteLine();
                        }

                        //Apartado e)
                        Console.WriteLine();
                        Console.WriteLine("Volcar los datos de la matriz a un fichero");

                        //Asignar la ruta
                        string ruta = Directory.GetCurrentDirectory();
                        string rutaFichero = ruta + "\\matriculas.txt";
                        StreamWriter fichero = new StreamWriter(rutaFichero);

                        //Volcar los datos
                        for (int i = 0; i < matricula.Length; i++)
                        {
                            fichero.WriteLine(matricula[i]);
                        }
                        fichero.Close(); 

                        break;

                    //Ejercicio 2
                    case 2:

                        //Algoritmo que obtiene el número de veces que aparece un determinado char en un  string. 
                        Console.WriteLine();
                        Console.WriteLine("Algoritmo que obtiene el número de veces que aparece un determinado char en un  string.");

                        //Solicitud de datos
                        Console.WriteLine("Introduce un char");
                        char caracter2 = char.Parse(Console.ReadLine());

                        //Declaración de variables
                        byte contador2 = 0;

                        string texto2 = "IU134BFP38A";

                        //Hace distincion entre mayúsculas y minúsculas
                        for(int i = 0; i < texto2.Length; i++)
                        {
                            if (texto2[i] == caracter2)
                            {
                                contador2++;
                            }
                        }
                        Console.WriteLine("Hay " + contador2 + " \"" + caracter2 + "\" en el string");
                        break;

                    //Ejercicio 3
                    case 3:
  

                        //Declaración de variables
                        bool correcto = false;
                        bool letra = false;
                        bool numero = false;
                        //Array letras DNI
                        char[] letras = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };


                        do
                        {
                            //Solicitud de datos
                            Console.WriteLine("Introduce tu DNI");
                            string dni = Console.ReadLine();

                            //Comprobación cantidad de caracteres
                            if (dni.Length == 9) 
                            {
                                for (int i = 0; i < dni.Length - 1; i++) //Recorrer el DNI
                                {
                                    if (char.IsDigit(dni[i])) //Si los 8 primeros son numeros 
                                    {
                                        numero = true; //Control del bucle
                                    }
                                    else //De lo contrario
                                    {
                                        Console.WriteLine("DNI incorrecto, la parte numerica es incorrecta");
                                        numero = false; //Control del bucle
                                        break;
                                    }
                                }

                                if (char.IsLetter(dni[8]))
                                {
                                    letra = true;
                                }
                                else
                                {
                                    Console.WriteLine("La parte de la letra es incorrecta");
                                    letra = false;
                                    break;
                                }
                                //Si hasta aquí todo fue correcto, procedemos a la comprobación final
                                if (letra == true && numero == true)
                                {
                                    //Comprobación del numero 
                                    int numero3 = Convert.ToInt32(dni.Substring(0, 8));

                                    int restoDiv = numero3 % 23;

                                    if (dni[8] == letras[restoDiv])
                                    {
                                        correcto = true;
                                        Console.WriteLine("Tu DNI es correcto al 100%");
                                    }
                                    else
                                    {
                                        correcto = false;
                                        Console.WriteLine("La letra es incorrecta");
                                    }
                                    
                                }
                            }
                            else
                            {
                                Console.WriteLine("El DNI es incorrecto, su longitud no es la correcta");
                            }

                            
                            


                        }
                        while (correcto == false);



                        break;

                    //Ejercicio 4
                    case 4:

                        Console.WriteLine("Introduce una cadena de texto");
                        string texto4 = Console.ReadLine();

                        string[] troceo4 = texto4.Split(' ');

                        Console.WriteLine();
                        Console.WriteLine("Palabras que comienzan con 'b': ");
                        foreach (string palabra4 in troceo4)
                        {
                            //Ex "palabra4.Length > 0" esto comprueba que la longitud sea mayor a 0, por si colocan doble espacio
                            if (palabra4.Length > 0 && char.ToLower(palabra4[0]) == 'b')
                            {
                                Console.WriteLine(palabra4);
                            }
                        }
                        break;

                    //Ejercicio 5
                    case 5:
                        Console.WriteLine("Introduce un string");
                        string ej5 = Console.ReadLine();

                        if (ej5.Contains("@"))
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                        break;

                    //Ejercicio 6
                    case 6:

                        string ejemplo6 = "abajo, abatida, abacero, antiaereo, formidable, austero, confortable, ramon, roto";
                        string contiene6 = "aba";
                        

                        //Por si introducen mayusculas
                        contiene6 = contiene6.ToLower();

                        //Trozear con split
                        string[] palabras = ejemplo6.Split(' ');

                        //Contador
                        int contar6 = 0;

                        //Contar el número de palabras
                        foreach (string palabracp in palabras)
                        {
                            if (palabracp.Contains(contiene6))
                            {
                                contar6++;
                            }

                        }
                        Console.WriteLine("Enontradas " + contar6 + " palabras que contienen \"" + contiene6 + "\"");

                        Console.WriteLine("Introduce un substring para buscar");
                        contiene6 = Console.ReadLine();
                        //Por si introducen mayusculas
                        contiene6 = contiene6.ToLower();

                        //Reseteo de contar6
                        contar6 = 0;

                        //Contar el número de palabras
                        foreach (string palabracp in palabras)
                        {
                            if (palabracp.Contains(contiene6))
                            {
                                contar6++;
                            }

                        }
                        Console.WriteLine("Enontradas " + contar6 + " palabras que contienen \"" + contiene6 + "\"");
                        break;

                    //Ejercicio 7
                    case 7:
                        Console.WriteLine("Introduce un email valido");
                        string email7 = Console.ReadLine();

                        //En caso de contener un @ se detecta como email
                        if(email7.Contains("@"))
                        {
                            string[] dominio7 = email7.Split('@'); //Troceo el string desde el @
                            Console.WriteLine(dominio7[1]); //Muestro la parte 2 del string
                        }
                        else
                        {
                            Console.WriteLine("Maquina, te dejaste el @");
                        }
                        break;

                    //Ejercicio 8
                    case 8:
                        Console.WriteLine("Introduce un código");
                        string codigo8 = Console.ReadLine();

                        //Verifico si tiene 4 caracteres
                        if (codigo8.Length == 4)
                        {
                            if (char.IsLetter(codigo8[0]) && char.IsLetter(codigo8[1]))
                            {
                                if (char.IsNumber(codigo8[2]) && char.IsNumber(codigo8[3]))
                                {
                                    Console.WriteLine("El formato es correcto");
                                }
                                else
                                {
                                    Console.WriteLine("La parte de numeros es incorrecta");
                                }
                            }
                            else
                            {
                                Console.WriteLine("La parte de letras es incorrecta");
                            }
                        }
                        else
                        {
                            Console.WriteLine("La cantidad de caracteres es incorrecta");
                        }
                        break;


                    //Ejercicio 9
                    case 9:
                        Console.WriteLine("Introduzca un string");
                        string ej9 = Console.ReadLine();

                        //.Replace remplaza el espacio por el asterisco en este caso
                        ej9 = ej9.Replace(" ", "*");

                        Console.WriteLine(ej9);
                        break;

                    //Ejercicio 10
                    case 10:

                        string a10 = "Pedro Jimenez*14Julio1990?2500";
                        string b10 = "Maria Benitez*9070!06Agosto1998";

                        string[] trozoA10 = a10.Split('?');
                        string[] trozoB10 = b10.Split('*', '!');

                        int salario = int.Parse(trozoA10[1]);

                        if (salario > 1000)
                        {
                            Console.WriteLine("El de Pedro Jimenez es " + salario + "€");
                        }

                        salario = int.Parse(trozoB10[1]);

                        if (salario > 1000)
                        {
                            Console.WriteLine("El de Maria Benitez es " + salario + "€");
                        }
                        break;
                    //Ejercicio 11
                    case 11:

                        //Bienvenido al ahorcado
                        Console.Title = "El Ahorcado: Console Edition - By: Xoán Alonso";
                        Console.WriteLine("Bienvenido al ahorcado");
                        Console.WriteLine();

                        //Declaración de variables
                        string[] palabra11 = new string[13];
                        bool easteregg = false;

                        //Palabras
                        palabra11[0] = "mesa";
                        palabra11[1] = "hormiga";
                        palabra11[2] = "cargador";
                        palabra11[3] = "mochila";
                        palabra11[4] = "ordenador";
                        palabra11[5] = "paisaje";
                        palabra11[6] = "competencia";
                        palabra11[7] = "submarino";
                        palabra11[8] = "ahorcado";
                        palabra11[9] = "pez";
                        palabra11[10] = "ladron";
                        palabra11[11] = "ahorcado";
                        palabra11[12] = "huevo";


                        //Monigote
                        Console.WriteLine("¡Salva a Miguel!");
                        Console.WriteLine("_________");
                        Console.WriteLine("|");
                        Console.WriteLine("|");
                        Console.WriteLine("|      (*)");
                        Console.WriteLine("|      /|\\");
                        Console.WriteLine("|      / \\");
                        Console.WriteLine("------------");
                        Console.WriteLine();


                        //Creación de variables copia y random
                        Random gen11 = new Random();
                        int num11 = gen11.Next(0, 13);
                        string palabraActiva = palabra11[num11];
                        char[] cpPalabra11 = new char[palabraActiva.Length];
                        byte fallos11 = 0;

                        //Colocación de asteriscos en copia
                        for(int i = 0; i < cpPalabra11.Length; i++)
                        {
                            cpPalabra11[i] = '*';
                        }
                        Console.WriteLine(cpPalabra11);

                        //Muestro de palabra para desarrollo
                        Console.WriteLine("Palabra que buscar: " + palabraActiva);


                        //Bucle principal
                        do
                        {
                            //Pregunta frecuente
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Introduce una letra:");
                            char letra11 = char.Parse(Console.ReadLine());
                            letra11 = char.ToLower(letra11);
                            Console.WriteLine();

                            //Obra de Arte infravalorada
                            if (char.IsLetter(letra11))
                            {
                                //Si contiene la letra introducida
                                if (palabraActiva.Contains(letra11))
                                {
                                    //Colocamos en la ubicacion la letra (remplazando los asteriscos necesarios=
                                    for (int i = 0; i < palabraActiva.Length; i++)
                                    {
                                        if (palabraActiva[i] == letra11)
                                        {
                                            cpPalabra11[i] = letra11;
                                            
                                        }
                                    }

                                    //Mostramos la ayuda
                                    Console.WriteLine(cpPalabra11);
                                }
                                else
                                {
                                    //Fallos con monigote
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("!Fallaste!");
                                    fallos11++;


                                    if (fallos11 == 1)
                                    {
                                        Console.WriteLine("_________");
                                        Console.WriteLine("|       |");
                                        Console.WriteLine("|      (*)");
                                        Console.WriteLine("|");
                                        Console.WriteLine("|");
                                        Console.WriteLine("|");
                                        Console.WriteLine("------------");
                                    }
                                    if (fallos11 == 2)
                                    {
                                        Console.WriteLine("_________");
                                        Console.WriteLine("|       |");
                                        Console.WriteLine("|      (*)");
                                        Console.WriteLine("|      /|");
                                        Console.WriteLine("|");
                                        Console.WriteLine("|");
                                        Console.WriteLine("------------");
                                    }
                                    if (fallos11 == 3)
                                    {
                                        Console.WriteLine("_________");
                                        Console.WriteLine("|       |");
                                        Console.WriteLine("|      (*)");
                                        Console.WriteLine("|      /|\\");
                                        Console.WriteLine("|");
                                        Console.WriteLine("|");
                                        Console.WriteLine("------------");
                                    }
                                    if (fallos11 == 4)
                                    {
                                        Console.WriteLine("_________");
                                        Console.WriteLine("|       |");
                                        Console.WriteLine("|      (*)");
                                        Console.WriteLine("|      /|\\");
                                        Console.WriteLine("|      /");
                                        Console.WriteLine("|");
                                        Console.WriteLine("------------");
                                    }
                                    if (fallos11 == 5)
                                    {    
                                        Console.WriteLine();
                                        Console.WriteLine("_________");
                                        Console.WriteLine("|       |");
                                        Console.WriteLine("|      (*)");
                                        Console.WriteLine("|      /|\\");
                                        Console.WriteLine("|      / \\");
                                        Console.WriteLine("|");
                                        Console.WriteLine("------------");

                                        Console.WriteLine();
                                        Console.Write("Hasta nunca Miguel");

                                        //Para continuar
                                        Console.ReadLine();

                                    }
                                }
                            }
                            
                            if(!char.IsLetter(letra11))
                            {
                                //Game Over por desobediencia 
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Has introducido un caracter invalido, por tanto ahorcamos a Miguel");
                                Console.WriteLine();
                                Console.WriteLine("_________");
                                Console.WriteLine("|       |");
                                Console.WriteLine("|      (*)");
                                Console.WriteLine("|      /|\\");
                                Console.WriteLine("|      / \\");
                                Console.WriteLine("|");
                                Console.WriteLine("------------");
                                easteregg = true;
                                break;
                            }                        
                        }
                        //El bucle termina cuando no tenemos las asteriscos en la copia
                        while (cpPalabra11.Contains('*'));

                        if(easteregg == false)
                        {
                            //Si lo consigue WIN MIGUEL
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("¡SALVASTE A MIGUEL!");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                            Console.WriteLine("   (*)");
                            Console.WriteLine("   \\|/");
                            Console.WriteLine("   / \\");
                            Console.WriteLine("------------");
                            Console.WriteLine("Perfecto, la palabra era: " + palabraActiva);
                        }                      
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
                        Console.WriteLine("1.Mostrar registros");
                        Console.WriteLine("2.Insertar nuevo registro");
                        Console.WriteLine("3.Consultar por DNI");
                        Console.WriteLine("4.Mostrar registros cuyo salario sea superior a 2500€");
                        Console.WriteLine("5.Modificar registro");
                        Console.WriteLine("6.Eliminar registro");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("7.Mostrar registros ordenados por salario (de menor a mayor)");
                        Console.WriteLine("8.Salir");
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

            //Ramon Exclamo: Eyyy, HUEPA 31/01/2024
            //*la clase se rio por primera vez
        }
    }
}
