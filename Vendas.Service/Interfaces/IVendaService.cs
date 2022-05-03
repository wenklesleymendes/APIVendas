using Vendas.Service.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vendas.Core.Model;

namespace Vendas.Service.Interfaces
{
    public interface IVendaService
    {
        Task<Venda> Inserir(Venda venda);
        Task<Venda> Alterar(Venda venda);
        Task<DtoVenda> BuscarPorId(int idVenda);
    }
}
