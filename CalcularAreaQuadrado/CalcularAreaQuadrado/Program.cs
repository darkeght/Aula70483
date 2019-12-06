using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularAreaQuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inform o valor do lado");
            

            Console.WriteLine(CalculaLado());

            Console.ReadKey(true);

        }

        static int CalculaLado()
        {
            var lado = int.Parse(Console.ReadLine());

            return lado * lado + 50;
        }

    }
}
