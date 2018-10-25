using Modelo.Cadastros;
using Servico.Cadastros;
using System.Web.Mvc;

namespace Aplicacao.Areas.Cadastros.Controllers
{
    public class ClienteController : Controller
    {
        private ClienteServico clienteServico = new ClienteServico();

        //Método para retornar View 
        //para entrada de dados de cadastro do Cliente
        public ActionResult Cadastrar()
        {
            return View();
        }

        //Gravar dados de cadastro do BD
        [HttpPost]
        public ActionResult Cadastrar(Cliente cliente)
        {
            try
            {
                clienteServico.CadastrarCliente(cliente);

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
            return View(clienteServico.ConsultarCliente());
        }


        public ActionResult Detalhes(int id)
        {
            return View(clienteServico.ConsultarClientePorID(id));
        }

        //Retorno da View de edição do Cliente selecionado
        public ActionResult Editar(int id)
        {
            return View(clienteServico.ConsultarClientePorID(id));
        }

        //Modificar dados de Clientes cadastrados
        [HttpPost]
        public ActionResult Editar(Cliente cliente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    clienteServico.EditarCliente(cliente);

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
            return View(clienteServico.ConsultarClientePorID(id));
        }

        //Excluir registro de Cliente do BD
        [HttpPost]
        public ActionResult Excluir(int id, Cliente cliente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    clienteServico.ExcluirCliente(id);

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