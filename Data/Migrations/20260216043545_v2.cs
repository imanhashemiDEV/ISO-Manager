using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ISO_Manager.Data.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "OrganizationId",
                table: "WorkPlaces",
                Type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "Office",
                columns: table => new
                {
                    Id = table.Column<int>(Type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    OrganizationId = table.Column<int>(Type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Office", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Office_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Office_OrganizationId",
                table: "Office",
                column: "OrganizationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Office");

            migrationBuilder.DropColumn(
                name: "OrganizationId",
                table: "WorkPlaces");
        }
    }
}
