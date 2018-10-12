using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Que lea tres números diferentes y determine el numero medio del conjunto de los tres números 
            (el numero medio es aquel numero que no es ni mayor, ni menor) */

            Console.WriteLine("\n\n\t\t\t NUMERO MEDIO \n\n\n\n");

            Console.WriteLine(" Ingrese numero A:\t");
            string a = Console.ReadLine();
            int na = int.Parse(a);
            Console.WriteLine("\n Ingrese numero B:\t");
            string b = Console.ReadLine();
            int nb = int.Parse(b);
            Console.WriteLine("\n Ingrese numero C:\t");
            string c = Console.ReadLine();
            int nc = int.Parse(c);

            if (na < nb && na > nc || na < nc && na > nb)
            {
                Console.WriteLine("\n\n El Numero medio es:" + na);
            }
            if (nb < na && nb > nc || nb < nc && nb > na)
            {
                Console.WriteLine("\n\n El Numero medio es:" + nb);
            }
            if (nc < na && nc > nb || nc < nb && nc > na)
            {
                Console.WriteLine("\n\n El Numero medio es: " + nc);
            }

            Console.ReadKey();
        }
    }
}
