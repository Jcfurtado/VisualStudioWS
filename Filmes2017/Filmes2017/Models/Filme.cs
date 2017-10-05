using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Filmes2017.Models
{
    public class Filme
    {

        public int  FilmeId { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public int Duracao { get; set; }
        public DateTime DataLancamento { get; set; }


        // mapeando a chave da produtora
        public Produtora Produtora { get; set; }
        public int ProdutoraId { get; set; }




    }
}