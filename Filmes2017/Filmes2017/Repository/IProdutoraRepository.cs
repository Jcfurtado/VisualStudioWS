using Filmes2017.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Filmes2017.Repository
{
   public interface IProdutoraRepository
    {

        void Cadastar(Produtora produtora);
        void Atualizar(Produtora produtora);
        void Remover(int id);
        Produtora Buscar(int id);
        List<Produtora> Listar();
        List<Produtora> BuscarPor(Expression<Func<Produtora, bool>> filtro);

    }
}
