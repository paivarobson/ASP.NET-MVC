﻿using Dados.Context;
using Modelo.Cadastros;
using System.Data.Entity;
using System.Linq;

namespace Dados.DAL.Cadastros
{
    public class UsuarioDAL
    {
        private ContextoDB db = new ContextoDB();

        //Consulta de Usuários cadastrados por ordem crescente do ID
        public IQueryable<Usuario> ConsultarUsuario()
        {
            return db.Usuarios.OrderBy(x => x.UsuarioID);
        }

        //Consulta de Usuários cadastrados por ID
        public Usuario ConsultarUsuarioPorID(int id)
        {
            return db.Usuarios.Where(x => x.UsuarioID == id).First();
        }

        public void CadastrarUsuario(Usuario usuario)
        {
            db.Usuarios.Add(usuario);
            db.SaveChanges();
            
        }

        //Modificar dados de Usuários cadastrados
        public void EditarUsuario(Usuario usuario)
        {
            db.Entry(usuario).State = EntityState.Modified;
            db.SaveChanges();

        }

        //Excluir registro de Usuário do BD
        public void ExcluirUsuario(int id)
        {
            db.Usuarios.Remove(db.Usuarios.Find(id));
            db.SaveChanges();
        }

    }
}
