using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CSharks.NFEs.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class Update8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("9d2fe87f-2829-4074-8ab0-a5ef5d9e2cae"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("f4df3f94-9494-42e4-9108-c02b99886b4b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9ebca88b-fd23-4b60-9331-a3e05a72beab"));

            migrationBuilder.DeleteData(
                table: "Enterprises",
                keyColumn: "Id",
                keyValue: new Guid("f97206ee-5853-496a-8321-5eb050903ae0"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("f97206ee-5853-496a-8321-5eb050903ae0"), "8453", "12345678901234", "csharkenterprise@hotmail.com", "Csharks Developers LTDA" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "aliquota_item_lista_servico", "codigo_item_lista_servico", "codigo_local_prestacao_servico", "descritivo", "situacao_tributaria", "tributa_municipio_prestador", "valor_tributavel" },
                values: new object[,]
                {
                    { new Guid("9d2fe87f-2829-4074-8ab0-a5ef5d9e2cae"), "5", "702", "8357", "Teste", "000", "S", "0" },
                    { new Guid("f4df3f94-9494-42e4-9108-c02b99886b4b"), "2", "0106", "8357", "Assessoria e consultoria em informática.", "000", "S", "0" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "EnterpriseId", "Login", "Name", "Password", "Profile" },
                values: new object[] { new Guid("9ebca88b-fd23-4b60-9331-a3e05a72beab"), "teste@hotmail.com", new Guid("f97206ee-5853-496a-8321-5eb050903ae0"), "dev", "Desenvolvedor", "MTIz", 1 });
        }
    }
}
