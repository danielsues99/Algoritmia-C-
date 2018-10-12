using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Una persona se encuentra con un problema de comprar un automóvil o un terreno, los cuales cuestan exactamente lo mismo. 
             Sabe que mientras el automóvil se devalúa, con el terreno sucede lo contrario. 
             Esta persona comprara el automóvil si al cabo de tres años la devaluación de este no es mayor que la mitad
             del incremento del valor del terreno. Ayúdale a esta persona a determinar si debe o no comprar el automóvil.
             */
            Console.WriteLine("\n\n\t\t\t COMPRA DE TERRENO O AUTO \n\n\n\n");
            Console.WriteLine("Ingrese el costo del terreno/auto:\t");
            string cos = Console.ReadLine();
            int costo = int.Parse(cos);
            Console.WriteLine("Ingrese tasa de devalucion del coche (mesual):\t");
            string deva = Console.ReadLine();
            int devauto = int.Parse(deva);

            Console.WriteLine("Ingrese tasa de avaluacion del terreno (mensual):\t");
            string det = Console.ReadLine();
            int avterreno = int.Parse(det);

            devauto = ((devauto / 100) * costo) * (3 * 12);
            avterreno = ((avterreno / 100) * costo) * (3 * 12);
            float mitad = avterreno / 2;

            if (devauto < mitad)
            {
                Console.WriteLine("\n\n Comprar coche");
            }
            else {
                Console.WriteLine("\n\n Comprar Terreno");
            }


            Console.ReadKey();
        }
    }
}
