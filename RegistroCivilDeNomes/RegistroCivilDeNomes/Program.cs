using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroCivilDeNomes
{
    class Program
    {
        static List<string> ListaDeNomes = new List<string>();
        static void Main(string[] args)
        {
            Console.WriteLine("***********************");
            Console.WriteLine("**SISTEMA DE REGISTRO**");
            Console.WriteLine("***********************");

            var menuEscolhido = "0";

            while(menuEscolhido != "5")
            {
                Console.WriteLine("Digite o número para a opção desejada:");
                Console.WriteLine("1 - Registrar Nome");
                Console.WriteLine("2 - Listar Nomes");
                Console.WriteLine("3 - Editar Um Nome");
                Console.WriteLine("4 - Excluir Nomes");
                Console.WriteLine("5 - Sair do sistema");

                menuEscolhido = Console.ReadLine();

                switch (menuEscolhido)
                {
                    case "1":
                        Console.WriteLine("Registro de Nome Selecionado");
                        Console.WriteLine("Informa um nome:");
                        var nomeInformado = Console.ReadLine();

                        ListaDeNomes.Add(nomeInformado);

                        Console.WriteLine("Nome informado com sucesso!");
                        Console.ReadKey(true);
                        break;
                    case "2":
                        Console.WriteLine("Listagem de Nome Selecionada");

                        ListaDeNomes.ForEach(x => Console.WriteLine($"Nome: {x}"));

                        Console.WriteLine("Listagem de nomes finalizada.");
                        Console.ReadKey(true);
                        break;
                    default:
                        Console.WriteLine("Menu Inválido");
                        break;
                }

                Console.Clear();
            }

            Console.ReadKey(true);
        }
    }
}
