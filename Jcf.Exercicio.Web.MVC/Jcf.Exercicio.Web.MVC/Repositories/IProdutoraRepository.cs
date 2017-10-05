using Jcf.Exercicio.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Jcf.Exercicio.Web.MVC.Repositories
{
    public interface IProdutoraRepository
    {
        void Cadastrar(Produtora produtora);
        List<Produtora> Listar();
        void Atualizar(Produtora produtora);
        void Remover(int codigo);
        Produtora Buscar(int codigo);
        List<Produtora> BuscarPor(Expression<Func<Produtora, bool>> filtro);
    }
}
