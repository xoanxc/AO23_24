using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Tema8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Crea una lista en la que se puedan guardar números enteros.");
            Console.WriteLine();

            //1.Xoán Alonso Fernández
            //Creo la lista, no le asigno una capacidad inicial
            List<int> list = new List<int>();

            //Introduzco numeros en la lista
            list.Add(0);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);


            Console.WriteLine("Guarda 20 números generados aleatoriamente dentro del rango [-10,10]");


            //a)Xoán Alonso Fernández
            //Creo la variable Random gen1
            Random gen1 = new Random();

            //Con el for introduzco los numeros entre el rango [-10,10]
            for (int i = 0; i < 20; i++)
            {
                list.Add(gen1.Next(-10, 11));
                Console.Write(list[i] + ", "); //Los muestro, para comprobar       
            }


            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Obtén la capacidad de la lista y cuantas posiciones quedarían por llenar.");
            Console.WriteLine();

            //b)Xoán Alonso Fernández
            //Utilizo list.Capacity y list.Count, opero para conseguir las vacias
            int capacidadLista = list.Capacity;
            int posicionesLlenar = list.Capacity - list.Count;
            Console.WriteLine("La capacidad es: " + capacidadLista + " y quedan por llenar " + posicionesLlenar);
            Console.WriteLine();


            Console.WriteLine("Obtén la posición del primer cero, en caso de que no haya mostrar mensaje por pantalla.");

           
            //c)Xoán Alonso Fernández
            //Si la lista contiene 0, entra en el if y luego cuenta con foreach
            if(list.Contains(0))
            {
                for(int i = 0; i < capacidadLista; i++)
                {
                    if (list[i] == 0)
                    {
                        Console.WriteLine("El primero 0 esta en la posición: " + list[i]);
                        break; //Para en la primera aparición
                    }
                }
            }
            else
            {
                Console.WriteLine("¡Jolines macho! No hay ceros en la lista ");
            }
            

            Console.WriteLine("Ajusta la capacidad de la lista  al número de elementos que contiene.");

            //d)Xoán Alonso Fernández

            //Utilizo list.TrimExcess para ajustar la capacidad
            list.Capacity = list.Count;

            Console.WriteLine("Añade un número superior a 10 en la posición 2 de la lista.");
            
            //e)Xoán Alonso Fernández
            //Añado el numero 11 en la posición 2
            list.Insert(2, 11);

            Console.WriteLine("Elimina el elemento situado en la posición 5");

            //f)Xoán Alonso Fernández
            //Elimino el elemento en la posición 5
            list.RemoveAt(5);

            Console.WriteLine("Elimina el primer número 3 que haya en la lista.");


            //g)Xoán Alonso Fernández

            //Elimino el primer 3 que haya en la lista
            list.RemoveAt(list.IndexOf(3));

            Console.WriteLine("Crea otra lista en la que se guardarán todos los elementos de la primera.");

            //h)Xoán Alonso Fernández
            //Creo la lista2 y le asigno los valores de la lista1
            List<int> list2 = new List<int>(list);


            Console.WriteLine("Crea otra lista en la que se guardarán sólo los valores negativos almacenados en la primera lista.");

    

            //i)Xoán Alonso Fernández
            //Creo la lista3 y con un foreach añado los valores negativos
            List<int> list3 = new List<int>();
            foreach (int num in list)
            {
                if (num < 0)
                {
                    list3.Add(num);
                }
            }

            Console.WriteLine("Muestra todos los valores sin duplicados.");

            //j)Xoán Alonso Fernández
            List<int> list4 = new List<int>();
            foreach (int num in list)
            {
                if (!list4.Contains(num))
                {
                    list4.Add(num);
                    Console.Write(num + ", ");
                }
            }



            Console.ReadLine();

        }
    }
}
