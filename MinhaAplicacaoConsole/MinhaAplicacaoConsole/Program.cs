using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaAplicacaoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá");

            var x = "Felipe";

            Console.WriteLine($"O seu nome é : {x}");

            x = Console.ReadLine();

            Console.WriteLine($"O seu nome é : {x}");

            Console.ReadKey(true);

            

        }
    }
}
