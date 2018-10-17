using DesafioMobWeb.Models;
using System.Web.Mvc;

namespace DesafioMobWeb.Controllers
{
    public class ClienteController : Controller
    {
        public ActionResult Cliente()
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

        public ActionResult Cadastrar()
        {
            return View();
        }

        public ActionResult Visualizar(int id)
        {
            return View();
        }

        public ActionResult Editar(int id)
        {
            return View();
        }
    }
}