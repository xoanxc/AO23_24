using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Aprobado_con_Bool
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Para aprobar 
            //Aprobar loe exámenes
            //Aprobar las tareas
            //Buen comportamiento

            Boolean examenesAprobados = true;
            Boolean tareasAprobadas = true;
            Boolean comportamientoCorrecto = true;

            if (examenesAprobados && tareasAprobadas && comportamientoCorrecto)
            {
                Console.WriteLine("Enhorabuena, has aprobado todo");
            }
            else if (!examenesAprobados)
            {
                Console.WriteLine("Exámenes suspensos");
            }
            else if (!tareasAprobadas)
            {
                Console.WriteLine("Suspenso por no entregar las tareas");
            }
            else if (!comportamientoCorrecto)
            {
                Console.WriteLine("Suspenso por cafre");
            }

            Console.ReadLine();
        }
    }
}
