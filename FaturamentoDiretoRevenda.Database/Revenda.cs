//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FaturamentoDiretoRevenda.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Revenda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Revenda()
        {
            this.ClienteIdentificacao = new HashSet<ClienteIdentificacao>();
            this.Produto = new HashSet<Produto>();
            this.Usuario = new HashSet<Usuario>();
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
        public virtual ICollection<ClienteIdentificacao> ClienteIdentificacao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Produto> Produto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
