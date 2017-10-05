using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jcf.Exercicio.Web.MVC.Models
{
    public class Filme
    {
        public int FilmeId { get; set; }

        [Required]
        public string Titulo { get; set; }

        [Required]
        [StringLength(10)]
        public string Genero { get; set; }

        [Required]
        public int Duracao { get; set; }

        [DataType(DataType.DateTime, ErrorMessage ="Data inválida")]
        public DateTime DataLancamento { get; set; }

        public Produtora Produtora { get; set; }

        public int ProdutoraId { get; set; }
    }
}