using System.Data.Entity;
using Modelo.Cadastros;

namespace Persistencia.Context
{
    public class ContextoDB : DbContext
    {
        //Construtor buscando conexão do BD
        public ContextoDB() : base("ContextoDB") { }
        
        public DbSet<Usuario> Usuarios { get; set; }
        

        public DbSet<Cliente> Clientes { get; set; }
    }
}