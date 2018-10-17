using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using DesafioMobWeb.Context;
using DesafioMobWeb.Models;

namespace DesafioMobWeb.Controllers
{
    public class UsuarioController : Controller
    {
        Usuario usu = new Usuario();

        private ContextoDB db = new ContextoDB();

        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Usuario usuario)
        {
            try
            {
                db.Usuarios.Add(usuario);
                db.SaveChanges();

                return RedirectToAction("Consultar");
            }
            catch
            {
                return View();
            }
            
        }

        //Método para Consulta de Usuários
        public ActionResult Consultar()
        {

            return View(db.Usuarios.ToList());
        }

        public ActionResult Detalhes(int id)
        {

            var usuario = db.Usuarios.Find(id);

            return View(usuario);
        }

        public ActionResult Editar(int id)
        {

            return View(db.Usuarios.Find(id));
        }

        [HttpPost]
        public ActionResult Editar(Usuario usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(usuario).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Consultar");
                }

                return View(usuario);
            }   
            catch
            {
                return View();
            }

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