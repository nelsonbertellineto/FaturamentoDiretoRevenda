using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturamentoDiretoRevenda.Model
{
    public partial class ClienteContatoMod
    {
        public int Id { get; set; }
        public Nullable<int> IdCliente { get; set; }
        public Nullable<int> TipoContato { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cargo { get; set; }
        public string Telefone { get; set; }
        public Nullable<System.DateTime> DataCadastro { get; set; }
        public Nullable<bool> Ativo { get; set; }

        public virtual ClienteIdentificacaoMod ClienteIdentificacao { get; set; }
    }
}
