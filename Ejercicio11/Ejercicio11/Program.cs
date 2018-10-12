using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
        
        

            Console.WriteLine("Programa para calcular el numero mayor");

            Console.WriteLine("\nCuantos numeros quieres:\n ");
            string num = Console.ReadLine();
            int Mayor = int.Parse(num);

            
            for (int i = 0; i < Mayor; i++)
            {
                Console.WriteLine("Introduce el numero ");
                string d = Console.ReadLine();
                int n = int.Parse(d);

                if (n > Mayor)
                {

                    Mayor = n;
                }
               
                
            }

            Console.WriteLine("El numero mayor es: " + Mayor);

            Console.ReadKey();
        }
    }
}
