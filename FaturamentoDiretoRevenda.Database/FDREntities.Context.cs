﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FDRConnectionString : DbContext
    {
        public FDRConnectionString()
            : base("name=FDRConnectionString")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ClienteComplemtentar> ClienteComplemtentar { get; set; }
        public virtual DbSet<ClienteContato> ClienteContato { get; set; }
        public virtual DbSet<ClienteEnderecamento> ClienteEnderecamento { get; set; }
        public virtual DbSet<ClienteFolowUp> ClienteFolowUp { get; set; }
        public virtual DbSet<ClienteIdentificacao> ClienteIdentificacao { get; set; }
        public virtual DbSet<Produto> Produto { get; set; }
        public virtual DbSet<Revenda> Revenda { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
    }
}