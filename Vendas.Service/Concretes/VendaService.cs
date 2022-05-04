using Vendas.Core.Model;
using Vendas.Repository.Interfaces;
using Vendas.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Vendas.Core.Enumeradores;
using Microsoft.EntityFrameworkCore;

namespace Vendas.Service.Concretes
{
    public class VendaService : IVendaService
    {

        private readonly IVendaRepository _vendaRepository;

        public VendaService(IVendaRepository vendaRepository)
        {
            _vendaRepository = vendaRepository;
        }
        public async Task<Venda> Alterar(Venda venda)
        {
            if (!await EhParaAtualizarStatus(venda))
            {
                throw new Exception("Não foi possível alterar a venda! \nStatus não permitido.");
            }

            await _vendaRepository.UpdateAsync(venda);

            return venda;
        }

        public async Task<Venda> BuscarPorId(int idVenda)
        {

            var venda = await _vendaRepository.GetByIdAsync(idVenda);          

            return venda;
        }

        public async Task<Venda> Inserir(Venda venda)
        {
            if (venda.Produtos.Count == 0)
            {
                throw new Exception("Insira ao menos um item");   
            }

            await _vendaRepository.AddAsync(venda);

            return venda; ;
        }

        public async Task<bool> EhParaAtualizarStatus(Venda venda)
        {
            var registroAnterior = await _vendaRepository.GetByIdAsync(venda.Id);

            return registroAnterior.Status switch
            {
                EnumStatus.AguardandoPagamento when venda.Status == EnumStatus.Pagamentoaprovado => true,
                EnumStatus.AguardandoPagamento when venda.Status == EnumStatus.Cancelada => true,
                EnumStatus.Pagamentoaprovado when venda.Status == EnumStatus.EnviadoparaTransportadora => true,
                EnumStatus.Pagamentoaprovado when venda.Status == EnumStatus.Cancelada => true,
                EnumStatus.EnviadoparaTransportadora when venda.Status == EnumStatus.Entregue => true,
                _ => false
            };
        }
    }
}
