namespace IniciandoBancoDeDados.Model
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class IniciandoContext : DbContext
    {

        public IniciandoContext()
            : base("name=IniciandoContext")
        {

        }
        public virtual DbSet<Bebida> Bebidas { get; set; }
    }


}