using Microsoft.EntityFrameworkCore.Migrations;

namespace API_Dispesa.Migrations
{
    public partial class NewCampo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Pago",
                table: "Dispesas",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pago",
                table: "Dispesas");
        }
    }
}
