using Fiap.Revisao.Models;
using Fiap.Revisao.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Revisao.Controllers
{
    public class PedidoController : Controller
    {
        private LojaContext _context = new LojaContext();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            var lista = _context.Clientes.ToList();
            ViewBag.clientes = new SelectList(lista, "ClienteId", "Nome");
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar( Pedido pedido)
        {
            _context.Pedidos.Add(pedido);
            _context.SaveChanges();
            TempData["msg"] = "Pedido Cadastrado!";
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_context.Pedidos.Include("Cliente").ToList());
        }
    }
}