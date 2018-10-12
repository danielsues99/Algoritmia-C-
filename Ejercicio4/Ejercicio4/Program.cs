using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             4-:
	En un hospital existen tres áreas: Ginecología, Pediatría, Traumatologia. 
    El presupuesto anual del hospital se reparte conforme a la sig. tabla:
	
			Área			Porcentaje del presupuesto
			Ginecología			40%
			Traumatologia			30%
			Pediatría			30%
	Obtener la cantidad de dinero que recibirá cada área, para cualquier monto presupuestal.
             */
            Console.WriteLine("Ingrese Monto Presupuestal");
            string Pre = Console.ReadLine();
            float Presupuesto = float.Parse(Pre);
            double Gineco = Presupuesto * 0.40;
            double Traumato = Presupuesto * 0.30;
            double Pedi = Presupuesto * 0.30;

            Console.WriteLine("El presupuesto se distribuye así:\n" + " Ginecología " + " " + Gineco + "\n Traumatología " + Traumato + "\n Pediatría " + Pedi);

            Console.ReadKey();
        }
    }
}
