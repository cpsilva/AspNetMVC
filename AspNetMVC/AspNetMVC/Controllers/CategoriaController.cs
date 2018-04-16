using AspNetMVC.DAO;
using AspNetMVC.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AspNetMVC.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: Categoria
        public ActionResult Index()
        {
            IList<CategoriaDoProduto> categorias = new CategoriasDAO().Lista();

            ViewBag.Categorias = categorias;

            return View();
        }
    }
}