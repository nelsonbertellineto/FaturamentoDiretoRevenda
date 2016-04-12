using System.Collections.Generic;
using FaturamentoDiretoRevenda.Repository;
using FaturamentoDiretoRevenda.Model;

namespace FaturamentoDiretoRevenda.Business
{
    public class UsuarioBus
    {
        private UsuarioRep rep = new UsuarioRep();
        public bool Salvar(UsuarioMod obj)
        {
            return rep.Salvar(obj);
        }
        public bool Alterar(UsuarioMod obj)
        {
            return rep.Alterar(obj);
        }
        public bool Delete(UsuarioMod obj)
        {
            return rep.Delete(obj);
        }
        public List<UsuarioMod> Buscar()
        {
            return rep.Buscar();
        }
        public UsuarioMod BuscarId(int Id)
        {
            return rep.BuscarId(Id);
        }
    }
}
