using System.Threading.Tasks;
using Vendas.Core.Model;
using Vendas.Repository.Interfaces;
using VendasCursos.Service.Interfaces;

namespace VendasCursos.Service.Concretes
{
    public class VendedorService : IVendedorService
    {
        private readonly IVendedorRepository _vendedorRepository;
        public VendedorService(IVendedorRepository vendedorRepository)
        {
            _vendedorRepository = vendedorRepository;
        }

        public async Task<Vendedor>CadastraVendedor(Vendedor vendedor)
        {
            await _vendedorRepository.AddAsync(vendedor);

            return vendedor;
        }

        public async Task<Vendedor> AtualizaVendedor(Vendedor vendedor)
        {
            await _vendedorRepository.UpdateAsync(vendedor);

            return vendedor;
        }

        public async Task<Vendedor> ConsultaVendedor(int idVendedor)
        {
            var vendedor = await _vendedorRepository.GetByIdAsync(idVendedor);

            return vendedor;
        }
    }
}
