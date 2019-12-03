using System;
using System.Collections.Generic;

namespace MinhaAplicacaoConsole
{ 
 class Program
    {
        static void Main(string[] args)
        {
            //Aqui criamos o corpo do nosso objeto
            List<string> 
                //Damos um nome ao nosso objeto
                minhaLista 
                = 
                //Aqui damos a vida a ela, ou seja iniciamos ele na memoria
                new List<string>
            {
                    //Como resultado podemos adicionar varios nomes ao "minhaLista
                "Felipe",
                "Giomar",
                "Ariosvaldo",
                "Adagoberto",
                "Valdisney",
                "Rusbervaldo"
            };

            //Chamamos pelo nome minha lista de nome
            minhaLista
                .ForEach(//Uma função reservada do linq para ler cada nome da nossa lista
                x //Aqui temos ja carregado nome por nome
                => // Falamos que ao lado ele ira passar o nome para utilizar no codigo
                //Aqui no console mostramos ele em tela para o usuario visualizar
                Console.WriteLine(x));

            //Aqui apenas acionamos um comando para ele parar e assim conseguirmos visualizar as 
            //informações
            Console.ReadKey(true);

        }
    }
}
