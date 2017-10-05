using Filmes2017.Models;
using Filmes2017.Unit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filmes2017.Controllers
{
    public class FilmeController : Controller
    {

        private UnitOfWork _unit = new UnitOfWork();

        [HttpGet]
        public ActionResult Cadastrar()
        {

            // armazena a lista de produtra em uma variavel
            var lista = _unit.ProdutoraRepository.Listar();
            // cria uma view bag com seletlist e uma lista de produtas
            ViewBag.produtoras = new SelectList(lista, "ProdutoraId", "Nome");
            return View();
        }
        [HttpPost]
        public ActionResult Cadastrar(Filme filme)
        {
            if (ModelState.IsValid) {

                _unit.FilmeRepository.Cadastrar(filme);
                _unit.Salvar();
                TempData["msg"] = "Filme Cadastrado com Sucesso";
                return RedirectToAction("Cadastrar");
            }else
            {
                // armazena a lista de produtra em uma variavel
                var lista = _unit.ProdutoraRepository.Listar();
                // cria uma view bag com seletlist e uma lista de produtas
                ViewBag.produtoras = new SelectList(lista, "ProdutoraId", "Nome");
                return View(filme);


            }
        }




        [HttpGet]
        public ActionResult Listar()
        {
            return View(_unit.FilmeRepository.Listar());
        }




        protected override void Dispose(bool disposing)
        {

            _unit.Dispose();
            base.Dispose(disposing);
        }




    }
}