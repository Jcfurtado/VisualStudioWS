using Jcf.Exercicio.Web.MVC.Persistencia;
using Jcf.Exercicio.Web.MVC.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jcf.Exercicio.Web.MVC.Unit
{
    public class UnitOfWork : IDisposable
    {
        private LocadoraContext _context;
        private IFilmeRepository _filmeRepository;
        private IProdutoraRepository _produtoraRepository;

        public IFilmeRepository FilmeRepository
        {
            get
            {
                if (_filmeRepository == null)
                {
                    _filmeRepository = new FilmeRepository(_context);
                }
                return _filmeRepository;
            }
        }

        public IProdutoraRepository ProdutoraRepository
        {
            get
            {
                if (_produtoraRepository == null)
                {
                    _produtoraRepository = new ProdutoraRespository(_context);
                }
                return _produtoraRepository;
            }
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
            GC.SuppressFinalize(this);
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}