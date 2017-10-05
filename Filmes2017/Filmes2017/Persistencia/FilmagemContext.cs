using Filmes2017.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Filmes2017.Persistencia
{
    public class FilmagemContext : DbContext
    {

        public DbSet<Filme>Filmes { get; set; }
        public DbSet<Produtora> Produtoras { get; set; }

    }
}