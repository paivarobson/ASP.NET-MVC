using Modelo.Cadastros;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace Aplicacao.Controllers
{
    /*
    public class ClienteController : Controller
    {

        //Método para retornar View 
        //para entrada de dados de cadastro do Cliente
        public ActionResult Cadastrar()
        {
            return View();
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

        //Retornar dados de Clientes do BD para Exclusão
        public ActionResult Excluir(int id)
        {
            return View(db.Clientes.Find(id));
        }

        //Excluir registro de Cliente do BD
        [HttpPost]
        public ActionResult Excluir(int id, Cliente cliente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    cliente = db.Clientes.Find(id);

                    db.Clientes.Remove(cliente);
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
    */
}