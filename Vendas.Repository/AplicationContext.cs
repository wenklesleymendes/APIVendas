using Microsoft.EntityFrameworkCore;
using System;
using Vendas.Core.Model;

namespace Vendas.Repository
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Venda> Vendas { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
    }
}
