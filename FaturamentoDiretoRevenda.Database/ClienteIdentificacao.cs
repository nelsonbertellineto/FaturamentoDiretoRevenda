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
    
    public partial class ClienteIdentificacao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClienteIdentificacao()
        {
            this.ClienteComplemtentar = new HashSet<ClienteComplemtentar>();
            this.ClienteContato = new HashSet<ClienteContato>();
            this.ClienteEnderecamento = new HashSet<ClienteEnderecamento>();
            this.ClienteFolowUp = new HashSet<ClienteFolowUp>();
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
        public virtual ICollection<ClienteComplemtentar> ClienteComplemtentar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClienteContato> ClienteContato { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClienteEnderecamento> ClienteEnderecamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClienteFolowUp> ClienteFolowUp { get; set; }
        public virtual Revenda Revenda { get; set; }
    }
}
