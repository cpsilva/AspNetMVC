using AspNetMVC.DAO;
using AspNetMVC.Models;
using System.Web.Mvc;

namespace AspNetMVC.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Authentication(string login, string senha)
        {
            var dao = new UsuariosDAO();

            var usuario = dao.Busca(login, senha);

            if (usuario != null)
            {
                Session["usuarioAutenticado"] = usuario;
                return RedirectToAction("Index", "Produto");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}