using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese numero a calcular su tala");
            string num = Console.ReadLine();
            int n = int.Parse(num);

            for (int i=0; i<=10; i++)
            {
                int r = n * i;
                Console.WriteLine(n + " x " + i + " = " + r);
              
            }
            Console.ReadKey();
        }
    }
}
