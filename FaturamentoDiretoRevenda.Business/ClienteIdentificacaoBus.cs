using System.Collections.Generic;
using FaturamentoDiretoRevenda.Repository;
using FaturamentoDiretoRevenda.Model;

namespace FaturamentoDiretoRevenda.Business
{
    public class ClienteIdentificacaoBus
    {
        private ClienteIdentificacaoRep rep = new ClienteIdentificacaoRep();
        public bool Salvar(ClienteIdentificacaoMod obj)
        {
            return rep.Salvar(obj);
        }
        public bool Alterar(ClienteIdentificacaoMod obj)
        {
            return rep.Alterar(obj);
        }
        public bool Delete(ClienteIdentificacaoMod obj)
        {
            return rep.Delete(obj);
        }
        public List<ClienteIdentificacaoMod> Buscar()
        {
            return rep.Buscar();
        }
        public ClienteIdentificacaoMod BuscarId(int Id)
        {
            return rep.BuscarId(Id);
        }
    }
}
