using DesafioMobWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DesafioMobWeb.Contexto
{
    public class ContextoDB : DbContext
    {
        //Construtor buscando conexão do BD
        public ContextoDB() : base("ConnectionBDMobWeb") { }
        
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Cliente> Clientes { get; set; }
    }
}