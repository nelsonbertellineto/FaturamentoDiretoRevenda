using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FaturamentoDiretoRevenda.Business;
using FaturamentoDiretoRevenda.Model;

namespace FaturamentoDiretoClienteIdentificacao.Controllers
{
    public class ClienteIdentificacaoController : Controller
    {
        readonly ClienteIdentificacaoBus bus = new ClienteIdentificacaoBus();

        // GET: ClienteIdentificacao
        public ActionResult Index()
        {
            var obj = bus.Buscar();
            return View(obj);
        }
        public ActionResult Create()
        {
            var obj = new ClienteIdentificacaoMod();
            obj.ClienteEnderecamento.Add(new ClienteEnderecamentoMod());
            return View(obj);
        }
        [HttpPost]
        public ActionResult Create(ClienteIdentificacaoMod obj)
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
        public ActionResult Edit(ClienteIdentificacaoMod obj)
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
        public ActionResult Delete(ClienteIdentificacaoMod obj)
        {
            bus.Delete(obj);
            return RedirectToAction("Index");
        }
    }
}