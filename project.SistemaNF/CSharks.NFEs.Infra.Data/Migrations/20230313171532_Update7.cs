using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSharks.NFEs.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class Update7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("523761ee-2b58-429a-8a05-4e2457cce66a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("098f894e-488e-48f5-9847-febe4e3f6c3d"));

            migrationBuilder.DeleteData(
                table: "Enterprises",
                keyColumn: "Id",
                keyValue: new Guid("61d4ef83-f50f-4487-8d3d-5eef17b12b93"));

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Code = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    City = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Isqns",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Code = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Aliquot = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Isqns", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Enterprises",
                columns: new[] { "Id", "City", "CpfCnpj", "Email", "Name" },
                values: new object[] { new Guid("f97206ee-5853-496a-8321-5eb050903ae0"), "8453", "12345678901234", "csharkenterprise@hotmail.com", "Csharks Developers LTDA" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "aliquota_item_lista_servico", "codigo_item_lista_servico", "codigo_local_prestacao_servico", "descritivo", "situacao_tributaria", "tributa_municipio_prestador", "valor_tributavel" },
                values: new object[] { new Guid("f48238f4-98e2-4ccd-86bd-9b2866ead0a4"), "5", "702", "8357", "Teste", "0", "S", "0" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "EnterpriseId", "Login", "Name", "Password", "Profile" },
                values: new object[] { new Guid("9ebca88b-fd23-4b60-9331-a3e05a72beab"), "teste@hotmail.com", new Guid("f97206ee-5853-496a-8321-5eb050903ae0"), "dev", "Desenvolvedor", "MTIz", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Isqns");

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("f48238f4-98e2-4ccd-86bd-9b2866ead0a4"));

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
                values: new object[] { new Guid("61d4ef83-f50f-4487-8d3d-5eef17b12b93"), "8453", "12345678901234", "csharkenterprise@hotmail.com", "Csharks Developers LTDA" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "aliquota_item_lista_servico", "codigo_item_lista_servico", "codigo_local_prestacao_servico", "descritivo", "situacao_tributaria", "tributa_municipio_prestador", "valor_tributavel" },
                values: new object[] { new Guid("523761ee-2b58-429a-8a05-4e2457cce66a"), "5", "702", "8357", "Teste", "0", "S", "0" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "EnterpriseId", "Login", "Name", "Password", "Profile" },
                values: new object[] { new Guid("098f894e-488e-48f5-9847-febe4e3f6c3d"), "teste@hotmail.com", new Guid("61d4ef83-f50f-4487-8d3d-5eef17b12b93"), "dev", "Desenvolvedor", "MTIz", 1 });
        }
    }
}
