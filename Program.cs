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
            // 3. Lea las teclas presionadas y finalice al presionar la tecla "X"
            ConsoleKeyInfo tecla;
            do
            {
                Console.WriteLine("Ingrese una tecla");
                char entrada = Convert.ToChar(Console.ReadLine());
                Console.WriteLine($"Usted ha presionado la tecla {entrada}");
                Console.WriteLine("Para finalizar presiones la tecla 'X'");
                tecla = Console.ReadKey(true);
            }
            while (tecla.Key != ConsoleKey.X);
            if (tecla.Key == ConsoleKey.X)
            {
                Console.WriteLine("Usted ha presionado la tecla 'X' para finalizar.");
            }
        }
    }
}
