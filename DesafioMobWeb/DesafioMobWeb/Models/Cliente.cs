using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesafioMobWeb.Models
{
    public class Cliente
    {
        public int clienteID { get; set; }

        public string razaoSocialCliente { get; set; }

        public string fantasiaCliente { get; set; }

        public string cnpjCliente { get; set; }

        public string ruaCliente { get; set; }

        public int numeroRuaCliente { get; set; }

        public string bairroCliente { get; set; }

        public string complementoCliente { get; set; }

        public string municipioCliente { get; set; }

        public int cepCliente { get; set; }

    }
}