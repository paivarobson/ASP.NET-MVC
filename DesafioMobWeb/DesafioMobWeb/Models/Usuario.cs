using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesafioMobWeb.Models
{
    public class Usuario
    {
        public int usuarioID { get; set; }
        public string nomeUsuario { get; set; }

        public string apelidoUsuario { get; set; }

        public string emailUsuario { get; set; }

        public string telefoneUsuario { get; set; }
    }
}