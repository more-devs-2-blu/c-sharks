using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSharks.NFEs.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class Update3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lists");

            migrationBuilder.DropTable(
                name: "NFS");

            migrationBuilder.DropTable(
                name: "Pesquisas");

            migrationBuilder.DropTable(
                name: "Prestadores");

            migrationBuilder.DropTable(
                name: "Tomadores");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ae67aed3-d6bd-402f-ae75-ac49d2208103"));

            migrationBuilder.DropColumn(
                name: "Aliquot",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Services");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Services",
                newName: "valor_tributavel");

            migrationBuilder.AddColumn<Guid>(
                name: "EnterpriseId",
                table: "Users",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<string>(
                name: "aliquota_item_lista_servico",
                table: "Services",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "codigo_item_lista_servico",
                table: "Services",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "codigo_local_prestacao_servico",
                table: "Services",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "descritivo",
                table: "Services",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "situacao_tributaria",
                table: "Services",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "tributa_municipio_prestador",
                table: "Services",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Enterprises",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CpfCnpj = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    City = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enterprises", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enterprises");

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("8e9bd480-0b90-4432-b417-1de613690020"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b487fddb-610e-4c68-ab38-5ecb5a4d2645"));

            migrationBuilder.DropColumn(
                name: "EnterpriseId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "aliquota_item_lista_servico",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "codigo_item_lista_servico",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "codigo_local_prestacao_servico",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "descritivo",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "situacao_tributaria",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "tributa_municipio_prestador",
                table: "Services");

            migrationBuilder.RenameColumn(
                name: "valor_tributavel",
                table: "Services",
                newName: "Name");

            migrationBuilder.AddColumn<double>(
                name: "Aliquot",
                table: "Services",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "Services",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.CreateTable(
                name: "Lists",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    aliquota_item_lista_servico = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    codigo_item_lista_servico = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    codigo_local_prestacao_servico = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    descritivo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    situacao_tributaria = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tributa_municipio_prestador = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    valor_tributavel = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lists", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "NFS",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    numero = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    observacao = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    serie_nfse = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    situacao = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    valor_total = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NFS", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pesquisas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    cadastro = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    numero = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    serie_nfse = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pesquisas", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Prestadores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    cidade = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cpfcnpj = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestadores", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tomadores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    complemento = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cpfcnpj = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    endereco_informado = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    identificador = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ie = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    logradouro = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nome_razao_social = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    numero_residencia = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tipo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tomadores", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Lists",
                columns: new[] { "Id", "aliquota_item_lista_servico", "codigo_item_lista_servico", "codigo_local_prestacao_servico", "descritivo", "situacao_tributaria", "tributa_municipio_prestador", "valor_tributavel" },
                values: new object[] { new Guid("1947c66a-fec5-4f4f-ab2a-d7ac78db1aca"), "5", "702", "8357", "Teste", "0", "S", "0" });

            migrationBuilder.InsertData(
                table: "NFS",
                columns: new[] { "Id", "numero", "observacao", "serie_nfse", "situacao", "valor_total" },
                values: new object[] { new Guid("9f11f8d5-d17c-463d-af1a-922424e7d3e8"), null, null, null, null, "1,00" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "cidade", "cpfcnpj" },
                values: new object[] { new Guid("844cb121-cb7b-4597-8ccc-3f3667e47d11"), "8357", "00000000000000" });

            migrationBuilder.InsertData(
                table: "Tomadores",
                columns: new[] { "Id", "complemento", "cpfcnpj", "email", "endereco_informado", "identificador", "ie", "logradouro", "nome_razao_social", "numero_residencia", "tipo" },
                values: new object[] { new Guid("4bc44014-7eaf-475b-8dd4-55050fcd5ae5"), "", "06262485902", "", "", "", "", "", "", "", "J" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Login", "Name", "Password", "Profile" },
                values: new object[] { new Guid("ae67aed3-d6bd-402f-ae75-ac49d2208103"), "dev", "Desenvolvedor", "MTIz", 1 });
        }
    }
}
