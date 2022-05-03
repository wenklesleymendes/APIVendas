using Vendas.Core.Model;
using Vendas.Repository.Interfaces;

namespace Vendas.Repository.Repository
{
    public class VendaRepository : DomainRepository<Venda>, IVendaRepository
    {
        public VendaRepository(ApplicationContext dbContext) : base(dbContext)
        {

        }
    }
}
