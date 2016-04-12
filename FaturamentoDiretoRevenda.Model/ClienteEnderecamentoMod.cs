using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturamentoDiretoRevenda.Model
{
    public partial class ClienteEnderecamentoMod
    {
        public int Id { get; set; }
        public Nullable<int> IdCliente { get; set; }
        public Nullable<int> TipoEndereco { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public string UF { get; set; }
        public Nullable<System.DateTime> DataCadastro { get; set; }
        public Nullable<bool> Ativo { get; set; }

        public virtual ClienteIdentificacaoMod ClienteIdentificacao { get; set; }
    }
}
