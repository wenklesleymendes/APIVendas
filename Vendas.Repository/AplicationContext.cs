using Microsoft.EntityFrameworkCore;
using System;
using Vendas.Core.Model;

namespace Vendas.Repository
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }


        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
    }
}
