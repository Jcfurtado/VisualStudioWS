using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Filmes2017.Models
{
    public class Produtora
    {
        public int ProdutoraId { get; set; }
        [Required]
        public string Nome { get; set; }



        //Relacionamento 1:N onde uma produtora tem 1 ou  vários filmes

        public List<Filme> Filmes { get; set; }

    }
}