using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DesafioMobWeb.Controllers
{
    public class CadastrosController : Controller
    {
        public ActionResult CadastroUsuario()
        {
            return View();
        }
        public ActionResult CadastroCliente()
        {
            return View();
        }

        
    }
}