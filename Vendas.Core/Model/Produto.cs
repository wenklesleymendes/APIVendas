using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendas.Core.Interfaces;

namespace Vendas.Core.Model
{
    public class Produto : IIdentityEntity
    { 
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Estoque { get; set; }
        public decimal Preco { get; set; }
    }
}
