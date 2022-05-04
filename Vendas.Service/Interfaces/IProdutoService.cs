using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendas.Core.Model;

namespace VendasCursos.Service.Interfaces
{
    public interface IProdutoService
    {
        Task<Produto> CadastrarProduto(Produto produto);
        Task<Produto> AtualizarProduto(Produto produto);
        Task<Produto> ConsultarProduto(int idProduto);
    }
}
