using System.Collections.Generic;
using FaturamentoDiretoRevenda.Repository;
using FaturamentoDiretoRevenda.Model;

namespace FaturamentoDiretoRevenda.Business
{
    public class RevendaBus
    {
        private RevendaRep rep = new RevendaRep();
        public bool Salvar(RevendaMod obj)
        {
            return rep.Salvar(obj);
        }
        public bool Alterar(RevendaMod obj)
        {
            return rep.Alterar(obj);
        }
        public bool Delete(RevendaMod obj)
        {
            return rep.Delete(obj);
        }
        public List<RevendaMod> Buscar()
        {
            return rep.Buscar();
        }
        public RevendaMod BuscarId(int Id)
        {
            return rep.BuscarId(Id);
        }
    }
}
