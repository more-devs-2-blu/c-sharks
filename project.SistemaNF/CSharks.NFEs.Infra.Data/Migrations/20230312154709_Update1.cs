using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSharks.NFEs.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class Update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_Categories_CategoryId1",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_CategoryId1",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "CategoryId1",
                table: "Services");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Login", "Name", "Password", "Profile" },
                values: new object[] { new Guid("7152e51f-13bd-4e50-8e81-49df774e536b"), "dev", "Desenvolvedor", "MTIz", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7152e51f-13bd-4e50-8e81-49df774e536b"));

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId1",
                table: "Services",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.CreateIndex(
                name: "IX_Services_CategoryId1",
                table: "Services",
                column: "CategoryId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Categories_CategoryId1",
                table: "Services",
                column: "CategoryId1",
                principalTable: "Categories",
                principalColumn: "Id");
        }
    }
}
