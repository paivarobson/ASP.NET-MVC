using System.Web.Mvc;
using Modelo.Cadastros;

namespace Aplicacao.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Minha página de Contato";

            return View();
        }
    }
}