using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Quiron.LojaVirtual.Dominio.Repositorio;
using Quiron.LojaVirtual.Web.Models;

namespace Quiron.LojaVirtual.Web.Controllers
{


    public class VitrineController : Controller
    {


        private RepositorioProdutos repositorioProdutos;

        public int produtosPorPagina = 8;

        // GET: Vitrine
        public ViewResult ListaProdutos(int pagina = 1)
        {


            repositorioProdutos = new RepositorioProdutos();

            ProdutosViewModel produtosViewModel = new ProdutosViewModel
            {

                Produtos = repositorioProdutos.Produtos.OrderBy(p => p.Nome).Skip((pagina - 1) * produtosPorPagina).Take(produtosPorPagina),

                Paginacao = new Paginacao
                {

                    
                    PaginaAtual = pagina,

                    
                    ItensPorPagina = produtosPorPagina,


                    ItensTotal = repositorioProdutos.Produtos.Count()

        
                }



            };

            return View(produtosViewModel);
        }
    }
}