using Filmes2017.Models;
using Filmes2017.Unit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filmes2017.Controllers
{
    public class ProdutoraController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();



        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar (Produtora produtora)


        {

            if (ModelState.IsValid) {
                _unit.ProdutoraRepository.Cadastar(produtora);
                _unit.Salvar();
                TempData["msg"] = "Produtora Cadastrada com Sucesso";
             return   RedirectToAction("Cadastrar");
            }else  {



            return View(produtora);
            }
        }
        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }



    }
}