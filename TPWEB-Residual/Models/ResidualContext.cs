using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TPWEB_Residual.Models
{
    public class ResidualContext : DbContext
    {
        public ResidualContext() : base("name=DefaultConnection")
        {

        }

        public DbSet<Utilizador> Utilizadores { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Recolha> Recolhas { get; set; }

    }
}