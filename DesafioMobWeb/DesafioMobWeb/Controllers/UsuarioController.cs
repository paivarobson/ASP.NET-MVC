using System.Linq;
using System.Web.Mvc;
using DesafioMobWeb.Context;
using DesafioMobWeb.Models;

namespace DesafioMobWeb.Controllers
{
    public class UsuarioController : Controller
    {
        private ContextoDB db = new ContextoDB();

        public ActionResult Index()
        {

            return View(db.Usuarios.ToList());
        }

        public ActionResult Usuario()
        {
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