using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TFSSincronizador.Migrations
{
    public partial class Mappingstatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MappingDirection",
                table: "MappingTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MappingMode",
                table: "MappingTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MappingDirection",
                table: "MappingStatuses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MappingMode",
                table: "MappingStatuses",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MappingDirection",
                table: "MappingTypes");

            migrationBuilder.DropColumn(
                name: "MappingMode",
                table: "MappingTypes");

            migrationBuilder.DropColumn(
                name: "MappingDirection",
                table: "MappingStatuses");

            migrationBuilder.DropColumn(
                name: "MappingMode",
                table: "MappingStatuses");
        }
    }
}
