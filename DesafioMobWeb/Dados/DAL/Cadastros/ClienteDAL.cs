using Dados.Context;
using Modelo.Cadastros;
using System.Data.Entity;
using System.Linq;

namespace Dados.DAL.Cadastros
{
    public class ClienteDAL
    {
        private ContextoDB db = new ContextoDB();

        //Consulta de Clientes cadastrados por ordem crescente do ID
        public IQueryable<Cliente> ConsultarCliente()
        {
            return db.Clientes.OrderBy(x => x.ClienteID);
        }

        //Consulta de Clientes cadastrados por ID
        public Cliente ConsultarClientePorID(int id)
        {
            return db.Clientes.Where(x => x.ClienteID == id).First();
        }

        public void CadastrarCliente(Cliente cliente)
        {
            db.Clientes.Add(cliente);
            db.SaveChanges();
        }

        //Modificar dados de Clientes cadastrados
        public void EditarCliente(Cliente cliente)
        {
            db.Entry(cliente).State = EntityState.Modified;
            db.SaveChanges();

        }

        //Excluir registro de Cliente do BD
        public void ExcluirCliente(int id)
        {
            db.Clientes.Remove(db.Clientes.Find(id));
            db.SaveChanges();
        }
    }
}
