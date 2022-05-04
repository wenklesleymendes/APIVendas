using Moq;
using System;
using System.Collections.Generic;
using Vendas.Core.Enumeradores;
using Vendas.Core.Model;
using Vendas.Repository.Interfaces;
using Vendas.Service.Concretes;
using Xunit;

namespace Vendas.Teste
{
    public class VendasServiceTeste
    {
        [Fact]
        public void TesteInserir()
        {
            //Arrenge
            List<ProdutosVenda> produtosVenda = new List<ProdutosVenda>()
            {
                new ProdutosVenda()
                {
                    Id = 1,
                    IdProduto = 1,
                    IdVenda = 1,
                    Preco = 13,
                    Quantidade = 1
                },
                new ProdutosVenda()
                {
                    Id = 2,
                    IdProduto = 2,
                    IdVenda = 1,
                    Preco = 13,
                    Quantidade = 1
                },
                new ProdutosVenda()
                {
                    Id = 3,
                    IdProduto = 3,
                    IdVenda = 1,
                    Preco = 13,
                    Quantidade = 1
                }
            };
            var venda = new Venda()
            {
                Id = 0,
                IdVendedor = 1,
                Data = DateTime.Now,
                Produtos = produtosVenda,
                Status = 0
            };
            var vendaRepositoryMock = new Mock<IVendaRepository>();
            var vendaService = new VendaService(vendaRepositoryMock.Object);

            //Act
            var resposta = vendaService.Inserir(venda);

            //Assert
            Assert.NotNull(resposta);
        }

        [Fact]
        public void TesteAtualizar()
        {
            //Arrenge
            var vendaRepositoryMock = new Mock<IVendaRepository>();
            var vendaService = new VendaService(vendaRepositoryMock.Object);
            List<ProdutosVenda> produtosVenda = new List<ProdutosVenda>()
            {
                new ProdutosVenda()
                {
                    Id = 1,
                    IdProduto = 1,
                    IdVenda = 1,
                    Preco = 13,
                    Quantidade = 1
                },
                new ProdutosVenda()
                {
                    Id = 2,
                    IdProduto = 2,
                    IdVenda = 1,
                    Preco = 13,
                    Quantidade = 1
                },
                new ProdutosVenda()
                {
                    Id = 3,
                    IdProduto = 3,
                    IdVenda = 1,
                    Preco = 13,
                    Quantidade = 1
                }
            };
            var venda = new Venda()
            {
                Id = 0,
                IdVendedor = 1,
                Data = DateTime.Now,
                Produtos = produtosVenda,
                Status = EnumStatus.Pagamentoaprovado
            };

            //Act
            var resposta = vendaService.Alterar(venda);

            //Assert
            Assert.NotNull(resposta);
        }

        [Fact]
        public void TesteConsultarPorId()
        {
            //Arrenge
            var vendaRepositoryMock = new Mock<IVendaRepository>();
            var vendaService = new VendaService(vendaRepositoryMock.Object);
            int idVenda = 1;

            //Act
            var resposta = vendaService.BuscarPorId(idVenda);

            //Assert
            Assert.NotNull(resposta);
        }
    }
}
