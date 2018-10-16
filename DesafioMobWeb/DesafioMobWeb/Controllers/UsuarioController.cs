using System.Web.Mvc;
using DesafioMobWeb.Models;

namespace DesafioMobWeb.Controllers
{
    public class UsuarioController : Controller
    {
        public ActionResult Usuario()
        {
            var usuario = new Usuario();

            return View();
        }

        public ActionResult Criar()
        {
            return View();
        }

        public ActionResult Detalhes(int id)
        {
            return View();
        }

        public ActionResult Editar(int id)
        {
            return View();
        }


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