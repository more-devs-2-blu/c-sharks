using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CSharks.NFEs.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class UPDATE11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("628383a5-04a3-4c1f-b85d-17005b5286e8"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("591659d9-8ff5-4329-90e9-b48f040be544"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("e076feed-09fd-4b17-b352-30b385e85d65"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e3f32fcc-69dc-42bf-af4f-a36cb0f67bb7"));

            migrationBuilder.DeleteData(
                table: "Enterprises",
                keyColumn: "Id",
                keyValue: new Guid("eaa3995c-7ab4-43a6-8453-8ea4a4cbc9d4"));

            migrationBuilder.CreateTable(
                name: "Emiteds",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    EmitDate = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ServiceName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClientName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ValueNF = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Situation = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LinkPDF = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NoNfse = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CodVerify = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emiteds", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Address", "CEP", "City", "Country", "CpfCnpj", "District", "Email", "Enrollment", "Ie", "Name", "ResidentialNumber", "State" },
                values: new object[] { new Guid("14fdf9c0-bb6f-477e-b92e-df6160d6d1fc"), "Leopoldo Holz", null, null, null, "06262485902", null, "patrick@gmail.com", "F", "16", "Patrick Weber", "111", null });

            migrationBuilder.InsertData(
                table: "Emiteds",
                columns: new[] { "Id", "ClientName", "CodVerify", "EmitDate", "LinkPDF", "NoNfse", "ServiceName", "Situation", "ValueNF" },
                values: new object[] { new Guid("e8f382b8-e4a1-41d5-9978-f09a8023374a"), "PATRICK WEBER", "8357738593202582530720240315032023189724", "23-03-15-19-29", "https://homologacao.atende.net//homologacao.atende.net//autoatendimento/servicos/consulta-de-autenticidade-de-nota-fiscal-eletronica-nfse/detalhar/1/identificador/atende.php?rot=1&aca=119&ajax=t&processo=viewFile&ajaxPrevent=1678894724274&file=3BEC12ECA3FEFF0F56229CD1C8598E57ABEC522A&sistema=wne&classe=upload_nota_fiscal_eletronica", "74", "Programação", "Success", "35" });

            migrationBuilder.InsertData(
                table: "Enterprises",
                columns: new[] { "Id", "City", "CpfCnpj", "Email", "Name" },
                values: new object[] { new Guid("b0f085eb-66cc-49ac-8cc2-c60bd819c86f"), "8453", "12345678901234", "csharkenterprise@hotmail.com", "Csharks Developers LTDA" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "aliquota_item_lista_servico", "codigo_item_lista_servico", "codigo_local_prestacao_servico", "descritivo", "situacao_tributaria", "tributa_municipio_prestador", "valor_tributavel" },
                values: new object[,]
                {
                    { new Guid("2aaba793-0853-4585-90b7-4b41688addf3"), "5", "702", "8357", "Teste", "000", "S", "0" },
                    { new Guid("a4b0a690-2804-48ef-8a3c-bd1cd13f44db"), "2", "0106", "8357", "Assessoria e consultoria em informática.", "0", "S", "0" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "EnterpriseId", "Login", "Name", "Password", "Profile" },
                values: new object[] { new Guid("24c9544d-180b-44d1-ab4f-0580ce54e803"), "teste@hotmail.com", new Guid("b0f085eb-66cc-49ac-8cc2-c60bd819c86f"), "dev", "Desenvolvedor", "MTIz", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emiteds");

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("14fdf9c0-bb6f-477e-b92e-df6160d6d1fc"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("2aaba793-0853-4585-90b7-4b41688addf3"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("a4b0a690-2804-48ef-8a3c-bd1cd13f44db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("24c9544d-180b-44d1-ab4f-0580ce54e803"));

            migrationBuilder.DeleteData(
                table: "Enterprises",
                keyColumn: "Id",
                keyValue: new Guid("b0f085eb-66cc-49ac-8cc2-c60bd819c86f"));

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Address", "CEP", "City", "Country", "CpfCnpj", "District", "Email", "Enrollment", "Ie", "Name", "ResidentialNumber", "State" },
                values: new object[] { new Guid("628383a5-04a3-4c1f-b85d-17005b5286e8"), "Leopoldo Holz", null, null, null, "06262485902", null, "patrick@gmail.com", "F", "16", "Patrick Weber", "111", null });

            migrationBuilder.InsertData(
                table: "Enterprises",
                columns: new[] { "Id", "City", "CpfCnpj", "Email", "Name" },
                values: new object[] { new Guid("eaa3995c-7ab4-43a6-8453-8ea4a4cbc9d4"), "8453", "12345678901234", "csharkenterprise@hotmail.com", "Csharks Developers LTDA" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "aliquota_item_lista_servico", "codigo_item_lista_servico", "codigo_local_prestacao_servico", "descritivo", "situacao_tributaria", "tributa_municipio_prestador", "valor_tributavel" },
                values: new object[,]
                {
                    { new Guid("591659d9-8ff5-4329-90e9-b48f040be544"), "5", "702", "8357", "Teste", "000", "S", "0" },
                    { new Guid("e076feed-09fd-4b17-b352-30b385e85d65"), "2", "0106", "8357", "Assessoria e consultoria em informática.", "000", "S", "0" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "EnterpriseId", "Login", "Name", "Password", "Profile" },
                values: new object[] { new Guid("e3f32fcc-69dc-42bf-af4f-a36cb0f67bb7"), "teste@hotmail.com", new Guid("eaa3995c-7ab4-43a6-8453-8ea4a4cbc9d4"), "dev", "Desenvolvedor", "MTIz", 1 });
        }
    }
}
