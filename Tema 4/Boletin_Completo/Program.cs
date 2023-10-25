﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletin_Completo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variable para el bucle
            char continuar;

            do //Bucle que pregunta si quieres continuar 
            {
                //Titulo de la ventana
                Console.Title = "Boletín Completo by Xoán Alonso Fernández";

                //Valor de la variable para elegir ejercicio
                int ejercicio = 0;

                //Selección de ejercicio
                Console.WriteLine("Escoja un ejercicio del 3 al 23");
                ejercicio = int.Parse(Console.ReadLine());


                if (ejercicio == 3) //Ejercicio 3
                { //Encuentra el numero menor entre 4
                    Console.WriteLine("Introduce el primer numero: ");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Introduce el segundo numero: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Introduce el tercer numero: ");
                    double c = double.Parse(Console.ReadLine());
                    Console.WriteLine("Introduce el cuarto numero: ");
                    double d = double.Parse(Console.ReadLine());
                    double minimo;

                    if (a < b)
                    {
                        minimo = a;
                    }
                    else
                    {
                        minimo = b;
                    }
                    if (minimo > c)
                    {
                        minimo = c;
                    }
                    if (minimo > d)
                    {
                        Console.WriteLine("Es menor de estos números es: " + d);
                    }
                    else
                    {
                        Console.WriteLine("El menor de estos números es " + minimo);
                    }


                }
                else if (ejercicio == 4) //Ejercicio 4
                {
                    Console.WriteLine("Introduce el primer número: ");
                    double numero1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Introduce el segundo número: ");
                    double numero2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Introduce el tercer número: ");
                    double numero3 = double.Parse(Console.ReadLine());

                    double resultado = (numero1 + numero2 + numero3) / 3;

                    if (resultado >= 5)
                    {
                        Console.WriteLine("Enhorabuena, has aprobado (que no se te suba a la cabeza)");
                    }
                    else
                    {
                        Console.WriteLine("Suspendiste y eso que regalé puntos (patético)");
                    }
                }
                else if (ejercicio == 5) //Ejercicio 5
                {
                    Console.Write("Introduce el primer número: ");
                    double numero1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Introduce el segundo número: ");
                    double numero2 = Convert.ToDouble(Console.ReadLine());

                    double suma = numero1 + numero2;

                    if (suma >= 0)
                    {
                        double raizCuadrada = Math.Sqrt(suma);
                        Console.WriteLine("La raíz cuadrada de la suma es: " + raizCuadrada);
                    }
                    else
                    {
                        Console.WriteLine("No se puede calcular la raíz cuadrada de una suma negativa.");
                    }
                }
                else if (ejercicio == 6) //Ejercicio 6
                {
                    string contraseñaPredefinida = "1234";

                    Console.Write("Ingrese la contraseña: ");
                    string contraseñaUsuario = Console.ReadLine();

                    if (contraseñaUsuario == contraseñaPredefinida)
                    {
                        Console.WriteLine("Contraseña correcta");
                    }
                    else
                    {
                        Console.WriteLine("La contraseña es incorrecta. Inténtelo de nuevo. (prueba con 1234)");
                    }
                }
                else if (ejercicio == 7) //Ejercicio 8
                {
                    Console.Write("Ingrese el primer número: ");
                    double numero1 = double.Parse(Console.ReadLine());

                    Console.Write("Ingrese el segundo número: ");
                    double numero2 = double.Parse(Console.ReadLine());

                    double resultado;

                    if (numero1 > numero2)
                    {
                        resultado = Math.Pow(numero1, numero2);
                    }
                    else
                    {
                        resultado = Math.Pow(numero2, numero1);
                    }

                    Console.WriteLine("El resultado de elevar el mayor número al más pequeño es: " + resultado);
                }
                else if (ejercicio == 8) //Ejercicio 9
                {
                    Console.WriteLine("Medición de la seguridad del núcleo");

                    //Solicitar la presión en atmósferas al usuario
                    Console.Write("Ingrese la presión (en atmósferas): ");
                    double presion = double.Parse(Console.ReadLine());

                    //Solicitar la temperatura en Kelvin al usuario
                    Console.Write("Ingrese la temperatura (en Kelvin): ");
                    double temperatura = double.Parse(Console.ReadLine());

                    bool abrirValvula = false;
                    bool reducirTemperatura = false;

                    if (presion > 2)
                    {
                        abrirValvula = true;
                    }

                    if (temperatura > 500)
                    {
                        reducirTemperatura = true;
                    }

                    if (abrirValvula && reducirTemperatura)
                    {
                        Console.WriteLine("Abrir válvula de seguridad");
                        Console.WriteLine("Reducir la temperatura");
                    }
                    else if (abrirValvula)
                    {
                        Console.WriteLine("Abrir válvula de seguridad");
                    }
                    else if (reducirTemperatura)
                    {
                        Console.WriteLine("Reducir la temperatura");
                    }
                    else
                    {
                        Console.WriteLine("Todo en orden");
                    }
                }
                else if (ejercicio == 9) //Ejercicio 9
                {
                    Console.WriteLine("Introduce un Numero: ");
                    double numero = double.Parse(Console.ReadLine());

                    if (numero % 2 == 0)
                    {
                        Console.WriteLine("Es múltiplo de 2");
                    }

                    if (numero % 3 == 0)
                    {
                        Console.WriteLine("Es múltiplo de 3");
                    }
                }
                else if (ejercicio == 10) //Ejercicio 10
                {
                    Console.WriteLine("Introduce una cantidad de Dinero: ");
                    double numero2 = double.Parse(Console.ReadLine());

                    if (numero2 <= 100)
                    {
                        double calculo1 = (numero2 * 0.90);
                        Console.WriteLine("El descuento es del 10% y el precio queda en " + calculo1);
                    }

                    if (numero2 > 100)
                    {
                        double calculo2 = (numero2 * 0.85);
                        Console.WriteLine("El descuento es del 15% y el precio queda en " + calculo2);
                    }
                }
                else if (ejercicio == 11) //Ejercicio 11
                {
                    Console.WriteLine("Introduce un número de 0 a 10: ");
                    double numero3 = double.Parse(Console.ReadLine());

                    if (numero3 < 5.0)
                    {
                        Console.WriteLine("Suspenso");
                    }
                    else if (numero3 < 6.5)
                    {
                        Console.WriteLine("Aprobado");
                    }
                    else if (numero3 < 8.5)
                    {
                        Console.WriteLine("Notable");
                    }
                    else if (numero3 <= 10.0)
                    {
                        Console.WriteLine("Sobresaliente");
                    }
                    else
                    {
                        Console.WriteLine("Error en nota");
                    }
                }
                else if (ejercicio == 12) //Ejercicio 12
                {

                    Console.WriteLine("Introduce un numero: ");
                    int numero4 = int.Parse(Console.ReadLine());
                    int resultadoEj12;

                    if (numero4 % 4 == 0)
                    {
                        resultadoEj12 = numero4 + 25;
                    }
                    else if (numero4 % 5 == 0)
                    {
                        resultadoEj12 = (numero4 + 50);
                    }
                    else
                    {
                        resultadoEj12 = (numero4 + 100);
                    }

                    Console.WriteLine("El valor inicial es " + numero4 + " y el valor final es " + resultadoEj12);
                }
                else if (ejercicio == 13) //Ejercicio 13
                {
                    //Lectura de la variable temp por teclado
                    Console.WriteLine("Introduce el valor de la variable temp: ");
                    double temp = double.Parse(Console.ReadLine());

                    if (temp < 0) //Si temp es menor que 0
                    {
                        Console.WriteLine("Sólido");
                    }
                    else if (temp <= 0 && temp >= 100) //Si temp esta entre 0 y 100
                    {
                        Console.WriteLine("Líquido");
                    }
                    else if (temp > 100) //Si temp es mayor que 100
                    {
                        Console.WriteLine("Vapor");
                    }
                    else if (temp > 1000000) //Si temp es mayor que 1000000
                    {
                        Console.WriteLine("Plasma");
                    }
                }
                else if (ejercicio == 14) //Ejercicio 14
                {
                    //Declaración de variables
                    char letra;
                    double num1, num2, resultado1;

                    //Lectura por teclado de las opciones
                    Console.WriteLine("a) Sumar");
                    Console.WriteLine("b) Restar");
                    Console.WriteLine("c) Multiplicar");
                    Console.WriteLine("d) Dividir");
                    Console.WriteLine("e) Raíz de la suma");
                    letra = char.Parse(Console.ReadLine());

                    if (letra == 'a')//a) Suma
                    {
                        Console.WriteLine("Introduce el primero numero: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce el segundo numero: ");
                        num2 = double.Parse(Console.ReadLine());
                        resultado1 = (num1 + num2);
                        Console.WriteLine("El resultado de la suma es " + resultado1);
                    }
                    else if (letra == 'b')//b) Resta
                    {
                        Console.WriteLine("Introduce el primero numero: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce el segundo numero: ");
                        num2 = double.Parse(Console.ReadLine());
                        resultado1 = (num1 - num2);
                        Console.WriteLine("El resultado de la resta es " + resultado1);

                    }
                    else if (letra == 'c')//c) Multiplicación
                    {
                        Console.WriteLine("Introduce el primero numero: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce el segundo numero: ");
                        num2 = double.Parse(Console.ReadLine());
                        resultado1 = (num1 * num2);
                        Console.WriteLine("El resultado de la multiplicación es " + resultado1);
                    }
                    else if (letra == 'd')//d) División
                    {
                        Console.WriteLine("Introduce el primero numero: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce el segundo numero: ");
                        num2 = double.Parse(Console.ReadLine());
                        resultado1 = (num1 / num2);
                        Console.WriteLine("El resultado de la división es " + resultado1);
                    }
                    else if (letra == 'e')//e) Raíz
                    {
                        Console.WriteLine("Introduce el primero numero: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce el segundo numero: ");
                        num2 = double.Parse(Console.ReadLine());
                        resultado1 = Math.Sqrt(num1 + num2);
                        Console.WriteLine("El resultado de la raíz de la suma es " + resultado1);
                    }
                    else //Si no introduce una letra validad da error
                    {
                        Console.WriteLine("Error, vuelve a intentarlo.");
                    }
                }
                else if (ejercicio == 15) //Ejercicio 15
                {
                    //Solicitud de litros gastados
                    Console.WriteLine("Cantidad de litros utilizados: ");
                    double litros = double.Parse(Console.ReadLine());

                    if (litros <= 50)
                    {
                        Console.WriteLine("El importe a pagar es de 45€");
                    }
                    else if (litros >= 20)
                    {
                        double resultado = (litros - 50) * 4.75;
                        Console.WriteLine("El importe a pagar es de " + resultado);
                    }
                    else
                    {
                        double resultado = (litros - 50) * 20;
                        Console.WriteLine("El importe a pagar es de " + resultado);
                    }
                }
                else if (ejercicio == 16) //Ejercicio 16
                {





                }



                //Pregunta para continuar el bucle
                Console.WriteLine("¿Quiere volver al menú? (s/n)");
                continuar = Char.Parse(Console.ReadLine());

            } while (continuar == 's');
        }
    }
}
