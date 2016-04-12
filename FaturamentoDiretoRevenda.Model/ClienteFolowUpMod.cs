using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturamentoDiretoRevenda.Model
{
    public partial class ClienteFolowUpMod
    {
        public int Id { get; set; }
        public Nullable<int> IdCliente { get; set; }
        public string Descricao { get; set; }
        public string Pessoa { get; set; }
        public Nullable<System.DateTime> DataCadastro { get; set; }
        public Nullable<bool> Ativo { get; set; }

        public virtual ClienteIdentificacaoMod ClienteIdentificacao { get; set; }
    }
}
