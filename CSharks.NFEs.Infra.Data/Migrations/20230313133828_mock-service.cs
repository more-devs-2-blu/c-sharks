using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CSharks.NFEs.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class mockservice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("7c471da7-a986-4657-a36f-f23922e0be6c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("67aaf223-aede-4cba-8af3-5666da050bbb"));

            migrationBuilder.DeleteData(
                table: "Enterprises",
                keyColumn: "Id",
                keyValue: new Guid("353ba636-7c20-481f-a597-f3c31fb91979"));

            migrationBuilder.InsertData(
                table: "Enterprises",
                columns: new[] { "Id", "City", "CpfCnpj", "Name" },
                values: new object[] { new Guid("1ec72713-91a4-48a6-b803-7ee15c5d35a0"), "Mock City", "12345678901234", "Mock Enterprise" });

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
                columns: new[] { "Id", "EnterpriseId", "Login", "Name", "Password", "Profile" },
                values: new object[] { new Guid("d3f12311-b743-46f2-8880-c7fa5b16b9a4"), new Guid("1ec72713-91a4-48a6-b803-7ee15c5d35a0"), "dev", "Desenvolvedor", "MTIz", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: new Guid("d3f12311-b743-46f2-8880-c7fa5b16b9a4"));

            migrationBuilder.DeleteData(
                table: "Enterprises",
                keyColumn: "Id",
                keyValue: new Guid("1ec72713-91a4-48a6-b803-7ee15c5d35a0"));

            migrationBuilder.InsertData(
                table: "Enterprises",
                columns: new[] { "Id", "City", "CpfCnpj", "Name" },
                values: new object[] { new Guid("353ba636-7c20-481f-a597-f3c31fb91979"), "Mock City", "12345678901234", "Mock Enterprise" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "aliquota_item_lista_servico", "codigo_item_lista_servico", "codigo_local_prestacao_servico", "descritivo", "situacao_tributaria", "tributa_municipio_prestador", "valor_tributavel" },
                values: new object[] { new Guid("7c471da7-a986-4657-a36f-f23922e0be6c"), "5", "702", "8357", "Teste", "0", "S", "0" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "EnterpriseId", "Login", "Name", "Password", "Profile" },
                values: new object[] { new Guid("67aaf223-aede-4cba-8af3-5666da050bbb"), new Guid("353ba636-7c20-481f-a597-f3c31fb91979"), "dev", "Desenvolvedor", "MTIz", 1 });
        }
    }
}
