using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jcf.Exercicio.Web.MVC.Models
{
    public class Produtora
    {
        public int ProdutoraId { get; set; }

        [Required]
        [StringLength(30)]
        public string Nome { get; set; }

        public virtual ICollection<Filme> Filmes { get; set; }
    }
}