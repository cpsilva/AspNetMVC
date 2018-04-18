using AspNetMVC.DAO;
using AspNetMVC.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AspNetMVC.Controllers
{
    public class CategoriaController : Controller
    {
        public ActionResult Index()
        {
            IList<CategoriaDoProduto> categorias = new CategoriasDAO().Lista();

            ViewBag.Categorias = categorias;

            return View();
        }

        public ActionResult Form()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Adiciona(CategoriaDoProduto categoria)
        {
            new CategoriasDAO().Adiciona(categoria);
            return RedirectToAction("Index", "Categoria");
        }
    }
}