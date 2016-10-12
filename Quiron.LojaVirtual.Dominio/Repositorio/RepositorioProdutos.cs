using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quiron.LojaVirtual.Dominio.Entidade;

namespace Quiron.LojaVirtual.Dominio.Repositorio
{
    public class RepositorioProdutos
    {

        private readonly EfDbContext efDbContext = new EfDbContext();


        //Consultar
        public IEnumerable<Produto> Produtos
        {
            get { return efDbContext.Produtos; }
        }


    }
}
