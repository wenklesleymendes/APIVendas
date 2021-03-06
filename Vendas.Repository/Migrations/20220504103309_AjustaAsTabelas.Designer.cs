// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vendas.Repository;

namespace Vendas.Repository.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220504103309_AjustaAsTabelas")]
    partial class AjustaAsTabelas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("Vendas.Core.Model.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<int>("Estoque")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Preco")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("Vendas.Core.Model.ProdutosVenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdProduto")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdVenda")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Preco")
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantidade")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("VendaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("VendaId");

                    b.ToTable("ProdutosVenda");
                });

            modelBuilder.Entity("Vendas.Core.Model.Venda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Data")
                        .HasColumnType("TEXT");

                    b.Property<int>("IdVendedor")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Vendas");
                });

            modelBuilder.Entity("Vendas.Core.Model.Vendedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CPF")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Vendedor");
                });

            modelBuilder.Entity("Vendas.Core.Model.ProdutosVenda", b =>
                {
                    b.HasOne("Vendas.Core.Model.Venda", null)
                        .WithMany("Produtos")
                        .HasForeignKey("VendaId");
                });

            modelBuilder.Entity("Vendas.Core.Model.Venda", b =>
                {
                    b.Navigation("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
