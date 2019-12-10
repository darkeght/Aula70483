using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPessoaMaiorIdade.CLasses
{
    class Pessoa
    {
        public string NomeCompleto { get; set; }
        public DateTime DataNascimento { get; set; }

        public string BebidaAlcoolica { get { return PodeBeber(); } }

        private string PodeBeber()
        {
            if(2019 - DataNascimento.Year >= 18)
            {
                return "Pode beber";
            }
            else
            {
                return "So leite ninho pra você";
            }
        }
    }
}
