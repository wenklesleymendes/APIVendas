using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendas.Core.Model;
using Vendas.Repository.Interfaces;
using VendasCursos.Service.Interfaces;

namespace VendasCursos.Service.Concretes
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;
        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<Produto> CadastrarProduto(Produto produto)
        {
            await _produtoRepository.AddAsync(produto);

            return produto;
        }

        public async Task<Produto> AtualizarProduto(Produto produto)
        {
            await _produtoRepository.UpdateAsync(produto);

            return produto;
        }

        public async Task<Produto> ConsultarProduto(int idProduto)
        {
            var produto = await _produtoRepository.GetByIdAsync(idProduto);

            return produto;
        }
    }
}
