using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TPWEB_Residual.Models
{
    public class ResidualContext : ApplicationDbContext //DbContext
    {
        public ResidualContext() // : base("name=DefaultConnection") -----> // nota: não esquecer de alterar o connectionString web.config
        {

        }

        public DbSet<Recolha> Recolhas { get; set; }
        public DbSet<Utilizador> Utilizdores { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }

    }
}