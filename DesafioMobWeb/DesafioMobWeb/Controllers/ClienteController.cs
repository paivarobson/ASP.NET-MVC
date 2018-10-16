using DesafioMobWeb.Models;
using System.Web.Mvc;

namespace DesafioMobWeb.Controllers
{
    public class ClienteController : Controller
    {
        public ActionResult CadastroCliente()
        {
            var cliente = new Cliente
            {
                ClienteID = 1,
                RazaoSocialCliente = "Robson Paiva Consultoria",
                FantasiaCliente = "Consultoria SystemsPaiva",
                CnpjCliente = "99.999.999/0001-01",
                RuaCliente = "Rua",
                NumeroRuaCliente = 99,
                ComplementoCliente = "Sem complemento",
                BairroCliente = "Bairro",
                MunicipioCliente = "Cidade",
                CepCliente = "60000-000"
            };

            return View(cliente);
        }
    }
}