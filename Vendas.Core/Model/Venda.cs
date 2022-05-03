using System;
using System.Collections.Generic;
using Vendas.Core.Enumeradores;
using Vendas.Core.Interfaces;

namespace Vendas.Core.Model
{
    public class Venda : EntidadeBase, IIdentityEntity
    {
        public int Id { get; set; }
        public int IdVendedor { get; set; }
        public DateTime Data { get; set; }     
        public EnumStatus Status { get; set; }
        public List<ProdutosVenda> Produtos { get; set; }
    }
}
