using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese Cantidad Invertida");
            string Invp = Console.ReadLine();
            float sinva = float.Parse(Invp);
            Console.WriteLine("Ingrese Cantidad Invertida");
            string Invs = Console.ReadLine();
            float sinvb = float.Parse(Invs);
            Console.WriteLine("Ingrese Cantidad Invertida");
            string Invt = Console.ReadLine();
            float sinvc = float.Parse(Invt);

            float total = (sinva + sinvb + sinvc);
            Console.WriteLine("El porcentaje equivalente del primer inversionista es: "+" "+ sinva/total*100);
            Console.WriteLine("El porcentaje equivalente del Segundo inversionista es: " + " " + sinvb / total * 100);
            Console.WriteLine("El porcentaje equivalente del Tercer inversionista es: " + " " + sinvc / total * 100);

            Console.ReadKey();
        }
    }
}
