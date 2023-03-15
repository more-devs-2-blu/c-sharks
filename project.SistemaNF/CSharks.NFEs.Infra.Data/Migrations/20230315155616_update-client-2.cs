using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CSharks.NFEs.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateclient2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("853a21b2-73c2-4666-8d3e-8f67d88f967f"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("7e7c21b6-31ee-4672-b721-39a8471b0e01"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("d634fee8-192c-4947-8de9-f094903db4aa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7cd918a0-92d8-4ee8-bc79-3ade20fad13f"));

            migrationBuilder.DeleteData(
                table: "Enterprises",
                keyColumn: "Id",
                keyValue: new Guid("b13f06d5-06f2-4682-9413-853f9dc8571e"));

            migrationBuilder.DropColumn(
                name: "Complement",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "DDDComercial",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "FoneComercial",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Identifier",
                table: "Clients");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Complement",
                table: "Clients",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DDDComercial",
                table: "Clients",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "FoneComercial",
                table: "Clients",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Identifier",
                table: "Clients",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Address", "CEP", "City", "Complement", "Country", "CpfCnpj", "DDDComercial", "District", "Email", "Enrollment", "FoneComercial", "Identifier", "Ie", "Name", "ResidentialNumber", "State" },
                values: new object[] { new Guid("853a21b2-73c2-4666-8d3e-8f67d88f967f"), "Leopoldo Holz", null, null, "Rua", null, "06262485902", null, null, "patrick@gmail.com", "F", null, "3812817100220600010000000001", "16", "Patrick Weber", "111", null });

            migrationBuilder.InsertData(
                table: "Enterprises",
                columns: new[] { "Id", "City", "CpfCnpj", "Email", "Name" },
                values: new object[] { new Guid("b13f06d5-06f2-4682-9413-853f9dc8571e"), "8453", "12345678901234", "csharkenterprise@hotmail.com", "Csharks Developers LTDA" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "aliquota_item_lista_servico", "codigo_item_lista_servico", "codigo_local_prestacao_servico", "descritivo", "situacao_tributaria", "tributa_municipio_prestador", "valor_tributavel" },
                values: new object[,]
                {
                    { new Guid("7e7c21b6-31ee-4672-b721-39a8471b0e01"), "5", "702", "8357", "Teste", "000", "S", "0" },
                    { new Guid("d634fee8-192c-4947-8de9-f094903db4aa"), "2", "0106", "8357", "Assessoria e consultoria em informática.", "000", "S", "0" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "EnterpriseId", "Login", "Name", "Password", "Profile" },
                values: new object[] { new Guid("7cd918a0-92d8-4ee8-bc79-3ade20fad13f"), "teste@hotmail.com", new Guid("b13f06d5-06f2-4682-9413-853f9dc8571e"), "dev", "Desenvolvedor", "MTIz", 1 });
        }
    }
}
