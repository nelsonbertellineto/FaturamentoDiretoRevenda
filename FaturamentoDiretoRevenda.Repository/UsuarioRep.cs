using System;
using System.Collections.Generic;
using System.Linq;
using FaturamentoDiretoRevenda.Model;
using FaturamentoDiretoRevenda.Database;

namespace FaturamentoDiretoRevenda.Repository
{
    public class UsuarioRep
    {
        private FDRConnectionString db;
        public bool Salvar(UsuarioMod obj)
        {
            using (db = new FDRConnectionString())
            {
                var objRep = new Usuario
                {
                    Id = obj.Id,
                    Nome = obj.Nome,
                    Login = obj.Login,
                    Senha = obj.Senha,
                    TipoAcesso = obj.TipoAcesso,
                    IdRevenda = obj.IdRevenda,
                    Ativo = true,
                    DataCadastro = DateTime.Now
                };
                db.Usuario.Add(objRep);
                return db.SaveChanges() > 0;
            }
        }
        public bool Alterar(UsuarioMod obj)
        {
            using (db = new FDRConnectionString())
            {
                var objRep = new Usuario
                {
                    Id = obj.Id,
                    Nome = obj.Nome,
                    Login = obj.Login,
                    Senha = obj.Senha,
                    TipoAcesso = obj.TipoAcesso,
                    IdRevenda = obj.IdRevenda,
                    Ativo = true,
                    DataCadastro = obj.DataCadastro
                };
                db.Entry(objRep).State = System.Data.Entity.EntityState.Modified;
                return db.SaveChanges() > 0;
            }
        }
        public bool Delete(UsuarioMod obj)
        {
            var usuario = BuscarId(obj.Id);

            using (db = new FDRConnectionString())
            {
                var objRep = new Usuario
                {
                    Id = usuario.Id,
                    Nome = usuario.Nome,
                    Login = usuario.Login,
                    Senha = usuario.Senha,
                    TipoAcesso = usuario.TipoAcesso,
                    IdRevenda = usuario.IdRevenda,
                    Ativo = false,
                    DataCadastro = usuario.DataCadastro
                };
                db.Entry(objRep).State = System.Data.Entity.EntityState.Modified;
                return db.SaveChanges() > 0;
            }
        }
        public List<UsuarioMod> Buscar()
        {
            using (db = new FDRConnectionString())
            {
                return db.Usuario.AsNoTracking().Select(obj => new UsuarioMod
                {
                    Id = obj.Id,
                    Nome = obj.Nome,
                    Login = obj.Login,
                    Senha = obj.Senha,
                    TipoAcesso = obj.TipoAcesso,
                    IdRevenda = obj.IdRevenda,
                    Ativo = obj.Ativo,
                    DataCadastro = obj.DataCadastro
                }).ToList();
            }
        }
        public UsuarioMod BuscarId(int Id)
        {
            using (db = new FDRConnectionString())
            {
                return db.Usuario.Where(u => u.Id == Id).Select(obj => new UsuarioMod
                {
                    Id = obj.Id,
                    Nome = obj.Nome,
                    Login = obj.Login,
                    Senha = obj.Senha,
                    TipoAcesso = obj.TipoAcesso,
                    IdRevenda = obj.IdRevenda,
                    Ativo = obj.Ativo,
                    DataCadastro = obj.DataCadastro
                }).FirstOrDefault();
            }
        }

    }
}
