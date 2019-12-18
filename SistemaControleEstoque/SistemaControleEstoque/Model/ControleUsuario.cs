using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControleEstoque.Model
{
    public class ControleUsuario
    {
        public bool Ativo { get; set; }
        public int UsuarioCriacao { get; set; }
        public int UsuarioAlteracao { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}
