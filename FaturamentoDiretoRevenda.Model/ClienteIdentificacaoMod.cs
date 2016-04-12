using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturamentoDiretoRevenda.Model
{
    public partial class ClienteIdentificacaoMod
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClienteIdentificacaoMod()
        {
            this.ClienteComplemtentar = new HashSet<ClienteComplemtentarMod>();
            this.ClienteContato = new HashSet<ClienteContatoMod>();
            this.ClienteEnderecamento = new HashSet<ClienteEnderecamentoMod>();
            this.ClienteFolowUp = new HashSet<ClienteFolowUpMod>();
        }

        public int Id { get; set; }
        public Nullable<int> IdRevenda { get; set; }
        public Nullable<int> TipoCliente { get; set; }
        public string Nome { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public string InscrEstadual { get; set; }
        public Nullable<System.DateTime> DataCadastro { get; set; }
        public Nullable<bool> Ativo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClienteComplemtentarMod> ClienteComplemtentar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClienteContatoMod> ClienteContato { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClienteEnderecamentoMod> ClienteEnderecamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClienteFolowUpMod> ClienteFolowUp { get; set; }
        public virtual RevendaMod Revenda { get; set; }
    }
}
