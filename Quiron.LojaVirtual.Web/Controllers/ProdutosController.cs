using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Quiron.LojaVirtual.Dominio.Repositorio;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class ProdutosController : Controller
    {

        private RepositorioProdutos repositorioProdutos;

        // GET: Produtos
        public ActionResult Index()
        {

            repositorioProdutos = new RepositorioProdutos();

            var produtos = repositorioProdutos.Produtos.Take(10);

            return View(produtos);
        }
    }
}