using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2- Una persona enferma, que pesa 70 kg, se encuentra en reposo y desea saber cuantas calorías consume su cuerpo
             * durante todo el tiempo que realice una misma actividad. Las actividades que tiene permitido realizar son 
             * únicamente dormir o estar sentado en reposo. Los datos que tiene son que estando dormido consume 1.08 calorías por minuto
             * y estando sentado en reposo consume 1.66 calorías por minuto.	
             */
            Console.WriteLine("Digite tiempo (Minutos) que dedica a dormir");
            string Dormir = Console.ReadLine();
            float tempD = float.Parse(Dormir);

            Console.WriteLine("Digite tiempo (Minutos) que destina a estar en reposo");
            string Reposo = Console.ReadLine();
            float tempR = float.Parse(Reposo);

          
          
            double CDormido = tempD * 1.08;
            Console.WriteLine("Las calorias que consume su cuerpo cuando duerme es: " + " " + CDormido);
            double CReposo = tempR * 1.66;
            Console.WriteLine("Las calorias que consume su cuerpo en Reposo es: " + " " + CReposo);


            Console.ReadKey();
        }
    }
}
