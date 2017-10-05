using Jcf.Exercicio.Web.MVC.Models;
using Jcf.Exercicio.Web.MVC.Unit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jcf.Exercicio.Web.MVC.Controllers
{
    public class FilmeController : Controller
    {
        UnitOfWork _unit = new UnitOfWork();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            //BUSCA TODAS AS PRODUTORAS
            var lista = _unit.ProdutoraRepository.Listar();
            ViewBag.produtoras = new SelectList(lista, "ProdutoraId", "Nome");
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Filme filme)
        {
            if (string.IsNullOrEmpty(filme.Titulo))
            {
                ModelState.AddModelError("Titulo", "Título Obrigatório");
            }

            if (ModelState.IsValid)
            {
                _unit.FilmeRepository.Cadastrar(filme);
                _unit.Salvar();
                TempData["msg"] = "Filme Cadastrado!";
                return RedirectToAction("Cadastrar");
            }
            else
            {
                var lista = _unit.ProdutoraRepository.Listar();
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