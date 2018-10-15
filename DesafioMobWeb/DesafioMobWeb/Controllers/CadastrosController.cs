﻿using DesafioMobWeb.Models;
using System.Web.Mvc;

namespace DesafioMobWeb.Controllers
{
    public class CadastrosController : Controller
    {
        public ActionResult CadastroUsuario()
        {
            return View();
        }
        public ActionResult CadastroCliente()
        {
            var cliente = new Cliente
            {
                clienteID = 1,
                razaoSocialCliente = "Robson Paiva Consultoria",
                fantasiaCliente = "Consultoria SystemsPaiva",
                cnpjCliente = "99.999.999/0001-01",
                ruaCliente = "Rua",
                numeroRuaCliente = 99,
                complementoCliente = "Sem complemento",
                bairroCliente = "Bairro",
                municipioCliente = "Cidade",
                cepCliente = "60000-000"
            };

            return View(cliente);
        }

        
    }
}