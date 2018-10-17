using DesafioMobWeb.Context;
using DesafioMobWeb.Models;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace DesafioMobWeb.Controllers
{
    public class ClienteController : Controller
    {
        public ContextoDB db = new ContextoDB();

        Cliente insercaoDeDadosCliente = new Cliente
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

        //Método para retornar View 
        //para entrada de dados de cadastro do Cliente
        public ActionResult Cadastrar()
        {
            return View(insercaoDeDadosCliente);
        }

        //Gravar dados de cadastro do BD
        [HttpPost]
        public ActionResult Cadastrar(Cliente cli)
        {
            try
            {
                db.Clientes.Add(cli);
                db.SaveChanges();

                return RedirectToAction("Consultar");
            }
            catch
            {
                return View();
            }
        }

        //Consulta de Clientes cadastrados
        public ActionResult Consultar()
        {
            return View(db.Clientes.ToList());
        }


        public ActionResult Detalhes(int id)
        {
            return View(db.Clientes.Find(id));
        }

        //Retorno da View de edição do Cliente selecionado
        public ActionResult Editar(int id)
        {
            return View(db.Clientes.Find(id));
        }

        //Modificar dados de Clientes cadastrados
        [HttpPost]
        public ActionResult Editar(Cliente cliente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(cliente).State = EntityState.Modified;
                    db.SaveChanges();

                    return RedirectToAction("Consultar");
                }

                return View(cliente);
            }
            catch
            {
                return View();
            }
        }


    }
}