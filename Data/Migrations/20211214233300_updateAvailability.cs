using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Alex.Data.Migrations
{
    public partial class updateAvailability : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DriverId",
                table: "Availabilities",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DriverId",
                table: "Availabilities");
        }
    }
}
