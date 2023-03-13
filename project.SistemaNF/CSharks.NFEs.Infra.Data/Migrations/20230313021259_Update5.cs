using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSharks.NFEs.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class Update5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enterprises",
                keyColumn: "Id",
                keyValue: new Guid("cb938628-8118-46b7-a396-1ee16e849c0b"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("8e9bd480-0b90-4432-b417-1de613690020"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b487fddb-610e-4c68-ab38-5ecb5a4d2645"));

            migrationBuilder.AlterColumn<Guid>(
                name: "EnterpriseId",
                table: "Users",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci",
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true)
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Enterprises",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.CreateIndex(
                name: "IX_Users_EnterpriseId",
                table: "Users",
                column: "EnterpriseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Enterprises_EnterpriseId",
                table: "Users",
                column: "EnterpriseId",
                principalTable: "Enterprises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Enterprises_EnterpriseId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_EnterpriseId",
                table: "Users");

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

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Enterprises");

            migrationBuilder.AlterColumn<Guid>(
                name: "EnterpriseId",
                table: "Users",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci",
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.InsertData(
                table: "Enterprises",
                columns: new[] { "Id", "City", "CpfCnpj" },
                values: new object[] { new Guid("cb938628-8118-46b7-a396-1ee16e849c0b"), "8357", "27883417000104" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "aliquota_item_lista_servico", "codigo_item_lista_servico", "codigo_local_prestacao_servico", "descritivo", "situacao_tributaria", "tributa_municipio_prestador", "valor_tributavel" },
                values: new object[] { new Guid("8e9bd480-0b90-4432-b417-1de613690020"), "5", "702", "8357", "Teste", "0", "S", "0" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "EnterpriseId", "Login", "Name", "Password", "Profile" },
                values: new object[] { new Guid("b487fddb-610e-4c68-ab38-5ecb5a4d2645"), null, "dev", "Desenvolvedor", "MTIz", 1 });
        }
    }
}
