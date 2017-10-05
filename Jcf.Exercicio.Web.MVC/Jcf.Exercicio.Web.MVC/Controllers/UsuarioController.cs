using Jcf.Exercicio.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jcf.Exercicio.Web.MVC.Controllers
{
    public class UsuarioController : Controller
    {
        [HttpGet]
        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastro(Usuario usuario)
        {
            TempData["msg"] = "Usuário Cadastrado!";
            ViewBag.mensagem = "Funciona!";
            return View("cadastro", usuario);
        }


    }
}