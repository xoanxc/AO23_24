using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            while (i <= 20)
            {
                i *= 10;
            }
            Console.WriteLine(i);


            for (int j = 3; j < 8; j += 2)
            {
                Console.WriteLine(j);
            }

            Console.ReadLine();
        }
    }
}
