using DesafioMobWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DesafioMobWeb.Context
{
    public class ContextoDB : DbContext
    {
        //Construtor buscando conexão do BD
        public ContextoDB() : base("ContextoDB") { }
        
        public DbSet<Usuario> Usuarios { get; set; }
        

        public DbSet<Cliente> Clientes { get; set; }
    }
}