using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletin_Completo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char continuar;

            do
            {


                Console.Title = "Boletín Completo by Xoán Alonso Fernández";

                int ejercicio = 0;

                Console.WriteLine("Escoja un ejercicio de 4 al 23");
                ejercicio = int.Parse(Console.ReadLine());

                if (ejercicio == 4)
                { //Ejercicio 4 - Xoán Alonso Fernández

                    Console.WriteLine("Introduce el primer número: "); //Solicitud de datos 1
                    double numero1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Introduce el segundo número: "); //Solicitud de datos 2
                    double numero2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Introduce el tercer número: "); //Solicitud de datos 3
                    double numero3 = double.Parse(Console.ReadLine());

                    double resultado = (numero1 + numero2 + numero3) / 3; //Calculo

                    if (resultado >= 5) //Si es mayor a 5
                    {
                        Console.WriteLine("Enhorabuena, has aprobado (que no se te suba a la cabeza)");
                    }
                    else
                    {
                        Console.WriteLine("Suspendiste y eso que regale puntos (patético)");
                    }


                }
                else if (ejercicio == 5)
                { //Ejercicio 5 - Xoán Alonso Fernández

                    Console.Write("Introduce el primer número: "); //Recogida de datos 1
                    double numero1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Introduce el segundo número: "); //Recogida de datos 2
                    double numero2 = Convert.ToDouble(Console.ReadLine());

                    double suma = numero1 + numero2; //Suma de los números

                    double raizCuadrada = Math.Sqrt(suma); //Raíz Cuadrada

                    if (raizCuadrada >= 0) //Verificar si la raíz es positiva
                    {
                        Console.WriteLine("La raíz cuadrada de la suma es: " + raizCuadrada);
                    }
                    else
                    {
                        Console.WriteLine("No se puede calcular la raíz cuadrada de una suma negativa.");
                    }
                }
                else if (ejercicio == 6)
                { //Ejercicio 6 - Xoán Alonso Fernández

                    //Contraseña predefinida
                    string contraseñaPredefinida = "1234";

                    //Solicitar una contraseña al usuario
                    Console.Write("Ingrese la contraseña: ");
                    string contraseñaUsuario = Console.ReadLine();

                    //Comprobar la contraseña
                    if (contraseñaUsuario == contraseñaPredefinida)
                    {
                        Console.WriteLine("Contraseña correcta");
                    }
                    else
                    {
                        Console.WriteLine("La contraseña es incorrecta. Inténtelo de nuevo. (prueba con 1234)");
                    }
                }
                else if (ejercicio == 7)
                { //Ejercicio 7 - Xoán Alonso Fernández

                    Console.Write("Ingrese el primer número: "); //Recogida de datos 1
                    double numero1 = double.Parse(Console.ReadLine());

                    Console.Write("Ingrese el segundo número: "); //Recogida de datos 2
                    double numero2 = double.Parse(Console.ReadLine());

                    double resultado; //Declaración de variable

                    if (numero1 > numero2) //Elevar el mas grande al mas pequeño
                    {
                        resultado = Math.Pow(numero1, numero2);
                    }
                    else
                    {
                        resultado = Math.Pow(numero2, numero1);
                    }

                    Console.WriteLine("El resultado de elevar el mayor número al más pequeño es: " + resultado);

                }
                else if (ejercicio == 8)
                { //Ejercicio 8 - Xoán Alonso Fernández

                    Console.Write("Ingrese la presión (en atmósferas): "); //Recogida de datos 1
                    double presion = double.Parse(Console.ReadLine());

                    Console.Write("Ingrese la temperatura (en Kelvin): "); //Recogida de datos 2
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
                    if (ejercicio == 9)
                    {

                        Console.WriteLine("Introduce un Numero: "); //Recogida de datos
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

                    else if (ejercicio == 10)
                    {
                        Console.WriteLine("Introduce una cantidad de Dinero: "); //Recogida de datos
                        double numero2 = double.Parse(Console.ReadLine());

                        if (numero2 <= 100)
                        {
                            double calculo1 = (numero2 * 0.90); //Calculo del 10%
                            Console.WriteLine("El descuento es del 10% y el precio queda en " + calculo1);
                        }

                        if (numero2 >= 100)
                        {
                            double calculo2 = (numero2 * 0.85); //Calculo del 15&%
                            Console.WriteLine("El descuento es del 15% y el precio queda en " + calculo2);
                        }
                    }
                    else if (ejercicio == 11)
                    {
                        Console.WriteLine("Introduce un numero de 0 a 10: "); //Recogida de Datos
                        double numero3 = double.Parse(Console.ReadLine());

                        if (numero3 <= 0.0 || numero3 >= 10.0)
                        {
                            Console.WriteLine("Error en nota (tan difícil es poner un numero?)");
                        }
                        else

                        {
                            Console.WriteLine("Te equivocaste, esperemos que no se repita");
                        }

                    }



                }

                Console.WriteLine();
                Console.WriteLine("Quiere volver al menú: s/n");
                continuar = Char.Parse(Console.ReadLine());


            }

            while (continuar == 's');




        }
    }
}
