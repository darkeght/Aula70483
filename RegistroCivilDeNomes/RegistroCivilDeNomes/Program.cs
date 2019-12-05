using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroCivilDeNomes
{
    class Program
    {
        //Aqui criamos uma lista estatica de nomes 
        static List<string> ListaDeNomes = new List<string>();
        static void Main(string[] args)
        {
            //Aqui invocamos nosso metodo 
            MensagemInicial();

            //aqui definimos um valor padrão para ele ja iniciar com uma informação
            //colocamos 0 para ele poder entrar pois ele tem como 5 para sair do sistema
            var menuEscolhido = "0";
            //Aqui temos nosso "while" o while fica perguntado se é diferente de 5 todo momento 
            //se for diferente de 5 ele continua executando quando for igual a 5 ele sai
            while(menuEscolhido != "5")
            {
                //aqui chamamos primeiro uma variavel para contem o menu escolhido
                //para acessar o metodo podemos utilizar o f12
                menuEscolhido = MostrarMenu();
                //
                switch (menuEscolhido)
                {
                    case "1":
                        RegistrarNome();
                        break;
                    case "2":
                        ListarNome();
                        break;
                    case "3":
                        EditarUmNome();
                        break;
                    default:
                        Console.WriteLine("Menu Inválido");
                        break;
                }

                Console.Clear();
            }

            Console.ReadKey(true);
        }
        static void EditarUmNome()
        {
            Console.WriteLine("Edição de nomes do sistema de registro");

            var numerador = 0;

            ListaDeNomes.ForEach(x => Console.WriteLine("Nome:{0,-10}Número:{1,-10}",x,numerador++));

            Console.WriteLine("Informe o número para edição");

            var index = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe um novo nome para o registro");

            var novoNome = Console.ReadLine();

            ListaDeNomes[index] = novoNome;

            Console.WriteLine("Registro alterado com sucesso!");

            Console.ReadKey(true);
        }
        static void MensagemInicial()
        {
            Console.WriteLine("***********************");
            Console.WriteLine("**SISTEMA DE REGISTRO**");
            Console.WriteLine("***********************");
        }
        static void ListarNome()
        {
            Console.WriteLine("Listagem de Nome Selecionada");

            ListaDeNomes.ForEach(x => Console.WriteLine($"Nome: {x}"));

            Console.WriteLine("Listagem de nomes finalizada.");
            Console.ReadKey(true);

        }
        static void RegistrarNome()
        {
            Console.WriteLine("Registro de Nome Selecionado");
            Console.WriteLine("Informa um nome:");
            var nomeInformado = Console.ReadLine();

            ListaDeNomes.Add(nomeInformado);

            Console.WriteLine("Nome informado com sucesso!");
            Console.ReadKey(true);
        }
        static string MostrarMenu()
        {
            Console.WriteLine("Digite o número para a opção desejada:");
            Console.WriteLine("1 - Registrar Nome"); //ok
            Console.WriteLine("2 - Listar Nomes");   //ok 
            Console.WriteLine("3 - Editar Um Nome"); //
            Console.WriteLine("4 - Excluir Nomes");
            Console.WriteLine("5 - Sair do sistema");

            return Console.ReadLine();
        }
    }
}
