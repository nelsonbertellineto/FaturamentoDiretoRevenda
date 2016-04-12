using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FaturamentoDiretoRevenda.Business;
using FaturamentoDiretoRevenda.Model;

namespace FaturamentoDiretoUsuario.Controllers
{
    public class UsuarioController : Controller
    {
        readonly UsuarioBus bus = new UsuarioBus();

        // GET: Usuario
        public ActionResult Index()
        {
            var obj = bus.Buscar();
            return View(obj);
        }
        public ActionResult Create()
        {            
            return View();
        }
        [HttpPost]
        public ActionResult Create(UsuarioMod obj)
        {
            bus.Salvar(obj);
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int Id)
        {
            var obj = bus.BuscarId(Id);
            return View(obj);
        }
        [HttpPost]
        public ActionResult Edit(UsuarioMod obj)
        {
            bus.Alterar(obj);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int Id)
        {
            var obj = bus.BuscarId(Id);
            return View(obj);
        }
        [HttpPost]
        public ActionResult Delete(UsuarioMod obj)
        {
            bus.Delete(obj);
            return RedirectToAction("Index");
        }
    }
}