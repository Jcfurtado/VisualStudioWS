using Fiap.Revisao.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap.Revisao.Persistencia
{
    public class LojaContext:DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
    }
}