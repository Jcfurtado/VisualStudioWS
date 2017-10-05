using Jcf.Exercicio.Web.MVC.Models;
using Jcf.Exercicio.Web.MVC.Unit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jcf.Exercicio.Web.MVC.Controllers
{
    public class ProdutoraController : Controller
    {
        UnitOfWork _unit = new UnitOfWork();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Produtora produtora)
        {
            _unit.ProdutoraRepository.Cadastrar(produtora);
            _unit.Salvar();
            TempData["msg"] = "Produtora Cadastrada!";
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_unit.ProdutoraRepository.Listar());
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}