using Jcf.Exercicio.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Jcf.Exercicio.Web.MVC.Repositories
{
    public interface IFilmeRepository
    {
        void Cadastrar(Filme filme);
        List<Filme> Listar();
        void Atualizar(Filme filme);
        void Remover(int codigo);
        Filme Buscar(int codigo);
        List<Filme> BuscarPor(Expression<Func<Filme, bool>> filtro);
    }
}
