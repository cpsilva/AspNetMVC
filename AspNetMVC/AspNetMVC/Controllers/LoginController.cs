using AspNetMVC.DAO;
using System.Web.Mvc;

namespace AspNetMVC.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        [AllowAnonymous]
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