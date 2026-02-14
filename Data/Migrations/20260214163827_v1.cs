using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ISO_Manager.Data.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "employment_type",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "AspNetUsers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "mobile",
                table: "AspNetUsers",
                newName: "Mobile");

            migrationBuilder.RenameColumn(
                name: "image",
                table: "AspNetUsers",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "AspNetUsers",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "register_code",
                table: "AspNetUsers",
                newName: "RegisterCode");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "AspNetUsers",
                newName: "NationalCode");

            migrationBuilder.RenameColumn(
                name: "national_code",
                table: "AspNetUsers",
                newName: "EmploymentType");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "AspNetUsers",
                newName: "CreatedAt");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "AspNetUsers",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Mobile",
                table: "AspNetUsers",
                newName: "mobile");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "AspNetUsers",
                newName: "image");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "AspNetUsers",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "RegisterCode",
                table: "AspNetUsers",
                newName: "register_code");

            migrationBuilder.RenameColumn(
                name: "NationalCode",
                table: "AspNetUsers",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "EmploymentType",
                table: "AspNetUsers",
                newName: "national_code");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "AspNetUsers",
                newName: "created_at");

            migrationBuilder.AddColumn<string>(
                name: "employment_type",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
