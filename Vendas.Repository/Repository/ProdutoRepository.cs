using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendas.Core.Model;
using Vendas.Repository.Interfaces;

namespace Vendas.Repository.Repository
{
    public class ProdutoRepository : DomainRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(ApplicationContext dbContext) : base(dbContext)
        {

        }
    }
}
