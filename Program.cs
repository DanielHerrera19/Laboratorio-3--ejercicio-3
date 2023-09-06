using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3__ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Usted es mayor o menor de edad?");
            Console.WriteLine("a: Mayor de edad");
            Console.WriteLine("b: Menor de edad");
            string menoromayor = Console.ReadLine();

            Console.Write("¿Cuantos años tiene?: ");
            int edad = int.Parse(Console.ReadLine());

            Console.Write("Cantidad de adivinanzas acertadas: ");
            int adivinanzasacertadas = int.Parse(Console.ReadLine());

            double montoinicial = 0;
            double montoextraedad = 0;
            double montoextra = 0;
            double montofinal = 0;

            switch (menoromayor)
            {
                case "a":
                    if (adivinanzasacertadas < 3)
                        montoinicial = 30;
                    else
                        montoinicial = 50;
                    break;

                case "b":
                    if (adivinanzasacertadas < 3)
                        montoinicial = 50;
                    else
                        montoinicial = 80;
                    break;
            }

            montoextra = adivinanzasacertadas * 2;
            montoextraedad = edad * 5;
            montofinal = montoinicial + montoextraedad + montoextra;

            Console.WriteLine("Monto Final del Premio: S/." + montofinal );
        }
    }
}