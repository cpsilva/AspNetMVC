﻿using System.Collections.Generic;
using System.Web.Mvc;
using AspNetMVC.DAO;
using AspNetMVC.Models;

namespace AspNetMVC.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {
            IList<Produto> produtos = new ProdutosDAO().Lista();

            ViewBag.Produtos = produtos;

            return View();
        }

        public ActionResult Form()
        {
            IList<CategoriaDoProduto> categorias = new CategoriasDAO().Lista();

            ViewBag.Categorias = categorias;
            return View();
        }

        [HttpPost]
        public ActionResult Adiciona(Produto produto)
        {
            new ProdutosDAO().Adiciona(produto);

            return RedirectToAction("Index", "Produto");
        }
    }
}