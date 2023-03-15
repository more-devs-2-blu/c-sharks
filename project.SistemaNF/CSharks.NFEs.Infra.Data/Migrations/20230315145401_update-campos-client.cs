using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CSharks.NFEs.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class updatecamposclient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Patio",
                table: "Clients");

            migrationBuilder.AlterColumn<string>(
                name: "ResidentialNumber",
                table: "Clients",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Ie",
                table: "Clients",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Identifier",
                table: "Clients",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Enrollment",
                table: "Clients",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Clients",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Complement",
                table: "Clients",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Clients",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CEP",
                table: "Clients",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Clients",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Country",
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
                name: "District",
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
                name: "State",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "CEP",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "DDDComercial",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "District",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "FoneComercial",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Clients");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ResidentialNumber",
                keyValue: null,
                column: "ResidentialNumber",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "ResidentialNumber",
                table: "Clients",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Ie",
                keyValue: null,
                column: "Ie",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Ie",
                table: "Clients",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Identifier",
                keyValue: null,
                column: "Identifier",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Identifier",
                table: "Clients",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Enrollment",
                keyValue: null,
                column: "Enrollment",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Enrollment",
                table: "Clients",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Email",
                keyValue: null,
                column: "Email",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Clients",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Complement",
                keyValue: null,
                column: "Complement",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Complement",
                table: "Clients",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Address",
                keyValue: null,
                column: "Address",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Clients",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Patio",
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
    }
}
