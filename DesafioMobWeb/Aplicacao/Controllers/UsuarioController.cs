using Modelo.Cadastros;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Servico.Cadastros;

namespace Aplicacao.Controllers
{
    public class UsuarioController : Controller
    {
        private UsuarioServico usuarioServico = new UsuarioServico();

        //Método para retornar View 
        //para entrada de dados de cadastro do Usuário
        public ActionResult Cadastrar()
        {
            return View();
        }

        //Gravar dados de cadastro do BD
        [HttpPost]
        public ActionResult Cadastrar(Usuario usuario)
        {
            try
            {
                usuarioServico.CadastrarUsuario(usuario);

                return RedirectToAction("Consultar");
            }
            catch
            {
                return View();
            }

        }

        //Consulta de Usuários cadastrados
        public ActionResult Consultar()
        {
            return View(usuarioServico.ConsultarUsuario());
        }

        public ActionResult Detalhes(int id)
        {
            return View(usuarioServico.ConsultarUsuarioPorID(id));
        }

        //Retornar dados de Usuários do BD para Edição
        public ActionResult Editar(int id)
        {

            return View(usuarioServico.ConsultarUsuarioPorID(id));
        }

        //Modificar dados de Usuários cadastrados
        [HttpPost]
        public ActionResult Editar(Usuario usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    usuarioServico.EditarUsuario(usuario);

                    return RedirectToAction("Consultar");
                }

                return View(usuario);
            }
            catch
            {
                return View();
            }

        }

        //Retornar dados de Usuários do BD para Exclusão
        public ActionResult Excluir(int id)
        {
            return View(usuarioServico.ConsultarUsuarioPorID(id));
        }

        //Excluir registro de Usuário do BD
        [HttpPost]
        public ActionResult Excluir(int id, Usuario usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    usuarioServico.ExcluirUsuario(id);

                    return RedirectToAction("Consultar");
                }

                return View(usuario);
            }
            catch
            {
                return View();
            }
        }

        ////////////////////////////////////////////////////////

        [HttpPost]
        public ActionResult Usuario(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                return View("ResultadoUsuario", usuario);
            }

            return View(usuario);
        }

        public ActionResult ResultadoUsuario(Usuario usuario)
        {
            return View(usuario);
        }
    }
}