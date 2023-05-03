using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentsApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Email", "Idade", "Name" },
                values: new object[,]
                {
                    { new Guid("03c35864-15a5-4638-85c6-c842949da2b5"), "natachafsp@hotmail.com", 35, "Natacha Passos" },
                    { new Guid("27efd318-a2fd-4c14-886d-6e78116afc69"), "gustavofsp@hotmail.com", 32, "Gustavo Passos" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("03c35864-15a5-4638-85c6-c842949da2b5"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("27efd318-a2fd-4c14-886d-6e78116afc69"));
        }
    }
}
