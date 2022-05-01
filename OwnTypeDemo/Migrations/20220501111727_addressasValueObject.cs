using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OwnTypeDemo.Migrations
{
    public partial class addressasValueObject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address_Street",
                table: "Employees",
                newName: "AddressTow_Street");

            migrationBuilder.RenameColumn(
                name: "Address_City",
                table: "Employees",
                newName: "AddressTow_City");

            migrationBuilder.AddColumn<string>(
                name: "AddressOne_City",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AddressOne_Street",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressOne_City",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "AddressOne_Street",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "AddressTow_Street",
                table: "Employees",
                newName: "Address_Street");

            migrationBuilder.RenameColumn(
                name: "AddressTow_City",
                table: "Employees",
                newName: "Address_City");
        }
    }
}
