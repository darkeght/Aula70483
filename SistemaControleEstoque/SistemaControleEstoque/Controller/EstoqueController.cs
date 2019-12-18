using SistemaControleEstoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControleEstoque.Controller
{
    public class EstoqueController
    {
        SistemaContext ctx;

        public EstoqueController()
        {
            ctx = new SistemaContext();
        }

        public void InsereEstoque(Estoque item)
        {
            ctx.Estoques.Add(item);
            ctx.SaveChanges();
        }

        public List<Estoque> GetEstoques()
        {
            return ctx.Estoques.ToList<Estoque>();
        }

   
    }
}
