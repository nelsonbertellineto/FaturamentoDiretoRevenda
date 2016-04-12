using System;
using System.Collections.Generic;
using System.Linq;
using FaturamentoDiretoRevenda.Model;
using FaturamentoDiretoRevenda.Database;

namespace FaturamentoDiretoRevenda.Repository
{
    public class RevendaRep
    {
        private FDRConnectionString db;
        public bool Salvar(RevendaMod obj)
        {
            using (db = new FDRConnectionString())
            {
                var objRep = new Revenda
                {
                    Id = obj.Id,
                    Descricao = obj.Descricao,
                    NomeResponsavel = obj.NomeResponsavel,
                    Email = obj.Email,
                    Telefone = obj.Telefone,
                    QuantidadeUsuariosAcesso = obj.QuantidadeUsuariosAcesso,
                    AcessoLibertado  = obj.AcessoLibertado,
                    DataTerminoAcesso = obj.DataTerminoAcesso,
                    DataUltimaAlteracao = DateTime.Now,
                    ChaveLiberacaoAcesso = obj.ChaveLiberacaoAcesso,
                    Ativo = true,
                    DataCadastro = DateTime.Now                    
                };
                db.Revenda.Add(objRep);
                return db.SaveChanges() > 0;
            }
        }
        public bool Alterar(RevendaMod obj)
        {
            using (db = new FDRConnectionString())
            {
                var objRep = new Revenda
                {
                    Id = obj.Id,
                    Descricao = obj.Descricao,
                    NomeResponsavel = obj.NomeResponsavel,
                    Email = obj.Email,
                    Telefone = obj.Telefone,
                    QuantidadeUsuariosAcesso = obj.QuantidadeUsuariosAcesso,
                    AcessoLibertado = obj.AcessoLibertado,
                    DataTerminoAcesso = obj.DataTerminoAcesso,
                    DataUltimaAlteracao = DateTime.Now,
                    ChaveLiberacaoAcesso = obj.ChaveLiberacaoAcesso,
                    Ativo = true,
                    DataCadastro = obj.DataCadastro
                };
                db.Entry(objRep).State = System.Data.Entity.EntityState.Modified;
                return db.SaveChanges() > 0;
            }
        }
        public bool Delete(RevendaMod obj)
        {
            var revenda = BuscarId(obj.Id);

            using (db = new FDRConnectionString())
            {
                var objRep = new Revenda
                {
                    Id = revenda.Id,
                    Descricao = revenda.Descricao,
                    NomeResponsavel = revenda.NomeResponsavel,
                    Email = revenda.Email,
                    Telefone = revenda.Telefone,
                    QuantidadeUsuariosAcesso = revenda.QuantidadeUsuariosAcesso,
                    AcessoLibertado = revenda.AcessoLibertado,
                    DataTerminoAcesso = revenda.DataTerminoAcesso,
                    DataUltimaAlteracao = DateTime.Now,
                    ChaveLiberacaoAcesso = revenda.ChaveLiberacaoAcesso,
                    Ativo = false,
                    DataCadastro = revenda.DataCadastro
                };
                db.Entry(objRep).State = System.Data.Entity.EntityState.Modified;
                return db.SaveChanges() > 0;
            }
        }
        public List<RevendaMod> Buscar()
        {
            using (db = new FDRConnectionString())
            {
                return db.Revenda.AsNoTracking().Select(obj => new RevendaMod
                {
                    Id = obj.Id,
                    Descricao = obj.Descricao,
                    NomeResponsavel = obj.NomeResponsavel,
                    Email = obj.Email,
                    Telefone = obj.Telefone,
                    QuantidadeUsuariosAcesso = obj.QuantidadeUsuariosAcesso,
                    AcessoLibertado = obj.AcessoLibertado,
                    DataTerminoAcesso = obj.DataTerminoAcesso,
                    DataUltimaAlteracao = obj.DataUltimaAlteracao,
                    ChaveLiberacaoAcesso = obj.ChaveLiberacaoAcesso,
                    Ativo = obj.Ativo,
                    DataCadastro = obj.DataCadastro
                }).ToList();
            }
        }
        public RevendaMod BuscarId(int Id)
        {
            using (db = new FDRConnectionString())
            {
                return db.Revenda.Where(u => u.Id == Id).Select(obj => new RevendaMod
                {
                    Id = obj.Id,
                    Descricao = obj.Descricao,
                    NomeResponsavel = obj.NomeResponsavel,
                    Email = obj.Email,
                    Telefone = obj.Telefone,
                    QuantidadeUsuariosAcesso = obj.QuantidadeUsuariosAcesso,
                    AcessoLibertado = obj.AcessoLibertado,
                    DataTerminoAcesso = obj.DataTerminoAcesso,
                    DataUltimaAlteracao = obj.DataUltimaAlteracao,
                    ChaveLiberacaoAcesso = obj.ChaveLiberacaoAcesso,
                    Ativo = obj.Ativo,
                    DataCadastro = obj.DataCadastro
                }).FirstOrDefault();
            }
        }

    }
}
