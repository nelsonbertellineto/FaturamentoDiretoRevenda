using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturamentoDiretoRevenda.Model
{
    public partial class RevendaMod
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RevendaMod()
        {
            this.ClienteIdentificacao = new HashSet<ClienteIdentificacaoMod>();
            this.Produto = new HashSet<ProdutoMod>();
            this.Usuario = new HashSet<UsuarioMod>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public string NomeResponsavel { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public Nullable<System.DateTime> DataCadastro { get; set; }
        public Nullable<int> QuantidadeUsuariosAcesso { get; set; }
        public Nullable<int> AcessoLibertado { get; set; }
        public Nullable<System.DateTime> DataTerminoAcesso { get; set; }
        public Nullable<System.DateTime> DataUltimaAlteracao { get; set; }
        public string ChaveLiberacaoAcesso { get; set; }
        public Nullable<bool> Ativo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClienteIdentificacaoMod> ClienteIdentificacao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProdutoMod> Produto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsuarioMod> Usuario { get; set; }
    }
}
