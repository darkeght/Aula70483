using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeCarros
{
    class Program
    {

        static List<string> ListaDeCarros = new List<string>
        {
            "Chevette tubarão 1974",
            "Corsa chavoso 2004",
            "Palio maligno da frozen 2008",
            "Miura 1970",
            "FNM D-11.000 truck, 1964"
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Listagem de veiculos do Giomar");

            ListaDeCarros.ForEach(x => Console.WriteLine(x));

            Console.ReadKey();
        }
    }
}
