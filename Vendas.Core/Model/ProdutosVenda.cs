using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendas.Core.Interfaces;

namespace Vendas.Core.Model
{
    public class ProdutosVenda : IIdentityEntity
    {
        public int Id { get; set; }
        public int IdVenda { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
    }
}
