using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eBarberShop.Services.Migrations
{
    public partial class add_bool_options_to_rezervacijas_and_narudzbas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsArchived",
                table: "Rezervacijas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsCanceled",
                table: "Rezervacijas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsCanceled",
                table: "Narudzbas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsShipped",
                table: "Narudzbas",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsArchived",
                table: "Rezervacijas");

            migrationBuilder.DropColumn(
                name: "IsCanceled",
                table: "Rezervacijas");

            migrationBuilder.DropColumn(
                name: "IsCanceled",
                table: "Narudzbas");

            migrationBuilder.DropColumn(
                name: "IsShipped",
                table: "Narudzbas");
        }
    }
}
