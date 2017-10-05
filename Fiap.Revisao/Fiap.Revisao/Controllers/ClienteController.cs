using Fiap.Revisao.Models;
using Fiap.Revisao.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Revisao.Controllers
{
    public class ClienteController : Controller
    {
        private LojaContext _context = new LojaContext();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            TempData["msg"] = "Cadastrado!";
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_context.Clientes.ToList());
        }
    }
}