using Vendas.Core.Model;
using Vendas.Repository.Interfaces;

namespace Vendas.Repository.Repository
{
    public class VendedorRepository : DomainRepository<Vendedor>, IVendedorRepository
    {
        public VendedorRepository(ApplicationContext dbContext) : base(dbContext)
        {

        }
    }
}
