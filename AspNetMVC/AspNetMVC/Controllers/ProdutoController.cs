using System.Collections.Generic;
using System.Web.Mvc;
using AspNetMVC.DAO;
using AspNetMVC.Models;

namespace AspNetMVC.Controllers
{
    public class ProdutoController : Controller
    {
        [Route("produtos", Name = "ListaProduto")]
        public ActionResult Index()
        {
            IList<Produto> produtos = new ProdutosDAO().Lista();

            return View(produtos);
        }

        public ActionResult Form()
        {
            IList<CategoriaDoProduto> categorias = new CategoriasDAO().Lista();
            ViewBag.Produto = new Produto();
            ViewBag.Categorias = categorias;
            
            return View();
        }

        [HttpPost]
        public ActionResult Adiciona(Produto produto)
        {
            int idInformatica = 1;

            if (produto.CategoriaId.Equals(idInformatica) && produto.Preco < 100)
            {
                ModelState.AddModelError("produto.Invalido", "Produto de informatica por menos de R$100");
            }

            if (ModelState.IsValid)
            {
                new ProdutosDAO().Adiciona(produto);

                return RedirectToAction("Index", "Produto");
            }
            else
            {
                IList<CategoriaDoProduto> categorias = new CategoriasDAO().Lista();

                ViewBag.Produto = produto;
                ViewBag.Categorias = categorias;
                return View("Form");
            }
        }

        [Route("produtos/{id}", Name = "VisualizaProduto")]
        public ActionResult Visualizar(int id)
        {
            Produto produto = new ProdutosDAO().BuscaPorId(id);
            ViewBag.Produto = produto;
            return View();
        }
    }
}