using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Vendas.Core.Model;
using Vendas.Service.Interfaces;
using VendasCursos.Service.Interfaces;

namespace Vendas.API.Controllers
{
    [Route("api-docs/[controller]")]
    [ApiController]
    public class VendedorController : Controller
    {

        private readonly IVendedorService _vendedorService;

        public VendedorController(IVendedorService vendedorService)
        {
            _vendedorService = vendedorService;
        }

        [Route("CadastrarVendedor")]
        [HttpPost]
        public async Task<IActionResult> Inserir(Vendedor vendedor)
        {
            try
            {
                var result = await _vendedorService.CadastraVendedor(vendedor);

                return Ok(result);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [Route("AtualizarVendedor")]
        [HttpPost]
        public async Task<IActionResult> Atualiza(Vendedor vendedor)
        {
            try
            {
                var result = await _vendedorService.AtualizaVendedor(vendedor);

                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [Route("ConsultarVendedor")]
        [HttpGet]
        public async Task<IActionResult> Consulta(int idVendedor)
        {
            try
            {
                var result = await _vendedorService.ConsultaVendedor(idVendedor);

                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
