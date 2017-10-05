using Jcf.Exercicio.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Jcf.Exercicio.Web.MVC.Persistencia
{
    public class LocadoraContext: DbContext
    {
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Produtora> Produtoras { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public List<Produtora> Times { get; internal set; }
    }
}