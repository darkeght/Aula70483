using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControleEstoque.Model
{
    public class Estoque : ControleUsuario
    {
        [Key]
        public int Id { get; set; }
        public string Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
    }
}
