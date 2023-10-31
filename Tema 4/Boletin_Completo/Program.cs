using System;
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
                        Console.WriteLine("El menor de estos números es: " + d);
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
                    //Obtención de los 3 precios
                    Console.WriteLine("Introduce el primer precio");
                    double pre1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Introduce el segundo precio");
                    double pre2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Introduce el tercer precio");
                    double pre3 = double.Parse(Console.ReadLine());

                    double tot = pre1 + pre2 + pre3;

                    if (tot < 500.00 && tot > 0.00)
                    {
                        Console.WriteLine("El precio final sin ningún descuento aplicado es de " + tot + " euros");
                    }
                    else if (tot < 1000.00 && tot > 500.00)
                    {
                        double calc = tot * 0.97;
                        Console.WriteLine("El precio final con un 3% de descuento aplicado es de " + calc + " euros (" + tot + " euros sin descuento)");
                    }
                    else if (tot >= 2000.00 && tot <= 3000.00)
                    {
                        double calc = tot * 0.95;
                        Console.WriteLine("El precio final con un 5% de descuento aplicado es de " + calc + " euros (" + tot + " euros sin descuento)");
                    }
                    else if (tot > 3000.00)
                    {
                        double calc = tot * 0.90;
                        Console.WriteLine("El precio final con un 10% de descuento aplicado es de " + calc + " euros (" + tot + " euros sin descuento)");
                    }
                    else
                    {
                        Console.WriteLine("Error, vuelve a intentarlo");
                    }
                }
                else if (ejercicio == 17) //Ejercicio 17
                {
                    //Registro de datos salario y horas
                    Console.WriteLine("Horas trabajadas este mes: ");
                    double horas = double.Parse(Console.ReadLine());
                    Console.WriteLine("Tasa por hora: ");
                    double tasa = double.Parse(Console.ReadLine());

                    if (horas <= 38)
                    {
                        double salarioB = horas * tasa;

                        if (salarioB > 300)
                        {
                            double salarioN = salarioB * 0.90;
                            Console.WriteLine("El salario bruto son " + salarioB + " euros y el neto " + salarioN + " euros");
                        }
                        else
                        {
                            Console.WriteLine("El salario bruto son " + salarioB + " euros y el neto " + salarioB + " euros");
                        }
                    }
                    else
                    {
                        double salarioB = (horas * tasa) * 1.50;

                        if (salarioB > 300)
                        {
                            double salarioN = salarioB * 0.90;
                            Console.WriteLine("El salario bruto son " + salarioB + " euros y el neto " + salarioN + " euros");
                        }
                        else
                        {
                            Console.WriteLine("El salario bruto son " + salarioB + " euros y el neto " + salarioB + " euros");
                        }
                    }
                }
                else if (ejercicio == 18)//Ejercicio 18
                {
                    //Recogida de datos
                    Console.WriteLine("Introduce un valor del 1 al 4");
                    int indicador = int.Parse(Console.ReadLine());

                    switch (indicador)
                    {
                        case 1:
                            Console.WriteLine("CALOR");
                            break;
                        case 2:
                            Console.WriteLine("TEMPLADO");
                            break;
                        case 3:
                            Console.WriteLine("FRIO");
                            break;
                        case 4:
                            Console.WriteLine("FUERA DE RANGO");
                            break;
                        default:
                            Console.WriteLine("Error, valor no reconocido");
                            break;
                    }
                }
                else if (ejercicio == 19)
                {
                    Console.WriteLine("Introduce una letra del abecedario");
                    Char color = Char.Parse(Console.ReadLine());

                    switch (Char.ToLower(color))
                    {
                        case 'r':
                            Console.WriteLine("ROJO");
                            break;
                        case 'v':
                            Console.WriteLine("VERDE");
                            break;
                        case 'a':
                            Console.WriteLine("AZUL");
                            break;
                        default:
                            Console.WriteLine("NEGRO");
                            break;
                    }
                }
                else if (ejercicio == 20) //Ejercicio 20
                {
                    //Recogida de datos
                    Console.WriteLine("Introduce un número de hasta 6 cifras");
                    double num1 = double.Parse(Console.ReadLine());

                    if (num1 <= 9)
                    {
                        Console.WriteLine("El numero tiene 1 cifra");
                    }
                    else if (num1 <= 99)
                    {
                        Console.WriteLine("El numero tiene 2 cifras");
                    }
                    else if (num1 <= 999)
                    {
                        Console.WriteLine("El numero tiene 3 cifras");
                    }
                    else if (num1 <= 9999)
                    {
                        Console.WriteLine("El numero tiene 4 cifras");
                    }
                    else if (num1 <= 99999)
                    {
                        Console.WriteLine("El numero tiene 5 cifras");
                    }
                    else if (num1 <= 999999)
                    {
                        Console.WriteLine("El numero tiene 6 cifras");
                    }
                    else //Ninguna de las anteriores, entonces:
                    {
                        Console.WriteLine("Error, numero mayor a 6 cifras");
                    }
                }
                else if (ejercicio == 21) //Ejercicio 21
                {
                    Console.WriteLine("Ingrese los coeficientes de la ecuación de segundo grado (ax^2 + bx + c = 0):");
                    Console.WriteLine(); //Espacio
                    Console.Write("Coeficiente a: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(); //Espacio
                    Console.Write("Coeficiente b: ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(); //Espacio
                    Console.Write("Coeficiente c: ");
                    double c = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(); //Espacio

                    //Ecuación
                    double ecuacion = b * b - 4 * a * c;

                    if (ecuacion > 0)
                    {
                        double raiz1 = (-b + Math.Sqrt(ecuacion)) / (2 * a);
                        double raiz2 = (-b - Math.Sqrt(ecuacion)) / (2 * a);
                        Console.WriteLine("Las raíces reales son: " + raiz1 + " y " + raiz2);
                    }
                    else if (ecuacion == 0)
                    {
                        double raiz = -b / (2 * a);
                        Console.WriteLine("La ecuación tiene una raíz doble: " + raiz);
                    }
                    else
                    {
                        double parte1 = -b / (2 * a);
                        double parte2 = Math.Sqrt(-ecuacion) / (2 * a);
                        Console.WriteLine("Las raíces son: " + parte1 + " + " + parte2 + " y " + parte1 + " - " + parte2);
                    }
                }
                else if (ejercicio == 22) //Ejercicio 22
                {
                    //Recogida de datos
                    Console.WriteLine("Introduce un año");
                    int año = int.Parse(Console.ReadLine());

                    if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
                    {
                        Console.WriteLine(año + "es un año bisiesto.");
                    }
                    else
                    {
                        Console.WriteLine(año + "no es un año bisiesto.");
                    }
                }
                else if (ejercicio == 23)//Ejercicio 23
                {
                    //Recogida de datos
                    Console.WriteLine("Introduzca los datos");
                    Console.WriteLine(); // Espacio
                    Console.WriteLine("Primer numero");
                    double num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Segundo numero");
                    double num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Tercer numero");
                    double num3 = double.Parse(Console.ReadLine());

                    //Ordenar los números
                    if (num1 > num2)
                    {
                        double temp = num1;
                        num1 = num2;
                        num2 = temp;
                    }

                    if (num2 > num3)
                    {
                        double temp = num2;
                        num2 = num3;
                        num3 = temp;

                        if (num1 > num2)
                        {
                            temp = num1;
                            num1 = num2;
                            num2 = temp;
                        }
                    }

                    //Mostrar los números ordenados de menor a mayor
                    Console.WriteLine("Números ordenados de menor a mayor: {0}, {1}, {2}", num1, num2, num3);
                }



                //Pregunta para continuar el bucle
                Console.WriteLine("¿Quiere volver al menú? (s/n)");



                continuar = Char.Parse(Console.ReadLine());

            } while (continuar == 's');

            //Boletin Completo By Xoán Alonso Fernández
        }
    }
}
