using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eBarberShop.Services.Migrations
{
    public partial class add_isbooked_to_termin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsBooked",
                table: "Termins",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsBooked",
                table: "Termins");
        }
    }
}
