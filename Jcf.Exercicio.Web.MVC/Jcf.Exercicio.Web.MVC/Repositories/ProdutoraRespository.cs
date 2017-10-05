using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Jcf.Exercicio.Web.MVC.Models;
using Jcf.Exercicio.Web.MVC.Persistencia;
using System.Data.Entity;

namespace Jcf.Exercicio.Web.MVC.Repositories
{
    public class ProdutoraRespository : IProdutoraRepository
    {
        private LocadoraContext _context;

        public ProdutoraRespository(LocadoraContext context)
        {
            _context = context;
        }

        public void Atualizar(Produtora produtora)
        {
            _context.Entry(produtora).State = EntityState.Modified;
        }

        public Produtora Buscar(int codigo)
        {
            return _context.Produtoras.Find(codigo);
        }

        public List<Produtora> BuscarPor(Expression<Func<Produtora, bool>> filtro)
        {
            return _context.Produtoras.Include("Filme").Where(filtro).ToList();
        }

        public void Cadastrar(Produtora produtora)
        {
            _context.Produtoras.Add(produtora);
        }

        public List<Produtora> Listar()
        {
            return _context.Produtoras.ToList();
        }

        public void Remover(int codigo)
        {
            var produtora = _context.Produtoras.Find(codigo);
            _context.Produtoras.Remove(produtora);
        }
    }
}