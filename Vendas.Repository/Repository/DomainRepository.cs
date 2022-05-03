using Vendas.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Vendas.Core.Interfaces;

namespace Vendas.Repository.Repository
{
    public class DomainRepository<TEntidade> : RepositoryBase<TEntidade>, IDomainRepository<TEntidade> where TEntidade : class, IIdentityEntity
    {
        protected DomainRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
