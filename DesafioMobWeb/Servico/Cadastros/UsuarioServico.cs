using Dados.DAL.Cadastros;
using Modelo.Cadastros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servico.Cadastros
{
    public class UsuarioServico
    {
        private UsuarioDAL usuarioDAL = new UsuarioDAL();

        //Consulta de Usuários cadastrados
        public IQueryable<Usuario> ConsultarUsuario()
        {
            return usuarioDAL.ConsultarUsuario();
        }

        public Usuario ConsultarUsuarioPorID(int id)
        {
            return usuarioDAL.ConsultarUsuarioPorID(id);
        }

        public void CadastrarUsuario(Usuario usuario)
        {
            usuarioDAL.CadastrarUsuario(usuario);

        }

        //Modificar dados de Usuários cadastrados
        public void EditarUsuario(Usuario usuario)
        {
            usuarioDAL.EditarUsuario(usuario);

        }

        //Excluir registro de Usuário do BD
        public void ExcluirUsuario(int id)
        {
            usuarioDAL.ExcluirUsuario(id);
        }
    }
}
