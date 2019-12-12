namespace CadasTroDePessoa.Model
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CadastroContext : DbContext
    {
         public CadastroContext()
            : base("name=CadastroContext")
        {
        }
        public virtual DbSet<Pessoa> Pessoas { get; set; }
    }
}