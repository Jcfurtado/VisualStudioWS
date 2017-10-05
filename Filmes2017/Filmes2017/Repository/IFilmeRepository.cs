using Filmes2017.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Filmes2017.Repository
{
   public interface IFilmeRepository
    {

        void Cadastrar(Filme filme);
        void Atualizar(Filme filme);
        void Remover(int id);

        Filme Buscar(int id);
        List<Filme> Listar();
        List<Filme> BuscarPor(Expression<Func<Filme, bool>> filtro);
    }
}
