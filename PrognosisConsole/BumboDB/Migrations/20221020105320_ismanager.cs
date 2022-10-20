using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BumboDB.Migrations
{
    public partial class ismanager : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsManager",
                table: "Werknemer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsManager",
                table: "Werknemer",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
