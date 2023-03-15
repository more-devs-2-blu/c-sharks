using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CSharks.NFEs.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class update10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Clients",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Complement",
                table: "Clients",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Clients",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Identifier",
                table: "Clients",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Ie",
                table: "Clients",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Patio",
                table: "Clients",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ResidentialNumber",
                table: "Clients",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Address", "Complement", "CpfCnpj", "Email", "Enrollment", "Identifier", "Ie", "Name", "Patio", "ResidentialNumber" },
                values: new object[] { new Guid("3aaca86a-7bca-4c79-aa8c-5b59a6201fe2"), "Leopoldo Holz", "Rua", "06262485902", "patrick@gmail.com", "F", "3812817100220600010000000001", "16", "Patrick Weber", "Condominio", "111" });

            migrationBuilder.InsertData(
                table: "Enterprises",
                columns: new[] { "Id", "City", "CpfCnpj", "Email", "Name" },
                values: new object[] { new Guid("140bb8fc-12f0-4287-b12a-b8d6901ccc46"), "8453", "12345678901234", "csharkenterprise@hotmail.com", "Csharks Developers LTDA" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "aliquota_item_lista_servico", "codigo_item_lista_servico", "codigo_local_prestacao_servico", "descritivo", "situacao_tributaria", "tributa_municipio_prestador", "valor_tributavel" },
                values: new object[,]
                {
                    { new Guid("93f4e4ee-3e42-483a-9acf-2fff13cdf0d4"), "5", "702", "8357", "Teste", "000", "S", "0" },
                    { new Guid("f91e6dfa-40e4-46dd-a502-0649b14e1e04"), "2", "0106", "8357", "Assessoria e consultoria em informática.", "000", "S", "0" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "EnterpriseId", "Login", "Name", "Password", "Profile" },
                values: new object[] { new Guid("a51bbf93-cded-42bd-834d-4426697a0bc1"), "teste@hotmail.com", new Guid("140bb8fc-12f0-4287-b12a-b8d6901ccc46"), "dev", "Desenvolvedor", "MTIz", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("3aaca86a-7bca-4c79-aa8c-5b59a6201fe2"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("93f4e4ee-3e42-483a-9acf-2fff13cdf0d4"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("f91e6dfa-40e4-46dd-a502-0649b14e1e04"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a51bbf93-cded-42bd-834d-4426697a0bc1"));

            migrationBuilder.DeleteData(
                table: "Enterprises",
                keyColumn: "Id",
                keyValue: new Guid("140bb8fc-12f0-4287-b12a-b8d6901ccc46"));

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Complement",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Identifier",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Ie",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Patio",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "ResidentialNumber",
                table: "Clients");

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
    }
}
