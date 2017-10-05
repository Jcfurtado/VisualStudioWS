using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Revisao.Models
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }

        public Cliente Cliente { get; set; }

        public int ClienteId { get; set; }

    }
}