using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Filmes2017.Models;
using Filmes2017.Persistencia;
using System.Data.Entity;

namespace Filmes2017.Repository
{
    public class ProdutoraRepository : IProdutoraRepository
    {

        private FilmagemContext _context;


        public ProdutoraRepository(FilmagemContext context)
        {

            _context = context;


        }



        public void Atualizar(Produtora produtora)
        {
            _context.Entry(produtora).State = EntityState.Modified;
        }

        public Produtora Buscar(int id)
        {
           return _context.Produtoras.Find(id);
        }

        public List<Produtora> BuscarPor(Expression<Func<Produtora, bool>> filtro)
        {
           return _context.Produtoras.Include("Filme").Where(filtro).ToList();
        }

        public void Cadastar(Produtora produtora)
        {
             _context.Produtoras.Add(produtora);
        }

        public List<Produtora> Listar()
        {
            return _context.Produtoras.ToList();
        }

        public void Remover(int id)
        {

            Produtora produtora = _context.Produtoras.Find(id);
            _context.Produtoras.Remove(produtora);


        }
    }
}