using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FaturamentoDiretoRevenda.Business;
using FaturamentoDiretoRevenda.Model;

namespace FaturamentoDiretoRevenda.Controllers
{
    public class RevendaController : Controller
    {
        readonly RevendaBus bus = new RevendaBus();

        // GET: Revenda
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
        public ActionResult Create(RevendaMod obj)
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
        public ActionResult Edit(RevendaMod obj)
        {
            bus.Alterar(obj);
            return RedirectToAction("Index");
        }
        public ActionResult Excluir(int Id)
        {
            var obj = bus.BuscarId(Id);
            return View(obj);
        }
        [HttpPost]
        public ActionResult Delete(RevendaMod obj)
        {
            bus.Delete(obj);
            return RedirectToAction("Index");
        }
    }
}