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
            char tecla;
            do
            {
                Console.WriteLine("Precione las teclas.");
                tecla = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Las teclas presionadas son: " + tecla);
                Console.WriteLine("Para finalizar, presione la tecla: X ");
            } while (tecla != 'x');
        }
    }
}
