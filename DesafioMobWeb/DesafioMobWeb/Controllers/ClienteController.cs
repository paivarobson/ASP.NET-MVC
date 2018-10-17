using DesafioMobWeb.Context;
using DesafioMobWeb.Models;
using System.Web.Mvc;

namespace DesafioMobWeb.Controllers
{
    public class ClienteController : Controller
    {
        public ContextoDB db = new ContextoDB();

        var insercaoDeDadosCliente = new Cliente
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

        public ActionResult Cliente()
        {
            

            return View(insercaoDeDadosCliente);
        }


        public ActionResult Cadastrar()
        {
            return View(insercaoDeDadosCliente);
        }

        [HttpPost]
        public ActionResult Cadastrar(Cliente cli)
        {
            try
            {
                db.Clientes.Add(cli);
                db.SaveChanges();

                return RedirectToAction("Editar");
            }
            catch
            {
                return View();
            }
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