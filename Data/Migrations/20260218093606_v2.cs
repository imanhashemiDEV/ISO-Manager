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
            migrationBuilder.AddColumn<DateTime>(
                name: "ProcessEditDate",
                table: "Processes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ProcessNumber",
                table: "Processes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProcessReviewNumber",
                table: "Processes",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProcessEditDate",
                table: "Processes");

            migrationBuilder.DropColumn(
                name: "ProcessNumber",
                table: "Processes");

            migrationBuilder.DropColumn(
                name: "ProcessReviewNumber",
                table: "Processes");
        }
    }
}
