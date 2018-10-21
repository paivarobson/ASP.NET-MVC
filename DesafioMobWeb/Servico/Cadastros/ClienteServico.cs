using Dados.DAL.Cadastros;
using Modelo.Cadastros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servico.Cadastros
{
    public class ClienteServico
    {
        private ClienteDAL clienteDAL = new ClienteDAL();

        //Consulta de Usuários cadastrados
        public IQueryable<Cliente> ConsultarCliente()
        {
            return clienteDAL.ConsultarCliente();
        }

        public Cliente ConsultarClientePorID(int id)
        {
            return clienteDAL.ConsultarClientePorID(id);
        }

        public void CadastrarCliente(Cliente cliente)
        {
            clienteDAL.CadastrarCliente(cliente);

        }

        //Modificar dados de Usuários cadastrados
        public void EditarCliente(Cliente cliente)
        {
            clienteDAL.EditarCliente(cliente);

        }

        //Excluir registro de Usuário do BD
        public void ExcluirCliente(int id)
        {
            clienteDAL.ExcluirCliente(id);
        }
    }
}
