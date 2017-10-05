    using Filmes2017.Persistencia;
using Filmes2017.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filmes2017.Unit
{
    public class UnitOfWork : IDisposable
    {

        private FilmagemContext _context = new FilmagemContext();


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

                    _produtoraRepository = new ProdutoraRepository(_context);


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

        // Metodo salvar com saveChanges do context
        public void Salvar()
        {

            _context.SaveChanges();

        }


    }
}