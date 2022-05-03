using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Vendas.Core.Model;
using Vendas.Service.Dtos;
using Vendas.Service.Interfaces;

namespace Vendas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendaController : Controller
    {

        private readonly IVendaService _vendaService;
        public VendaController(IVendaService vendaService)
        {
            _vendaService = vendaService;
        }

        [Route("RegistrarVenda")]
        [HttpPost]
        public async Task<IActionResult> Inserir(Venda venda)
        {

            try
            {
                var retorno = await _vendaService.Inserir(venda);
                return Ok(retorno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [Route("AtualizarVenda")]
        [HttpPut]
        public async Task<IActionResult> Editar(Venda venda)
        {

            try
            {
                var retorno = await _vendaService.Alterar(venda);
                return Ok(retorno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [Route("BuscarVenda")]
        [HttpGet]
        public async Task<IActionResult> BuscarPorId(int idVenda)
        {
            try
            {

                var retorno = await _vendaService.BuscarPorId(idVenda);

                return Ok(retorno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
