using Quiron.LojaVirtual.Web.Models;
using System;
using System.Text;
using System.Web.Mvc;


//Aula:08

namespace Quiron.LojaVirtual.Web.HtmlHelpers
{
    public static class PaginacaoHelpers
    {

        //Total de Pagina = 3

        public static MvcHtmlString PageLinks(this HtmlHelper htmlHelper, Paginacao paginacao, Func<int, string> paginaUrl)
        {


            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i <= paginacao.TotalPagina; i++)
            {

                
                TagBuilder tagBuilder = new TagBuilder("a");

                
                tagBuilder.MergeAttribute("href", paginaUrl(i));

                
                tagBuilder.InnerHtml = i.ToString();


                if (i == paginacao.PaginaAtual)
                {

                    tagBuilder.AddCssClass("selected");

                    tagBuilder.AddCssClass("btn-primary");

                }
                tagBuilder.AddCssClass("btn btn-default");

                stringBuilder.Append(tagBuilder);
            }


            return MvcHtmlString.Create(stringBuilder.ToString());



        }

    }
}