using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCoresGiomar
{
    class Program
    {
        static List<string> ListaDeCores = new List<string>
        {
            "Vermelho",
            "Verde"
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de cadastro de cores");

            var menuescolhido = "0";

            while(menuescolhido != "3")
            {
                menuescolhido = ApresentaMenu();

                switch (menuescolhido)
                {
                    case "1":
                        RegistarCores();
                        break;
                    case "2":
                        MostraAsCores();
                        break;
                    default:
                        break;
                }

                Console.Clear();

            }

            Console.ReadKey();
        }

        static string ApresentaMenu()
        {
            Console.WriteLine("1 - Cadastrar cor");
            Console.WriteLine("2 - Listar cores");
            Console.WriteLine("3 - Sair");

            return Console.ReadLine();
        }

        static void MostraAsCores()
        {
            Console.WriteLine("Listagem de cores");

            ListaDeCores.ForEach(x => Console.WriteLine(x));

            Console.ReadKey(true);
        }

        static void RegistarCores()
        {
            Console.WriteLine("Registro de cores");

            Console.WriteLine("Informe a cor para cadastro:");

            ListaDeCores.Add(Console.ReadLine());

            Console.WriteLine("Cor cadastrada com sucesso");

            Console.ReadKey(true);
        }
    }
}
