using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Jcf.Exercicio.Web.MVC.Models;
using Jcf.Exercicio.Web.MVC.Persistencia;

namespace Jcf.Exercicio.Web.MVC.Repositories
{
    public class FilmeRepository : IFilmeRepository
    {
        private LocadoraContext _context;

        public FilmeRepository(LocadoraContext context)
        {
            _context = context;
        }
        public void Remover(int codigo)
        {
            var filme = _context.Filmes.Find(codigo);
            _context.Filmes.Remove(filme);
        }

        public List<Filme> Listar()
        {
            return _context.Filmes.Include("Produtora").ToList();
        }

        public Filme Buscar(int codigo)
        {
            return _context.Filmes.Find(codigo);
        }

        public void Cadastrar(Filme filme)
        {
            _context.Filmes.Add(filme);
        }

        public List<Filme> BuscarPor(Expression<Func<Filme, bool>> predicate)
        {
            return _context.Filmes.Include("Produtora").Where(predicate).ToList();
        }

        public void Atualizar(Filme filme)
        {
            throw new NotImplementedException();
        }
    }
}