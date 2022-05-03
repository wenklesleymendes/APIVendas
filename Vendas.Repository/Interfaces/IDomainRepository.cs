using Vendas.Core.Interfaces;

namespace Vendas.Repository.Interfaces
{
    public interface IDomainRepository<TEntidade> : IRepositoryBase<TEntidade> where TEntidade : class, IIdentityEntity
    {
    }
}
