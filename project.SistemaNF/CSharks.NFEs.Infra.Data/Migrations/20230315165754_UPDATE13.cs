using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CSharks.NFEs.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class UPDATE13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("3ac04250-fb25-4a99-a4d5-ab7ab070f78d"));

            migrationBuilder.DeleteData(
                table: "Emiteds",
                keyColumn: "Id",
                keyValue: new Guid("5f02452a-e9e7-4d65-abf8-41e09a1d2863"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("53fa0b05-72c4-477d-b0e1-d817b9b5dbc3"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("9333e8c7-4767-46a2-b9e2-dd898a4f2eb3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0cfa54b6-584f-43c4-b8b3-77a769abe3db"));

            migrationBuilder.DeleteData(
                table: "Enterprises",
                keyColumn: "Id",
                keyValue: new Guid("eedadba9-5ced-491e-af02-0e29daea5f70"));

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Address", "CEP", "City", "CpfCnpj", "District", "Email", "Enrollment", "Ie", "InformedAdress", "Name", "ResidentialNumber" },
                values: new object[] { new Guid("412a7651-7cd4-4528-9cc3-306b3e11a050"), "Rua Gustavo Zimmermann", "89062100 ", "8357", "43975686855", "Itoupava Central", "juninhocb@hotmail.com", "F", "16", "1", "Carlos Eduardo dos Santos Junior", "2421" });

            migrationBuilder.InsertData(
                table: "Emiteds",
                columns: new[] { "Id", "ClientName", "CodVerify", "EmitDate", "LinkPDF", "NoNfse", "ServiceName", "Situation", "ValueNF" },
                values: new object[] { new Guid("a4830455-6511-4be7-aab2-ff1efa488a96"), "PATRICK WEBER", "8357738593202582530720240315032023189724", "23-03-15-19-29", "https://homologacao.atende.net//homologacao.atende.net//autoatendimento/servicos/consulta-de-autenticidade-de-nota-fiscal-eletronica-nfse/detalhar/1/identificador/atende.php?rot=1&aca=119&ajax=t&processo=viewFile&ajaxPrevent=1678894724274&file=3BEC12ECA3FEFF0F56229CD1C8598E57ABEC522A&sistema=wne&classe=upload_nota_fiscal_eletronica", "74", "Programação", "Success", "35" });

            migrationBuilder.InsertData(
                table: "Enterprises",
                columns: new[] { "Id", "City", "CpfCnpj", "Email", "Name" },
                values: new object[] { new Guid("dffa0ee5-bce8-43e0-8401-fd5c57c1befc"), "8357", "25825307000152", "csharkenterprise@hotmail.com", "Csharks Developers LTDA" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "aliquota_item_lista_servico", "codigo_item_lista_servico", "codigo_local_prestacao_servico", "descritivo", "situacao_tributaria", "tributa_municipio_prestador", "valor_tributavel" },
                values: new object[] { new Guid("842cb543-e444-4634-a4f4-7191cce6987c"), "5", "702", "8357", "Assessoria e consultoria em informática.", "0", "S", "1" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "EnterpriseId", "Login", "Name", "Password", "Profile" },
                values: new object[] { new Guid("bc7b9b60-543a-4e42-8cfe-2337e8738830"), "teste@hotmail.com", new Guid("dffa0ee5-bce8-43e0-8401-fd5c57c1befc"), "dev", "Desenvolvedor", "MTIz", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("412a7651-7cd4-4528-9cc3-306b3e11a050"));

            migrationBuilder.DeleteData(
                table: "Emiteds",
                keyColumn: "Id",
                keyValue: new Guid("a4830455-6511-4be7-aab2-ff1efa488a96"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("842cb543-e444-4634-a4f4-7191cce6987c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bc7b9b60-543a-4e42-8cfe-2337e8738830"));

            migrationBuilder.DeleteData(
                table: "Enterprises",
                keyColumn: "Id",
                keyValue: new Guid("dffa0ee5-bce8-43e0-8401-fd5c57c1befc"));

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Address", "CEP", "City", "CpfCnpj", "District", "Email", "Enrollment", "Ie", "InformedAdress", "Name", "ResidentialNumber" },
                values: new object[] { new Guid("3ac04250-fb25-4a99-a4d5-ab7ab070f78d"), "Rua Gustavo Zimmermann", "89062100 ", "8357", "43975686855", "Itoupava Central", "juninhocb@hotmail.com", "F", "16", "1", "Carlos Eduardo dos Santos Junior", "2421" });

            migrationBuilder.InsertData(
                table: "Emiteds",
                columns: new[] { "Id", "ClientName", "CodVerify", "EmitDate", "LinkPDF", "NoNfse", "ServiceName", "Situation", "ValueNF" },
                values: new object[] { new Guid("5f02452a-e9e7-4d65-abf8-41e09a1d2863"), "PATRICK WEBER", "8357738593202582530720240315032023189724", "23-03-15-19-29", "https://homologacao.atende.net//homologacao.atende.net//autoatendimento/servicos/consulta-de-autenticidade-de-nota-fiscal-eletronica-nfse/detalhar/1/identificador/atende.php?rot=1&aca=119&ajax=t&processo=viewFile&ajaxPrevent=1678894724274&file=3BEC12ECA3FEFF0F56229CD1C8598E57ABEC522A&sistema=wne&classe=upload_nota_fiscal_eletronica", "74", "Programação", "Success", "35" });

            migrationBuilder.InsertData(
                table: "Enterprises",
                columns: new[] { "Id", "City", "CpfCnpj", "Email", "Name" },
                values: new object[] { new Guid("eedadba9-5ced-491e-af02-0e29daea5f70"), "8357", "25825307000152", "csharkenterprise@hotmail.com", "Csharks Developers LTDA" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "aliquota_item_lista_servico", "codigo_item_lista_servico", "codigo_local_prestacao_servico", "descritivo", "situacao_tributaria", "tributa_municipio_prestador", "valor_tributavel" },
                values: new object[,]
                {
                    { new Guid("53fa0b05-72c4-477d-b0e1-d817b9b5dbc3"), "2", "0106", "8357", "Assessoria e consultoria em informática.", "0", "S", "1" },
                    { new Guid("9333e8c7-4767-46a2-b9e2-dd898a4f2eb3"), "5", "702", "8357", "Assessoria e consultoria em informática.", "0", "S", "1" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "EnterpriseId", "Login", "Name", "Password", "Profile" },
                values: new object[] { new Guid("0cfa54b6-584f-43c4-b8b3-77a769abe3db"), "teste@hotmail.com", new Guid("eedadba9-5ced-491e-af02-0e29daea5f70"), "dev", "Desenvolvedor", "MTIz", 1 });
        }
    }
}
