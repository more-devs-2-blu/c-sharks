using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CSharks.NFEs.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class Update9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("96397d8e-90a6-4320-a67a-cda18286bfb7"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("c4599466-04ba-4570-85f4-d3f13c0f78e4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eab4085c-de7e-4a6f-b351-20224630fa6c"));

            migrationBuilder.DeleteData(
                table: "Enterprises",
                keyColumn: "Id",
                keyValue: new Guid("ce5664c3-523f-4791-aeda-bd17d5a55a99"));

            migrationBuilder.InsertData(
                table: "Enterprises",
                columns: new[] { "Id", "City", "CpfCnpj", "Email", "Name" },
                values: new object[] { new Guid("6778bf07-517f-4916-989b-15b17b374203"), "8453", "12345678901234", "csharkenterprise@hotmail.com", "Csharks Developers LTDA" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "aliquota_item_lista_servico", "codigo_item_lista_servico", "codigo_local_prestacao_servico", "descritivo", "situacao_tributaria", "tributa_municipio_prestador", "valor_tributavel" },
                values: new object[,]
                {
                    { new Guid("7e7e5c29-e582-465e-a6f8-ea045c94f392"), "5", "702", "8357", "Teste", "000", "S", "0" },
                    { new Guid("e0015a6c-f696-4eaf-a098-0cfb99fc320e"), "2", "0106", "8357", "Assessoria e consultoria em informática.", "000", "S", "0" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "EnterpriseId", "Login", "Name", "Password", "Profile" },
                values: new object[] { new Guid("1e6a2479-c86a-4e5e-a46b-82b870fa4cb8"), "teste@hotmail.com", new Guid("6778bf07-517f-4916-989b-15b17b374203"), "dev", "Desenvolvedor", "MTIz", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("7e7e5c29-e582-465e-a6f8-ea045c94f392"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("e0015a6c-f696-4eaf-a098-0cfb99fc320e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e6a2479-c86a-4e5e-a46b-82b870fa4cb8"));

            migrationBuilder.DeleteData(
                table: "Enterprises",
                keyColumn: "Id",
                keyValue: new Guid("6778bf07-517f-4916-989b-15b17b374203"));

            migrationBuilder.InsertData(
                table: "Enterprises",
                columns: new[] { "Id", "City", "CpfCnpj", "Email", "Name" },
                values: new object[] { new Guid("ce5664c3-523f-4791-aeda-bd17d5a55a99"), "8453", "12345678901234", "csharkenterprise@hotmail.com", "Csharks Developers LTDA" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "aliquota_item_lista_servico", "codigo_item_lista_servico", "codigo_local_prestacao_servico", "descritivo", "situacao_tributaria", "tributa_municipio_prestador", "valor_tributavel" },
                values: new object[,]
                {
                    { new Guid("96397d8e-90a6-4320-a67a-cda18286bfb7"), "2", "0106", "8357", "Assessoria e consultoria em informática.", "000", "S", "0" },
                    { new Guid("c4599466-04ba-4570-85f4-d3f13c0f78e4"), "5", "702", "8357", "Teste", "000", "S", "0" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "EnterpriseId", "Login", "Name", "Password", "Profile" },
                values: new object[] { new Guid("eab4085c-de7e-4a6f-b351-20224630fa6c"), "teste@hotmail.com", new Guid("ce5664c3-523f-4791-aeda-bd17d5a55a99"), "dev", "Desenvolvedor", "MTIz", 1 });
        }
    }
}
