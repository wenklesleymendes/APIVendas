using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Vendas.Core.Model;
using VendasCursos.Service.Interfaces;

namespace Vendas.API.Controllers
{
    [Route("api-docs/[controller]")]
    [ApiController]
    public class ProdutoController : Controller
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [Route("CadastrarVendedor")]
        [HttpPost]
        public async Task<IActionResult> Inserir(Produto produto)
        {
            try
            {
                var result = await _produtoService.CadastrarProduto(produto);

                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [Route("AtualizarVendedor")]
        [HttpPost]
        public async Task<IActionResult> Atualizar(Produto produto)
        {
            try
            {
                var result = await _produtoService.AtualizarProduto(produto);

                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [Route("ConsultarVendedor")]
        [HttpGet]
        public async Task<IActionResult> Consultar(int idProduto)
        {
            try
            {
                var result = await _produtoService.ConsultarProduto(idProduto);

                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
