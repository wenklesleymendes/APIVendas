using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendas.Core.Model;

namespace VendasCursos.Service.Interfaces
{
    public interface IVendedorService
    {
        Task<Vendedor> CadastraVendedor(Vendedor vendedor);
        Task<Vendedor> AtualizaVendedor(Vendedor vendedor);
        Task<Vendedor> ConsultaVendedor(int idVendedor);
    }
}
