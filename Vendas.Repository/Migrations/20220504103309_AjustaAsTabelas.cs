using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vendas.Repository.Migrations
{
    public partial class AjustaAsTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AtualizadoEm",
                table: "Vendedor");

            migrationBuilder.DropColumn(
                name: "DeletadoEm",
                table: "Vendedor");

            migrationBuilder.DropColumn(
                name: "EhAtivo",
                table: "Vendedor");

            migrationBuilder.DropColumn(
                name: "EhDeletado",
                table: "Vendedor");

            migrationBuilder.DropColumn(
                name: "AtualizadoEm",
                table: "Vendas");

            migrationBuilder.DropColumn(
                name: "DeletadoEm",
                table: "Vendas");

            migrationBuilder.DropColumn(
                name: "EhAtivo",
                table: "Vendas");

            migrationBuilder.DropColumn(
                name: "EhDeletado",
                table: "Vendas");

            migrationBuilder.DropColumn(
                name: "AtualizadoEm",
                table: "ProdutosVenda");

            migrationBuilder.DropColumn(
                name: "DeletadoEm",
                table: "ProdutosVenda");

            migrationBuilder.DropColumn(
                name: "EhAtivo",
                table: "ProdutosVenda");

            migrationBuilder.DropColumn(
                name: "EhDeletado",
                table: "ProdutosVenda");

            migrationBuilder.DropColumn(
                name: "AtualizadoEm",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "DeletadoEm",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "EhAtivo",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "EhDeletado",
                table: "Produtos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "AtualizadoEm",
                table: "Vendedor",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletadoEm",
                table: "Vendedor",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EhAtivo",
                table: "Vendedor",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EhDeletado",
                table: "Vendedor",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "AtualizadoEm",
                table: "Vendas",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletadoEm",
                table: "Vendas",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EhAtivo",
                table: "Vendas",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EhDeletado",
                table: "Vendas",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "AtualizadoEm",
                table: "ProdutosVenda",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletadoEm",
                table: "ProdutosVenda",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EhAtivo",
                table: "ProdutosVenda",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EhDeletado",
                table: "ProdutosVenda",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "AtualizadoEm",
                table: "Produtos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletadoEm",
                table: "Produtos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EhAtivo",
                table: "Produtos",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EhDeletado",
                table: "Produtos",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }
    }
}
