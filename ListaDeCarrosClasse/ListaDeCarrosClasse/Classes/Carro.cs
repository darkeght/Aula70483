using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeCarrosClasse.Classes
{
    class Carro
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
        public string Placa
        {
            get
            {
                return TipoPlaca();
            }
        }

        private string TipoPlaca()
        {
            if((2019 - Ano) > 20)
            {
                return "Placa preta";
            }
            else
            {
                return "Placa normal";
            }
        }
    }
}
