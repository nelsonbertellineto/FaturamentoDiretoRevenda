using System;
using System.Collections.Generic;
using System.Linq;
using FaturamentoDiretoRevenda.Model;
using FaturamentoDiretoRevenda.Database;

namespace FaturamentoDiretoRevenda.Repository
{
    public class ClienteIdentificacaoRep
    {
        private FDRConnectionString db;
        public bool Salvar(ClienteIdentificacaoMod obj)
        {
            using (db = new FDRConnectionString())
            {
                var objRep = new ClienteIdentificacao
                {
                    Id = obj.Id,
                    IdRevenda = obj.IdRevenda,
                    TipoCliente = obj.TipoCliente,
                    Nome = obj.Nome,
                    NomeFantasia = obj.NomeFantasia,
                    CNPJ = obj.CNPJ,
                    InscrEstadual = obj.InscrEstadual,
                    DataCadastro = DateTime.Now,
                    Ativo = true,
                    ClienteEnderecamento = obj.ClienteEnderecamento.Select(ce => new ClienteEnderecamento {
                        Bairro = ce.Bairro
                    }).ToList()                    
                };
                db.ClienteIdentificacao.Add(objRep);
                return db.SaveChanges() > 0;
            }
        }
        public bool Alterar(ClienteIdentificacaoMod obj)
        {
            using (db = new FDRConnectionString())
            {
                var objRep = new ClienteIdentificacao
                {
                    Id = obj.Id,
                    IdRevenda = obj.IdRevenda,
                    TipoCliente = obj.TipoCliente,
                    Nome = obj.Nome,
                    NomeFantasia = obj.NomeFantasia,
                    CNPJ = obj.CNPJ,
                    InscrEstadual = obj.InscrEstadual,
                    DataCadastro = obj.DataCadastro,
                    Ativo = true
                    
                };
                db.Entry(objRep).State = System.Data.Entity.EntityState.Modified;
                return db.SaveChanges() > 0;
            }
        }
        public bool Delete(ClienteIdentificacaoMod obj)
        {
            var Ci = BuscarId(obj.Id);

            using (db = new FDRConnectionString())
            {
                var objRep = new ClienteIdentificacao
                {
                    Id = Ci.Id,
                    IdRevenda = Ci.IdRevenda,
                    TipoCliente = Ci.TipoCliente,
                    Nome = Ci.Nome,
                    NomeFantasia = Ci.NomeFantasia,
                    CNPJ = Ci.CNPJ,
                    InscrEstadual = Ci.InscrEstadual,
                    DataCadastro = Ci.DataCadastro,
                    Ativo = false
                };
                db.Entry(objRep).State = System.Data.Entity.EntityState.Modified;
                return db.SaveChanges() > 0;
            }
        }
        public List<ClienteIdentificacaoMod> Buscar()
        {
            using (db = new FDRConnectionString())
            {
                return db.ClienteIdentificacao.AsNoTracking().Select(obj => new ClienteIdentificacaoMod
                {
                    Id = obj.Id,
                    IdRevenda = obj.IdRevenda,
                    TipoCliente = obj.TipoCliente,
                    Nome = obj.Nome,
                    NomeFantasia = obj.NomeFantasia,
                    CNPJ = obj.CNPJ,
                    InscrEstadual = obj.InscrEstadual,
                    DataCadastro = obj.DataCadastro,
                    Ativo = obj.Ativo
                }).ToList();
            }
        }
        public ClienteIdentificacaoMod BuscarId(int Id)
        {
            using (db = new FDRConnectionString())
            {
                return db.ClienteIdentificacao.Where(u => u.Id == Id).Select(obj => new ClienteIdentificacaoMod
                {
                    Id = obj.Id,
                    IdRevenda = obj.IdRevenda,
                    TipoCliente = obj.TipoCliente,
                    Nome = obj.Nome,
                    NomeFantasia = obj.NomeFantasia,
                    CNPJ = obj.CNPJ,
                    InscrEstadual = obj.InscrEstadual,
                    DataCadastro = obj.DataCadastro,
                    Ativo = obj.Ativo
                }).FirstOrDefault();
            }
        }

    }
}
