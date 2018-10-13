using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesafioMobWeb.Models
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public String nomeUsuario { get; set; }

        public String apelidoUsuario { get; set; }

        public String emailUsuario { get; set; }

        public String telefoneUsuario { get; set; }
    }
}