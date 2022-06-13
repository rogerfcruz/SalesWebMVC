using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMVC.Migrations
{
    public partial class AlterSellerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Emai",
                table: "Seller",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "Birthday",
                table: "Seller",
                newName: "BirthDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Seller",
                newName: "Emai");

            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "Seller",
                newName: "Birthday");
        }
    }
}
