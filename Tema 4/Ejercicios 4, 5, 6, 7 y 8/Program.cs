using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_4__5__6__7_y_8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Ejercicios 4-8";

            int ejercicio = 0;

            Console.WriteLine("Introducir ejercicios 4-8: ");
            ejercicio = int.Parse(Console.ReadLine());

            if (ejercicio == 4)
            { //Ejercicio 4

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
            { //Ejercicio 5

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
            { //Ejercicio 6

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
            { //Ejercicio 7

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
            { //Ejercicio 8

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
            }

            Console.ReadLine(); //Evitar que se cierre la consola

        }
    }
}
