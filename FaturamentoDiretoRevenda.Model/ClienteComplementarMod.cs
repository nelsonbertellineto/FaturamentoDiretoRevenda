using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturamentoDiretoRevenda.Model
{
    public partial class ClienteComplemtentarMod
    {
        public int Id { get; set; }
        public Nullable<int> IdCliente { get; set; }
        public string WebSite { get; set; }
        public string EmailNF { get; set; }
        public Nullable<int> IdCondicaoPagto { get; set; }
        public string Desconto { get; set; }
        public string LimiteCredito { get; set; }
        public string ObservacaoGeral { get; set; }
        public string ObservacaoFaturamento { get; set; }
        public Nullable<System.DateTime> DataCadastro { get; set; }
        public Nullable<System.DateTime> DataUltimaAlteracao { get; set; }
        public Nullable<bool> Ativo { get; set; }

        public virtual ClienteIdentificacaoMod ClienteIdentificacao { get; set; }
    }
}
