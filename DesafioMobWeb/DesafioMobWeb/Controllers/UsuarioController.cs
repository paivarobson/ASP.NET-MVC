using System.Web.Mvc;
using DesafioMobWeb.Models;

namespace DesafioMobWeb.Controllers
{
    public class UsuarioController : Controller
    {
        public ActionResult CadastroUsuario()
        {
            var usuario = new Usuario();

            return View();
        }

        [HttpPost]
        public ActionResult CadastroUsuario(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                return View("Resultado", usuario);
            }

            return View(usuario);
        }

        public ActionResult ResultadoUsuario(Usuario usuario)
        {
            return View(usuario);
        }
    }
}